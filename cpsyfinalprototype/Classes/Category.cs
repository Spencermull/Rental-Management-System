using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpsyfinalprototype.Classes
{
    public class Category
    {
        public int number {  get; set; }
        public string description { get; set; }

        public Category(int number, string description)
        {
            this.number = number;
            this.description = description;
        }
    }
}
