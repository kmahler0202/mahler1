using System;
using System.Collections.Generic;
using System.Text;

namespace lets_try_this_again
    
{   public class Pet
    {
        public string Name { get; }
        public int Age { get; }
        public string Species { get; }
        public Pet(string Name, int Age, string Species)
        {
            this.Name = Name;
            this.Age = Age;
            this.Species = Species;
        }

        public Pet(int Age, string Name, string Species)
        {
            this.Name = Name;
            this.Age = Age;
            this.Species = Species;
        }

        public Pet(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            this.Species = "Unknown Species";
        }

    }

      
    
         
   
    
}
