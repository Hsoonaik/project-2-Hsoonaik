using DS_proj2_Music_player.Forms;
using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static TagLib.File;
using WMPLib;


namespace DS_proj2_Music_player
{


  public partial class MainForm : Form
  {
    int b = 0, bck_butt_val = -1, music_play_butt = -1; // 0 for playlist
    Datas Datas = new Datas(); // for playlists
    PlayList LocalMusics = new PlayList { Name = "Local Musics" };

    PlayList CurrentPlayList = new PlayList();
    Music CurrenMusic = new Music();
    WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer(); // for playing musics

    LinkedList<Music> LikedMusics = new LinkedList<Music>();
    LinkedList<Music> AllMusics = new LinkedList<Music>();















    void b_click(int tmp)
    {
      switch (tmp)
      {
        case 1:
          b1.Show();
          b2.Hide();
          b3.Hide();
          b4.Hide();
          b = 1;
          break;
        case 2:
          b1.Hide();
          b2.Show();
          b3.Hide();
          b4.Hide();
          b = 2;
          break;
        case 3:
          b1.Hide();
          b2.Hide();
          b3.Show();
          b4.Hide();
          b = 3;
          break;
        case 4:
          b1.Hide();
          b2.Hide();
          b3.Hide();
          b4.Show();
          b = 4;
          break;
        default:
          b = 0;
          break;
      }
    }
    void PPNButts()
    {
      nxt_butt.Location = new Point((panel2.Width - nxt_butt.Width), (panel2.Height - nxt_butt.Height) / 2);
      ply_butt.Location = new Point((panel2.Width - ply_butt.Width - nxt_butt.Width + 4), (panel2.Height - ply_butt.Height) / 2);
      pre_butt.Location = new Point((panel2.Width - pre_butt.Width - ply_butt.Width - nxt_butt.Width), (panel2.Height - pre_butt.Height) / 2);
    }
    void LftButtLyut()
    {
      this.FormBorderStyle = FormBorderStyle.None;
      add_butt.Top = plylst_butt.Bottom;
      liked_butt.Top = add_butt.Bottom;
      merge_butt.Top = liked_butt.Bottom; // to set the order!

      b1.Height = plylst_butt.Height;
      b2.Height = add_butt.Height;
      b3.Height = liked_butt.Height;
      b4.Height = merge_butt.Height;


      b1.Top = plylst_butt.Top;
      b2.Top = add_butt.Top;
      b3.Top = liked_butt.Top;
      b4.Top = merge_butt.Top;
    }
    void ReadCsv()
    {
      plylist_list.Items.Add("Local Musics"); // to show these musics

      var csvTable = new DataTable(); // for reading csv

      using (var csvReader = new CsvReader(new FileStream("musics.csv", FileMode.Open, FileAccess.Read, FileShare.ReadWrite), true, Encoding.UTF8))
      {
        csvTable.Load(csvReader);
      }

      foreach (DataRow row in csvTable.Rows)
      {
        LocalMusics.Musics.push_front(new Music { ArtistName = row[0].ToString(), TrackName = row[1].ToString(), ReleaseDate = row[2].ToString(), Genre = row[3].ToString(), Len = row[4].ToString(), Topic = row[5].ToString() });
        AllMusics.push_front(new Music { ArtistName = row[0].ToString(), TrackName = row[1].ToString(), ReleaseDate = row[2].ToString(), Genre = row[3].ToString(), Len = row[4].ToString(), Topic = row[5].ToString() });
        // Pushs all csv datas in localMusic list
      }
    }
    void add_to_song_list()
    {
      songs_list.Items.Clear();
      string adding_item;
      try
      {
        string item = plylist_list.SelectedItem.ToString();
        if (item == "Local Musics")
        {
          CurrentPlayList = LocalMusics; //imp

          int i = 1;
          Node<Music> tmp = LocalMusics.Musics.head;
          while (tmp != null)
          {
            if (tmp.data.TrackName == null) { adding_item = "🛇 No name 🛇"; tmp.data.TrackName = "🛇 No name 🛇"; }

            else if (tmp.data.TrackName.Length > 15)
              adding_item = tmp.data.TrackName.Substring(0, 15) + "..."; // to avoid text overwriting!
            else
              adding_item = tmp.data.TrackName;

            songs_list.Items.Add(i.ToString() + " - " + adding_item);
            tmp = tmp.Next;
            i++;
          }
        }


        else
        {
          int i = 1;
          Node<PlayList> tmp = Datas.PList.head;

          while (tmp != null)
          {

            if (tmp.data.Name == item)
            {
              CurrentPlayList = tmp.data;
              if (tmp.data.Musics.getSize() != 0)
              {
                Node<Music> tmp2 = tmp.data.Musics.head;



                while (tmp2 != null)
                {
                  if (tmp2.data.TrackName == null) { adding_item = "🛇 No name 🛇"; tmp2.data.TrackName = "🛇 No name 🛇"; }

                  else if (tmp2.data.TrackName.Length > 15)
                    adding_item = tmp2.data.TrackName.Substring(0, 15) + "...";
                  else
                    adding_item = tmp2.data.TrackName;

                  songs_list.Items.Add(i.ToString() + " - " + adding_item);
                  tmp2 = tmp2.Next;
                  i++;
                }
              }


              else
              {
                MessageF err_msg = new MessageF("Playlist is Empty!", 0);
                err_msg.ShowDialog();
                break;
              }
            }

            tmp = tmp.Next;
          }
        }
      }
      catch { songs_pnl.Hide(); playlist_pnl.Show(); }

    }
    string get_added_music_path()
    {
      openFileDialog1.Filter = "Music files (*.mp3)|*.mp3";
      openFileDialog1.ShowDialog();
      string path = openFileDialog1.FileName;
      return path;
    }
    bool search_in_liked_list(string name) // true if founded
    {
      int i = 0;
      Node<Music> tmp = LikedMusics.head;
      while (tmp != null)
      {
        if (tmp.data.TrackName == name)
          return true;
        tmp = tmp.Next;
      }
      return false;
    }

