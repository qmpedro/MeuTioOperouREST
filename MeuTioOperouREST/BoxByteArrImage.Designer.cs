namespace MeuTioOperouREST
{
    partial class BoxByteArrImage
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
            this.txtImageByteArray = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImageByteArray
            // 
            this.txtImageByteArray.Location = new System.Drawing.Point(13, 13);
            this.txtImageByteArray.Multiline = true;
            this.txtImageByteArray.Name = "txtImageByteArray";
            this.txtImageByteArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtImageByteArray.Size = new System.Drawing.Size(419, 383);
            this.txtImageByteArray.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(13, 402);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(419, 23);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Ctrl + C";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // BoxByteArrImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 433);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtImageByteArray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BoxByteArrImage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Byte Array";
            this.Load += new System.EventHandler(this.BoxByteArrImage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImageByteArray;
        private System.Windows.Forms.Button btnCopy;
    }
}