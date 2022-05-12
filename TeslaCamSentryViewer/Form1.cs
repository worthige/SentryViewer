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

namespace TeslaCamSentryViewer
{
    public partial class form1 : Form
    {
        private const string DefaultPath = @"C:\TempG\tcam_vids\RecentClips";
        private string videoState = "";
        public form1()
        {
            InitializeComponent();

            VideoPlayerLeft.uiMode = VideoPlayerCenter.uiMode = VideoPlayerRight.uiMode = VideoPlayerBack.uiMode = "none";
            LoadVideos(DefaultPath);


        }

        private void FolderChooserButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Please select the folder containing TeslaCam videos";
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;

            string videoFolderPath = null;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                videoFolderPath = fbd.SelectedPath;
                LoadVideos(videoFolderPath);

            }
        }

        private void LoadVideos(string path)
        {
            videoGroupListBox.Items.Clear();
            var allfiles = Directory.GetFiles(path, "*.mp4", SearchOption.AllDirectories).ToList().OrderBy(s => s).ToList();


            // group by date

            var groupedFiles = new List<string>();

            foreach (var file in allfiles)
            {
                string currentGrouping = file.Substring(0, file.LastIndexOf('\\') + 20); // plus twenty to account for the time stamp: yyyy-MM-dd_hh-mm-ss

                if (!groupedFiles.Contains(currentGrouping))
                {
                    groupedFiles.Add(currentGrouping);
                }
                
            }


            foreach (var group in groupedFiles)
            {

                videoGroupListBox.Items.Add(group);
            }
        }


        private void videoGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var baseVideoPath = videoGroupListBox.SelectedItem.ToString();

            VideoPlayerLeft.URL = $"{baseVideoPath}-left_repeater.mp4";
            VideoPlayerCenter.URL = $"{baseVideoPath}-front.mp4";
            VideoPlayerRight.URL = $"{baseVideoPath}-right_repeater.mp4";
            VideoPlayerBack.URL = $"{baseVideoPath}-back.mp4";

            UpdateLabel();
            timer1.Enabled = true;
            videoState = "";
            lblPlayingStatus.Text = "Playing";
        }


        


        private void UpdateLabel()
        {
            lblDurationLeft.Text = $"{VideoPlayerLeft.Ctlcontrols.currentPositionString}/{VideoPlayerLeft.currentMedia.durationString}";
            lblDurationCenter.Text = $"{VideoPlayerCenter.Ctlcontrols.currentPositionString}/{VideoPlayerCenter.currentMedia.durationString}";
            lblDurationRight.Text = $"{VideoPlayerRight.Ctlcontrols.currentPositionString}/{VideoPlayerRight.currentMedia.durationString}";
            lblDurationBack.Text = $"{VideoPlayerBack.Ctlcontrols.currentPositionString}/{VideoPlayerBack.currentMedia.durationString}";
        }
        


        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 1 second.  
            timer1.Interval = 1000;           

            // Enable timer.  
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (videoState == "paused")
            {
                VideoPlayerLeft.Ctlcontrols.play();
                VideoPlayerCenter.Ctlcontrols.play();
                VideoPlayerRight.Ctlcontrols.play();
                VideoPlayerBack.Ctlcontrols.play();
                videoState = "";

                lblPlayingStatus.Text = "Playing" + VideoPlayerCenter.settings.rate;

            }
            else
            {
                videoState = "paused";
                VideoPlayerLeft.Ctlcontrols.pause();
                VideoPlayerCenter.Ctlcontrols.pause();
                VideoPlayerRight.Ctlcontrols.pause();
                VideoPlayerBack.Ctlcontrols.pause();

                lblPlayingStatus.Text = "Paused";
            }
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            VideoPlayerLeft.Ctlcontrols.fastReverse();
            VideoPlayerCenter.Ctlcontrols.fastReverse();
            VideoPlayerRight.Ctlcontrols.fastReverse();
            VideoPlayerBack.Ctlcontrols.fastReverse();
            videoState = "rewind2x";

            lblPlayingStatus.Text = "Rewind 2x";


        }

        private void btnFastForward_Click(object sender, EventArgs e)
        {
            VideoPlayerLeft.Ctlcontrols.fastForward();
            VideoPlayerCenter.Ctlcontrols.fastForward();
            VideoPlayerRight.Ctlcontrols.fastForward();
            VideoPlayerBack.Ctlcontrols.fastForward();
            videoState = "fast2x";

            lblPlayingStatus.Text = "Playing 2x" + VideoPlayerCenter.settings.rate;


        }
    }
}
