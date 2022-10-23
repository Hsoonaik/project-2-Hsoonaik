using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_proj2_Music_player
{
  public partial class MessageF : Form
  {
    Boolean Ok, yes, No; // for buttons!!!

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Msg">Message(string)</param>
    /// <param name="type">0 for Ok
    /// 1 for y/n q.</param>
    public MessageF(String Msg , byte type)
    {
      InitializeComponent();
      this.MsgTxt.Text = Msg;

      if(type == 0)
      {
        YesBtn.Hide();
        NoBtn.Hide();
        OkBtn.Show();
      }
      else if (type == 1)
      {
        YesBtn.Show();
        NoBtn.Show();
        OkBtn.Hide();
      }

      Ok = false;
      yes = false;
      No = false;
    }






    private void OkBtn_Click(object sender, EventArgs e)
    {
      Ok = true;
      this.Close();
    }

    private void YesBtn_Click(object sender, EventArgs e)
    {
      yes = true;
      this.Close();
    }

    private void NoBtn_Click(object sender, EventArgs e)
    {
      No = true;
      this.Close();
    }



    private void label1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void MsgTxt_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
        {
      yes = true;
      this.Close();
        }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
    }
  }
}
