using System;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkList = new LinkList();
            linkList.Add(10);
            linkList.Add(20);
            linkList.Add(30);
            linkList.Add(40);
            linkList.Add(50);


            linkList.DeleteByPosition(1);
            linkList.Print();
            linkList.DeleteByPosition(2);
            linkList.Print();
            linkList.DeleteByPosition(2);
            linkList.Print();
            linkList.DeleteByPosition(1);
            linkList.Print();
            linkList.Print();
            linkList.Print();
            linkList.Print();

        }
    }
}
