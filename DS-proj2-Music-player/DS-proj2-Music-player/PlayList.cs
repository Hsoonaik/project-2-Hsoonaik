using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_proj2_Music_player
{
  internal class PlayList
  {
    public int id { get; set; }
    string _Name;
    public string Name
    {
      get { return _Name; }
      set { if (value != "") { _Name = value; if (value != "Local Musics") { MessageF msg = new MessageF("Successfuly aded!", 0); msg.Show(); } } else { MessageF msg = new MessageF("Please enter a valid name!", 0); msg.Show(); } }
    }
    public bool isChecked { get; set; } = false;

    public LinkedList<Music> Musics = new LinkedList<Music>();
  }
}
