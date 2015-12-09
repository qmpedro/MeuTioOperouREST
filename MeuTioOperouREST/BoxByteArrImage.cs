using System;
using System.IO;
using System.Windows.Forms;

namespace MeuTioOperouREST
{
    public partial class BoxByteArrImage : Form
    {
        public string ImagePath { get; set; }

        public BoxByteArrImage(string path)
        {
            InitializeComponent();
            ImagePath = path;
        }

        private void BoxByteArrImage_Load(object sender, EventArgs e)
        {
            var imgBtArr = File.ReadAllBytes(ImagePath);
            string imgBase64 = Convert.ToBase64String(imgBtArr);
            txtImageByteArray.Text = imgBase64;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtImageByteArray.Text);
            MessageBox.Show("OK");
        }
    }
}
