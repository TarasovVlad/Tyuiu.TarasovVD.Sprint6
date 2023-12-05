
namespace Tyuiu.TarasovVD.Sprint6.Task6.V6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_TVD = new System.Windows.Forms.Panel();
            this.groupBoxTask_TVD = new System.Windows.Forms.GroupBox();
            this.labelInfo_TVD = new System.Windows.Forms.Label();
            this.panelLeft_TVD = new System.Windows.Forms.Panel();
            this.groupBoxInPutData_TVD = new System.Windows.Forms.GroupBox();
            this.textBoxInPutData_TVD = new System.Windows.Forms.TextBox();
            this.splitterLeft_TVD = new System.Windows.Forms.Splitter();
            this.panelFill_TVD = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_TVD = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_TVD = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_TVD = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_TVD = new System.Windows.Forms.ToolTip(this.components);
            this.buttonHelp_TVD = new System.Windows.Forms.Button();
            this.buttonDone_TVD = new System.Windows.Forms.Button();
            this.buttonOpenFile_TVD = new System.Windows.Forms.Button();
            this.panelTop_TVD.SuspendLayout();
            this.groupBoxTask_TVD.SuspendLayout();
            this.panelLeft_TVD.SuspendLayout();
            this.groupBoxInPutData_TVD.SuspendLayout();
            this.panelFill_TVD.SuspendLayout();
            this.groupBoxOutPutData_TVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_TVD
            // 
            this.panelTop_TVD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelTop_TVD.Controls.Add(this.buttonHelp_TVD);
            this.panelTop_TVD.Controls.Add(this.buttonDone_TVD);
            this.panelTop_TVD.Controls.Add(this.groupBoxTask_TVD);
            this.panelTop_TVD.Controls.Add(this.buttonOpenFile_TVD);
            this.panelTop_TVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_TVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_TVD.Name = "panelTop_TVD";
            this.panelTop_TVD.Size = new System.Drawing.Size(634, 133);
            this.panelTop_TVD.TabIndex = 0;
            // 
            // groupBoxTask_TVD
            // 
            this.groupBoxTask_TVD.Controls.Add(this.labelInfo_TVD);
            this.groupBoxTask_TVD.Location = new System.Drawing.Point(13, 66);
            this.groupBoxTask_TVD.Name = "groupBoxTask_TVD";
            this.groupBoxTask_TVD.Size = new System.Drawing.Size(613, 61);
            this.groupBoxTask_TVD.TabIndex = 1;
            this.groupBoxTask_TVD.TabStop = false;
            this.groupBoxTask_TVD.Text = "Условие";
            // 
            // labelInfo_TVD
            // 
            this.labelInfo_TVD.AutoSize = true;
            this.labelInfo_TVD.Location = new System.Drawing.Point(7, 20);
            this.labelInfo_TVD.Name = "labelInfo_TVD";
            this.labelInfo_TVD.Size = new System.Drawing.Size(598, 26);
            this.labelInfo_TVD.TabIndex = 0;
            this.labelInfo_TVD.Text = resources.GetString("labelInfo_TVD.Text");
            // 
            // panelLeft_TVD
            // 
            this.panelLeft_TVD.Controls.Add(this.groupBoxInPutData_TVD);
            this.panelLeft_TVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_TVD.Location = new System.Drawing.Point(0, 133);
            this.panelLeft_TVD.Name = "panelLeft_TVD";
            this.panelLeft_TVD.Size = new System.Drawing.Size(309, 317);
            this.panelLeft_TVD.TabIndex = 1;
            // 
            // groupBoxInPutData_TVD
            // 
            this.groupBoxInPutData_TVD.Controls.Add(this.textBoxInPutData_TVD);
            this.groupBoxInPutData_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData_TVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_TVD.Name = "groupBoxInPutData_TVD";
            this.groupBoxInPutData_TVD.Size = new System.Drawing.Size(309, 317);
            this.groupBoxInPutData_TVD.TabIndex = 0;
            this.groupBoxInPutData_TVD.TabStop = false;
            this.groupBoxInPutData_TVD.Text = "Ввод:";
            // 
            // textBoxInPutData_TVD
            // 
            this.textBoxInPutData_TVD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxInPutData_TVD.Location = new System.Drawing.Point(3, 41);
            this.textBoxInPutData_TVD.Multiline = true;
            this.textBoxInPutData_TVD.Name = "textBoxInPutData_TVD";
            this.textBoxInPutData_TVD.ReadOnly = true;
            this.textBoxInPutData_TVD.Size = new System.Drawing.Size(303, 273);
            this.textBoxInPutData_TVD.TabIndex = 0;
            // 
            // splitterLeft_TVD
            // 
            this.splitterLeft_TVD.Location = new System.Drawing.Point(309, 133);
            this.splitterLeft_TVD.Name = "splitterLeft_TVD";
            this.splitterLeft_TVD.Size = new System.Drawing.Size(3, 317);
            this.splitterLeft_TVD.TabIndex = 2;
            this.splitterLeft_TVD.TabStop = false;
            // 
            // panelFill_TVD
            // 
            this.panelFill_TVD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFill_TVD.Controls.Add(this.groupBoxOutPutData_TVD);
            this.panelFill_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_TVD.Location = new System.Drawing.Point(312, 133);
            this.panelFill_TVD.Name = "panelFill_TVD";
            this.panelFill_TVD.Size = new System.Drawing.Size(322, 317);
            this.panelFill_TVD.TabIndex = 3;
            // 
            // groupBoxOutPutData_TVD
            // 
            this.groupBoxOutPutData_TVD.Controls.Add(this.textBoxOutPutData_TVD);
            this.groupBoxOutPutData_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_TVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_TVD.Name = "groupBoxOutPutData_TVD";
            this.groupBoxOutPutData_TVD.Size = new System.Drawing.Size(322, 317);
            this.groupBoxOutPutData_TVD.TabIndex = 0;
            this.groupBoxOutPutData_TVD.TabStop = false;
            this.groupBoxOutPutData_TVD.Text = "Вывод:";
            // 
            // textBoxOutPutData_TVD
            // 
            this.textBoxOutPutData_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPutData_TVD.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPutData_TVD.Multiline = true;
            this.textBoxOutPutData_TVD.Name = "textBoxOutPutData_TVD";
            this.textBoxOutPutData_TVD.Size = new System.Drawing.Size(316, 298);
            this.textBoxOutPutData_TVD.TabIndex = 0;
            // 
            // openFileDialogTask_TVD
            // 
            this.openFileDialogTask_TVD.FileName = "openFileDialog1";
            // 
            // toolTip_TVD
            // 
            this.toolTip_TVD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_TVD.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_TVD
            // 
            this.buttonHelp_TVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_TVD.Image = global::Tyuiu.TarasovVD.Sprint6.Task6.V6.Properties.Resources.help;
            this.buttonHelp_TVD.Location = new System.Drawing.Point(551, 4);
            this.buttonHelp_TVD.Name = "buttonHelp_TVD";
            this.buttonHelp_TVD.Size = new System.Drawing.Size(75, 56);
            this.buttonHelp_TVD.TabIndex = 3;
            this.toolTip_TVD.SetToolTip(this.buttonHelp_TVD, "Сведения о программе");
            this.buttonHelp_TVD.UseVisualStyleBackColor = true;
            this.buttonHelp_TVD.Click += new System.EventHandler(this.buttonHelp_TVD_Click);
            // 
            // buttonDone_TVD
            // 
            this.buttonDone_TVD.Enabled = false;
            this.buttonDone_TVD.Image = global::Tyuiu.TarasovVD.Sprint6.Task6.V6.Properties.Resources.page_go;
            this.buttonDone_TVD.Location = new System.Drawing.Point(84, 4);
            this.buttonDone_TVD.Name = "buttonDone_TVD";
            this.buttonDone_TVD.Size = new System.Drawing.Size(75, 56);
            this.buttonDone_TVD.TabIndex = 2;
            this.buttonDone_TVD.UseVisualStyleBackColor = true;
            this.buttonDone_TVD.Click += new System.EventHandler(this.buttonDone_TVD_Click);
            // 
            // buttonOpenFile_TVD
            // 
            this.buttonOpenFile_TVD.Image = global::Tyuiu.TarasovVD.Sprint6.Task6.V6.Properties.Resources.folder_page;
            this.buttonOpenFile_TVD.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_TVD.Name = "buttonOpenFile_TVD";
            this.buttonOpenFile_TVD.Size = new System.Drawing.Size(75, 56);
            this.buttonOpenFile_TVD.TabIndex = 0;
            this.toolTip_TVD.SetToolTip(this.buttonOpenFile_TVD, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_TVD.UseVisualStyleBackColor = true;
            this.buttonOpenFile_TVD.Click += new System.EventHandler(this.buttonOpenFile_TVD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.panelFill_TVD);
            this.Controls.Add(this.splitterLeft_TVD);
            this.Controls.Add(this.panelLeft_TVD);
            this.Controls.Add(this.panelTop_TVD);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 6 | Тарасов В. Д. ";
            this.panelTop_TVD.ResumeLayout(false);
            this.groupBoxTask_TVD.ResumeLayout(false);
            this.groupBoxTask_TVD.PerformLayout();
            this.panelLeft_TVD.ResumeLayout(false);
            this.groupBoxInPutData_TVD.ResumeLayout(false);
            this.groupBoxInPutData_TVD.PerformLayout();
            this.panelFill_TVD.ResumeLayout(false);
            this.groupBoxOutPutData_TVD.ResumeLayout(false);
            this.groupBoxOutPutData_TVD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_TVD;
        private System.Windows.Forms.Panel panelLeft_TVD;
        private System.Windows.Forms.Button buttonOpenFile_TVD;
        private System.Windows.Forms.GroupBox groupBoxTask_TVD;
        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.Button buttonHelp_TVD;
        private System.Windows.Forms.Button buttonDone_TVD;
        private System.Windows.Forms.GroupBox groupBoxInPutData_TVD;
        private System.Windows.Forms.TextBox textBoxInPutData_TVD;
        private System.Windows.Forms.Splitter splitterLeft_TVD;
        private System.Windows.Forms.Panel panelFill_TVD;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_TVD;
        private System.Windows.Forms.TextBox textBoxOutPutData_TVD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_TVD;
        private System.Windows.Forms.ToolTip toolTip_TVD;
    }
}

