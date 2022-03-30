using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop s = new Shop();
            s.Add("Байрактар", 10000, 10);
            s.Add("Джевелин", 1000, 10);
            s.Add("Система ПВО", 5000, 10);
            s.Sell(0);
            s.Sell(0);
            s.Sell(0);
            s.Sell(2);
            s.Sell(2);
            s.Show();
        }
    }
}
