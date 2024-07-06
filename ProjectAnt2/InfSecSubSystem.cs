using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnt2
{
    public class InfSecSubSystem
    {
        string name;
        List<Requirement> requirements;
        public InfSecSubSystem(string name, List<Requirement> requirements)
        {
            Name = name;
            Requirements = requirements;
        }

        public string Name { get => name; set => name = value; }
        public List<Requirement> Requirements { get => requirements; set => requirements = value; }

        public string ConvertToString()
        {
            string s = "В рамках подсистемы " + Name + " настоящими решениями реализуются следующие требования, предъявляемые к КПТС Объекта: \n";
            foreach (Requirement requirement in Requirements)
            {
                s += "- " + requirement.RequirementDescription + ";";
            }
            foreach (Requirement requirement in Requirements)
            {
                s += requirement.ToString() + "\n";
            }
            return s;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
