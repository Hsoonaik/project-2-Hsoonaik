using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DS_proj2_Music_player
{
  internal class LinkedList<T>
  {
    public Node<T> head { get; set; }
    public Node<T> tail { get; set; }
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

    public void remove_by_value(T value)
    {
      Node<T> current = head;
      Node<T> previos = tail;
      while(current != null && !EqualityComparer<T>.Default.Equals(current.data, value)) // to compare 2 generic datas
      {
        previos = current;
        current = current.Next;
      }
      if(current != null)
      {
        if (current == head)
          head = current.Next;
        else
          previos.Next = current.Next;
        current = null;
        size--;
      }
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

    public void merge(LinkedList<T> a , LinkedList<T> b)
    {
      
      while(a.head != null)
      {
        this.push_front(a.head.data);
        a.head = a.head.Next;
      }
      while(b.head != null)
      {
        this.push_front(b.head.data);
        b.head = b.head.Next;
      }
    }
    public int getSize()
    {
      return size;
    }
  }
}
