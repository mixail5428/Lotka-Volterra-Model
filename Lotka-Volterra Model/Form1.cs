using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace LotkaVolterraModel
{
    public partial class Form1 : Form
    {
        //обьекты для рисования графиков
        //график зависимостей
        private static GraphPane dependencyGraphPanel;
        //график фозового портрета
        private static GraphPane phasePortraitPanel;

        public Form1()
        {
            InitializeComponent();

            // нахождение обьектов в окне
            dependencyGraphPanel = dependencyGraphControl.GraphPane;
            phasePortraitPanel = phasePortraitGraphControl.GraphPane;
            //настройка графика зависимостей
            dependencyGraphPanel.Title.Text = "График зависимости популяций друг от друга";
            dependencyGraphPanel.XAxis.Title.Text = "Время";
            dependencyGraphPanel.YAxis.Title.Text = "Размеры популяций";
            dependencyGraphPanel.XAxis.MajorGrid.IsVisible = true;
            dependencyGraphPanel.YAxis.MajorGrid.IsVisible = true;
            dependencyGraphPanel.XAxis.MajorGrid.DashOn = 10;
            dependencyGraphPanel.XAxis.MajorGrid.DashOff = 5;
            dependencyGraphPanel.YAxis.MajorGrid.DashOn = 10;
            dependencyGraphPanel.YAxis.MajorGrid.DashOff = 5;

            //настройка графика фазового портрета
            phasePortraitPanel.Title.Text = "Фазовый портрет";
            phasePortraitPanel.XAxis.Title.Text = "Жертвы";
            phasePortraitPanel.YAxis.Title.Text = "Хищники";
            phasePortraitPanel.XAxis.MajorGrid.IsVisible = true;
            phasePortraitPanel.YAxis.MajorGrid.IsVisible = true;
            phasePortraitPanel.XAxis.MajorGrid.DashOn = 10;
            phasePortraitPanel.XAxis.MajorGrid.DashOff = 5;
            phasePortraitPanel.YAxis.MajorGrid.DashOn = 10;
            phasePortraitPanel.YAxis.MajorGrid.DashOff = 5;
        }

        private void PlotButton_Click(object sender, EventArgs e)
        {
            //очистка графических объектов
            dependencyGraphPanel.CurveList.Clear();
            phasePortraitPanel.CurveList.Clear();

            // формула для жертв
            Func<double, double, double> preyPop = (x, y) =>
            x * ((double)PreyBirthRate.Value - (double)PreyDeathRate.Value * y);

            // формула для хищников
            Func<double, double, double> predatorPop = (x, y) =>
            y * ((double)PredatorBirthRate.Value * x - (double)PredatorDeathRate.Value);

            // переменная для хранения точек графиков
            double[,] preyAndPredatorCurves;

            try
            {
                //получение точек для построения графиков
                preyAndPredatorCurves = RungeKutta.Rkf45(preyPop, predatorPop, (double)PreyPopulation.Value,
                   (double)PredatorPopulation.Value, (int)TimeSpan.Value, 0.01);

                //переменные для графических объектов
                PointPairList preySolution = new PointPairList();
                PointPairList predatorSolution = new PointPairList();
                PointPairList preyAndPredatorSolution = new PointPairList();
                //присваивание значений переменным для графических объектов
                for (int i = 0; i <= preyAndPredatorCurves.GetUpperBound(1); i++)
                {
                    preySolution.Add(preyAndPredatorCurves[2, i], preyAndPredatorCurves[0, i]);
                    predatorSolution.Add(preyAndPredatorCurves[2, i], preyAndPredatorCurves[1, i]);

                    preyAndPredatorSolution.Add(preyAndPredatorCurves[0, i], preyAndPredatorCurves[1, i]);
                }

                // Добавление кривой для жертв
                LineItem preyCurve = dependencyGraphPanel.AddCurve("Популяция жертв",
                    preySolution, Color.Green, SymbolType.None);
                preyCurve.Line.Width = 2;
                preyCurve.Line.IsSmooth = true;

                // Добавление кривой для хищников
                LineItem predatorCurve = dependencyGraphPanel.AddCurve("Популяция хищников",
                    predatorSolution, Color.Red, SymbolType.None);
                predatorCurve.Line.Width = 2;
                predatorCurve.Line.IsSmooth = true;

                //кривая для фазового портрета
                LineItem predatorAndPreyCurve = phasePortraitPanel.AddCurve("",
                    preyAndPredatorSolution, Color.Red, SymbolType.None);
                predatorAndPreyCurve.Line.Width = 2;
                predatorAndPreyCurve.Line.IsSmooth = true;
            } 
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message + "\nPlease enter smaller parameters", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Изменение графиков в соответствии с кривыми
            dependencyGraphControl.AxisChange();
            dependencyGraphControl.Invalidate();

            phasePortraitGraphControl.AxisChange();
            phasePortraitGraphControl.Invalidate();
        }
    }
}
