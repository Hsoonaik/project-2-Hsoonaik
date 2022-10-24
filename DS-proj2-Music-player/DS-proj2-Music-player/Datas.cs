using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_proj2_Music_player
{
  internal class Datas
  {
    public LinkedList<PlayList> PList= new LinkedList<PlayList>();

    public void add_new_play_list(PlayList P)
    {
      PList.push_front(P);
    }
  }
}
