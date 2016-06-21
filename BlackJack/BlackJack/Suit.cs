using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Suit
    {
        private int Ace { get; set; }
        private int two { get; set; }
        private int three { get; set; }
        private int four { get; set; }
        private int five { get; set; }
        private int six { get; set; }
        private int seven { get; set; }
        private int eight { get; set; }
        private int nine { get; set; }
        private int ten { get; set; }
        private int jack { get; set; }
        private int queen { get; set; }
        private int king { get; set; }

        public Suit()
        {
            Ace = 1;
            two = 2;
            three = 3;
            four = 4;
            five = 5;
            six = 6;
            seven = 7;
            eight = 8;
            nine = 9;
            ten = 10;
            jack = 10;
            queen = 10;
            king = 10;
        }
    }
}
