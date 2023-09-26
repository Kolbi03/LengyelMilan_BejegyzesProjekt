﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lengyel_Milán_BejegyzésProjekt
{
    internal class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott = new DateTime();
        private DateTime szerkesztve = new DateTime();

        public Bejegyzes (string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
            this.letrejott = DateTime.UtcNow;
            this.szerkesztve = DateTime.UtcNow;
        }

        public string Szerzo { get => szerzo;}
        public string Tartalom { get => tartalom; set => tartalom = value; }
        public int Likeok { get => likeok;}
        public DateTime Letrejott { get => letrejott;}
        public DateTime Szerkesztve { get => szerkesztve;}

        public void Like()
        {
            this.likeok++;
        }

        public override string ToString()
        {
            return $"{this.szerzo}, {this.likeok}, {this.letrejott} \nSzerkesztve: {this.szerkesztve} \n{this.tartalom}".ToString();
        }
    }
}
