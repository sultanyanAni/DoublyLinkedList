using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            for (int i = 0; i < 4; i++)
            {
                list.AddToEnd(i);
            }
            list.Display();
            Console.WriteLine("Which index do you want to add at?");
            int response = int.Parse(Console.ReadLine());
            Console.WriteLine("Would you like to add the number before or after the index?");
            string answer = Console.ReadLine().ToLower();
            if(answer == "before")
            {
                list.AddBefore(222, response);
            }
            else
            {
                list.AddAfter(222, response);
            }
           list.RemoveFromEnd();
            foreach(Node<int> node in list)
            {

            }

            Console.ReadKey();
        }
    }
}
