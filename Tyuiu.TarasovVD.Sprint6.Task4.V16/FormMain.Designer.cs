
namespace Tyuiu.TarasovVD.Sprint6.Task4.V16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_TVD = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_TVD = new System.Windows.Forms.PictureBox();
            this.labelInfo_TVD = new System.Windows.Forms.Label();
            this.groupBoxInPutData_TVD = new System.Windows.Forms.GroupBox();
            this.labelStopStep_TVD = new System.Windows.Forms.Label();
            this.labelStartStep_TVD = new System.Windows.Forms.Label();
            this.textBoxStopStep_TVD = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_TVD = new System.Windows.Forms.TextBox();
            this.buttonDone_TVD = new System.Windows.Forms.Button();
            this.buttonSave_TVD = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_TVD = new System.Windows.Forms.GroupBox();
            this.textBoxResult_TVD = new System.Windows.Forms.TextBox();
            this.chartFunction_TVD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonHelp_TVD = new System.Windows.Forms.Button();
            this.labelGrafik_TVD = new System.Windows.Forms.Label();
            this.groupBoxTask_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_TVD)).BeginInit();
            this.groupBoxInPutData_TVD.SuspendLayout();
            this.groupBoxOutPutData_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_TVD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_TVD
            // 
            this.groupBoxTask_TVD.Controls.Add(this.pictureBoxFormula_TVD);
            this.groupBoxTask_TVD.Controls.Add(this.labelInfo_TVD);
            this.groupBoxTask_TVD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_TVD.Name = "groupBoxTask_TVD";
            this.groupBoxTask_TVD.Size = new System.Drawing.Size(406, 134);
            this.groupBoxTask_TVD.TabIndex = 0;
            this.groupBoxTask_TVD.TabStop = false;
            this.groupBoxTask_TVD.Text = "Условие";
            // 
            // pictureBoxFormula_TVD
            // 
            this.pictureBoxFormula_TVD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_TVD.Image")));
            this.pictureBoxFormula_TVD.Location = new System.Drawing.Point(10, 73);
            this.pictureBoxFormula_TVD.Name = "pictureBoxFormula_TVD";
            this.pictureBoxFormula_TVD.Size = new System.Drawing.Size(306, 50);
            this.pictureBoxFormula_TVD.TabIndex = 1;
            this.pictureBoxFormula_TVD.TabStop = false;
            // 
            // labelInfo_TVD
            // 
            this.labelInfo_TVD.AutoSize = true;
            this.labelInfo_TVD.Location = new System.Drawing.Point(7, 20);
            this.labelInfo_TVD.Name = "labelInfo_TVD";
            this.labelInfo_TVD.Size = new System.Drawing.Size(398, 39);
            this.labelInfo_TVD.TabIndex = 0;
            this.labelInfo_TVD.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V16.txt по на" +
    "жатию кнопки.\r\n";
            // 
            // groupBoxInPutData_TVD
            // 
            this.groupBoxInPutData_TVD.Controls.Add(this.labelStopStep_TVD);
            this.groupBoxInPutData_TVD.Controls.Add(this.labelStartStep_TVD);
            this.groupBoxInPutData_TVD.Controls.Add(this.textBoxStopStep_TVD);
            this.groupBoxInPutData_TVD.Controls.Add(this.textBoxStartStep_TVD);
            this.groupBoxInPutData_TVD.Location = new System.Drawing.Point(424, 12);
            this.groupBoxInPutData_TVD.Name = "groupBoxInPutData_TVD";
            this.groupBoxInPutData_TVD.Size = new System.Drawing.Size(222, 59);
            this.groupBoxInPutData_TVD.TabIndex = 1;
            this.groupBoxInPutData_TVD.TabStop = false;
            this.groupBoxInPutData_TVD.Text = "Ввод данных";
            // 
            // labelStopStep_TVD
            // 
            this.labelStopStep_TVD.AutoSize = true;
            this.labelStopStep_TVD.Location = new System.Drawing.Point(111, 16);
            this.labelStopStep_TVD.Name = "labelStopStep_TVD";
            this.labelStopStep_TVD.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_TVD.TabIndex = 3;
            this.labelStopStep_TVD.Text = "Конец шага:";
            // 
            // labelStartStep_TVD
            // 
            this.labelStartStep_TVD.AutoSize = true;
            this.labelStartStep_TVD.Location = new System.Drawing.Point(6, 16);
            this.labelStartStep_TVD.Name = "labelStartStep_TVD";
            this.labelStartStep_TVD.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_TVD.TabIndex = 2;
            this.labelStartStep_TVD.Text = "Старт шага:";
            // 
            // textBoxStopStep_TVD
            // 
            this.textBoxStopStep_TVD.Location = new System.Drawing.Point(114, 33);
            this.textBoxStopStep_TVD.Name = "textBoxStopStep_TVD";
            this.textBoxStopStep_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_TVD.TabIndex = 1;
            this.textBoxStopStep_TVD.Text = "5";
            // 
            // textBoxStartStep_TVD
            // 
            this.textBoxStartStep_TVD.Location = new System.Drawing.Point(9, 32);
            this.textBoxStartStep_TVD.Name = "textBoxStartStep_TVD";
            this.textBoxStartStep_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_TVD.TabIndex = 0;
            this.textBoxStartStep_TVD.Text = "-5";
            // 
            // buttonDone_TVD
            // 
            this.buttonDone_TVD.BackColor = System.Drawing.Color.Green;
            this.buttonDone_TVD.Location = new System.Drawing.Point(668, 12);
            this.buttonDone_TVD.Name = "buttonDone_TVD";
            this.buttonDone_TVD.Size = new System.Drawing.Size(75, 58);
            this.buttonDone_TVD.TabIndex = 2;
            this.buttonDone_TVD.Text = "Выполнить";
            this.buttonDone_TVD.UseVisualStyleBackColor = false;
            this.buttonDone_TVD.Click += new System.EventHandler(this.buttonDone_TVD_Click);
            // 
            // buttonSave_TVD
            // 
            this.buttonSave_TVD.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSave_TVD.Location = new System.Drawing.Point(749, 13);
            this.buttonSave_TVD.Name = "buttonSave_TVD";
            this.buttonSave_TVD.Size = new System.Drawing.Size(75, 58);
            this.buttonSave_TVD.TabIndex = 3;
            this.buttonSave_TVD.Text = "Сохранить";
            this.buttonSave_TVD.UseVisualStyleBackColor = false;
            this.buttonSave_TVD.Click += new System.EventHandler(this.buttonSave_TVD_Click);
            // 
            // groupBoxOutPutData_TVD
            // 
            this.groupBoxOutPutData_TVD.Controls.Add(this.textBoxResult_TVD);
            this.groupBoxOutPutData_TVD.Location = new System.Drawing.Point(22, 153);
            this.groupBoxOutPutData_TVD.Name = "groupBoxOutPutData_TVD";
            this.groupBoxOutPutData_TVD.Size = new System.Drawing.Size(216, 285);
            this.groupBoxOutPutData_TVD.TabIndex = 5;
            this.groupBoxOutPutData_TVD.TabStop = false;
            this.groupBoxOutPutData_TVD.Text = "Вывод";
            // 
            // textBoxResult_TVD
            // 
            this.textBoxResult_TVD.Location = new System.Drawing.Point(7, 20);
            this.textBoxResult_TVD.Multiline = true;
            this.textBoxResult_TVD.Name = "textBoxResult_TVD";
            this.textBoxResult_TVD.ReadOnly = true;
            this.textBoxResult_TVD.Size = new System.Drawing.Size(203, 259);
            this.textBoxResult_TVD.TabIndex = 0;
            // 
            // chartFunction_TVD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_TVD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_TVD.Legends.Add(legend1);
            this.chartFunction_TVD.Location = new System.Drawing.Point(337, 149);
            this.chartFunction_TVD.Name = "chartFunction_TVD";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_TVD.Series.Add(series1);
            this.chartFunction_TVD.Size = new System.Drawing.Size(531, 338);
            this.chartFunction_TVD.TabIndex = 6;
            this.chartFunction_TVD.Text = "chart1";
            // 
            // buttonHelp_TVD
            // 
            this.buttonHelp_TVD.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_TVD.Location = new System.Drawing.Point(830, 13);
            this.buttonHelp_TVD.Name = "buttonHelp_TVD";
            this.buttonHelp_TVD.Size = new System.Drawing.Size(75, 57);
            this.buttonHelp_TVD.TabIndex = 7;
            this.buttonHelp_TVD.Text = "Справка";
            this.buttonHelp_TVD.UseVisualStyleBackColor = false;
            this.buttonHelp_TVD.Click += new System.EventHandler(this.buttonHelp_TVD_Click);
            // 
            // labelGrafik_TVD
            // 
            this.labelGrafik_TVD.AutoSize = true;
            this.labelGrafik_TVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrafik_TVD.ForeColor = System.Drawing.Color.Blue;
            this.labelGrafik_TVD.Location = new System.Drawing.Point(538, 132);
            this.labelGrafik_TVD.Name = "labelGrafik_TVD";
            this.labelGrafik_TVD.Size = new System.Drawing.Size(132, 16);
            this.labelGrafik_TVD.TabIndex = 8;
            this.labelGrafik_TVD.Text = "График функции";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 491);
            this.Controls.Add(this.labelGrafik_TVD);
            this.Controls.Add(this.buttonHelp_TVD);
            this.Controls.Add(this.chartFunction_TVD);
            this.Controls.Add(this.groupBoxOutPutData_TVD);
            this.Controls.Add(this.buttonSave_TVD);
            this.Controls.Add(this.buttonDone_TVD);
            this.Controls.Add(this.groupBoxInPutData_TVD);
            this.Controls.Add(this.groupBoxTask_TVD);
            this.MinimumSize = new System.Drawing.Size(950, 530);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 16 | Тарасов В. Д.";
            this.groupBoxTask_TVD.ResumeLayout(false);
            this.groupBoxTask_TVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_TVD)).EndInit();
            this.groupBoxInPutData_TVD.ResumeLayout(false);
            this.groupBoxInPutData_TVD.PerformLayout();
            this.groupBoxOutPutData_TVD.ResumeLayout(false);
            this.groupBoxOutPutData_TVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_TVD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_TVD;
        private System.Windows.Forms.PictureBox pictureBoxFormula_TVD;
        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.GroupBox groupBoxInPutData_TVD;
        private System.Windows.Forms.Label labelStopStep_TVD;
        private System.Windows.Forms.Label labelStartStep_TVD;
        private System.Windows.Forms.TextBox textBoxStopStep_TVD;
        private System.Windows.Forms.TextBox textBoxStartStep_TVD;
        private System.Windows.Forms.Button buttonDone_TVD;
        private System.Windows.Forms.Button buttonSave_TVD;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_TVD;
        private System.Windows.Forms.TextBox textBoxResult_TVD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_TVD;
        private System.Windows.Forms.Button buttonHelp_TVD;
        private System.Windows.Forms.Label labelGrafik_TVD;
    }
}

