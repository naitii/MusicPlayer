namespace MusicPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pr_btn = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.open_btn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vol_track = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.vol_indicator = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.track_list = new System.Windows.Forms.ListBox();
            this.show_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vol_track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pr_btn
            // 
            this.pr_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pr_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pr_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pr_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pr_btn.Location = new System.Drawing.Point(32, 526);
            this.pr_btn.Margin = new System.Windows.Forms.Padding(4);
            this.pr_btn.Name = "pr_btn";
            this.pr_btn.Size = new System.Drawing.Size(131, 46);
            this.pr_btn.TabIndex = 0;
            this.pr_btn.Text = "PREVIOUS";
            this.pr_btn.UseVisualStyleBackColor = false;
            this.pr_btn.Click += new System.EventHandler(this.pr_btn_Click);
            // 
            // play_btn
            // 
            this.play_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.play_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.play_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.play_btn.Location = new System.Drawing.Point(207, 526);
            this.play_btn.Margin = new System.Windows.Forms.Padding(4);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(171, 46);
            this.play_btn.TabIndex = 1;
            this.play_btn.Text = "PLAY / PAUSE";
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stop_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stop_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stop_btn.Location = new System.Drawing.Point(386, 526);
            this.stop_btn.Margin = new System.Windows.Forms.Padding(4);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(124, 46);
            this.stop_btn.TabIndex = 3;
            this.stop_btn.Text = "STOP";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.next_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.next_btn.Location = new System.Drawing.Point(572, 526);
            this.next_btn.Margin = new System.Windows.Forms.Padding(4);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(124, 46);
            this.next_btn.TabIndex = 4;
            this.next_btn.Text = "NEXT";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.open_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.open_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.open_btn.Location = new System.Drawing.Point(745, 526);
            this.open_btn.Margin = new System.Windows.Forms.Padding(4);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(124, 46);
            this.open_btn.TabIndex = 5;
            this.open_btn.Text = "OPEN";
            this.open_btn.UseVisualStyleBackColor = false;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar1.Location = new System.Drawing.Point(32, 495);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(935, 16);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1004, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // vol_track
            // 
            this.vol_track.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vol_track.Location = new System.Drawing.Point(32, 149);
            this.vol_track.Margin = new System.Windows.Forms.Padding(4);
            this.vol_track.Maximum = 100;
            this.vol_track.Name = "vol_track";
            this.vol_track.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vol_track.Size = new System.Drawing.Size(90, 295);
            this.vol_track.TabIndex = 9;
            this.vol_track.Value = 100;
            this.vol_track.Scroll += new System.EventHandler(this.vol_track_Scroll_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 447);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vol";
            // 
            // vol_indicator
            // 
            this.vol_indicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vol_indicator.AutoSize = true;
            this.vol_indicator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vol_indicator.Location = new System.Drawing.Point(12, 126);
            this.vol_indicator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vol_indicator.Name = "vol_indicator";
            this.vol_indicator.Size = new System.Drawing.Size(67, 25);
            this.vol_indicator.TabIndex = 11;
            this.vol_indicator.Text = "100%";
            // 
            // duration
            // 
            this.duration.Font = new System.Drawing.Font("Forte", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.ForeColor = System.Drawing.Color.SpringGreen;
            this.duration.Location = new System.Drawing.Point(858, 457);
            this.duration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(109, 34);
            this.duration.TabIndex = 14;
            this.duration.Text = "00:00";
            this.duration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.DarkGray;
            this.track_list.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_list.ForeColor = System.Drawing.Color.Lime;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 29;
            this.track_list.Location = new System.Drawing.Point(111, 130);
            this.track_list.Margin = new System.Windows.Forms.Padding(4);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(843, 323);
            this.track_list.TabIndex = 15;
            this.track_list.Visible = false;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // show_btn
            // 
            this.show_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.show_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.show_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_btn.Image = ((System.Drawing.Image)(resources.GetObject("show_btn.Image")));
            this.show_btn.Location = new System.Drawing.Point(894, 526);
            this.show_btn.Margin = new System.Windows.Forms.Padding(4);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(72, 46);
            this.show_btn.TabIndex = 16;
            this.show_btn.UseVisualStyleBackColor = false;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1004, 89);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1004, 585);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.vol_indicator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vol_track);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.pr_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MusicPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vol_track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pr_btn;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TrackBar vol_track;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vol_indicator;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Timer timer1;
    }
}

