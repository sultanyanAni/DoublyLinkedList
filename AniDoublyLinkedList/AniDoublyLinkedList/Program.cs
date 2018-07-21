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
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            bool Exit = false;
            while (Exit == false)
            {
                Console.WriteLine("1. Add to list");
                Console.WriteLine("2. Remove from list");
                Console.WriteLine("3. Display the list");
                Console.WriteLine("4. Exit");
                int index = 0;
                string response = Console.ReadLine();
                string choose = "";
               
                switch (response)
                {
                    case "1":
                        Console.WriteLine("Enter the item you would like to add:");
                        string item = Console.ReadLine();
                        Console.WriteLine("Where would you like to add your item?");
                        Console.WriteLine("1. Front of the list");
                        Console.WriteLine("2. End of the list");
                        Console.WriteLine("3. Before a specific index");
                        Console.WriteLine("4. After a specific index");
                        choose = Console.ReadLine();
                        switch (choose)
                        {
                            case "1":
                                list.AddToFront(item);
                                break;
                            case "2":
                                list.AddToEnd(item);
                                break;
                            case "3":
                                Console.WriteLine("Which index would you like to add before?");
                                index = int.Parse(Console.ReadLine()) - 1;
                                list.AddBefore(item, index);
                                break;
                            case "4":
                                Console.WriteLine("Which index would you like to add after?");
                                index = int.Parse(Console.ReadLine()) - 1;
                                list.AddAfter(item, index);
                                break;
                            default:
                                Console.WriteLine("Not a valid response");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Where do you want to remove an item from?");
                        Console.WriteLine("1. Front of the list");
                        Console.WriteLine("2. End of the list");
                        Console.WriteLine("3. At a specific index");
                        choose = Console.ReadLine();
                        switch (choose)
                        {
                            case "1":
                                list.RemoveFromFront();
                                break;
                            case "2":
                                list.RemoveFromEnd();
                                break;
                            case "3":
                                Console.WriteLine("Which index do you want to remove an item from?");
                                index = int.Parse(Console.ReadLine()) - 1;
                                list.RemoveAt(index);
                                break;
                            default:
                                Console.WriteLine("Not a valid response");
                                break;
                        }
                        break;
                    case "3":
                        int location = 1;
                        foreach (Node<string> node in list)
                        {
                            Console.WriteLine($"{location}) {node.Value}");
                            location++;
                        }
                        break;
                    case "4":
                        Exit = true;
                        break;


                    default:
                        Console.WriteLine("Please enter a valid response");
                        break;
                }
            }
        }
    }
}
