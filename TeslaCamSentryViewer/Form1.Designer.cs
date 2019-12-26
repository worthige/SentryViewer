namespace TeslaCamSentryViewer
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.FolderChooser = new System.Windows.Forms.Button();
            this.videoGroupListBox = new System.Windows.Forms.ListBox();
            this.VideoPlayerCenter = new AxWMPLib.AxWindowsMediaPlayer();
            this.VideoPlayerLeft = new AxWMPLib.AxWindowsMediaPlayer();
            this.VideoPlayerRight = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDurationLeft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.lblDurationCenter = new System.Windows.Forms.Label();
            this.lblDurationRight = new System.Windows.Forms.Label();
            this.VideoPlayerBack = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblDurationBack = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRewind = new System.Windows.Forms.Button();
            this.btnFastForward = new System.Windows.Forms.Button();
            this.lblPlayingStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayerCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayerLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayerRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayerBack)).BeginInit();
            this.SuspendLayout();
            // 
            // FolderChooser
            // 
            this.FolderChooser.Location = new System.Drawing.Point(12, 499);
            this.FolderChooser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FolderChooser.Name = "FolderChooser";
            this.FolderChooser.Size = new System.Drawing.Size(157, 22);
            this.FolderChooser.TabIndex = 0;
            this.FolderChooser.Text = "Choose TeslaCam Folder";
            this.FolderChooser.UseVisualStyleBackColor = true;
            this.FolderChooser.Click += new System.EventHandler(this.FolderChooserButton_Click);
            // 
            // videoGroupListBox
            // 
            this.videoGroupListBox.FormattingEnabled = true;
            this.videoGroupListBox.Location = new System.Drawing.Point(10, 538);
            this.videoGroupListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.videoGroupListBox.Name = "videoGroupListBox";
            this.videoGroupListBox.Size = new System.Drawing.Size(449, 342);
            this.videoGroupListBox.TabIndex = 1;
            this.videoGroupListBox.SelectedIndexChanged += new System.EventHandler(this.videoGroupListBox_SelectedIndexChanged);
            // 
            // VideoPlayerCenter
            // 
            this.VideoPlayerCenter.Enabled = true;
            this.VideoPlayerCenter.Location = new System.Drawing.Point(621, 41);
            this.VideoPlayerCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VideoPlayerCenter.Name = "VideoPlayerCenter";
            this.VideoPlayerCenter.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayerCenter.OcxState")));
            this.VideoPlayerCenter.Size = new System.Drawing.Size(586, 416);
            this.VideoPlayerCenter.TabIndex = 2;
            // 
            // VideoPlayerLeft
            // 
            this.VideoPlayerLeft.Enabled = true;
            this.VideoPlayerLeft.Location = new System.Drawing.Point(10, 41);
            this.VideoPlayerLeft.Name = "VideoPlayerLeft";
            this.VideoPlayerLeft.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayerLeft.OcxState")));
            this.VideoPlayerLeft.Size = new System.Drawing.Size(605, 416);
            this.VideoPlayerLeft.TabIndex = 3;
            // 
            // VideoPlayerRight
            // 
            this.VideoPlayerRight.Enabled = true;
            this.VideoPlayerRight.Location = new System.Drawing.Point(1213, 41);
            this.VideoPlayerRight.Name = "VideoPlayerRight";
            this.VideoPlayerRight.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayerRight.OcxState")));
            this.VideoPlayerRight.Size = new System.Drawing.Size(600, 416);
            this.VideoPlayerRight.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Driver\'s Side";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1395, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Passenger\'s Side";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(832, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dash";
            // 
            // lblDurationLeft
            // 
            this.lblDurationLeft.AutoSize = true;
            this.lblDurationLeft.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurationLeft.Location = new System.Drawing.Point(497, 460);
            this.lblDurationLeft.Name = "lblDurationLeft";
            this.lblDurationLeft.Size = new System.Drawing.Size(118, 17);
            this.lblDurationLeft.TabIndex = 8;
            this.lblDurationLeft.Text = "00:00/00:00";
            this.lblDurationLeft.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Webdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPause.Location = new System.Drawing.Point(1465, 758);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(86, 39);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = ";";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblDurationCenter
            // 
            this.lblDurationCenter.AutoSize = true;
            this.lblDurationCenter.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurationCenter.Location = new System.Drawing.Point(1089, 460);
            this.lblDurationCenter.Name = "lblDurationCenter";
            this.lblDurationCenter.Size = new System.Drawing.Size(118, 17);
            this.lblDurationCenter.TabIndex = 10;
            this.lblDurationCenter.Text = "00:00/00:00";
            this.lblDurationCenter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDurationRight
            // 
            this.lblDurationRight.AutoSize = true;
            this.lblDurationRight.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurationRight.Location = new System.Drawing.Point(1695, 460);
            this.lblDurationRight.Name = "lblDurationRight";
            this.lblDurationRight.Size = new System.Drawing.Size(118, 17);
            this.lblDurationRight.TabIndex = 11;
            this.lblDurationRight.Text = "00:00/00:00";
            this.lblDurationRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // VideoPlayerBack
            // 
            this.VideoPlayerBack.Enabled = true;
            this.VideoPlayerBack.Location = new System.Drawing.Point(621, 499);
            this.VideoPlayerBack.Name = "VideoPlayerBack";
            this.VideoPlayerBack.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayerBack.OcxState")));
            this.VideoPlayerBack.Size = new System.Drawing.Size(586, 416);
            this.VideoPlayerBack.TabIndex = 12;
            // 
            // lblDurationBack
            // 
            this.lblDurationBack.AutoSize = true;
            this.lblDurationBack.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurationBack.Location = new System.Drawing.Point(1089, 918);
            this.lblDurationBack.Name = "lblDurationBack";
            this.lblDurationBack.Size = new System.Drawing.Size(118, 17);
            this.lblDurationBack.TabIndex = 13;
            this.lblDurationBack.Text = "00:00/00:00";
            this.lblDurationBack.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(832, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rearview";
            // 
            // btnRewind
            // 
            this.btnRewind.Font = new System.Drawing.Font("Webdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRewind.Location = new System.Drawing.Point(1373, 758);
            this.btnRewind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(86, 39);
            this.btnRewind.TabIndex = 15;
            this.btnRewind.Text = "7";
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // btnFastForward
            // 
            this.btnFastForward.Font = new System.Drawing.Font("Webdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnFastForward.Location = new System.Drawing.Point(1557, 758);
            this.btnFastForward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFastForward.Name = "btnFastForward";
            this.btnFastForward.Size = new System.Drawing.Size(86, 39);
            this.btnFastForward.TabIndex = 16;
            this.btnFastForward.Text = "8";
            this.btnFastForward.UseVisualStyleBackColor = true;
            this.btnFastForward.Click += new System.EventHandler(this.btnFastForward_Click);
            // 
            // lblPlayingStatus
            // 
            this.lblPlayingStatus.AutoSize = true;
            this.lblPlayingStatus.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayingStatus.Location = new System.Drawing.Point(1450, 737);
            this.lblPlayingStatus.Name = "lblPlayingStatus";
            this.lblPlayingStatus.Size = new System.Drawing.Size(118, 17);
            this.lblPlayingStatus.TabIndex = 17;
            this.lblPlayingStatus.Text = "00:00/00:00";
            this.lblPlayingStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 1008);
            this.Controls.Add(this.lblPlayingStatus);
            this.Controls.Add(this.btnFastForward);
            this.Controls.Add(this.btnRewind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDurationBack);
            this.Controls.Add(this.VideoPlayerBack);
            this.Controls.Add(this.lblDurationRight);
            this.Controls.Add(this.lblDurationCenter);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblDurationLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VideoPlayerRight);
            this.Controls.Add(this.VideoPlayerLeft);
            this.Controls.Add(this.VideoPlayerCenter);
            this.Controls.Add(this.videoGroupListBox);
            this.Controls.Add(this.FolderChooser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "form1";
            this.Text = "Tesla Cam Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayerCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayerLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayerRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayerBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FolderChooser;
        private System.Windows.Forms.ListBox videoGroupListBox;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayerCenter;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayerLeft;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayerRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDurationLeft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblDurationCenter;
        private System.Windows.Forms.Label lblDurationRight;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayerBack;
        private System.Windows.Forms.Label lblDurationBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Button btnFastForward;
        private System.Windows.Forms.Label lblPlayingStatus;
    }
}

