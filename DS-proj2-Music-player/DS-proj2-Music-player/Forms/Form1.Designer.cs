namespace DS_proj2_Music_player
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add_butt = new System.Windows.Forms.Button();
            this.liked_butt = new System.Windows.Forms.Button();
            this.plylst_butt = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Panel();
            this.b2 = new System.Windows.Forms.Panel();
            this.b3 = new System.Windows.Forms.Panel();
            this.merge_butt = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.music_detail_container = new System.Windows.Forms.Panel();
            this.like_butt = new System.Windows.Forms.Label();
            this.trck_nme_lbl = new System.Windows.Forms.Label();
            this.tpc_lbl = new System.Windows.Forms.Label();
            this.artst_nme_lbl = new System.Windows.Forms.Label();
            this.len_lbl = new System.Windows.Forms.Label();
            this.rls_dte_lbl = new System.Windows.Forms.Label();
            this.gnr_nme_lbl = new System.Windows.Forms.Label();
            this.nxt_butt = new System.Windows.Forms.Label();
            this.pre_butt = new System.Windows.Forms.Label();
            this.ply_butt = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.add_playlist_pnl = new System.Windows.Forms.Panel();
            this.plylst_nme = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.playlist_pnl = new System.Windows.Forms.Panel();
            this.plylist_list = new System.Windows.Forms.ListBox();
            this.back_butt = new System.Windows.Forms.Label();
            this.songs_pnl = new System.Windows.Forms.Panel();
            this.songs_list = new System.Windows.Forms.ListBox();
            this.chse_file_buttkk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.liked_song_pnl = new System.Windows.Forms.Panel();
            this.liked_song_list = new System.Windows.Forms.ListBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.music_detail_container.SuspendLayout();
            this.panel4.SuspendLayout();
            this.add_playlist_pnl.SuspendLayout();
            this.playlist_pnl.SuspendLayout();
            this.songs_pnl.SuspendLayout();
            this.liked_song_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Help;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 108);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // add_butt
            // 
            this.add_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_butt.FlatAppearance.BorderSize = 0;
            this.add_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_butt.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_butt.ForeColor = System.Drawing.Color.White;
            this.add_butt.Image = ((System.Drawing.Image)(resources.GetObject("add_butt.Image")));
            this.add_butt.Location = new System.Drawing.Point(0, 238);
            this.add_butt.Name = "add_butt";
            this.add_butt.Size = new System.Drawing.Size(200, 105);
            this.add_butt.TabIndex = 3;
            this.add_butt.Text = "Add Play List";
            this.add_butt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.add_butt.UseVisualStyleBackColor = true;
            this.add_butt.Click += new System.EventHandler(this.add_butt_Click);
            this.add_butt.MouseEnter += new System.EventHandler(this.add_butt_MouseEnter);
            this.add_butt.MouseLeave += new System.EventHandler(this.add_butt_MouseLeave);
            // 
            // liked_butt
            // 
            this.liked_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.liked_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.liked_butt.FlatAppearance.BorderSize = 0;
            this.liked_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.liked_butt.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liked_butt.ForeColor = System.Drawing.Color.White;
            this.liked_butt.Image = ((System.Drawing.Image)(resources.GetObject("liked_butt.Image")));
            this.liked_butt.Location = new System.Drawing.Point(0, 351);
            this.liked_butt.Name = "liked_butt";
            this.liked_butt.Size = new System.Drawing.Size(200, 105);
            this.liked_butt.TabIndex = 4;
            this.liked_butt.Text = "Liked Songs";
            this.liked_butt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.liked_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.liked_butt.UseVisualStyleBackColor = true;
            this.liked_butt.Click += new System.EventHandler(this.liked_butt_Click);
            this.liked_butt.MouseEnter += new System.EventHandler(this.liked_butt_MouseEnter);
            this.liked_butt.MouseLeave += new System.EventHandler(this.liked_butt_MouseLeave);
            // 
            // plylst_butt
            // 
            this.plylst_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plylst_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plylst_butt.FlatAppearance.BorderSize = 0;
            this.plylst_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plylst_butt.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plylst_butt.ForeColor = System.Drawing.Color.White;
            this.plylst_butt.Image = ((System.Drawing.Image)(resources.GetObject("plylst_butt.Image")));
            this.plylst_butt.Location = new System.Drawing.Point(0, 132);
            this.plylst_butt.Name = "plylst_butt";
            this.plylst_butt.Size = new System.Drawing.Size(200, 105);
            this.plylst_butt.TabIndex = 6;
            this.plylst_butt.Text = "Play Lists";
            this.plylst_butt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.plylst_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.plylst_butt.UseVisualStyleBackColor = true;
            this.plylst_butt.Click += new System.EventHandler(this.plylst_butt_Click);
            this.plylst_butt.MouseEnter += new System.EventHandler(this.plylst_butt_MouseEnter);
            this.plylst_butt.MouseLeave += new System.EventHandler(this.plylst_butt_MouseLeave);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.b1.Location = new System.Drawing.Point(0, 132);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(10, 113);
            this.b1.TabIndex = 7;
            this.b1.Visible = false;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.b2.Location = new System.Drawing.Point(0, 251);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(10, 113);
            this.b2.TabIndex = 8;
            this.b2.Visible = false;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.b3.Location = new System.Drawing.Point(0, 381);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(10, 113);
            this.b3.TabIndex = 9;
            this.b3.Visible = false;
            // 
            // merge_butt
            // 
            this.merge_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.merge_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.merge_butt.FlatAppearance.BorderSize = 0;
            this.merge_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.merge_butt.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merge_butt.ForeColor = System.Drawing.Color.White;
            this.merge_butt.Image = ((System.Drawing.Image)(resources.GetObject("merge_butt.Image")));
            this.merge_butt.Location = new System.Drawing.Point(0, 473);
            this.merge_butt.Name = "merge_butt";
            this.merge_butt.Size = new System.Drawing.Size(200, 105);
            this.merge_butt.TabIndex = 10;
            this.merge_butt.Text = "Merge Play List";
            this.merge_butt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.merge_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.merge_butt.UseVisualStyleBackColor = true;
            this.merge_butt.Click += new System.EventHandler(this.merge_butt_Click);
            this.merge_butt.MouseEnter += new System.EventHandler(this.merge_butt_MouseEnter);
            this.merge_butt.MouseLeave += new System.EventHandler(this.merge_butt_MouseLeave);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.b4.Location = new System.Drawing.Point(0, 476);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(10, 113);
            this.b4.TabIndex = 9;
            this.b4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.b4);
            this.panel1.Controls.Add(this.merge_butt);
            this.panel1.Controls.Add(this.b3);
            this.panel1.Controls.Add(this.b2);
            this.panel1.Controls.Add(this.b1);
            this.panel1.Controls.Add(this.plylst_butt);
            this.panel1.Controls.Add(this.liked_butt);
            this.panel1.Controls.Add(this.add_butt);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 567);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.music_detail_container);
            this.panel2.Controls.Add(this.nxt_butt);
            this.panel2.Controls.Add(this.pre_butt);
            this.panel2.Controls.Add(this.ply_butt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 128);
            this.panel2.TabIndex = 1;
            // 
            // music_detail_container
            // 
            this.music_detail_container.Controls.Add(this.like_butt);
            this.music_detail_container.Controls.Add(this.trck_nme_lbl);
            this.music_detail_container.Controls.Add(this.tpc_lbl);
            this.music_detail_container.Controls.Add(this.artst_nme_lbl);
            this.music_detail_container.Controls.Add(this.len_lbl);
            this.music_detail_container.Controls.Add(this.rls_dte_lbl);
            this.music_detail_container.Controls.Add(this.gnr_nme_lbl);
            this.music_detail_container.Location = new System.Drawing.Point(0, 0);
            this.music_detail_container.Name = "music_detail_container";
            this.music_detail_container.Size = new System.Drawing.Size(369, 128);
            this.music_detail_container.TabIndex = 14;
            this.music_detail_container.Visible = false;
            // 
            // like_butt
            // 
            this.like_butt.AutoSize = true;
            this.like_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.like_butt.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.like_butt.ForeColor = System.Drawing.Color.White;
            this.like_butt.Location = new System.Drawing.Point(304, 10);
            this.like_butt.Name = "like_butt";
            this.like_butt.Size = new System.Drawing.Size(65, 45);
            this.like_butt.TabIndex = 14;
            this.like_butt.Text = "❤";
            this.like_butt.Click += new System.EventHandler(this.like_butt_Click);
            // 
            // trck_nme_lbl
            // 
            this.trck_nme_lbl.AutoSize = true;
            this.trck_nme_lbl.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.trck_nme_lbl.ForeColor = System.Drawing.Color.White;
            this.trck_nme_lbl.Location = new System.Drawing.Point(3, 0);
            this.trck_nme_lbl.Name = "trck_nme_lbl";
            this.trck_nme_lbl.Size = new System.Drawing.Size(207, 45);
            this.trck_nme_lbl.TabIndex = 8;
            this.trck_nme_lbl.Text = "Track_Name";
            // 
            // tpc_lbl
            // 
            this.tpc_lbl.AutoSize = true;
            this.tpc_lbl.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tpc_lbl.ForeColor = System.Drawing.Color.White;
            this.tpc_lbl.Location = new System.Drawing.Point(11, 92);
            this.tpc_lbl.Name = "tpc_lbl";
            this.tpc_lbl.Size = new System.Drawing.Size(51, 24);
            this.tpc_lbl.TabIndex = 13;
            this.tpc_lbl.Text = "Topic";
            // 
            // artst_nme_lbl
            // 
            this.artst_nme_lbl.AutoSize = true;
            this.artst_nme_lbl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.artst_nme_lbl.ForeColor = System.Drawing.Color.White;
            this.artst_nme_lbl.Location = new System.Drawing.Point(9, 40);
            this.artst_nme_lbl.Name = "artst_nme_lbl";
            this.artst_nme_lbl.Size = new System.Drawing.Size(126, 28);
            this.artst_nme_lbl.TabIndex = 10;
            this.artst_nme_lbl.Text = "Artist Name";
            // 
            // len_lbl
            // 
            this.len_lbl.AutoSize = true;
            this.len_lbl.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.len_lbl.ForeColor = System.Drawing.Color.White;
            this.len_lbl.Location = new System.Drawing.Point(141, 68);
            this.len_lbl.Name = "len_lbl";
            this.len_lbl.Size = new System.Drawing.Size(38, 24);
            this.len_lbl.TabIndex = 12;
            this.len_lbl.Text = "Len";
            // 
            // rls_dte_lbl
            // 
            this.rls_dte_lbl.AutoSize = true;
            this.rls_dte_lbl.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rls_dte_lbl.ForeColor = System.Drawing.Color.White;
            this.rls_dte_lbl.Location = new System.Drawing.Point(10, 68);
            this.rls_dte_lbl.Name = "rls_dte_lbl";
            this.rls_dte_lbl.Size = new System.Drawing.Size(115, 24);
            this.rls_dte_lbl.TabIndex = 11;
            this.rls_dte_lbl.Text = "Release Date";
            // 
            // gnr_nme_lbl
            // 
            this.gnr_nme_lbl.AutoSize = true;
            this.gnr_nme_lbl.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gnr_nme_lbl.ForeColor = System.Drawing.Color.White;
            this.gnr_nme_lbl.Location = new System.Drawing.Point(141, 44);
            this.gnr_nme_lbl.Name = "gnr_nme_lbl";
            this.gnr_nme_lbl.Size = new System.Drawing.Size(60, 24);
            this.gnr_nme_lbl.TabIndex = 12;
            this.gnr_nme_lbl.Text = "Genre";
            // 
            // nxt_butt
            // 
            this.nxt_butt.AutoSize = true;
            this.nxt_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nxt_butt.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nxt_butt.ForeColor = System.Drawing.Color.White;
            this.nxt_butt.Location = new System.Drawing.Point(564, 24);
            this.nxt_butt.Name = "nxt_butt";
            this.nxt_butt.Size = new System.Drawing.Size(86, 73);
            this.nxt_butt.TabIndex = 9;
            this.nxt_butt.Text = "→";
            this.nxt_butt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nxt_butt.Click += new System.EventHandler(this.nxt_butt_Click);
            // 
            // pre_butt
            // 
            this.pre_butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pre_butt.AutoSize = true;
            this.pre_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pre_butt.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pre_butt.ForeColor = System.Drawing.Color.White;
            this.pre_butt.Location = new System.Drawing.Point(419, 24);
            this.pre_butt.Name = "pre_butt";
            this.pre_butt.Size = new System.Drawing.Size(86, 73);
            this.pre_butt.TabIndex = 8;
            this.pre_butt.Text = "←";
            this.pre_butt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pre_butt.Click += new System.EventHandler(this.pre_butt_Click);
            // 
            // ply_butt
            // 
            this.ply_butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ply_butt.AutoSize = true;
            this.ply_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ply_butt.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ply_butt.ForeColor = System.Drawing.Color.White;
            this.ply_butt.Location = new System.Drawing.Point(499, 24);
            this.ply_butt.Name = "ply_butt";
            this.ply_butt.Size = new System.Drawing.Size(78, 73);
            this.ply_butt.TabIndex = 7;
            this.ply_butt.Text = "▶";
            this.ply_butt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ply_butt.Click += new System.EventHandler(this.ply_butt_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.liked_song_pnl);
            this.panel4.Controls.Add(this.title_lbl);
            this.panel4.Controls.Add(this.playlist_pnl);
            this.panel4.Controls.Add(this.back_butt);
            this.panel4.Controls.Add(this.songs_pnl);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.add_playlist_pnl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 439);
            this.panel4.TabIndex = 3;
            // 
            // add_playlist_pnl
            // 
            this.add_playlist_pnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_playlist_pnl.Controls.Add(this.plylst_nme);
            this.add_playlist_pnl.Controls.Add(this.button1);
            this.add_playlist_pnl.Font = new System.Drawing.Font("Calibri Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.add_playlist_pnl.Location = new System.Drawing.Point(50, 96);
            this.add_playlist_pnl.Name = "add_playlist_pnl";
            this.add_playlist_pnl.Size = new System.Drawing.Size(550, 300);
            this.add_playlist_pnl.TabIndex = 2;
            this.add_playlist_pnl.Visible = false;
            // 
            // plylst_nme
            // 
            this.plylst_nme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plylst_nme.Font = new System.Drawing.Font("Calibri Light", 26F);
            this.plylst_nme.Location = new System.Drawing.Point(95, 94);
            this.plylst_nme.Name = "plylst_nme";
            this.plylst_nme.Size = new System.Drawing.Size(360, 60);
            this.plylst_nme.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(145, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Creat playlist";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.title_lbl.ForeColor = System.Drawing.Color.White;
            this.title_lbl.Location = new System.Drawing.Point(6, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(148, 73);
            this.title_lbl.TabIndex = 5;
            this.title_lbl.Text = "Test!";
            // 
            // playlist_pnl
            // 
            this.playlist_pnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playlist_pnl.Controls.Add(this.plylist_list);
            this.playlist_pnl.Font = new System.Drawing.Font("Calibri Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.playlist_pnl.Location = new System.Drawing.Point(55, 96);
            this.playlist_pnl.Name = "playlist_pnl";
            this.playlist_pnl.Size = new System.Drawing.Size(550, 300);
            this.playlist_pnl.TabIndex = 3;
            this.playlist_pnl.Visible = false;
            // 
            // plylist_list
            // 
            this.plylist_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.plylist_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plylist_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plylist_list.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.plylist_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.plylist_list.FormattingEnabled = true;
            this.plylist_list.ItemHeight = 49;
            this.plylist_list.Location = new System.Drawing.Point(0, 0);
            this.plylist_list.Name = "plylist_list";
            this.plylist_list.Size = new System.Drawing.Size(550, 294);
            this.plylist_list.TabIndex = 0;
            this.plylist_list.DoubleClick += new System.EventHandler(this.plylist_list_DoubleClick_1);
            // 
            // back_butt
            // 
            this.back_butt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.back_butt.AutoSize = true;
            this.back_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_butt.Font = new System.Drawing.Font("Calibri Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.back_butt.ForeColor = System.Drawing.Color.White;
            this.back_butt.Location = new System.Drawing.Point(505, 9);
            this.back_butt.Name = "back_butt";
            this.back_butt.Size = new System.Drawing.Size(47, 40);
            this.back_butt.TabIndex = 6;
            this.back_butt.Text = "←";
            this.back_butt.Visible = false;
            this.back_butt.Click += new System.EventHandler(this.back_butt_Click);
            // 
            // songs_pnl
            // 
            this.songs_pnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.songs_pnl.Controls.Add(this.songs_list);
            this.songs_pnl.Controls.Add(this.chse_file_buttkk);
            this.songs_pnl.Font = new System.Drawing.Font("Calibri Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.songs_pnl.Location = new System.Drawing.Point(55, 96);
            this.songs_pnl.Name = "songs_pnl";
            this.songs_pnl.Size = new System.Drawing.Size(550, 337);
            this.songs_pnl.TabIndex = 4;
            this.songs_pnl.Visible = false;
            // 
            // songs_list
            // 
            this.songs_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.songs_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songs_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songs_list.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.songs_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.songs_list.FormattingEnabled = true;
            this.songs_list.ItemHeight = 49;
            this.songs_list.Location = new System.Drawing.Point(0, 0);
            this.songs_list.Name = "songs_list";
            this.songs_list.Size = new System.Drawing.Size(550, 294);
            this.songs_list.TabIndex = 0;
            this.songs_list.Visible = false;
            this.songs_list.SelectedIndexChanged += new System.EventHandler(this.songs_list_SelectedIndexChanged);
            this.songs_list.DoubleClick += new System.EventHandler(this.songs_list_DoubleClick);
            // 
            // chse_file_buttkk
            // 
            this.chse_file_buttkk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.chse_file_buttkk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chse_file_buttkk.FlatAppearance.BorderSize = 0;
            this.chse_file_buttkk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chse_file_buttkk.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chse_file_buttkk.ForeColor = System.Drawing.Color.White;
            this.chse_file_buttkk.Location = new System.Drawing.Point(-2, 297);
            this.chse_file_buttkk.Name = "chse_file_buttkk";
            this.chse_file_buttkk.Size = new System.Drawing.Size(155, 39);
            this.chse_file_buttkk.TabIndex = 7;
            this.chse_file_buttkk.Text = "Add Music";
            this.chse_file_buttkk.UseVisualStyleBackColor = false;
            this.chse_file_buttkk.Visible = false;
            this.chse_file_buttkk.Click += new System.EventHandler(this.add_msc_butt_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(553, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "⬕";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(603, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Select Music";
            // 
            // liked_song_pnl
            // 
            this.liked_song_pnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.liked_song_pnl.Controls.Add(this.liked_song_list);
            this.liked_song_pnl.Font = new System.Drawing.Font("Calibri Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.liked_song_pnl.Location = new System.Drawing.Point(55, 99);
            this.liked_song_pnl.Name = "liked_song_pnl";
            this.liked_song_pnl.Size = new System.Drawing.Size(550, 300);
            this.liked_song_pnl.TabIndex = 5;
            this.liked_song_pnl.Visible = false;
            // 
            // liked_song_list
            // 
            this.liked_song_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.liked_song_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.liked_song_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.liked_song_list.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.liked_song_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.liked_song_list.FormattingEnabled = true;
            this.liked_song_list.ItemHeight = 49;
            this.liked_song_list.Location = new System.Drawing.Point(3, 0);
            this.liked_song_list.Name = "liked_song_list";
            this.liked_song_list.Size = new System.Drawing.Size(550, 294);
            this.liked_song_list.TabIndex = 0;
            this.liked_song_list.DoubleClick += new System.EventHandler(this.liked_song_list_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(850, 567);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.music_detail_container.ResumeLayout(false);
            this.music_detail_container.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.add_playlist_pnl.ResumeLayout(false);
            this.add_playlist_pnl.PerformLayout();
            this.playlist_pnl.ResumeLayout(false);
            this.songs_pnl.ResumeLayout(false);
            this.liked_song_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button add_butt;
        private System.Windows.Forms.Button liked_butt;
        private System.Windows.Forms.Button plylst_butt;
        private System.Windows.Forms.Panel b1;
        private System.Windows.Forms.Panel b2;
        private System.Windows.Forms.Panel b3;
        private System.Windows.Forms.Button merge_butt;
        private System.Windows.Forms.Panel b4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel add_playlist_pnl;
    private System.Windows.Forms.TextBox plylst_nme;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel playlist_pnl;
    private System.Windows.Forms.ListBox plylist_list;
    private System.Windows.Forms.Panel songs_pnl;
    private System.Windows.Forms.ListBox songs_list;
    private System.Windows.Forms.Label title_lbl;
    private System.Windows.Forms.Label back_butt;
    private System.Windows.Forms.Label ply_butt;
    private System.Windows.Forms.Label nxt_butt;
    private System.Windows.Forms.Label pre_butt;
    private System.Windows.Forms.Button chse_file_buttkk;
    private System.Windows.Forms.Label trck_nme_lbl;
    private System.Windows.Forms.Label tpc_lbl;
    private System.Windows.Forms.Label gnr_nme_lbl;
    private System.Windows.Forms.Label rls_dte_lbl;
    private System.Windows.Forms.Label artst_nme_lbl;
    private System.Windows.Forms.Label len_lbl;
    private System.Windows.Forms.Panel music_detail_container;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Label like_butt;
    private System.Windows.Forms.Panel liked_song_pnl;
    private System.Windows.Forms.ListBox liked_song_list;
  }
}

