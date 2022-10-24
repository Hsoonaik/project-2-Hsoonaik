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
  public partial class SplashForm : Form
  {
    public SplashForm()
    {
      InitializeComponent();
      //Size : (500, 300);
      // Back color : 082032

      pictureBox1.Select(); // for beauty :)
      this.Opacity = 0; // for effect
      
    }

    private void SplashForm_Load(object sender, EventArgs e)
        {
      timer1.Enabled = true;

        }

    private void timer1_Tick(object sender, EventArgs e)
    {
      circularProgress2.Value++;
      this.Opacity += 0.08; //for effect
      if (circularProgress2.Value > 99)
        this.Close();
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
