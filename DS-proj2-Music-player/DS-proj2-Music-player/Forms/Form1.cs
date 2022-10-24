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

namespace DS_proj2_Music_player
{

  
    public partial class MainForm : Form
    {
    
    int b = 0;
    Datas Datas = new Datas(); // for playlists    


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

    

    #region About Form
    public MainForm()
    {

      InitializeComponent();
      Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(8, 32, 50); // to set color that changed by mdi

      #region buuts
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
      #endregion

      #region CsvReading

      var csvTable = new DataTable(); // for reading csv

      using (var csvReader = new CsvReader(new FileStream("musics.csv", FileMode.Open), true, Encoding.UTF8))
      {
        csvTable.Load(csvReader);
      }

      foreach (DataRow row in csvTable.Rows)
      {
        MessageBox.Show(row[0].ToString());
        MessageBox.Show(row[1].ToString());

      }


      #endregion






      //X_butt.Cursor = Cursors.Hand;
      // size is 850,550
    }

    private void Form1_Load(object sender, EventArgs e)
    {
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

      add_playlist_pnl.Hide();
      playlist_pnl.Show();

      Node<PlayList> tmp;
      tmp = Datas.PList.head;
      while(tmp != null)
      {
        plylist_list.Items.Add(tmp.data.Name);
        tmp = tmp.Next;
      }

      
      
    }

    private void add_butt_Click(object sender, EventArgs e)
    {
      b_click(2);
      add_playlist_pnl.Show();
      plylst_nme.Select();
    }

    private void liked_butt_Click(object sender, EventArgs e)
    {
      b_click(3);
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
        this.WindowState = FormWindowState.Maximized;
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


  }
}
