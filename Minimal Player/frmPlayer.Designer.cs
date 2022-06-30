namespace Minimal_Player
{
    partial class frmPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayer));
            this.lsPlay = new System.Windows.Forms.ListBox();
            this.miniPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGetList = new System.Windows.Forms.Button();
            this.ofdVideo = new System.Windows.Forms.OpenFileDialog();
            this.fbdGetlist = new System.Windows.Forms.FolderBrowserDialog();
            this.lblCopyRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.miniPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lsPlay
            // 
            this.lsPlay.FormattingEnabled = true;
            this.lsPlay.ItemHeight = 16;
            this.lsPlay.Location = new System.Drawing.Point(547, 17);
            this.lsPlay.Name = "lsPlay";
            this.lsPlay.Size = new System.Drawing.Size(323, 388);
            this.lsPlay.TabIndex = 0;
            this.lsPlay.SelectedIndexChanged += new System.EventHandler(this.lsPlay_SelectedIndexChanged);
            // 
            // miniPlayer
            // 
            this.miniPlayer.Enabled = true;
            this.miniPlayer.Location = new System.Drawing.Point(12, 17);
            this.miniPlayer.Name = "miniPlayer";
            this.miniPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("miniPlayer.OcxState")));
            this.miniPlayer.Size = new System.Drawing.Size(385, 260);
            this.miniPlayer.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 355);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(255, 50);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Video";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(273, 355);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(255, 50);
            this.btnGetList.TabIndex = 3;
            this.btnGetList.Text = "Get Playlist";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // ofdVideo
            // 
            this.ofdVideo.FileName = "Open Video File";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(602, 398);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(213, 16);
            this.lblCopyRight.TabIndex = 4;
            this.lblCopyRight.Text = "Made with ❤️ by yarzardhiyit © 2022";
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 423);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.miniPlayer);
            this.Controls.Add(this.lsPlay);
            this.MaximumSize = new System.Drawing.Size(900, 470);
            this.MinimumSize = new System.Drawing.Size(900, 470);
            this.Name = "frmPlayer";
            this.Text = "Minimal Player";
            ((System.ComponentModel.ISupportInitialize)(this.miniPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lsPlay;
        private AxWMPLib.AxWindowsMediaPlayer miniPlayer;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGetList;
        private System.Windows.Forms.OpenFileDialog ofdVideo;
        private System.Windows.Forms.FolderBrowserDialog fbdGetlist;
        private System.Windows.Forms.Label lblCopyRight;
    }
}

