using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_proj2_Music_player
{
  internal class Music
  {
    public string ArtistName { get; set; }
    public string TrackName { get; set; }
    public string ReleaseDate { get; set; } 
    public string Genre { get; set; }
    public string Len { get; set; }
    public string Topic { get; set; }
    public string Path { get; set; } = "$";
  }
}
