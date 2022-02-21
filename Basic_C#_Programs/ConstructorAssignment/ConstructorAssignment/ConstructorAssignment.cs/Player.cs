using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAssignment.cs
{
   public class Player
    {
        private string name;
        private int money;

        public Player(): this (0, "")
        {

        }

        public Player(int money, string name)
        {
            this.Money = money;
            this.Name = name;
        }

        public int Money { get; set; }
        public string Name { get; set; }

    }
}
