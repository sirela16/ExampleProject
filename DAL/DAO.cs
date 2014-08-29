using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAO
    {
        private string Name { get; set; }
        private int Id { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public string GetName()
        {
            return Name;
        }
        public int GetId ()
        {
            return Id;
        }
        public int IncrementAge(int view)
        {
            return view + Age;
        }

    }
}
