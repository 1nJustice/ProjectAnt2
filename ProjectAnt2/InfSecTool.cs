using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnt2
{
    public class InfSecTool
    {
        string name; //Имя СрЗИ
        List<InfSecDescription> descriptionList;
        public InfSecTool(string name, List<InfSecDescription> descriptionList)
        {
            this.name = name;
            this.descriptionList = descriptionList;
        }
        public InfSecDescription GetInfSecDescription(string requireLaw)
        {
            InfSecDescription requiredDescription = null;

            foreach (InfSecDescription infSecDescription in descriptionList)
            {
                if (infSecDescription.Law == requireLaw) requiredDescription = infSecDescription;
            }

            return requiredDescription;
        }
    }
}
