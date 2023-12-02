
namespace Tyuiu.TarasovVD.Sprint6.Task2.V8
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_TVD = new System.Windows.Forms.GroupBox();
            this.labelInfo_TVD = new System.Windows.Forms.Label();
            this.groupBoxInPutData_TVD = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_TVD = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_TVD = new System.Windows.Forms.TextBox();
            this.labelStartStep_TVD = new System.Windows.Forms.Label();
            this.labelStopStep_TVD = new System.Windows.Forms.Label();
            this.buttonHelp_TVD = new System.Windows.Forms.Button();
            this.buttonDone_TVD = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_TVD = new System.Windows.Forms.GroupBox();
            this.labelResult_TVD = new System.Windows.Forms.Label();
            this.dataGridViewFunction_TVD = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_TVD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxFormula_TVD = new System.Windows.Forms.PictureBox();
            this.groupBoxTask_TVD.SuspendLayout();
            this.groupBoxInPutData_TVD.SuspendLayout();
            this.groupBoxOutPutData_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_TVD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_TVD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_TVD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_TVD
            // 
            this.groupBoxTask_TVD.Controls.Add(this.pictureBoxFormula_TVD);
            this.groupBoxTask_TVD.Controls.Add(this.labelInfo_TVD);
            this.groupBoxTask_TVD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_TVD.Name = "groupBoxTask_TVD";
            this.groupBoxTask_TVD.Size = new System.Drawing.Size(418, 262);
            this.groupBoxTask_TVD.TabIndex = 1;
            this.groupBoxTask_TVD.TabStop = false;
            this.groupBoxTask_TVD.Text = "Условие";
            // 
            // labelInfo_TVD
            // 
            this.labelInfo_TVD.AutoSize = true;
            this.labelInfo_TVD.Location = new System.Drawing.Point(7, 20);
            this.labelInfo_TVD.Name = "labelInfo_TVD";
            this.labelInfo_TVD.Size = new System.Drawing.Size(335, 26);
            this.labelInfo_TVD.TabIndex = 0;
            this.labelInfo_TVD.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.\r\n";
            // 
            // groupBoxInPutData_TVD
            // 
            this.groupBoxInPutData_TVD.Controls.Add(this.labelStopStep_TVD);
            this.groupBoxInPutData_TVD.Controls.Add(this.labelStartStep_TVD);
            this.groupBoxInPutData_TVD.Controls.Add(this.textBoxStopStep_TVD);
            this.groupBoxInPutData_TVD.Controls.Add(this.textBoxStartStep_TVD);
            this.groupBoxInPutData_TVD.Location = new System.Drawing.Point(13, 281);
            this.groupBoxInPutData_TVD.Name = "groupBoxInPutData_TVD";
            this.groupBoxInPutData_TVD.Size = new System.Drawing.Size(221, 71);
            this.groupBoxInPutData_TVD.TabIndex = 2;
            this.groupBoxInPutData_TVD.TabStop = false;
            this.groupBoxInPutData_TVD.Text = "Ввод данных";
            // 
            // textBoxStartStep_TVD
            // 
            this.textBoxStartStep_TVD.Location = new System.Drawing.Point(9, 39);
            this.textBoxStartStep_TVD.Name = "textBoxStartStep_TVD";
            this.textBoxStartStep_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_TVD.TabIndex = 0;
            this.textBoxStartStep_TVD.Text = "-5";
            // 
            // textBoxStopStep_TVD
            // 
            this.textBoxStopStep_TVD.Location = new System.Drawing.Point(116, 39);
            this.textBoxStopStep_TVD.Name = "textBoxStopStep_TVD";
            this.textBoxStopStep_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_TVD.TabIndex = 1;
            this.textBoxStopStep_TVD.Text = "5";
            // 
            // labelStartStep_TVD
            // 
            this.labelStartStep_TVD.AutoSize = true;
            this.labelStartStep_TVD.Location = new System.Drawing.Point(9, 20);
            this.labelStartStep_TVD.Name = "labelStartStep_TVD";
            this.labelStartStep_TVD.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_TVD.TabIndex = 2;
            this.labelStartStep_TVD.Text = "Старт шага:";
            // 
            // labelStopStep_TVD
            // 
            this.labelStopStep_TVD.AutoSize = true;
            this.labelStopStep_TVD.Location = new System.Drawing.Point(116, 20);
            this.labelStopStep_TVD.Name = "labelStopStep_TVD";
            this.labelStopStep_TVD.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_TVD.TabIndex = 3;
            this.labelStopStep_TVD.Text = "Конец шага:";
            // 
            // buttonHelp_TVD
            // 
            this.buttonHelp_TVD.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_TVD.Location = new System.Drawing.Point(240, 293);
            this.buttonHelp_TVD.Name = "buttonHelp_TVD";
            this.buttonHelp_TVD.Size = new System.Drawing.Size(75, 59);
            this.buttonHelp_TVD.TabIndex = 3;
            this.buttonHelp_TVD.Text = "Справка";
            this.buttonHelp_TVD.UseVisualStyleBackColor = false;
            this.buttonHelp_TVD.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone_TVD
            // 
            this.buttonDone_TVD.BackColor = System.Drawing.Color.Green;
            this.buttonDone_TVD.Location = new System.Drawing.Point(321, 293);
            this.buttonDone_TVD.Name = "buttonDone_TVD";
            this.buttonDone_TVD.Size = new System.Drawing.Size(109, 59);
            this.buttonDone_TVD.TabIndex = 4;
            this.buttonDone_TVD.Text = "Выполнить";
            this.buttonDone_TVD.UseVisualStyleBackColor = false;
            this.buttonDone_TVD.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone_TVD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_TVD_MouseDown);
            this.buttonDone_TVD.MouseEnter += new System.EventHandler(this.buttonDone_TVD_MouseEnter);
            this.buttonDone_TVD.MouseLeave += new System.EventHandler(this.buttonDone_TVD_MouseLeave);
            // 
            // groupBoxOutPutData_TVD
            // 
            this.groupBoxOutPutData_TVD.Controls.Add(this.chartFunction_TVD);
            this.groupBoxOutPutData_TVD.Controls.Add(this.dataGridViewFunction_TVD);
            this.groupBoxOutPutData_TVD.Controls.Add(this.labelResult_TVD);
            this.groupBoxOutPutData_TVD.Location = new System.Drawing.Point(437, 22);
            this.groupBoxOutPutData_TVD.Name = "groupBoxOutPutData_TVD";
            this.groupBoxOutPutData_TVD.Size = new System.Drawing.Size(638, 322);
            this.groupBoxOutPutData_TVD.TabIndex = 5;
            this.groupBoxOutPutData_TVD.TabStop = false;
            this.groupBoxOutPutData_TVD.Text = "Вывод данных";
            // 
            // labelResult_TVD
            // 
            this.labelResult_TVD.AutoSize = true;
            this.labelResult_TVD.Location = new System.Drawing.Point(7, 22);
            this.labelResult_TVD.Name = "labelResult_TVD";
            this.labelResult_TVD.Size = new System.Drawing.Size(62, 13);
            this.labelResult_TVD.TabIndex = 0;
            this.labelResult_TVD.Text = "Результат:";
            // 
            // dataGridViewFunction_TVD
            // 
            this.dataGridViewFunction_TVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_TVD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_TVD.Location = new System.Drawing.Point(10, 38);
            this.dataGridViewFunction_TVD.Name = "dataGridViewFunction_TVD";
            this.dataGridViewFunction_TVD.RowHeadersVisible = false;
            this.dataGridViewFunction_TVD.Size = new System.Drawing.Size(131, 277);
            this.dataGridViewFunction_TVD.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "f(x)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // chartFunction_TVD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_TVD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_TVD.Legends.Add(legend1);
            this.chartFunction_TVD.Location = new System.Drawing.Point(147, 18);
            this.chartFunction_TVD.Name = "chartFunction_TVD";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_TVD.Series.Add(series1);
            this.chartFunction_TVD.Size = new System.Drawing.Size(485, 300);
            this.chartFunction_TVD.TabIndex = 2;
            this.chartFunction_TVD.Text = "chart1";
            // 
            // pictureBoxFormula_TVD
            // 
            this.pictureBoxFormula_TVD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_TVD.Image")));
            this.pictureBoxFormula_TVD.Location = new System.Drawing.Point(13, 48);
            this.pictureBoxFormula_TVD.Name = "pictureBoxFormula_TVD";
            this.pictureBoxFormula_TVD.Size = new System.Drawing.Size(297, 50);
            this.pictureBoxFormula_TVD.TabIndex = 1;
            this.pictureBoxFormula_TVD.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 356);
            this.Controls.Add(this.groupBoxOutPutData_TVD);
            this.Controls.Add(this.buttonDone_TVD);
            this.Controls.Add(this.buttonHelp_TVD);
            this.Controls.Add(this.groupBoxInPutData_TVD);
            this.Controls.Add(this.groupBoxTask_TVD);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 8 | Тарасов В. Д.";
            this.groupBoxTask_TVD.ResumeLayout(false);
            this.groupBoxTask_TVD.PerformLayout();
            this.groupBoxInPutData_TVD.ResumeLayout(false);
            this.groupBoxInPutData_TVD.PerformLayout();
            this.groupBoxOutPutData_TVD.ResumeLayout(false);
            this.groupBoxOutPutData_TVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_TVD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_TVD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_TVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_TVD;
        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.GroupBox groupBoxInPutData_TVD;
        private System.Windows.Forms.Label labelStartStep_TVD;
        private System.Windows.Forms.TextBox textBoxStopStep_TVD;
        private System.Windows.Forms.TextBox textBoxStartStep_TVD;
        private System.Windows.Forms.Label labelStopStep_TVD;
        private System.Windows.Forms.Button buttonHelp_TVD;
        private System.Windows.Forms.Button buttonDone_TVD;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_TVD;
        private System.Windows.Forms.Label labelResult_TVD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_TVD;
        private System.Windows.Forms.DataGridView dataGridViewFunction_TVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.PictureBox pictureBoxFormula_TVD;
    }
}

