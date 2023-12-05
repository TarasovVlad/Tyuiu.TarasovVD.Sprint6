
namespace Tyuiu.TarasovVD.Sprint6.Task5.V18
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_TVD = new System.Windows.Forms.Panel();
            this.buttonHelp_TVD = new System.Windows.Forms.Button();
            this.buttonOpenFile_TVD = new System.Windows.Forms.Button();
            this.buttonDone_TVD = new System.Windows.Forms.Button();
            this.groupBoxTask_TVD = new System.Windows.Forms.GroupBox();
            this.labelInfo_TVD = new System.Windows.Forms.Label();
            this.panelLeft_TVD = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_TVD = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_TVD = new System.Windows.Forms.DataGridView();
            this.panelFill_TVD = new System.Windows.Forms.Panel();
            this.chartDiag_TVD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterLeft_TVD = new System.Windows.Forms.Splitter();
            this.panelTop_TVD.SuspendLayout();
            this.groupBoxTask_TVD.SuspendLayout();
            this.panelLeft_TVD.SuspendLayout();
            this.groupBoxOutPutData_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_TVD)).BeginInit();
            this.panelFill_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_TVD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_TVD
            // 
            this.panelTop_TVD.BackColor = System.Drawing.Color.White;
            this.panelTop_TVD.Controls.Add(this.buttonHelp_TVD);
            this.panelTop_TVD.Controls.Add(this.buttonOpenFile_TVD);
            this.panelTop_TVD.Controls.Add(this.buttonDone_TVD);
            this.panelTop_TVD.Controls.Add(this.groupBoxTask_TVD);
            this.panelTop_TVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_TVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_TVD.Name = "panelTop_TVD";
            this.panelTop_TVD.Size = new System.Drawing.Size(698, 80);
            this.panelTop_TVD.TabIndex = 0;
            // 
            // buttonHelp_TVD
            // 
            this.buttonHelp_TVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_TVD.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_TVD.Location = new System.Drawing.Point(606, 12);
            this.buttonHelp_TVD.Name = "buttonHelp_TVD";
            this.buttonHelp_TVD.Size = new System.Drawing.Size(75, 62);
            this.buttonHelp_TVD.TabIndex = 3;
            this.buttonHelp_TVD.Text = "Справка";
            this.buttonHelp_TVD.UseVisualStyleBackColor = false;
            this.buttonHelp_TVD.Click += new System.EventHandler(this.buttonHelp_TVD_Click);
            // 
            // buttonOpenFile_TVD
            // 
            this.buttonOpenFile_TVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile_TVD.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile_TVD.Location = new System.Drawing.Point(525, 12);
            this.buttonOpenFile_TVD.Name = "buttonOpenFile_TVD";
            this.buttonOpenFile_TVD.Size = new System.Drawing.Size(75, 62);
            this.buttonOpenFile_TVD.TabIndex = 2;
            this.buttonOpenFile_TVD.Text = "Открыть файл";
            this.buttonOpenFile_TVD.UseVisualStyleBackColor = false;
            this.buttonOpenFile_TVD.Click += new System.EventHandler(this.buttonOpenFile_TVD_Click);
            // 
            // buttonDone_TVD
            // 
            this.buttonDone_TVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_TVD.BackColor = System.Drawing.Color.Green;
            this.buttonDone_TVD.Location = new System.Drawing.Point(444, 12);
            this.buttonDone_TVD.Name = "buttonDone_TVD";
            this.buttonDone_TVD.Size = new System.Drawing.Size(75, 62);
            this.buttonDone_TVD.TabIndex = 1;
            this.buttonDone_TVD.Text = "Выполнить";
            this.buttonDone_TVD.UseVisualStyleBackColor = false;
            this.buttonDone_TVD.Click += new System.EventHandler(this.buttonDone_TVD_Click);
            // 
            // groupBoxTask_TVD
            // 
            this.groupBoxTask_TVD.Controls.Add(this.labelInfo_TVD);
            this.groupBoxTask_TVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_TVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_TVD.Name = "groupBoxTask_TVD";
            this.groupBoxTask_TVD.Size = new System.Drawing.Size(427, 80);
            this.groupBoxTask_TVD.TabIndex = 0;
            this.groupBoxTask_TVD.TabStop = false;
            this.groupBoxTask_TVD.Text = "Условие";
            // 
            // labelInfo_TVD
            // 
            this.labelInfo_TVD.AutoSize = true;
            this.labelInfo_TVD.Location = new System.Drawing.Point(7, 20);
            this.labelInfo_TVD.Name = "labelInfo_TVD";
            this.labelInfo_TVD.Size = new System.Drawing.Size(412, 26);
            this.labelInfo_TVD.TabIndex = 0;
            this.labelInfo_TVD.Text = "Прочитать данные из файла InPutFileTask5V18.txt. Вывести в dataGridView.\r\n Вывест" +
    "и все вещественные числа.  Построить диаграмму по этим значениям.";
            // 
            // panelLeft_TVD
            // 
            this.panelLeft_TVD.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelLeft_TVD.Controls.Add(this.groupBoxOutPutData_TVD);
            this.panelLeft_TVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_TVD.Location = new System.Drawing.Point(0, 80);
            this.panelLeft_TVD.Name = "panelLeft_TVD";
            this.panelLeft_TVD.Size = new System.Drawing.Size(200, 370);
            this.panelLeft_TVD.TabIndex = 1;
            // 
            // groupBoxOutPutData_TVD
            // 
            this.groupBoxOutPutData_TVD.Controls.Add(this.dataGridViewResult_TVD);
            this.groupBoxOutPutData_TVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutPutData_TVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_TVD.Name = "groupBoxOutPutData_TVD";
            this.groupBoxOutPutData_TVD.Size = new System.Drawing.Size(200, 370);
            this.groupBoxOutPutData_TVD.TabIndex = 0;
            this.groupBoxOutPutData_TVD.TabStop = false;
            this.groupBoxOutPutData_TVD.Text = "Вывод данных";
            // 
            // dataGridViewResult_TVD
            // 
            this.dataGridViewResult_TVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_TVD.ColumnHeadersVisible = false;
            this.dataGridViewResult_TVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewResult_TVD.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_TVD.Name = "dataGridViewResult_TVD";
            this.dataGridViewResult_TVD.RowHeadersVisible = false;
            this.dataGridViewResult_TVD.Size = new System.Drawing.Size(194, 351);
            this.dataGridViewResult_TVD.TabIndex = 0;
            // 
            // panelFill_TVD
            // 
            this.panelFill_TVD.BackColor = System.Drawing.Color.Gold;
            this.panelFill_TVD.Controls.Add(this.chartDiag_TVD);
            this.panelFill_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_TVD.Location = new System.Drawing.Point(200, 80);
            this.panelFill_TVD.Name = "panelFill_TVD";
            this.panelFill_TVD.Size = new System.Drawing.Size(498, 370);
            this.panelFill_TVD.TabIndex = 1;
            // 
            // chartDiag_TVD
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiag_TVD.ChartAreas.Add(chartArea2);
            this.chartDiag_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartDiag_TVD.Legends.Add(legend2);
            this.chartDiag_TVD.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_TVD.Name = "chartDiag_TVD";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDiag_TVD.Series.Add(series2);
            this.chartDiag_TVD.Size = new System.Drawing.Size(498, 370);
            this.chartDiag_TVD.TabIndex = 0;
            this.chartDiag_TVD.Text = "chart1";
            // 
            // splitterLeft_TVD
            // 
            this.splitterLeft_TVD.Location = new System.Drawing.Point(200, 80);
            this.splitterLeft_TVD.Name = "splitterLeft_TVD";
            this.splitterLeft_TVD.Size = new System.Drawing.Size(3, 370);
            this.splitterLeft_TVD.TabIndex = 2;
            this.splitterLeft_TVD.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.splitterLeft_TVD);
            this.Controls.Add(this.panelFill_TVD);
            this.Controls.Add(this.panelLeft_TVD);
            this.Controls.Add(this.panelTop_TVD);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 18 | Тарасов В. Д.";
            this.panelTop_TVD.ResumeLayout(false);
            this.groupBoxTask_TVD.ResumeLayout(false);
            this.groupBoxTask_TVD.PerformLayout();
            this.panelLeft_TVD.ResumeLayout(false);
            this.groupBoxOutPutData_TVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_TVD)).EndInit();
            this.panelFill_TVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_TVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_TVD;
        private System.Windows.Forms.GroupBox groupBoxTask_TVD;
        private System.Windows.Forms.Panel panelLeft_TVD;
        private System.Windows.Forms.Panel panelFill_TVD;
        private System.Windows.Forms.Splitter splitterLeft_TVD;
        private System.Windows.Forms.Button buttonHelp_TVD;
        private System.Windows.Forms.Button buttonOpenFile_TVD;
        private System.Windows.Forms.Button buttonDone_TVD;
        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_TVD;
        private System.Windows.Forms.DataGridView dataGridViewResult_TVD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_TVD;
    }
}

