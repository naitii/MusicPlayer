using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        string[] paths, files;

        private void show_btn_Click(object sender, EventArgs e)
        {
            if(track_list.Visible)
            {
                track_list.Visible = false;
            }
            else
            {
                track_list.Visible=true;
            }
            
        }
        
        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[track_list.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
           axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if(track_list.SelectedIndex<track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        private void vol_track_Scroll(object sender, EventArgs e)
        {

        }

        private void pr_btn_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying) 
            { 
                progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
            duration.Text =  "";
            try
            {
                duration.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch
            {

            }
        }

        private void vol_track_Scroll_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = vol_track.Value;
            vol_indicator.Text = vol_track.Value.ToString() + "%";
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration * e.X / progressBar1.Width;
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.FileNames;
                paths = openFileDialog.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }
        }
    }
}
