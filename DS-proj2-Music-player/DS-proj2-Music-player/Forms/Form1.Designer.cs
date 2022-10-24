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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add_playlist_pnl = new System.Windows.Forms.Panel();
            this.plylst_nme = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.playlist_pnl = new System.Windows.Forms.Panel();
            this.plylist_list = new System.Windows.Forms.ListBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.add_playlist_pnl.SuspendLayout();
            this.playlist_pnl.SuspendLayout();
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 128);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.playlist_pnl);
            this.panel4.Controls.Add(this.add_playlist_pnl);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 439);
            this.panel4.TabIndex = 3;
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
            this.plylst_nme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // playlist_pnl
            // 
            this.playlist_pnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playlist_pnl.Controls.Add(this.plylist_list);
            this.playlist_pnl.Font = new System.Drawing.Font("Calibri Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.playlist_pnl.Location = new System.Drawing.Point(50, 96);
            this.playlist_pnl.Name = "playlist_pnl";
            this.playlist_pnl.Size = new System.Drawing.Size(550, 300);
            this.playlist_pnl.TabIndex = 3;
            this.playlist_pnl.Visible = false;
            // 
            // plylist_list
            // 
            this.plylist_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.plylist_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plylist_list.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.plylist_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(41)))));
            this.plylist_list.FormattingEnabled = true;
            this.plylist_list.ItemHeight = 49;
            this.plylist_list.Location = new System.Drawing.Point(0, 0);
            this.plylist_list.Name = "plylist_list";
            this.plylist_list.Size = new System.Drawing.Size(550, 294);
            this.plylist_list.TabIndex = 0;
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.add_playlist_pnl.ResumeLayout(false);
            this.add_playlist_pnl.PerformLayout();
            this.playlist_pnl.ResumeLayout(false);
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
  }
}