    void sort_by_track_name(ref LinkedList<Music> P)
    {
      LinkedList<Music> sorted_linked_list = new LinkedList<Music>();
      List<Music> list = new List<Music>();
      Node<Music> tmp = P.head;

      while (tmp != null)
      {
        list.Add(tmp.data);
        tmp = tmp.Next;
      }

      var q = list.OrderBy((i) => i.TrackName);

      for (int i = q.ToList().Count - 1; i >= 0; i--)
      {
        sorted_linked_list.push_front(q.ToList()[i]);
      }

      P = sorted_linked_list;
    }
    void sort_by_artist_name(ref LinkedList<Music> P)
    {
      LinkedList<Music> sorted_linked_list = new LinkedList<Music>();
      List<Music> list = new List<Music>();
      Node<Music> tmp = P.head;

      while (tmp != null)
      {
        list.Add(tmp.data);
        tmp = tmp.Next;
      }

      var q = list.OrderBy((i) => i.ArtistName);

      for(int i = q.ToList().Count - 1; i >= 0; i--)
      {
        sorted_linked_list.push_front(q.ToList()[i]);
      }

      P = sorted_linked_list;

    }
    void sort_by_release_date(ref LinkedList<Music> P)
    {
      LinkedList<Music> sorted_linked_list = new LinkedList<Music>();
      List<Music> list = new List<Music>();
      Node<Music> tmp = P.head;

      while (tmp != null)
      {
        list.Add(tmp.data);
        tmp = tmp.Next;
      }

      var q = list.OrderBy((i) => i.ReleaseDate);

      for (int i = q.ToList().Count - 1; i >= 0; i--)
      {
        sorted_linked_list.push_front(q.ToList()[i]);
      }

      P = sorted_linked_list;
    }









      #region About Form
      public MainForm()
    {


      InitializeComponent();

      title_lbl.Text = ""; // tirle

      Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(8, 32, 50); // to set color that changed by mdi

      LftButtLyut();
      ReadCsv();
      PPNButts();

      //X_butt.Cursor = Cursors.Hand;
      // size is 850,550
    }

