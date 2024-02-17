using Homework_6_2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Homework_6_2
{
    public partial class Main : Form
    {
        private string _filePath = "";

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
            if (Settings.Default.PhotoPath == "")
            {
                var confirmDismiss = MessageBox.Show($"Czy chcesz wczytać zdjęcie domyślne?", "Wczytanie zdjęcia domyślnego", MessageBoxButtons.OKCancel);

                if (confirmDismiss == DialogResult.OK)
                {
                    int lowerLimit = 1, upperLimit = 14;
                    var rnd = new Random();
                    var drawnNumber = rnd.Next(lowerLimit, upperLimit);
                    SetImageLocation(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), $@"..\..\resource\{drawnNumber}.jpg"));
                }
            }
            else
            {
                if (!File.Exists(Settings.Default.PhotoPath))
                    MessageBox.Show("Plik o podanej ścieżce nie istnieje!", "Komunikat", MessageBoxButtons.OK);
                SetImageLocation(Settings.Default.PhotoPath);
            }
        }

        private void SetImageLocation(string path)
        {
            _filePath = path;
            tbPhotoPath.Text = _filePath;
            pbAddedPhoto.ImageLocation = _filePath;
            btnDeletePhoto.Visible = true;
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)

        {
            ofdBrowsePhoto.FilterIndex = 1;
            ofdBrowsePhoto.Filter = "Picture|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*";

            if (_filePath == "")
                ofdBrowsePhoto.InitialDirectory = Environment.CurrentDirectory;//Path.GetDirectoryName(Application.ExecutablePath);
            else
                ofdBrowsePhoto.InitialDirectory = _filePath;

            ofdBrowsePhoto.ShowDialog();

            SetImageLocation(ofdBrowsePhoto.FileName.ToString());
            
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            SetImageLocation("");
            btnDeletePhoto.Visible = false;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_filePath == null)
                Settings.Default.PhotoPath = "";
            else
                Settings.Default.PhotoPath = _filePath;

            Settings.Default.Save();
        }

    }
}
