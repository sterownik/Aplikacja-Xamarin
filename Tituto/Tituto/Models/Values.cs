using System;
using System.Collections.Generic;
using System.Text;

namespace Tituto.Models
{
    public class Values
    {
        private int expEarn = 60;
        private int expToEarn = 100;

        public int ExpEarn { get => expEarn; set => expEarn = value; }
        public int ExpToEarn { get => expToEarn; set => expToEarn = value; }
        public Values() { }
    }
}
