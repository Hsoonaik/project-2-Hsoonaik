using DS_proj2_Music_player.Forms;
using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DS_proj2_Music_player
{

  
    public partial class MainForm : Form
    {
    
    int b = 0 , bck_butt_val = -1; // 0 for playlist
    Datas Datas = new Datas(); // for playlists    
    //LinkedList<Music> LocalMusics = new LinkedList<Music>();
    PlayList CurrentPlayList = new PlayList();
    PlayList LocalMusics = new PlayList { Name = "Local Musics" };
    

    void b_click(int tmp)
    {
      switch(tmp)
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

      using (var csvReader = new CsvReader(new FileStream("musics.csv", FileMode.Open), true, Encoding.UTF8))
      {
        csvTable.Load(csvReader);
      }

      foreach (DataRow row in csvTable.Rows)
      {
        LocalMusics.Musics.push_front(new Music { ArtistName = row[0].ToString(), TrackName = row[1].ToString(), ReleaseDate = row[2].ToString(), Genre = row[3].ToString(), Len = row[4].ToString(), Topic = row[5].ToString() });
        // Pushs all csv datas in localMusic list
      }
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
      title_lbl.Text = "";

      b_click(2);
      playlist_pnl.Hide();
      songs_pnl.Hide();
      add_playlist_pnl.Show();
      plylst_nme.Select();
    }

    private void liked_butt_Click(object sender, EventArgs e)
    {
      b_click(3);

      title_lbl.Text = "";

    }


    private void merge_butt_Click(object sender, EventArgs e)
    {
      b_click(4);
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
      Node<Music> tmp = CurrentPlayList.Musics.head;
      String tmp_name = songs_list.SelectedItem.ToString();
      int start_str = tmp_name.IndexOf('-') + 2; // get the index arter <num - >
      tmp_name = songs_list.SelectedItem.ToString().Substring(start_str);
      if (tmp_name.Length >= 18)
        tmp_name = tmp_name.Substring(0, tmp_name.Length - 3);
      Console.WriteLine(tmp_name);


      while (tmp != null)
      {
        if (tmp.data.TrackName.Contains(tmp_name) || tmp.data.TrackName == tmp_name)
        {
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
          break;
        }
        tmp = tmp.Next;
      }
    }

    private void plylist_list_DoubleClick_1(object sender, EventArgs e) // playlist doubble click / Musics show
    {
      if(plylist_list.SelectedItem == null)
        plylist_list.SelectedIndex = 0; // to avoid click without selectiong

      add_msc_butt.Show();

      back_butt.Show();
      bck_butt_val = 0;// for playlist

      title_lbl.Text = "Musics : ";


      playlist_pnl.Hide();
      songs_pnl.Show();
      songs_list.Items.Clear();
      songs_list.Show();

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
            if (tmp.data.TrackName.Length > 15)
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

                if (tmp2.data.TrackName.Length > 15)
                  adding_item = tmp2.data.TrackName.Substring(0, 15) + "...";
                else
                  adding_item = tmp2.data.TrackName;

                while (tmp2 != null)
                {
                  songs_list.Items.Add(i.ToString() + " - " + adding_item);
                  tmp2 = tmp2.Next;
                  i++;
                }
              }


              else
              {
                MessageF err_msg = new MessageF("Playlist is Empty!", 0);
                err_msg.ShowDialog();

              }
            }

            tmp = tmp.Next;
          }
        }
      }
      catch { songs_pnl.Hide(); playlist_pnl.Show(); }
 
      
    }
  }
}
