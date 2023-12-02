
namespace Tyuiu.TarasovVD.Sprint6.Task0.V7
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
            this.pictureBoxFormula_TVD = new System.Windows.Forms.PictureBox();
            this.groupBoxTask_TVD = new System.Windows.Forms.GroupBox();
            this.groupBoxInputData_TVD = new System.Windows.Forms.GroupBox();
            this.labelVarX_TVD = new System.Windows.Forms.Label();
            this.textBoxVarX_TVD = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_TVD = new System.Windows.Forms.GroupBox();
            this.labelResult_TVD = new System.Windows.Forms.Label();
            this.textBoxResult_TVD = new System.Windows.Forms.TextBox();
            this.buttonDone_TVD = new System.Windows.Forms.Button();
            this.buttonInfo_TVD = new System.Windows.Forms.Button();
            this.labelnfo_TVD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_TVD)).BeginInit();
            this.groupBoxTask_TVD.SuspendLayout();
            this.groupBoxInputData_TVD.SuspendLayout();
            this.groupBoxOutPutData_TVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxFormula_TVD
            // 
            this.pictureBoxFormula_TVD.Image = global::Tyuiu.TarasovVD.Sprint6.Task0.V7.Properties.Resources.Untitled;
            this.pictureBoxFormula_TVD.Location = new System.Drawing.Point(356, 19);
            this.pictureBoxFormula_TVD.Name = "pictureBoxFormula_TVD";
            this.pictureBoxFormula_TVD.Size = new System.Drawing.Size(133, 74);
            this.pictureBoxFormula_TVD.TabIndex = 0;
            this.pictureBoxFormula_TVD.TabStop = false;
            // 
            // groupBoxTask_TVD
            // 
            this.groupBoxTask_TVD.Controls.Add(this.labelnfo_TVD);
            this.groupBoxTask_TVD.Controls.Add(this.pictureBoxFormula_TVD);
            this.groupBoxTask_TVD.Location = new System.Drawing.Point(12, 26);
            this.groupBoxTask_TVD.Name = "groupBoxTask_TVD";
            this.groupBoxTask_TVD.Size = new System.Drawing.Size(499, 218);
            this.groupBoxTask_TVD.TabIndex = 1;
            this.groupBoxTask_TVD.TabStop = false;
            this.groupBoxTask_TVD.Text = "Условие";
            // 
            // groupBoxInputData_TVD
            // 
            this.groupBoxInputData_TVD.Controls.Add(this.labelVarX_TVD);
            this.groupBoxInputData_TVD.Controls.Add(this.textBoxVarX_TVD);
            this.groupBoxInputData_TVD.Location = new System.Drawing.Point(27, 250);
            this.groupBoxInputData_TVD.Name = "groupBoxInputData_TVD";
            this.groupBoxInputData_TVD.Size = new System.Drawing.Size(335, 100);
            this.groupBoxInputData_TVD.TabIndex = 2;
            this.groupBoxInputData_TVD.TabStop = false;
            this.groupBoxInputData_TVD.Text = "Ввод данных";
            // 
            // labelVarX_TVD
            // 
            this.labelVarX_TVD.AutoSize = true;
            this.labelVarX_TVD.Location = new System.Drawing.Point(7, 42);
            this.labelVarX_TVD.Name = "labelVarX_TVD";
            this.labelVarX_TVD.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_TVD.TabIndex = 1;
            this.labelVarX_TVD.Text = "Переменная X:";
            // 
            // textBoxVarX_TVD
            // 
            this.textBoxVarX_TVD.Location = new System.Drawing.Point(6, 58);
            this.textBoxVarX_TVD.Name = "textBoxVarX_TVD";
            this.textBoxVarX_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_TVD.TabIndex = 0;
            this.textBoxVarX_TVD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // groupBoxOutPutData_TVD
            // 
            this.groupBoxOutPutData_TVD.Controls.Add(this.labelResult_TVD);
            this.groupBoxOutPutData_TVD.Controls.Add(this.textBoxResult_TVD);
            this.groupBoxOutPutData_TVD.Location = new System.Drawing.Point(368, 250);
            this.groupBoxOutPutData_TVD.Name = "groupBoxOutPutData_TVD";
            this.groupBoxOutPutData_TVD.Size = new System.Drawing.Size(143, 100);
            this.groupBoxOutPutData_TVD.TabIndex = 3;
            this.groupBoxOutPutData_TVD.TabStop = false;
            this.groupBoxOutPutData_TVD.Text = "Вывод данных";
            // 
            // labelResult_TVD
            // 
            this.labelResult_TVD.AutoSize = true;
            this.labelResult_TVD.Location = new System.Drawing.Point(6, 42);
            this.labelResult_TVD.Name = "labelResult_TVD";
            this.labelResult_TVD.Size = new System.Drawing.Size(62, 13);
            this.labelResult_TVD.TabIndex = 1;
            this.labelResult_TVD.Text = "Результат:";
            // 
            // textBoxResult_TVD
            // 
            this.textBoxResult_TVD.Location = new System.Drawing.Point(6, 58);
            this.textBoxResult_TVD.Name = "textBoxResult_TVD";
            this.textBoxResult_TVD.ReadOnly = true;
            this.textBoxResult_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_TVD.TabIndex = 0;
            this.textBoxResult_TVD.TextChanged += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonDone_TVD
            // 
            this.buttonDone_TVD.Location = new System.Drawing.Point(407, 357);
            this.buttonDone_TVD.Name = "buttonDone_TVD";
            this.buttonDone_TVD.Size = new System.Drawing.Size(104, 38);
            this.buttonDone_TVD.TabIndex = 4;
            this.buttonDone_TVD.Text = "Выполнить";
            this.buttonDone_TVD.UseVisualStyleBackColor = true;
            this.buttonDone_TVD.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonInfo_TVD
            // 
            this.buttonInfo_TVD.Location = new System.Drawing.Point(364, 357);
            this.buttonInfo_TVD.Name = "buttonInfo_TVD";
            this.buttonInfo_TVD.Size = new System.Drawing.Size(37, 38);
            this.buttonInfo_TVD.TabIndex = 5;
            this.buttonInfo_TVD.Text = "?";
            this.buttonInfo_TVD.UseVisualStyleBackColor = true;
            this.buttonInfo_TVD.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // labelnfo_TVD
            // 
            this.labelnfo_TVD.AutoSize = true;
            this.labelnfo_TVD.Location = new System.Drawing.Point(25, 20);
            this.labelnfo_TVD.Name = "labelnfo_TVD";
            this.labelnfo_TVD.Size = new System.Drawing.Size(186, 13);
            this.labelnfo_TVD.TabIndex = 1;
            this.labelnfo_TVD.Text = "Вычислить выражение по формуле";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 407);
            this.Controls.Add(this.buttonInfo_TVD);
            this.Controls.Add(this.buttonDone_TVD);
            this.Controls.Add(this.groupBoxOutPutData_TVD);
            this.Controls.Add(this.groupBoxInputData_TVD);
            this.Controls.Add(this.groupBoxTask_TVD);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Такс 0 | Вариант 7 | Тарасов В. Д. ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_TVD)).EndInit();
            this.groupBoxTask_TVD.ResumeLayout(false);
            this.groupBoxTask_TVD.PerformLayout();
            this.groupBoxInputData_TVD.ResumeLayout(false);
            this.groupBoxInputData_TVD.PerformLayout();
            this.groupBoxOutPutData_TVD.ResumeLayout(false);
            this.groupBoxOutPutData_TVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFormula_TVD;
        private System.Windows.Forms.GroupBox groupBoxTask_TVD;
        private System.Windows.Forms.GroupBox groupBoxInputData_TVD;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_TVD;
        private System.Windows.Forms.Button buttonDone_TVD;
        private System.Windows.Forms.TextBox textBoxResult_TVD;
        private System.Windows.Forms.Label labelVarX_TVD;
        private System.Windows.Forms.TextBox textBoxVarX_TVD;
        private System.Windows.Forms.Label labelResult_TVD;
        private System.Windows.Forms.Button buttonInfo_TVD;
        private System.Windows.Forms.Label labelnfo_TVD;
    }
}

