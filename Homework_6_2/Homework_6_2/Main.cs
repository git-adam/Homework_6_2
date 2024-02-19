using Homework_6_2.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Homework_6_2
{
    public partial class Main : Form
    {
        public string PhotoPath
        {
            get
            {
                return Settings.Default.PhotoPath;
            }
            set
            {
                Settings.Default.PhotoPath = value;
            }
        }
        public Main()
        {
            InitializeComponent();

            InitImageLocationOnStart();
        }


        private void InitImageLocationOnStart()
        {
            if (PhotoPath != "")
            {
                if (!File.Exists(PhotoPath))
                    MessageBox.Show("Plik o podanej ścieżce nie istnieje!", "Komunikat", MessageBoxButtons.OK);
                else
                    SetImageData(true);
            }
            else
            {
                var confirmDismiss = MessageBox.Show($"Czy chcesz wczytać zdjęcie domyślne?", "Wczytanie zdjęcia domyślnego", MessageBoxButtons.OKCancel);

                if (confirmDismiss == DialogResult.OK)
                {
                    int lowerLimit = 1, upperLimit = 14;
                    var rnd = new Random();
                    var drawnNumber = rnd.Next(lowerLimit, upperLimit);
                    UpdatePhotoPath(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), $@"..\..\resource\{drawnNumber}.jpg"));

                    if (!File.Exists(PhotoPath))
                        MessageBox.Show("Plik o podanej ścieżce nie istnieje!", "Komunikat", MessageBoxButtons.OK);
                    else
                        SetImageData(true);
                }
            }
        }

        private void SetImageData(bool isDeleteButtonVisible)
        {
            tbPhotoPath.Text = PhotoPath;
            pbAddedPhoto.ImageLocation = PhotoPath;
            btnDeletePhoto.Visible = isDeleteButtonVisible;
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            ofdBrowsePhoto.FileName = "";
            ofdBrowsePhoto.FilterIndex = 1;
            ofdBrowsePhoto.Filter = "Picture|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*";
            ofdBrowsePhoto.InitialDirectory = PhotoPath == "" ? Environment.CurrentDirectory : PhotoPath;
            ofdBrowsePhoto.ShowDialog();
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            UpdatePhotoPath("");
            SetImageData(false);
        }


        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdatePhotoPath(PhotoPath);
        }

        private void UpdatePhotoPath(string path)
        {
            Settings.Default.PhotoPath = path;
            Settings.Default.Save();
        }

        private void pbAddedPhoto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (PhotoPath != "")
            {
                var FullScreenPhoto = new FullScreenPhoto();
                FullScreenPhoto.ShowDialog();
            }
        }

        private void ofdBrowsePhoto_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            UpdatePhotoPath(ofdBrowsePhoto.FileName.ToString());
            SetImageData(true);
        }
    }
}
