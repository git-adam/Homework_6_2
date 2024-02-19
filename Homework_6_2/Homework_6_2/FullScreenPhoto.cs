using Homework_6_2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_6_2
{
    public partial class FullScreenPhoto : Form
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

        public FullScreenPhoto()
        {
            InitializeComponent();

            pbFullScreenPhoto.ImageLocation = PhotoPath;
        }

        private void pbFullScreenPhoto_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
