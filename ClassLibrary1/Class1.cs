using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
        public class Good
        {
            public Good()
            { }
            public Good(int _count)
            {
                count = _count;
            }
            public Good(int _cost, string _name)
            {
                name = _name;
                cost = _cost;
            }
            public Good(int _cost, string _name, int _count)
            {
                name = _name;
                cost = _cost;
                count = _count;
            }
            public static Good operator +(Good g, int _cost)
            {
                return new Good(g.cost + _cost, g.name, g.count);
            }
            public static Good operator --(Good g)
            {
                g.count--;
                return new Good(g.cost, g.name, g.count);
            }
            public static Good operator ++(Good g)
            {
                g.count++;
                return new Good(g.cost, g.name, g.count);
            }
            public static Good operator -(Good g, int _cost)
            {
                return g.cost - _cost < 0 ? new Good(g.cost - _cost, g.name, g.count) : new Good(g.cost, g.name, g.count);
            }
            public static implicit operator Good(int count) => new Good(count);
            public override string ToString()
            {
                return $"{name} | {cost}$ | {count}\n";
            }
            public string name;
            public int cost;
            public int count = 0;
        }
}