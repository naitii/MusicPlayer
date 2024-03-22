﻿using System;
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
        
        string[] paths, files;
        public Form1()
        {

            MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            
        }


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
        int count = 0;
        int c = 0;
        private void play_btn_Click(object sender, EventArgs e)
        {
            count++;
            if(c == 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                play_btn.Text = "PLAY";
                c = 1;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                play_btn.Text = "PAUSE";
                c = 0;
            }
        }

       

        public void next_btn_Click(object sender, EventArgs e)
        {
            if(track_list.SelectedIndex<track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }

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
                if(progressBar1.Value == progressBar1.Maximum) 
                {
                    if (track_list.SelectedIndex < track_list.Items.Count - 1)
                    {
                        track_list.SelectedIndex = track_list.SelectedIndex + 1;
                    }
                }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            track_list.Visible = false;
        }

        

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            string path;
            path = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            path = Path.Combine(path, "Music");
            openFileDialog.InitialDirectory = path;
            openFileDialog.Title = "Please select one or more files";
            openFileDialog.Filter = "Music Files|*.mp3;*.wav;*.aac";
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
