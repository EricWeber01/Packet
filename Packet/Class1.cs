using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace Packet
{
    class Shop
    {
        public Shop() { }
        Good[] goods = new Good[0] { };
        public void Add(string name, int cost, int count)
        {
            Array.Resize(ref goods, goods.Length + 1);
            goods[goods.Length - 1] = new Good(cost, name);
            goods[goods.Length - 1].count = count;
        }
        public void Sell(int i)
        {
            goods[i]--;
        }
        public void Show()
        {
            foreach (Good n in goods)
                Console.Write(n);
        }
    }
}