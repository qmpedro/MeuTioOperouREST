using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeuTioOperouREST
{
    public partial class Form1 : Form
    {
        public Form1()
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
            var result = new RestGateway();
            try
            {                
                txtResultJson.Text = result.GetContent(endpoint);
                lblContentType.Text = String.Concat("Content Type: ", result.ContentType, " | Status Code: ", result.StatusCode, " | Timestamp: ", DateTime.Now);
            }
            catch (Exception ex)
            {
                lblContentType.Text = String.Concat("Status Code: ", result.StatusCode, " | Timestamp: ", DateTime.Now);
                txtResultJson.Text = ex.Message;
            }
        }

        private void GetResultMethodPost(string endpoint, string postData)
        {
            var result = new RestGateway();
            try
            {                
                txtPostResult.Text = result.SetContent(endpoint, postData);
                lblPostContentType.Text = String.Concat("Content Type: ", result.ContentType, " | Status Code: ", result.StatusCode, " | Timestamp: ", DateTime.Now);
            }
            catch (Exception ex)
            {
                lblPostContentType.Text = String.Concat("Status Code: ", result.StatusCode, " | Timestamp: ", DateTime.Now);
                txtPostResult.Text = ex.Message;
            }
        }

        private void btnPostFile_Click(object sender, EventArgs e)
        {
            var dr = ofdImage.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                var box = new BoxByteArrImage(ofdImage.FileName);
                box.ShowDialog();
            }
        }

        
    }
}
