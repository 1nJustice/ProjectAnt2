using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnt2
{
    public class Requirement
    {
        int idRequirement; //ID 
        string requirementDescription; //Требование
        string requirementText; // Описание

        public Requirement(int idRequirement, string requirementDescription, string requirementText)
        {
            IdRequirement = idRequirement;
            RequirementDescription = requirementDescription;
            RequirementText = requirementText;
        }

        public int IdRequirement { get => idRequirement; set => idRequirement = value; }
        public string RequirementDescription { get => requirementDescription; set => requirementDescription = value; }
        public string RequirementText { get => requirementText; set => requirementText = value; }

        public string ConvertToString()
        {
            return requirementDescription + " реализуется " + requirementText;
        }
        public override string ToString()
        {
            return requirementDescription;
        }
    }
}
