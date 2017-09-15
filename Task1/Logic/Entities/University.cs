using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class University
    {
        public string Name { get; }
        public List<Faculty> Faculties { get; }

        public University(string name, params Faculty[] faculties)
        {
            Name = name;
            if (faculties == null) Faculties = new List<Faculty>();
            else
            {
                Faculties = new List<Faculty>(faculties.Length);
                Array.ForEach(faculties, i => Faculties.Add(i));
            }
        }
    }
}
