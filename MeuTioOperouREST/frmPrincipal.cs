using System;
using System.Windows.Forms;

namespace MeuTioOperouREST
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetGo_Click(object sender, EventArgs e)
        {
            var endpoint = txtGetEndPoint.Text;
            GetResultMethodGet(endpoint);
        }

        private void btnPostGo_Click(object sender, EventArgs e)
        {
            var endpoint = txtPostEndpoint.Text;
            var postData = txtPostData.Text;
            GetResultMethodPost(endpoint, postData);
        }

        private void GetResultMethodGet(string endpoint)
        {
            try
            {
                var result = new RestGateway();
                txtResultJson.Text = result.GetContent(endpoint);
                lblContentType.Text = String.Concat("Content Type: ", result.ContentType);
            }
            catch (Exception ex)
            {
                txtResultJson.Text = ex.Message;
            }
        }

        private void GetResultMethodPost(string endpoint, string postData)
        {
            try
            {
                var result = new RestGateway();
                txtPostResult.Text = result.SetContent(endpoint, postData);
                lblPostContentType.Text = String.Concat("Content Type: ", result.ContentType);
            }
            catch (Exception ex)
            {
                txtPostResult.Text = ex.Message;
            }
        }

        private void btnPostFile_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                var box = new BoxByteArrImage(ofdImage.FileName);
                box.ShowDialog();
            }
        }


    }
}
