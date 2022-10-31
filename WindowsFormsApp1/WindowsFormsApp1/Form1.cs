using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

  class a
  {
    int _name;
    public int name { get { return _name; } set { _name = value; } }
  }

  public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      string s = "pjpj";
      s = s.Replace('p',';');
      Console.WriteLine(s);
        }
    }
}
