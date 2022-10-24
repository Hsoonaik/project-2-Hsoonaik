using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_proj2_Music_player
{
  internal class FileAbstraction : TagLib.File.IFileAbstraction // interface
  {
    public FileAbstraction(string file)
    {
      Name = file;
    }

    public string Name { get; }

    public Stream ReadStream => new FileStream(Name, FileMode.Open , FileAccess.Read , FileShare.ReadWrite);

    public Stream WriteStream => new FileStream(Name, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);

    public void CloseStream(Stream stream)
    {
      stream.Close();
    }
  }
}