    private void Form1_Load(object sender, EventArgs e)
    {

      //TagLib.File file = TagLib.File.Create(new FileAbstraction("C:\\Users\\Padidar\\Downloads\\Music\\lera_lynn_-_my_least_favorite_life.mp3"));
      //String title = file.Tag.Title;
      //String album = file.Tag.Album;
      //String length = Convert.ToInt16(file.Properties.Duration.TotalSeconds).ToString();

      //Console.WriteLine(file.Tag.FirstArtist);

      playlist_pnl.Show();
      SplashForm F = new SplashForm();
      this.Hide();
      //F.ShowDialog();
      this.Show();
      b_click(1); // PlayList

    }

    #region menu_butts

    private void plylst_butt_Click(object sender, EventArgs e)
    {
      b_click(1);
      music_detail_container.Hide();
      liked_song_pnl.Hide();
      title_lbl.Text = "";
      add_playlist_pnl.Hide();
      playlist_pnl.Show();
      plylist_list.Show();
      plylist_list.Items.Clear();

      Node<PlayList> tmp;
      tmp = Datas.PList.head;
      while(tmp != null)
      {
        try
        {
          plylist_list.Items.Add(tmp.data.Name);
          tmp = tmp.Next;
        }
        catch { break; }
        
      }

      plylist_list.Items.Add("Local Musics");


    }

    private void add_butt_Click(object sender, EventArgs e)
    {
      liked_song_pnl.Hide();

      back_butt.Hide();
      title_lbl.Text = "";
      music_detail_container.Hide();

      b_click(2);
      playlist_pnl.Hide();
      songs_pnl.Hide();
      add_playlist_pnl.Show();
      plylst_nme.Select();
    }

    private void liked_butt_Click(object sender, EventArgs e)
    {
      add_playlist_pnl.Hide();
      songs_pnl.Hide();
      playlist_pnl.Hide();
      liked_song_list.Items.Clear();
      b_click(3);
      back_butt.Hide();
      music_detail_container.Hide();
      liked_song_list.Show();
      liked_song_pnl.Show();
      title_lbl.Text = "";


      Node<Music> tmp = LikedMusics.head;
      while(tmp!=null)
      {
        if (tmp.data.isLiked)
          liked_song_list.Items.Add(tmp.data.TrackName);
        tmp = tmp.Next;
      }
    }


    private void merge_butt_Click(object sender, EventArgs e)
    {
      liked_song_pnl.Hide();

      b_click(4);
      back_butt.Hide();
      music_detail_container.Hide();

    }

    private void pictureBox1_Click(object sender, EventArgs e) //info
    {
      Console.Write("\a");
      MessageF info_msg = new MessageF("Made by Kinoosh Vadaei\nDS UI Proj", 0);
      info_msg.ShowDialog();

    }
    #endregion

    private void label1_Click(object sender, EventArgs e) // close
    {
      MessageF exit_msg = new MessageF("Are you sure to exit?", 1);
      this.Select();
      exit_msg.ShowDialog();
      if (exit_msg.yes)
        this.Close();

    }

    private void label2_Click(object sender, EventArgs e) // minimize
    {
      if (this.WindowState == FormWindowState.Maximized)
      {
        this.WindowState = FormWindowState.Normal;
        this.StartPosition = FormStartPosition.CenterScreen;
      }
      else
      {
        this.WindowState = FormWindowState.Maximized;

      }
      //ply_butt.Location = new Point((panel2.Width - ply_butt.Width) / 2, (panel2.Height - ply_butt.Height) / 2);
      //nxt_butt.Location = new Point((panel2.Width - nxt_butt.Width) / 2 + ply_butt.Width - 6, (panel2.Height - nxt_butt.Height) / 2);
      //pre_butt.Location = new Point((panel2.Width - pre_butt.Width) / 2 - ply_butt.Width, (panel2.Height - pre_butt.Height) / 2);
      PPNButts();

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Datas.add_new_play_list(new PlayList { Name = plylst_nme.Text });
      plylst_nme.Clear();
      plylst_nme.Select();
    }

    #endregion

    #region menu_left_border

    private void plylst_butt_MouseLeave(object sender, EventArgs e)
    {
      if (b != 1)
        b1.Hide();
    }

    private void plylst_butt_MouseEnter(object sender, EventArgs e)
    {
      b1.Show();
    }

    private void add_butt_MouseEnter(object sender, EventArgs e)
    {
      b2.Show();
    }

