using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_proj2_Music_player.Forms
{
  public partial class AddPlayListF : Form
  {
    public AddPlayListF()
    {
      InitializeComponent();
      this.Dock = DockStyle.Fill;
    }

        private void AddPlayListF_Load(object sender, EventArgs e)
        {
      checkedListBox1.Items.Add("sdfsdf");
      checkedListBox1.Items.Add("sdfsdf");
        }
    }
}
