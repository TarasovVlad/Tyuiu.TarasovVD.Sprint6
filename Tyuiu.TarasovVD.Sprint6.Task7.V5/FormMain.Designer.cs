
namespace Tyuiu.TarasovVD.Sprint6.Task7.V5
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
            this.panelLeft_TVD = new System.Windows.Forms.Panel();
            this.panelFill_TVD = new System.Windows.Forms.Panel();
            this.splitterLeft_TVD = new System.Windows.Forms.Splitter();
            this.groupBoxTask_TVD = new System.Windows.Forms.GroupBox();
            this.labelInfo_TVD = new System.Windows.Forms.Label();
            this.groupBoxInPutData_TVD = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPutData_TVD = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPutData_TVD = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPutData_TVD = new System.Windows.Forms.DataGridView();
            this.buttonHelp_TVD = new System.Windows.Forms.Button();
            this.buttonSaveFile_TVD = new System.Windows.Forms.Button();
            this.buttonDone_TVD = new System.Windows.Forms.Button();
            this.buttonOpenFile_TVD = new System.Windows.Forms.Button();
            this.openFileDialogTask_TVD = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_TVD = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_TVD = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_TVD.SuspendLayout();
            this.panelLeft_TVD.SuspendLayout();
            this.panelFill_TVD.SuspendLayout();
            this.groupBoxTask_TVD.SuspendLayout();
            this.groupBoxInPutData_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_TVD)).BeginInit();
            this.groupBoxOutPutData_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_TVD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_TVD
            // 
            this.panelTop_TVD.Controls.Add(this.groupBoxTask_TVD);
            this.panelTop_TVD.Controls.Add(this.buttonHelp_TVD);
            this.panelTop_TVD.Controls.Add(this.buttonSaveFile_TVD);
            this.panelTop_TVD.Controls.Add(this.buttonDone_TVD);
            this.panelTop_TVD.Controls.Add(this.buttonOpenFile_TVD);
            this.panelTop_TVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_TVD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_TVD.Name = "panelTop_TVD";
            this.panelTop_TVD.Size = new System.Drawing.Size(895, 125);
            this.panelTop_TVD.TabIndex = 0;
            // 
            // panelLeft_TVD
            // 
            this.panelLeft_TVD.Controls.Add(this.groupBoxInPutData_TVD);
            this.panelLeft_TVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_TVD.Location = new System.Drawing.Point(0, 125);
            this.panelLeft_TVD.Name = "panelLeft_TVD";
            this.panelLeft_TVD.Size = new System.Drawing.Size(436, 346);
            this.panelLeft_TVD.TabIndex = 1;
            // 
            // panelFill_TVD
            // 
            this.panelFill_TVD.Controls.Add(this.groupBoxOutPutData_TVD);
            this.panelFill_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_TVD.Location = new System.Drawing.Point(436, 125);
            this.panelFill_TVD.Name = "panelFill_TVD";
            this.panelFill_TVD.Size = new System.Drawing.Size(459, 346);
            this.panelFill_TVD.TabIndex = 2;
            // 
            // splitterLeft_TVD
            // 
            this.splitterLeft_TVD.Location = new System.Drawing.Point(436, 125);
            this.splitterLeft_TVD.Name = "splitterLeft_TVD";
            this.splitterLeft_TVD.Size = new System.Drawing.Size(3, 346);
            this.splitterLeft_TVD.TabIndex = 3;
            this.splitterLeft_TVD.TabStop = false;
            // 
            // groupBoxTask_TVD
            // 
            this.groupBoxTask_TVD.Controls.Add(this.labelInfo_TVD);
            this.groupBoxTask_TVD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxTask_TVD.Location = new System.Drawing.Point(0, 66);
            this.groupBoxTask_TVD.Name = "groupBoxTask_TVD";
            this.groupBoxTask_TVD.Size = new System.Drawing.Size(895, 59);
            this.groupBoxTask_TVD.TabIndex = 4;
            this.groupBoxTask_TVD.TabStop = false;
            this.groupBoxTask_TVD.Text = "Условие";
            // 
            // labelInfo_TVD
            // 
            this.labelInfo_TVD.AutoSize = true;
            this.labelInfo_TVD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelInfo_TVD.Location = new System.Drawing.Point(3, 17);
            this.labelInfo_TVD.Name = "labelInfo_TVD";
            this.labelInfo_TVD.Size = new System.Drawing.Size(891, 26);
            this.labelInfo_TVD.TabIndex = 0;
            this.labelInfo_TVD.Text = resources.GetString("labelInfo_TVD.Text");
            // 
            // groupBoxInPutData_TVD
            // 
            this.groupBoxInPutData_TVD.Controls.Add(this.dataGridViewInPutData_TVD);
            this.groupBoxInPutData_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData_TVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_TVD.Name = "groupBoxInPutData_TVD";
            this.groupBoxInPutData_TVD.Size = new System.Drawing.Size(436, 346);
            this.groupBoxInPutData_TVD.TabIndex = 0;
            this.groupBoxInPutData_TVD.TabStop = false;
            this.groupBoxInPutData_TVD.Text = "Ввод:";
            // 
            // dataGridViewInPutData_TVD
            // 
            this.dataGridViewInPutData_TVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutData_TVD.ColumnHeadersVisible = false;
            this.dataGridViewInPutData_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPutData_TVD.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPutData_TVD.Name = "dataGridViewInPutData_TVD";
            this.dataGridViewInPutData_TVD.ReadOnly = true;
            this.dataGridViewInPutData_TVD.RowHeadersVisible = false;
            this.dataGridViewInPutData_TVD.Size = new System.Drawing.Size(430, 327);
            this.dataGridViewInPutData_TVD.TabIndex = 0;
            // 
            // groupBoxOutPutData_TVD
            // 
            this.groupBoxOutPutData_TVD.Controls.Add(this.dataGridViewOutPutData_TVD);
            this.groupBoxOutPutData_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_TVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_TVD.Name = "groupBoxOutPutData_TVD";
            this.groupBoxOutPutData_TVD.Size = new System.Drawing.Size(459, 346);
            this.groupBoxOutPutData_TVD.TabIndex = 0;
            this.groupBoxOutPutData_TVD.TabStop = false;
            this.groupBoxOutPutData_TVD.Text = "Вывод:";
            // 
            // dataGridViewOutPutData_TVD
            // 
            this.dataGridViewOutPutData_TVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutData_TVD.ColumnHeadersVisible = false;
            this.dataGridViewOutPutData_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPutData_TVD.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPutData_TVD.Name = "dataGridViewOutPutData_TVD";
            this.dataGridViewOutPutData_TVD.ReadOnly = true;
            this.dataGridViewOutPutData_TVD.RowHeadersVisible = false;
            this.dataGridViewOutPutData_TVD.Size = new System.Drawing.Size(453, 327);
            this.dataGridViewOutPutData_TVD.TabIndex = 0;
            // 
            // buttonHelp_TVD
            // 
            this.buttonHelp_TVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_TVD.Image = global::Tyuiu.TarasovVD.Sprint6.Task7.V5.Properties.Resources.help;
            this.buttonHelp_TVD.Location = new System.Drawing.Point(817, 3);
            this.buttonHelp_TVD.Name = "buttonHelp_TVD";
            this.buttonHelp_TVD.Size = new System.Drawing.Size(75, 57);
            this.buttonHelp_TVD.TabIndex = 3;
            this.toolTip_TVD.SetToolTip(this.buttonHelp_TVD, "Сведения о программе");
            this.buttonHelp_TVD.UseVisualStyleBackColor = true;
            this.buttonHelp_TVD.Click += new System.EventHandler(this.buttonHelp_TVD_Click);
            this.buttonHelp_TVD.MouseEnter += new System.EventHandler(this.buttonHelp_TVD_MouseEnter);
            // 
            // buttonSaveFile_TVD
            // 
            this.buttonSaveFile_TVD.Enabled = false;
            this.buttonSaveFile_TVD.Image = global::Tyuiu.TarasovVD.Sprint6.Task7.V5.Properties.Resources.page_save;
            this.buttonSaveFile_TVD.Location = new System.Drawing.Point(165, 3);
            this.buttonSaveFile_TVD.Name = "buttonSaveFile_TVD";
            this.buttonSaveFile_TVD.Size = new System.Drawing.Size(75, 57);
            this.buttonSaveFile_TVD.TabIndex = 2;
            this.toolTip_TVD.SetToolTip(this.buttonSaveFile_TVD, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_TVD.UseVisualStyleBackColor = true;
            this.buttonSaveFile_TVD.Click += new System.EventHandler(this.buttonSaveFile_TVD_Click);
            this.buttonSaveFile_TVD.MouseEnter += new System.EventHandler(this.buttonSaveFile_TVD_MouseEnter);
            // 
            // buttonDone_TVD
            // 
            this.buttonDone_TVD.Enabled = false;
            this.buttonDone_TVD.Image = global::Tyuiu.TarasovVD.Sprint6.Task7.V5.Properties.Resources.page_white_go;
            this.buttonDone_TVD.Location = new System.Drawing.Point(84, 3);
            this.buttonDone_TVD.Name = "buttonDone_TVD";
            this.buttonDone_TVD.Size = new System.Drawing.Size(75, 57);
            this.buttonDone_TVD.TabIndex = 1;
            this.toolTip_TVD.SetToolTip(this.buttonDone_TVD, "Выполнить обработку данных");
            this.buttonDone_TVD.UseVisualStyleBackColor = true;
            this.buttonDone_TVD.Click += new System.EventHandler(this.buttonDone_TVD_Click);
            this.buttonDone_TVD.MouseEnter += new System.EventHandler(this.buttonDone_TVD_MouseEnter);
            // 
            // buttonOpenFile_TVD
            // 
            this.buttonOpenFile_TVD.Image = global::Tyuiu.TarasovVD.Sprint6.Task7.V5.Properties.Resources.folder_page;
            this.buttonOpenFile_TVD.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_TVD.Name = "buttonOpenFile_TVD";
            this.buttonOpenFile_TVD.Size = new System.Drawing.Size(75, 57);
            this.buttonOpenFile_TVD.TabIndex = 0;
            this.toolTip_TVD.SetToolTip(this.buttonOpenFile_TVD, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_TVD.UseVisualStyleBackColor = true;
            this.buttonOpenFile_TVD.Click += new System.EventHandler(this.buttonOpenFile_TVD_Click);
            this.buttonOpenFile_TVD.MouseEnter += new System.EventHandler(this.buttonOpenFile_TVD_MouseEnter);
            // 
            // openFileDialogTask_TVD
            // 
            this.openFileDialogTask_TVD.FileName = "openFileDialog1";
            // 
            // toolTip_TVD
            // 
            this.toolTip_TVD.IsBalloon = true;
            this.toolTip_TVD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_TVD.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 471);
            this.Controls.Add(this.splitterLeft_TVD);
            this.Controls.Add(this.panelFill_TVD);
            this.Controls.Add(this.panelLeft_TVD);
            this.Controls.Add(this.panelTop_TVD);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 5 | Тарасов В. Д.";
            this.panelTop_TVD.ResumeLayout(false);
            this.panelLeft_TVD.ResumeLayout(false);
            this.panelFill_TVD.ResumeLayout(false);
            this.groupBoxTask_TVD.ResumeLayout(false);
            this.groupBoxTask_TVD.PerformLayout();
            this.groupBoxInPutData_TVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_TVD)).EndInit();
            this.groupBoxOutPutData_TVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_TVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_TVD;
        private System.Windows.Forms.Button buttonHelp_TVD;
        private System.Windows.Forms.Button buttonSaveFile_TVD;
        private System.Windows.Forms.Button buttonDone_TVD;
        private System.Windows.Forms.Button buttonOpenFile_TVD;
        private System.Windows.Forms.Panel panelLeft_TVD;
        private System.Windows.Forms.Panel panelFill_TVD;
        private System.Windows.Forms.Splitter splitterLeft_TVD;
        private System.Windows.Forms.GroupBox groupBoxTask_TVD;
        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.GroupBox groupBoxInPutData_TVD;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_TVD;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_TVD;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_TVD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_TVD;
        private System.Windows.Forms.ToolTip toolTip_TVD;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_TVD;
    }
}

