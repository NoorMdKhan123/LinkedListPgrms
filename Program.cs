using System;

namespace LinkedListAsign
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedListClass list = new LinkedListClass();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.DeleteFirstNode();
            list.Display();

        }
    }
}