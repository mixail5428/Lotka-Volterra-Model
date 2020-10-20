namespace LotkaVolterraModel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlotButton = new System.Windows.Forms.Button();
            this.dependencyGraphControl = new ZedGraph.ZedGraphControl();
            this.TimeSpan = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.PredPreyTabControl = new System.Windows.Forms.TabControl();
            this.PredatorTabPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PredatorPopulation = new System.Windows.Forms.NumericUpDown();
            this.PredatorDeathRate = new System.Windows.Forms.NumericUpDown();
            this.PredatorBirthRate = new System.Windows.Forms.NumericUpDown();
            this.PreyTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PreyPopulation = new System.Windows.Forms.NumericUpDown();
            this.PreyDeathRate = new System.Windows.Forms.NumericUpDown();
            this.PreyBirthRate = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.phasePortraitGraphControl = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSpan)).BeginInit();
            this.PredPreyTabControl.SuspendLayout();
            this.PredatorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorDeathRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorBirthRate)).BeginInit();
            this.PreyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreyPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreyDeathRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreyBirthRate)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlotButton
            // 
            this.PlotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlotButton.Location = new System.Drawing.Point(9, 438);
            this.PlotButton.Name = "PlotButton";
            this.PlotButton.Size = new System.Drawing.Size(219, 46);
            this.PlotButton.TabIndex = 1;
            this.PlotButton.Text = "Построить график";
            this.PlotButton.UseVisualStyleBackColor = true;
            this.PlotButton.Click += new System.EventHandler(this.PlotButton_Click);
            // 
            // dependencyGraphControl
            // 
            this.dependencyGraphControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dependencyGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dependencyGraphControl.Location = new System.Drawing.Point(3, 3);
            this.dependencyGraphControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dependencyGraphControl.Name = "dependencyGraphControl";
            this.dependencyGraphControl.ScrollGrace = 0D;
            this.dependencyGraphControl.ScrollMaxX = 0D;
            this.dependencyGraphControl.ScrollMaxY = 0D;
            this.dependencyGraphControl.ScrollMaxY2 = 0D;
            this.dependencyGraphControl.ScrollMinX = 0D;
            this.dependencyGraphControl.ScrollMinY = 0D;
            this.dependencyGraphControl.ScrollMinY2 = 0D;
            this.dependencyGraphControl.Size = new System.Drawing.Size(819, 444);
            this.dependencyGraphControl.TabIndex = 2;
            this.dependencyGraphControl.UseExtendedPrintDialog = true;
            // 
            // TimeSpan
            // 
            this.TimeSpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeSpan.Location = new System.Drawing.Point(72, 391);
            this.TimeSpan.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.TimeSpan.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TimeSpan.Name = "TimeSpan";
            this.TimeSpan.Size = new System.Drawing.Size(79, 22);
            this.TimeSpan.TabIndex = 9;
            this.TimeSpan.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Время:";
            // 
            // PredPreyTabControl
            // 
            this.PredPreyTabControl.Controls.Add(this.PredatorTabPage);
            this.PredPreyTabControl.Controls.Add(this.PreyTabPage);
            this.PredPreyTabControl.Location = new System.Drawing.Point(12, 12);
            this.PredPreyTabControl.Name = "PredPreyTabControl";
            this.PredPreyTabControl.SelectedIndex = 0;
            this.PredPreyTabControl.Size = new System.Drawing.Size(216, 150);
            this.PredPreyTabControl.TabIndex = 13;
            // 
            // PredatorTabPage
            // 
            this.PredatorTabPage.BackColor = System.Drawing.Color.White;
            this.PredatorTabPage.Controls.Add(this.label6);
            this.PredatorTabPage.Controls.Add(this.label5);
            this.PredatorTabPage.Controls.Add(this.label4);
            this.PredatorTabPage.Controls.Add(this.PredatorPopulation);
            this.PredatorTabPage.Controls.Add(this.PredatorDeathRate);
            this.PredatorTabPage.Controls.Add(this.PredatorBirthRate);
            this.PredatorTabPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PredatorTabPage.Location = new System.Drawing.Point(4, 25);
            this.PredatorTabPage.Name = "PredatorTabPage";
            this.PredatorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PredatorTabPage.Size = new System.Drawing.Size(208, 121);
            this.PredatorTabPage.TabIndex = 0;
            this.PredatorTabPage.Text = "Хищник";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Численность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Gamma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Delta:";
            // 
            // PredatorPopulation
            // 
            this.PredatorPopulation.Location = new System.Drawing.Point(123, 81);
            this.PredatorPopulation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PredatorPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PredatorPopulation.Name = "PredatorPopulation";
            this.PredatorPopulation.Size = new System.Drawing.Size(79, 22);
            this.PredatorPopulation.TabIndex = 18;
            this.PredatorPopulation.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // PredatorDeathRate
            // 
            this.PredatorDeathRate.DecimalPlaces = 3;
            this.PredatorDeathRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PredatorDeathRate.Location = new System.Drawing.Point(123, 49);
            this.PredatorDeathRate.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PredatorDeathRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.PredatorDeathRate.Name = "PredatorDeathRate";
            this.PredatorDeathRate.Size = new System.Drawing.Size(79, 22);
            this.PredatorDeathRate.TabIndex = 17;
            this.PredatorDeathRate.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // PredatorBirthRate
            // 
            this.PredatorBirthRate.DecimalPlaces = 3;
            this.PredatorBirthRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PredatorBirthRate.Location = new System.Drawing.Point(123, 17);
            this.PredatorBirthRate.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PredatorBirthRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.PredatorBirthRate.Name = "PredatorBirthRate";
            this.PredatorBirthRate.Size = new System.Drawing.Size(79, 22);
            this.PredatorBirthRate.TabIndex = 16;
            this.PredatorBirthRate.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // PreyTabPage
            // 
            this.PreyTabPage.Controls.Add(this.label1);
            this.PreyTabPage.Controls.Add(this.label2);
            this.PreyTabPage.Controls.Add(this.label3);
            this.PreyTabPage.Controls.Add(this.PreyPopulation);
            this.PreyTabPage.Controls.Add(this.PreyDeathRate);
            this.PreyTabPage.Controls.Add(this.PreyBirthRate);
            this.PreyTabPage.Location = new System.Drawing.Point(4, 25);
            this.PreyTabPage.Name = "PreyTabPage";
            this.PreyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PreyTabPage.Size = new System.Drawing.Size(208, 121);
            this.PreyTabPage.TabIndex = 1;
            this.PreyTabPage.Text = "Жертва";
            this.PreyTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Численность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Beta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Alpha:";
            // 
            // PreyPopulation
            // 
            this.PreyPopulation.Location = new System.Drawing.Point(123, 81);
            this.PreyPopulation.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PreyPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PreyPopulation.Name = "PreyPopulation";
            this.PreyPopulation.Size = new System.Drawing.Size(79, 22);
            this.PreyPopulation.TabIndex = 18;
            this.PreyPopulation.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // PreyDeathRate
            // 
            this.PreyDeathRate.DecimalPlaces = 3;
            this.PreyDeathRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PreyDeathRate.Location = new System.Drawing.Point(123, 49);
            this.PreyDeathRate.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PreyDeathRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.PreyDeathRate.Name = "PreyDeathRate";
            this.PreyDeathRate.Size = new System.Drawing.Size(79, 22);
            this.PreyDeathRate.TabIndex = 17;
            this.PreyDeathRate.Value = new decimal(new int[] {
            28,
            0,
            0,
            131072});
            // 
            // PreyBirthRate
            // 
            this.PreyBirthRate.DecimalPlaces = 3;
            this.PreyBirthRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PreyBirthRate.Location = new System.Drawing.Point(123, 17);
            this.PreyBirthRate.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PreyBirthRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.PreyBirthRate.Name = "PreyBirthRate";
            this.PreyBirthRate.Size = new System.Drawing.Size(79, 22);
            this.PreyBirthRate.TabIndex = 16;
            this.PreyBirthRate.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(237, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 479);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dependencyGraphControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "График зависимости";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.phasePortraitGraphControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Фазовый портрет";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // phasePortraitGraphControl
            // 
            this.phasePortraitGraphControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phasePortraitGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phasePortraitGraphControl.Location = new System.Drawing.Point(3, 3);
            this.phasePortraitGraphControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phasePortraitGraphControl.Name = "phasePortraitGraphControl";
            this.phasePortraitGraphControl.ScrollGrace = 0D;
            this.phasePortraitGraphControl.ScrollMaxX = 0D;
            this.phasePortraitGraphControl.ScrollMaxY = 0D;
            this.phasePortraitGraphControl.ScrollMaxY2 = 0D;
            this.phasePortraitGraphControl.ScrollMinX = 0D;
            this.phasePortraitGraphControl.ScrollMinY = 0D;
            this.phasePortraitGraphControl.ScrollMinY2 = 0D;
            this.phasePortraitGraphControl.Size = new System.Drawing.Size(819, 444);
            this.phasePortraitGraphControl.TabIndex = 3;
            this.phasePortraitGraphControl.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1082, 503);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PredPreyTabControl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TimeSpan);
            this.Controls.Add(this.PlotButton);
            this.MinimumSize = new System.Drawing.Size(1024, 512);
            this.Name = "Form1";
            this.Text = "Модель Лотки-Вольтерры";
            ((System.ComponentModel.ISupportInitialize)(this.TimeSpan)).EndInit();
            this.PredPreyTabControl.ResumeLayout(false);
            this.PredatorTabPage.ResumeLayout(false);
            this.PredatorTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorDeathRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredatorBirthRate)).EndInit();
            this.PreyTabPage.ResumeLayout(false);
            this.PreyTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreyPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreyDeathRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreyBirthRate)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PlotButton;
        private ZedGraph.ZedGraphControl dependencyGraphControl;
        private System.Windows.Forms.NumericUpDown TimeSpan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl PredPreyTabControl;
        private System.Windows.Forms.TabPage PredatorTabPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PredatorPopulation;
        private System.Windows.Forms.NumericUpDown PredatorDeathRate;
        private System.Windows.Forms.NumericUpDown PredatorBirthRate;
        private System.Windows.Forms.TabPage PreyTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PreyPopulation;
        private System.Windows.Forms.NumericUpDown PreyDeathRate;
        private System.Windows.Forms.NumericUpDown PreyBirthRate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl phasePortraitGraphControl;
    }
}

