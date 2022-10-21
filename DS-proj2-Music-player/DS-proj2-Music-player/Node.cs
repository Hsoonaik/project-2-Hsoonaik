using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_proj2_Music_player
{
  internal class Node<T>
  {
    public T data;
    public Node<T> Next;
    public Node(T d, Node<T> n)
    {
      data = d;
      Next = n;
    }

    public T getData()
    {
      return data;
    }
    public Node<T> getNext()
    {
      return Next;
    }
  }
}
