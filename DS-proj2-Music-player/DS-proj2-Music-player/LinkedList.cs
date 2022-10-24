using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_proj2_Music_player
{
  internal class LinkedList<T>
  {
    public Node<T> head;
    public Node<T> tail;
    int size = 0;

    /// <summary>
    /// add first
    /// </summary>
    /// <param name="data">Data</param>
    public void push_front(T data)
    {
      head = new Node<T>(data, head);

      if (size == 0)
        tail = head;
      size++;
    }

    public void print()
    {
      Node<T> tmp = head;
      while (tmp != null)
      {
        Console.WriteLine(Convert.ToString(tmp.getData()));
        tmp = tmp.getNext();
      }
    }

    public T index(int i)
    {
      Node<T> tmp = head;
      for (int j = 0; j < i - 1; j++)
      {
        tmp = tmp.Next;
      }
      return tmp.data;
    }

  }
}
