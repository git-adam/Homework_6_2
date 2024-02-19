
namespace Homework_6_2
{
    partial class FullScreenPhoto
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
            this.pbFullScreenPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFullScreenPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFullScreenPhoto
            // 
            this.pbFullScreenPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFullScreenPhoto.Location = new System.Drawing.Point(0, 0);
            this.pbFullScreenPhoto.Name = "pbFullScreenPhoto";
            this.pbFullScreenPhoto.Size = new System.Drawing.Size(800, 450);
            this.pbFullScreenPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFullScreenPhoto.TabIndex = 0;
            this.pbFullScreenPhoto.TabStop = false;
            this.pbFullScreenPhoto.DoubleClick += new System.EventHandler(this.pbFullScreenPhoto_DoubleClick);
            // 
            // FullScreenPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbFullScreenPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FullScreenPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FullScreenPhoto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbFullScreenPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFullScreenPhoto;
    }
}