using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Dog
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public bool Sex { get; set; }
        public string Breed { get; set; }
        public int Age => DateTime.Now.Year - Birthday.Year;
        public float Weight { get; set; }
    }
}
