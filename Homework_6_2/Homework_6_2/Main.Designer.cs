
using System;

namespace Homework_6_2
{
    partial class Main
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
            this.pbAddedPhoto = new System.Windows.Forms.PictureBox();
            this.ofdBrowsePhoto = new System.Windows.Forms.OpenFileDialog();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.tbPhotoPath = new System.Windows.Forms.TextBox();
            this.btnDeletePhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddedPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAddedPhoto
            // 
            this.pbAddedPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAddedPhoto.BackColor = System.Drawing.SystemColors.GrayText;
            this.pbAddedPhoto.Location = new System.Drawing.Point(12, 12);
            this.pbAddedPhoto.Name = "pbAddedPhoto";
            this.pbAddedPhoto.Size = new System.Drawing.Size(776, 374);
            this.pbAddedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddedPhoto.TabIndex = 0;
            this.pbAddedPhoto.TabStop = false;
            this.pbAddedPhoto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbAddedPhoto_MouseDoubleClick);
            // 
            // ofdBrowsePhoto
            // 
            this.ofdBrowsePhoto.Title = "Przeglądaj zdjęcia";
            this.ofdBrowsePhoto.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdBrowsePhoto_FileOk);
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPhoto.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddPhoto.Location = new System.Drawing.Point(654, 404);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(109, 45);
            this.btnAddPhoto.TabIndex = 1;
            this.btnAddPhoto.Text = "Dodaj";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // tbPhotoPath
            // 
            this.tbPhotoPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhotoPath.Location = new System.Drawing.Point(12, 415);
            this.tbPhotoPath.Name = "tbPhotoPath";
            this.tbPhotoPath.ReadOnly = true;
            this.tbPhotoPath.Size = new System.Drawing.Size(620, 20);
            this.tbPhotoPath.TabIndex = 2;
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePhoto.BackColor = System.Drawing.Color.Brown;
            this.btnDeletePhoto.Location = new System.Drawing.Point(654, 448);
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.Size = new System.Drawing.Size(109, 48);
            this.btnDeletePhoto.TabIndex = 3;
            this.btnDeletePhoto.Text = "Usuń";
            this.btnDeletePhoto.UseVisualStyleBackColor = false;
            this.btnDeletePhoto.Visible = false;
            this.btnDeletePhoto.Click += new System.EventHandler(this.btnDeletePhoto_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(805, 508);
            this.Controls.Add(this.btnDeletePhoto);
            this.Controls.Add(this.tbPhotoPath);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.pbAddedPhoto);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zdjęcie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddedPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAddedPhoto;
        private System.Windows.Forms.OpenFileDialog ofdBrowsePhoto;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.TextBox tbPhotoPath;
        private System.Windows.Forms.Button btnDeletePhoto;
    }
}

