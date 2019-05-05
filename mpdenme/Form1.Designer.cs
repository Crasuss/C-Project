namespace mpdenme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.FilesBtn = new System.Windows.Forms.Button();
            this.ArtistBtn = new System.Windows.Forms.Button();
            this.AlbumsBtn = new System.Windows.Forms.Button();
            this.SongsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioBtn = new System.Windows.Forms.Button();
            this.LiveTVBtn = new System.Windows.Forms.Button();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Label();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CanMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CanMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.FilesBtn);
            this.panel1.Controls.Add(this.ArtistBtn);
            this.panel1.Controls.Add(this.AlbumsBtn);
            this.panel1.Controls.Add(this.SongsBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RadioBtn);
            this.panel1.Controls.Add(this.LiveTVBtn);
            this.panel1.Controls.Add(this.BrowseBtn);
            this.panel1.Controls.Add(this.Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 774);
            this.panel1.TabIndex = 0;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.ImageKey = "maximize.png";
            this.button11.ImageList = this.ımageList1;
            this.button11.Location = new System.Drawing.Point(72, 13);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 53);
            this.button11.TabIndex = 15;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder.png");
            this.ımageList1.Images.SetKeyName(1, "288875-Trap_Nation-748x421.jpg");
            this.ımageList1.Images.SetKeyName(2, "video-player.png");
            this.ımageList1.Images.SetKeyName(3, "music-player.png");
            this.ımageList1.Images.SetKeyName(4, "radio.png");
            this.ımageList1.Images.SetKeyName(5, "tv.png");
            this.ımageList1.Images.SetKeyName(6, "archive.png");
            this.ımageList1.Images.SetKeyName(7, "album.png");
            this.ımageList1.Images.SetKeyName(8, "microphone.png");
            this.ımageList1.Images.SetKeyName(9, "rewind-1.png");
            this.ımageList1.Images.SetKeyName(10, "pause-1.png");
            this.ımageList1.Images.SetKeyName(11, "previous-1.png");
            this.ımageList1.Images.SetKeyName(12, "skip-1.png");
            this.ımageList1.Images.SetKeyName(13, "play-1.png");
            this.ımageList1.Images.SetKeyName(14, "fast-forward-1.png");
            this.ımageList1.Images.SetKeyName(15, "eject-1.png");
            this.ımageList1.Images.SetKeyName(16, "speaker.png");
            this.ımageList1.Images.SetKeyName(17, "error.png");
            this.ımageList1.Images.SetKeyName(18, "maximize.png");
            this.ımageList1.Images.SetKeyName(19, "minimize.png");
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ImageKey = "error.png";
            this.button10.ImageList = this.ımageList1;
            this.button10.Location = new System.Drawing.Point(124, -1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(66, 67);
            this.button10.TabIndex = 14;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ImageKey = "minimize.png";
            this.button9.ImageList = this.ımageList1;
            this.button9.Location = new System.Drawing.Point(20, 13);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 53);
            this.button9.TabIndex = 13;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // FilesBtn
            // 
            this.FilesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FilesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FilesBtn.ForeColor = System.Drawing.Color.Transparent;
            this.FilesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilesBtn.ImageKey = "archive.png";
            this.FilesBtn.ImageList = this.ımageList1;
            this.FilesBtn.Location = new System.Drawing.Point(20, 658);
            this.FilesBtn.Name = "FilesBtn";
            this.FilesBtn.Size = new System.Drawing.Size(209, 65);
            this.FilesBtn.TabIndex = 12;
            this.FilesBtn.Text = "       Your Files";
            this.FilesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FilesBtn.UseVisualStyleBackColor = true;
            this.FilesBtn.Click += new System.EventHandler(this.FilesBtn_Click);
            // 
            // ArtistBtn
            // 
            this.ArtistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ArtistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ArtistBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ArtistBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArtistBtn.ImageKey = "microphone.png";
            this.ArtistBtn.ImageList = this.ımageList1;
            this.ArtistBtn.Location = new System.Drawing.Point(24, 570);
            this.ArtistBtn.Name = "ArtistBtn";
            this.ArtistBtn.Size = new System.Drawing.Size(180, 64);
            this.ArtistBtn.TabIndex = 11;
            this.ArtistBtn.Text = "Artist";
            this.ArtistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArtistBtn.UseVisualStyleBackColor = true;
            this.ArtistBtn.Click += new System.EventHandler(this.ArtistBtn_Click);
            // 
            // AlbumsBtn
            // 
            this.AlbumsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AlbumsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AlbumsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AlbumsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AlbumsBtn.ImageKey = "album.png";
            this.AlbumsBtn.ImageList = this.ımageList1;
            this.AlbumsBtn.Location = new System.Drawing.Point(24, 493);
            this.AlbumsBtn.Name = "AlbumsBtn";
            this.AlbumsBtn.Size = new System.Drawing.Size(180, 71);
            this.AlbumsBtn.TabIndex = 10;
            this.AlbumsBtn.Text = "     Albums";
            this.AlbumsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AlbumsBtn.UseVisualStyleBackColor = true;
            this.AlbumsBtn.Click += new System.EventHandler(this.AlbumsBtn_Click);
            // 
            // SongsBtn
            // 
            this.SongsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SongsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SongsBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SongsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SongsBtn.ImageKey = "music-player.png";
            this.SongsBtn.ImageList = this.ımageList1;
            this.SongsBtn.Location = new System.Drawing.Point(24, 415);
            this.SongsBtn.Name = "SongsBtn";
            this.SongsBtn.Size = new System.Drawing.Size(180, 72);
            this.SongsBtn.TabIndex = 9;
            this.SongsBtn.Text = "Songs";
            this.SongsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SongsBtn.UseVisualStyleBackColor = true;
            this.SongsBtn.Click += new System.EventHandler(this.SongsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sub Menu";
            // 
            // RadioBtn
            // 
            this.RadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RadioBtn.ForeColor = System.Drawing.Color.Transparent;
            this.RadioBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RadioBtn.ImageKey = "radio.png";
            this.RadioBtn.ImageList = this.ımageList1;
            this.RadioBtn.Location = new System.Drawing.Point(24, 285);
            this.RadioBtn.Name = "RadioBtn";
            this.RadioBtn.Size = new System.Drawing.Size(160, 70);
            this.RadioBtn.TabIndex = 7;
            this.RadioBtn.Text = "Radio";
            this.RadioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioBtn.UseVisualStyleBackColor = true;
            this.RadioBtn.Click += new System.EventHandler(this.RadioBtn_Click);
            // 
            // LiveTVBtn
            // 
            this.LiveTVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LiveTVBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LiveTVBtn.ForeColor = System.Drawing.Color.Transparent;
            this.LiveTVBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LiveTVBtn.ImageKey = "tv.png";
            this.LiveTVBtn.ImageList = this.ımageList1;
            this.LiveTVBtn.Location = new System.Drawing.Point(24, 198);
            this.LiveTVBtn.Name = "LiveTVBtn";
            this.LiveTVBtn.Size = new System.Drawing.Size(180, 81);
            this.LiveTVBtn.TabIndex = 6;
            this.LiveTVBtn.Text = "Live TV";
            this.LiveTVBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LiveTVBtn.UseVisualStyleBackColor = true;
            this.LiveTVBtn.Click += new System.EventHandler(this.LiveTVBtn_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BrowseBtn.FlatAppearance.BorderSize = 0;
            this.BrowseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BrowseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BrowseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrowseBtn.ForeColor = System.Drawing.Color.White;
            this.BrowseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseBtn.ImageKey = "folder.png";
            this.BrowseBtn.ImageList = this.ımageList1;
            this.BrowseBtn.Location = new System.Drawing.Point(24, 130);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(180, 62);
            this.BrowseBtn.TabIndex = 5;
            this.BrowseBtn.Text = "        Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Location = new System.Drawing.Point(28, 95);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(90, 32);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "Menu";
            // 
            // PlayList
            // 
            this.PlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlayList.FormattingEnabled = true;
            this.PlayList.ItemHeight = 16;
            this.PlayList.Location = new System.Drawing.Point(976, 95);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(256, 512);
            this.PlayList.TabIndex = 2;
            this.PlayList.SelectedIndexChanged += new System.EventHandler(this.PlayList_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(297, 609);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 165);
            this.panel2.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.ImageKey = "speaker.png";
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(628, 46);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(57, 53);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(714, 49);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(184, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ImageIndex = 12;
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(467, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 53);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ImageIndex = 14;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(380, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 53);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ImageIndex = 10;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(289, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 53);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ImageIndex = 13;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(197, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 53);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ImageIndex = 11;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(12, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 57);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImageIndex = 9;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(97, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 53);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CanMP
            // 
            this.CanMP.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.CanMP.AllowDrop = true;
            this.CanMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanMP.Enabled = true;
            this.CanMP.Location = new System.Drawing.Point(223, 84);
            this.CanMP.Name = "CanMP";
            this.CanMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("CanMP.OcxState")));
            this.CanMP.Size = new System.Drawing.Size(511, 414);
            this.CanMP.TabIndex = 4;
            this.CanMP.Enter += new System.EventHandler(this.CanMP_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::mpdenme.Properties.Resources.gT6c2d1;
            this.pictureBox1.Location = new System.Drawing.Point(297, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(935, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1233, 774);
            this.Controls.Add(this.CanMP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CanMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button FilesBtn;
        private System.Windows.Forms.Button ArtistBtn;
        private System.Windows.Forms.Button AlbumsBtn;
        private System.Windows.Forms.Button SongsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RadioBtn;
        private System.Windows.Forms.Button LiveTVBtn;
        private System.Windows.Forms.ListBox PlayList;
        private System.Windows.Forms.Panel panel2;
        private AxWMPLib.AxWindowsMediaPlayer CanMP;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
    }
}

