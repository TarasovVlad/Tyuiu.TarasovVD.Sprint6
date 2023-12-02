
namespace Tyuiu.TarasovVD.Sprint6.Task3.V30
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
            this.groupBoxTask_TVD = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_TVD = new System.Windows.Forms.DataGridView();
            this.labelInfo_TVD = new System.Windows.Forms.Label();
            this.groupBoxOutPutData_TVD = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix2_TVD = new System.Windows.Forms.DataGridView();
            this.buttonDone_TVD = new System.Windows.Forms.Button();
            this.buttonHelp_TVD = new System.Windows.Forms.Button();
            this.groupBoxTask_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_TVD)).BeginInit();
            this.groupBoxOutPutData_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix2_TVD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_TVD
            // 
            this.groupBoxTask_TVD.Controls.Add(this.dataGridViewMatrix_TVD);
            this.groupBoxTask_TVD.Controls.Add(this.labelInfo_TVD);
            this.groupBoxTask_TVD.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_TVD.Name = "groupBoxTask_TVD";
            this.groupBoxTask_TVD.Size = new System.Drawing.Size(517, 255);
            this.groupBoxTask_TVD.TabIndex = 0;
            this.groupBoxTask_TVD.TabStop = false;
            this.groupBoxTask_TVD.Text = "Условие";
            // 
            // dataGridViewMatrix_TVD
            // 
            this.dataGridViewMatrix_TVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_TVD.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_TVD.Location = new System.Drawing.Point(266, 20);
            this.dataGridViewMatrix_TVD.Name = "dataGridViewMatrix_TVD";
            this.dataGridViewMatrix_TVD.ReadOnly = true;
            this.dataGridViewMatrix_TVD.RowHeadersVisible = false;
            this.dataGridViewMatrix_TVD.Size = new System.Drawing.Size(240, 223);
            this.dataGridViewMatrix_TVD.TabIndex = 1;
            // 
            // labelInfo_TVD
            // 
            this.labelInfo_TVD.AutoSize = true;
            this.labelInfo_TVD.Location = new System.Drawing.Point(7, 20);
            this.labelInfo_TVD.Name = "labelInfo_TVD";
            this.labelInfo_TVD.Size = new System.Drawing.Size(252, 91);
            this.labelInfo_TVD.TabIndex = 0;
            this.labelInfo_TVD.Text = "Дана матрица 5 на 5\r\n -9  -4  17  -1 -20\r\n -19  18  -4   2  14\r\n -12  16  -2   7 " +
    " 18\r\n -16  15   4 -12 -13\r\n -15  -4 -16   1 -14\r\nЗаменить четные значения в пято" +
    "й строке на 0.";
            // 
            // groupBoxOutPutData_TVD
            // 
            this.groupBoxOutPutData_TVD.Controls.Add(this.dataGridViewMatrix2_TVD);
            this.groupBoxOutPutData_TVD.Location = new System.Drawing.Point(536, 13);
            this.groupBoxOutPutData_TVD.Name = "groupBoxOutPutData_TVD";
            this.groupBoxOutPutData_TVD.Size = new System.Drawing.Size(252, 255);
            this.groupBoxOutPutData_TVD.TabIndex = 1;
            this.groupBoxOutPutData_TVD.TabStop = false;
            this.groupBoxOutPutData_TVD.Text = "Вывод данных";
            // 
            // dataGridViewMatrix2_TVD
            // 
            this.dataGridViewMatrix2_TVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix2_TVD.ColumnHeadersVisible = false;
            this.dataGridViewMatrix2_TVD.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMatrix2_TVD.Name = "dataGridViewMatrix2_TVD";
            this.dataGridViewMatrix2_TVD.ReadOnly = true;
            this.dataGridViewMatrix2_TVD.RowHeadersVisible = false;
            this.dataGridViewMatrix2_TVD.Size = new System.Drawing.Size(240, 223);
            this.dataGridViewMatrix2_TVD.TabIndex = 0;
            // 
            // buttonDone_TVD
            // 
            this.buttonDone_TVD.Location = new System.Drawing.Point(684, 268);
            this.buttonDone_TVD.Name = "buttonDone_TVD";
            this.buttonDone_TVD.Size = new System.Drawing.Size(98, 33);
            this.buttonDone_TVD.TabIndex = 2;
            this.buttonDone_TVD.Text = "Выполнить";
            this.buttonDone_TVD.UseVisualStyleBackColor = true;
            this.buttonDone_TVD.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp_TVD
            // 
            this.buttonHelp_TVD.Location = new System.Drawing.Point(647, 268);
            this.buttonHelp_TVD.Name = "buttonHelp_TVD";
            this.buttonHelp_TVD.Size = new System.Drawing.Size(31, 33);
            this.buttonHelp_TVD.TabIndex = 3;
            this.buttonHelp_TVD.Text = "?";
            this.buttonHelp_TVD.UseVisualStyleBackColor = true;
            this.buttonHelp_TVD.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.buttonHelp_TVD);
            this.Controls.Add(this.buttonDone_TVD);
            this.Controls.Add(this.groupBoxOutPutData_TVD);
            this.Controls.Add(this.groupBoxTask_TVD);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 30 |  Тарасов В. Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_TVD.ResumeLayout(false);
            this.groupBoxTask_TVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_TVD)).EndInit();
            this.groupBoxOutPutData_TVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix2_TVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_TVD;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_TVD;
        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_TVD;
        private System.Windows.Forms.DataGridView dataGridViewMatrix2_TVD;
        private System.Windows.Forms.Button buttonDone_TVD;
        private System.Windows.Forms.Button buttonHelp_TVD;
    }
}

