namespace VLC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VLCPlayer = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)(this.VLCPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // VLCPlayer
            // 
            this.VLCPlayer.BackColor = System.Drawing.Color.Black;
            this.VLCPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VLCPlayer.Location = new System.Drawing.Point(0, 0);
            this.VLCPlayer.Name = "VLCPlayer";
            this.VLCPlayer.Size = new System.Drawing.Size(737, 470);
            this.VLCPlayer.Spu = -1;
            this.VLCPlayer.TabIndex = 0;
            this.VLCPlayer.Text = "vlcControl1";
            this.VLCPlayer.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("VLCPlayer.VlcLibDirectory")));
            this.VLCPlayer.VlcMediaplayerOptions = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 470);
            this.Controls.Add(this.VLCPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VLCPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl VLCPlayer;
    }
}

