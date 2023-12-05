
namespace Tyuiu.TarasovVD.Sprint6.Task6.V6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_TVD = new System.Windows.Forms.Label();
            this.buttonOK_TVD = new System.Windows.Forms.Button();
            this.pictureBoxPhoto_TVD = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_TVD)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_TVD
            // 
            this.labelInfo_TVD.AutoSize = true;
            this.labelInfo_TVD.Location = new System.Drawing.Point(120, 13);
            this.labelInfo_TVD.Name = "labelInfo_TVD";
            this.labelInfo_TVD.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_TVD.TabIndex = 1;
            this.labelInfo_TVD.Text = resources.GetString("labelInfo_TVD.Text");
            // 
            // buttonOK_TVD
            // 
            this.buttonOK_TVD.Location = new System.Drawing.Point(325, 133);
            this.buttonOK_TVD.Name = "buttonOK_TVD";
            this.buttonOK_TVD.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_TVD.TabIndex = 2;
            this.buttonOK_TVD.Text = "Ок";
            this.buttonOK_TVD.UseVisualStyleBackColor = true;
            this.buttonOK_TVD.Click += new System.EventHandler(this.buttonOK_TVD_Click);
            // 
            // pictureBoxPhoto_TVD
            // 
            this.pictureBoxPhoto_TVD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto_TVD.Image")));
            this.pictureBoxPhoto_TVD.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxPhoto_TVD.Name = "pictureBoxPhoto_TVD";
            this.pictureBoxPhoto_TVD.Size = new System.Drawing.Size(100, 136);
            this.pictureBoxPhoto_TVD.TabIndex = 0;
            this.pictureBoxPhoto_TVD.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 161);
            this.Controls.Add(this.buttonOK_TVD);
            this.Controls.Add(this.labelInfo_TVD);
            this.Controls.Add(this.pictureBoxPhoto_TVD);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_TVD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhoto_TVD;
        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.Button buttonOK_TVD;
    }
}