    private void add_butt_MouseLeave(object sender, EventArgs e)
    {
      if (b != 2)
        b2.Hide();
    }


    private void liked_butt_MouseEnter(object sender, EventArgs e)
    {
      b3.Show();
    }

    private void liked_butt_MouseLeave(object sender, EventArgs e)
    {
      if (b != 3)
        b3.Hide();
    }

    private void merge_butt_MouseEnter(object sender, EventArgs e)
    {
      b4.Show();
    }

    private void merge_butt_MouseLeave(object sender, EventArgs e)
    {
      if (b != 4)
        b4.Hide();
    }

    #endregion

    private void plylist_list_DoubleClick(object sender, EventArgs e)
    {
      MessageBox.Show("");
    }

    private void back_butt_Click(object sender, EventArgs e)
    {
      music_detail_container.Hide();
      title_lbl.Text = "";
      switch(bck_butt_val)
      {
        case 0:
          songs_pnl.Hide();
          playlist_pnl.Show();
          break;
      }

      back_butt.Hide();
    }

    private void songs_list_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void songs_list_DoubleClick(object sender, EventArgs e)
    {
      if (songs_list.SelectedItem == null)
        songs_list.SelectedIndex = 0; // to avoid click without selectiong
      like_butt.Text = "❤";
      ply_butt.Text = "▶";
      music_play_butt = -1;
      Node<Music> tmp = CurrentPlayList.Musics.head;
      String tmp_name = songs_list.SelectedItem.ToString();
      Console.WriteLine(tmp_name);
      int start_str = tmp_name.IndexOf('-') + 2; // get the index arter <num - >
      tmp_name = songs_list.SelectedItem.ToString().Substring(start_str);
      if (tmp_name.Length >= 18)
        tmp_name = tmp_name.Substring(0, tmp_name.Length - 3);
      Console.WriteLine(tmp_name);


      while (tmp != null)
      {
        if (tmp.data.TrackName.Contains(tmp_name) || tmp.data.TrackName == tmp_name)
        {
          CurrenMusic = tmp.data; // to selected music can be reconized!

          string tmpName = tmp.data.TrackName;
          if (tmpName.Length > 18)
            tmpName = tmpName.Substring(0, 18) + "...";
          Console.WriteLine(tmp.data.TrackName);
          trck_nme_lbl.Text = tmpName; // tmp.data.TrackName
          artst_nme_lbl.Text = tmp.data.ArtistName;
          rls_dte_lbl.Text = tmp.data.ReleaseDate;
          gnr_nme_lbl.Text = tmp.data.Genre;
          len_lbl.Text = tmp.data.Len;
          tpc_lbl.Text = tmp.data.Topic;

          if (tmp.data.isLiked)
            like_butt.Text = "♥";
          else
            like_butt.Text = "❤";
          break;
        }

        tmp = tmp.Next;
      }
      music_detail_container.Show();
    }

    private void chse_file_butt_Click(object sender, EventArgs e)
    {

    }

    private void add_msc_butt_Click(object sender, EventArgs e)
    {
      string path = get_added_music_path();
      TagLib.File track = TagLib.File.Create(new FileAbstraction(path));
      //String title = file.Tag.Title;
      //String album = file.Tag.Album;
      //String length = Convert.ToInt16(file.Properties.Duration.TotalSeconds).ToString();


      CurrentPlayList.Musics.push_front(new Music
      {
        Path = path,
        TrackName = track.Tag.Title,
        ArtistName = track.Tag.FirstArtist,
        ReleaseDate = "0000",
        Genre = track.Tag.FirstGenre,
        Len = Convert.ToInt16(track.Properties.Duration.TotalSeconds).ToString(),
        Topic = track.Tag.Title,

      });

      AllMusics.push_front(CurrentPlayList.Musics.head.data); // add to all musics


      add_to_song_list();
      songs_pnl.Show();
    }

    private void nxt_butt_Click(object sender, EventArgs e)
    {
      MessageF msg = new MessageF("Will be available in next versions!", 0);
      msg.Show();
    }

    private void pre_butt_Click(object sender, EventArgs e)
    {
      MessageF msg = new MessageF("Will be available in next versions!", 0);
      msg.Show();
    }

