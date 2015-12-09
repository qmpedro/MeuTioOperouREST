namespace MeuTioOperouREST
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txtGetEndPoint = new System.Windows.Forms.TextBox();
            this.btnGetGo = new System.Windows.Forms.Button();
            this.txtResultJson = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGet = new System.Windows.Forms.TabPage();
            this.lblContentType = new System.Windows.Forms.Label();
            this.tabPost = new System.Windows.Forms.TabPage();
            this.btnPostFile = new System.Windows.Forms.Button();
            this.lblPostContentType = new System.Windows.Forms.Label();
            this.txtPostData = new System.Windows.Forms.TextBox();
            this.txtPostResult = new System.Windows.Forms.TextBox();
            this.btnPostGo = new System.Windows.Forms.Button();
            this.txtPostEndpoint = new System.Windows.Forms.TextBox();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabGet.SuspendLayout();
            this.tabPost.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGetEndPoint
            // 
            this.txtGetEndPoint.Location = new System.Drawing.Point(6, 11);
            this.txtGetEndPoint.Name = "txtGetEndPoint";
            this.txtGetEndPoint.Size = new System.Drawing.Size(743, 20);
            this.txtGetEndPoint.TabIndex = 1;
            // 
            // btnGetGo
            // 
            this.btnGetGo.Location = new System.Drawing.Point(755, 10);
            this.btnGetGo.Name = "btnGetGo";
            this.btnGetGo.Size = new System.Drawing.Size(75, 23);
            this.btnGetGo.TabIndex = 2;
            this.btnGetGo.Text = "Go, tio!";
            this.btnGetGo.UseVisualStyleBackColor = true;
            this.btnGetGo.Click += new System.EventHandler(this.btnGetGo_Click);
            // 
            // txtResultJson
            // 
            this.txtResultJson.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultJson.Location = new System.Drawing.Point(6, 44);
            this.txtResultJson.MaxLength = 1000000;
            this.txtResultJson.Multiline = true;
            this.txtResultJson.Name = "txtResultJson";
            this.txtResultJson.ReadOnly = true;
            this.txtResultJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultJson.Size = new System.Drawing.Size(824, 343);
            this.txtResultJson.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGet);
            this.tabControl1.Controls.Add(this.tabPost);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 443);
            this.tabControl1.TabIndex = 4;
            // 
            // tabGet
            // 
            this.tabGet.Controls.Add(this.lblContentType);
            this.tabGet.Controls.Add(this.txtResultJson);
            this.tabGet.Controls.Add(this.btnGetGo);
            this.tabGet.Controls.Add(this.txtGetEndPoint);
            this.tabGet.Location = new System.Drawing.Point(4, 22);
            this.tabGet.Name = "tabGet";
            this.tabGet.Padding = new System.Windows.Forms.Padding(3);
            this.tabGet.Size = new System.Drawing.Size(836, 417);
            this.tabGet.TabIndex = 0;
            this.tabGet.Text = "GET";
            this.tabGet.UseVisualStyleBackColor = true;
            // 
            // lblContentType
            // 
            this.lblContentType.AutoSize = true;
            this.lblContentType.Location = new System.Drawing.Point(6, 394);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(0, 13);
            this.lblContentType.TabIndex = 4;
            // 
            // tabPost
            // 
            this.tabPost.Controls.Add(this.btnPostFile);
            this.tabPost.Controls.Add(this.lblPostContentType);
            this.tabPost.Controls.Add(this.txtPostData);
            this.tabPost.Controls.Add(this.txtPostResult);
            this.tabPost.Controls.Add(this.btnPostGo);
            this.tabPost.Controls.Add(this.txtPostEndpoint);
            this.tabPost.Location = new System.Drawing.Point(4, 22);
            this.tabPost.Name = "tabPost";
            this.tabPost.Padding = new System.Windows.Forms.Padding(3);
            this.tabPost.Size = new System.Drawing.Size(836, 417);
            this.tabPost.TabIndex = 1;
            this.tabPost.Text = "POST";
            this.tabPost.UseVisualStyleBackColor = true;
            // 
            // btnPostFile
            // 
            this.btnPostFile.Location = new System.Drawing.Point(7, 185);
            this.btnPostFile.Name = "btnPostFile";
            this.btnPostFile.Size = new System.Drawing.Size(95, 23);
            this.btnPostFile.TabIndex = 10;
            this.btnPostFile.Text = "Search Image";
            this.btnPostFile.UseVisualStyleBackColor = true;
            this.btnPostFile.Click += new System.EventHandler(this.btnPostFile_Click);
            // 
            // lblPostContentType
            // 
            this.lblPostContentType.AutoSize = true;
            this.lblPostContentType.Location = new System.Drawing.Point(6, 394);
            this.lblPostContentType.Name = "lblPostContentType";
            this.lblPostContentType.Size = new System.Drawing.Size(0, 13);
            this.lblPostContentType.TabIndex = 8;
            // 
            // txtPostData
            // 
            this.txtPostData.Location = new System.Drawing.Point(7, 38);
            this.txtPostData.MaxLength = 1000000;
            this.txtPostData.Multiline = true;
            this.txtPostData.Name = "txtPostData";
            this.txtPostData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPostData.Size = new System.Drawing.Size(823, 142);
            this.txtPostData.TabIndex = 6;
            this.txtPostData.Text = "{ Post Data }";
            // 
            // txtPostResult
            // 
            this.txtPostResult.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostResult.Location = new System.Drawing.Point(6, 213);
            this.txtPostResult.MaxLength = 1000000;
            this.txtPostResult.Multiline = true;
            this.txtPostResult.Name = "txtPostResult";
            this.txtPostResult.ReadOnly = true;
            this.txtPostResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPostResult.Size = new System.Drawing.Size(824, 173);
            this.txtPostResult.TabIndex = 7;
            // 
            // btnPostGo
            // 
            this.btnPostGo.Location = new System.Drawing.Point(755, 10);
            this.btnPostGo.Name = "btnPostGo";
            this.btnPostGo.Size = new System.Drawing.Size(75, 23);
            this.btnPostGo.TabIndex = 5;
            this.btnPostGo.Text = "Go, tio!";
            this.btnPostGo.UseVisualStyleBackColor = true;
            this.btnPostGo.Click += new System.EventHandler(this.btnPostGo_Click);
            // 
            // txtPostEndpoint
            // 
            this.txtPostEndpoint.Location = new System.Drawing.Point(6, 11);
            this.txtPostEndpoint.Name = "txtPostEndpoint";
            this.txtPostEndpoint.Size = new System.Drawing.Size(743, 20);
            this.txtPostEndpoint.TabIndex = 4;
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            this.ofdImage.Filter = "\"Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|\" + \"All " +
    "files (*.*)|*.*\";";
            this.ofdImage.Title = "Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 467);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Tio Operou REST";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabGet.ResumeLayout(false);
            this.tabGet.PerformLayout();
            this.tabPost.ResumeLayout(false);
            this.tabPost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetEndPoint;
        private System.Windows.Forms.Button btnGetGo;
        private System.Windows.Forms.TextBox txtResultJson;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGet;
        private System.Windows.Forms.TabPage tabPost;
        private System.Windows.Forms.TextBox txtPostResult;
        private System.Windows.Forms.Button btnPostGo;
        private System.Windows.Forms.TextBox txtPostEndpoint;
        private System.Windows.Forms.TextBox txtPostData;
        private System.Windows.Forms.Label lblContentType;
        private System.Windows.Forms.Label lblPostContentType;
        private System.Windows.Forms.Button btnPostFile;
        private System.Windows.Forms.OpenFileDialog ofdImage;
    }
}

