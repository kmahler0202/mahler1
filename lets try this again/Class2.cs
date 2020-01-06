using System;
using System.Collections.Generic;
using System.Text;

namespace lets_try_this_again
{
    public class Petowner
    {
        public string Name { get; }
        public int Age { get; }
        public Petowner(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

    }
}