    private void like_butt_Click(object sender, EventArgs e)
    {
   

      if (!CurrenMusic.isLiked)
      {
        like_butt.Text = "♥";
        CurrenMusic.isLiked = true;
        if(!search_in_liked_list(CurrenMusic.TrackName))
          LikedMusics.push_front(CurrenMusic);
      }
      else
      {
        like_butt.Text = "❤";
        LikedMusics.remove_by_value(CurrenMusic);
        CurrenMusic.isLiked = false;

      }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void liked_song_list_DoubleClick(object sender, EventArgs e)
    {
      Node<Music> tmp = AllMusics.head;
      String tmp_name = liked_song_list.SelectedItem.ToString();
      Console.WriteLine(tmp_name);
      int start_str = tmp_name.IndexOf('-') + 2; // get the index arter <num - >
      tmp_name = liked_song_list.SelectedItem.ToString().Substring(start_str);
      if (tmp_name.Length >= 18)
        tmp_name = tmp_name.Substring(0, tmp_name.Length - 3);
      Console.WriteLine(tmp_name);


      while (tmp != null)
      {
        if (tmp.data.TrackName.Contains(tmp_name) || tmp.data.TrackName == tmp_name)
        {
          CurrenMusic = tmp.data; // to selected music can be reconized!

          string tmpName = tmp.data.TrackName;
          if (tmpName.Length > 18)
            tmpName = tmpName.Substring(0, 18) + "...";
          Console.WriteLine(tmp.data.TrackName);
          trck_nme_lbl.Text = tmpName; // tmp.data.TrackName
          artst_nme_lbl.Text = tmp.data.ArtistName;
          rls_dte_lbl.Text = tmp.data.ReleaseDate;
          gnr_nme_lbl.Text = tmp.data.Genre;
          len_lbl.Text = tmp.data.Len;
          tpc_lbl.Text = tmp.data.Topic;

          if (tmp.data.isLiked)
            like_butt.Text = "♥";
          else
            like_butt.Text = "❤";
          break;
        }

        tmp = tmp.Next;
      }
      music_detail_container.Show();
    }

    private void sort_selection_SelectedIndexChanged(object sender, EventArgs e)
    {
      songs_list.Items.Clear();
      if (sort_selection_butt.SelectedIndex == 0)
      {
        if (CurrentPlayList.Name == "Local Musics")
          sort_by_track_name(ref LocalMusics.Musics);
        else
          sort_by_track_name(ref CurrentPlayList.Musics);
      }
      else if(sort_selection_butt.SelectedIndex == 1)
      {
        if (CurrentPlayList.Name == "Local Musics")
          sort_by_artist_name(ref LocalMusics.Musics);
        else
          sort_by_artist_name(ref CurrentPlayList.Musics);
      }
      else if (sort_selection_butt.SelectedIndex == 2)
      {
        if (CurrentPlayList.Name == "Local Musics")
          sort_by_release_date(ref LocalMusics.Musics);
        else
          sort_by_release_date(ref CurrentPlayList.Musics);
      }

      add_to_song_list();

    }

    private void ply_butt_Click(object sender, EventArgs e)
    {
      Console.WriteLine(CurrenMusic.Path);
      if(CurrenMusic.Path != "$")
      {
        wplayer.URL = CurrenMusic.Path;
        if (music_play_butt < 0)
        {
          ply_butt.Text = "||";
          wplayer.controls.play();
          music_play_butt *= -1;
        }
        else
        {
          ply_butt.Text = "▶";
          wplayer.controls.stop();
          music_play_butt *= -1;
        }
      }

    }

    private void plylist_list_DoubleClick_1(object sender, EventArgs e) // playlist doubble click / Musics show
    {
      if(plylist_list.SelectedItem == null)
        plylist_list.SelectedIndex = 0; // to avoid click without selectiong

      
      chse_file_buttkk.Show();

      sort_selection_butt.Show();
      back_butt.Show();
      bck_butt_val = 0;// for playlist

      title_lbl.Text = "Musics : ";


      playlist_pnl.Hide();
      songs_pnl.Show();
      songs_list.Items.Clear();
      songs_list.Show();

      add_to_song_list();


    }
  }
}
