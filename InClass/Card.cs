using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass
{
    public class Card
    {
        public string CardName { get; set; }

        public string Suit { get; set; }

        public override string ToString()
        {
            return string.Format($"{CardName} of {Suit}");
        }
    }
}
