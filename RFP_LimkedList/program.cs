using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_LinkedList
{
    internal class program
    {
        public static void Main()
        {
            LinkedList list = new LinkedList();

            list.addFirst("70"); list.addFirst("30"); list.addFirst("56"); list.printlist();

            list.InsertAtParticularPosition(1, "40"); list.printlist();

            //list.deleteLast("70");list.printlist();  //this will delete the last node

            //list.deleteFirst("56"); list.printlist();  //this will delete the first node

            //list.Search("70");list.printlist();

        }
    }
}
