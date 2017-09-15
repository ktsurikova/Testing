using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class Faculty
    {
        public string Name { get; }
        public List<Group> Groups { get; }

        public Faculty(string name, params Group[] groups)
        {
            Name = name;
            if (groups == null) Groups = new List<Group>();
            else
            {
                Groups = new List<Group>(groups.Length);
                Array.ForEach(groups, i => Groups.Add(i));
            }
        }
    }
}
