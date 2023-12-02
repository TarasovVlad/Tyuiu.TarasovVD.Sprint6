
namespace Tyuiu.TarasovVD.Sprint6.Task1.V12
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
            this.groupBoxTask_TVD = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_TVD = new System.Windows.Forms.PictureBox();
            this.labelInfo_TVD = new System.Windows.Forms.Label();
            this.groupBoxInPutData_TVD = new System.Windows.Forms.GroupBox();
            this.labelStop_TVD = new System.Windows.Forms.Label();
            this.labelStart_TVD = new System.Windows.Forms.Label();
            this.textBoxStopStep_TVD = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_TVD = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_TVD = new System.Windows.Forms.GroupBox();
            this.labelResult_TVD = new System.Windows.Forms.Label();
            this.textBoxResult_TVD = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonHelp_TVD = new System.Windows.Forms.Button();
            this.groupBoxTask_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_TVD)).BeginInit();
            this.groupBoxInPutData_TVD.SuspendLayout();
            this.groupBoxOutPutData_TVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_TVD
            // 
            this.groupBoxTask_TVD.Controls.Add(this.pictureBoxFormula_TVD);
            this.groupBoxTask_TVD.Controls.Add(this.labelInfo_TVD);
            this.groupBoxTask_TVD.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_TVD.Name = "groupBoxTask_TVD";
            this.groupBoxTask_TVD.Size = new System.Drawing.Size(482, 311);
            this.groupBoxTask_TVD.TabIndex = 0;
            this.groupBoxTask_TVD.TabStop = false;
            this.groupBoxTask_TVD.Text = "Условие";
            // 
            // pictureBoxFormula_TVD
            // 
            this.pictureBoxFormula_TVD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_TVD.Image")));
            this.pictureBoxFormula_TVD.Location = new System.Drawing.Point(13, 62);
            this.pictureBoxFormula_TVD.Name = "pictureBoxFormula_TVD";
            this.pictureBoxFormula_TVD.Size = new System.Drawing.Size(302, 38);
            this.pictureBoxFormula_TVD.TabIndex = 1;
            this.pictureBoxFormula_TVD.TabStop = false;
            // 
            // labelInfo_TVD
            // 
            this.labelInfo_TVD.AutoSize = true;
            this.labelInfo_TVD.Location = new System.Drawing.Point(10, 20);
            this.labelInfo_TVD.Name = "labelInfo_TVD";
            this.labelInfo_TVD.Size = new System.Drawing.Size(272, 26);
            this.labelInfo_TVD.TabIndex = 0;
            this.labelInfo_TVD.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы." +
    "\r\n";
            // 
            // groupBoxInPutData_TVD
            // 
            this.groupBoxInPutData_TVD.Controls.Add(this.labelStop_TVD);
            this.groupBoxInPutData_TVD.Controls.Add(this.labelStart_TVD);
            this.groupBoxInPutData_TVD.Controls.Add(this.textBoxStopStep_TVD);
            this.groupBoxInPutData_TVD.Controls.Add(this.textBoxStartStep_TVD);
            this.groupBoxInPutData_TVD.Location = new System.Drawing.Point(13, 330);
            this.groupBoxInPutData_TVD.Name = "groupBoxInPutData_TVD";
            this.groupBoxInPutData_TVD.Size = new System.Drawing.Size(263, 67);
            this.groupBoxInPutData_TVD.TabIndex = 1;
            this.groupBoxInPutData_TVD.TabStop = false;
            this.groupBoxInPutData_TVD.Text = "Ввод данных";
            // 
            // labelStop_TVD
            // 
            this.labelStop_TVD.AutoSize = true;
            this.labelStop_TVD.Location = new System.Drawing.Point(117, 20);
            this.labelStop_TVD.Name = "labelStop_TVD";
            this.labelStop_TVD.Size = new System.Drawing.Size(69, 13);
            this.labelStop_TVD.TabIndex = 3;
            this.labelStop_TVD.Text = "Конец шага:";
            // 
            // labelStart_TVD
            // 
            this.labelStart_TVD.AutoSize = true;
            this.labelStart_TVD.Location = new System.Drawing.Point(7, 20);
            this.labelStart_TVD.Name = "labelStart_TVD";
            this.labelStart_TVD.Size = new System.Drawing.Size(67, 13);
            this.labelStart_TVD.TabIndex = 2;
            this.labelStart_TVD.Text = "Старт шага:";
            // 
            // textBoxStopStep_TVD
            // 
            this.textBoxStopStep_TVD.Location = new System.Drawing.Point(117, 39);
            this.textBoxStopStep_TVD.Name = "textBoxStopStep_TVD";
            this.textBoxStopStep_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_TVD.TabIndex = 1;
            this.textBoxStopStep_TVD.Text = "5";
            // 
            // textBoxStartStep_TVD
            // 
            this.textBoxStartStep_TVD.Location = new System.Drawing.Point(6, 39);
            this.textBoxStartStep_TVD.Name = "textBoxStartStep_TVD";
            this.textBoxStartStep_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_TVD.TabIndex = 0;
            this.textBoxStartStep_TVD.Text = "-5";
            // 
            // groupBoxOutPutData_TVD
            // 
            this.groupBoxOutPutData_TVD.Controls.Add(this.labelResult_TVD);
            this.groupBoxOutPutData_TVD.Controls.Add(this.textBoxResult_TVD);
            this.groupBoxOutPutData_TVD.Location = new System.Drawing.Point(501, 13);
            this.groupBoxOutPutData_TVD.Name = "groupBoxOutPutData_TVD";
            this.groupBoxOutPutData_TVD.Size = new System.Drawing.Size(212, 418);
            this.groupBoxOutPutData_TVD.TabIndex = 2;
            this.groupBoxOutPutData_TVD.TabStop = false;
            this.groupBoxOutPutData_TVD.Text = "Вывод данных";
            // 
            // labelResult_TVD
            // 
            this.labelResult_TVD.AutoSize = true;
            this.labelResult_TVD.Location = new System.Drawing.Point(7, 20);
            this.labelResult_TVD.Name = "labelResult_TVD";
            this.labelResult_TVD.Size = new System.Drawing.Size(62, 13);
            this.labelResult_TVD.TabIndex = 1;
            this.labelResult_TVD.Text = "Результат:";
            // 
            // textBoxResult_TVD
            // 
            this.textBoxResult_TVD.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_TVD.Location = new System.Drawing.Point(7, 42);
            this.textBoxResult_TVD.Multiline = true;
            this.textBoxResult_TVD.Name = "textBoxResult_TVD";
            this.textBoxResult_TVD.ReadOnly = true;
            this.textBoxResult_TVD.Size = new System.Drawing.Size(197, 342);
            this.textBoxResult_TVD.TabIndex = 0;
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Green;
            this.buttonDone.Location = new System.Drawing.Point(370, 334);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(125, 55);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp_TVD
            // 
            this.buttonHelp_TVD.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_TVD.Location = new System.Drawing.Point(282, 334);
            this.buttonHelp_TVD.Name = "buttonHelp_TVD";
            this.buttonHelp_TVD.Size = new System.Drawing.Size(82, 55);
            this.buttonHelp_TVD.TabIndex = 4;
            this.buttonHelp_TVD.Text = "Справка";
            this.buttonHelp_TVD.UseVisualStyleBackColor = false;
            this.buttonHelp_TVD.Click += new System.EventHandler(this.buttonHelp_TVD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 401);
            this.Controls.Add(this.buttonHelp_TVD);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxOutPutData_TVD);
            this.Controls.Add(this.groupBoxInPutData_TVD);
            this.Controls.Add(this.groupBoxTask_TVD);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 12 | Тарасов В. Д.";
            this.groupBoxTask_TVD.ResumeLayout(false);
            this.groupBoxTask_TVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_TVD)).EndInit();
            this.groupBoxInPutData_TVD.ResumeLayout(false);
            this.groupBoxInPutData_TVD.PerformLayout();
            this.groupBoxOutPutData_TVD.ResumeLayout(false);
            this.groupBoxOutPutData_TVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_TVD;
        private System.Windows.Forms.GroupBox groupBoxInPutData_TVD;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_TVD;
        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.Label labelStop_TVD;
        private System.Windows.Forms.Label labelStart_TVD;
        private System.Windows.Forms.TextBox textBoxStopStep_TVD;
        private System.Windows.Forms.TextBox textBoxStartStep_TVD;
        private System.Windows.Forms.Label labelResult_TVD;
        private System.Windows.Forms.TextBox textBoxResult_TVD;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp_TVD;
        private System.Windows.Forms.PictureBox pictureBoxFormula_TVD;
    }
}

