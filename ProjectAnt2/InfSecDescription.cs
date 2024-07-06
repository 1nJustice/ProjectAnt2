using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAnt2
{
    public class InfSecDescription
    {
        string law;//НПА в области ИБ
        string infSecToolName;
        List<InfSecSubSystem> infSecSubSystems;

        public InfSecDescription(string law, string infSecToolName, List<InfSecSubSystem> infSecSubSystems)
        {
            this.Law = law;
            this.InfSecToolName = infSecToolName;
            this.InfSecSubSystems = infSecSubSystems;

        }

        public string Law { get => law; set => law = value; }
        public string InfSecToolName { get => infSecToolName; set => infSecToolName = value; }
        public List<InfSecSubSystem> InfSecSubSystems { get => infSecSubSystems; set => infSecSubSystems = value; }

        public string ConvertToString()
        {
            string s = "С целью выполнения предъявляемых требований к " +
                "КПТС Объекта по обеспечению ИБ, программно-техническими " +
                "мероприятиями предусматривается настройка " + InfSecToolName + ".\n" +
                "Настоящими решениями предусматривается применение следующих подсистем обеспечения ИБ: \n";

            foreach (InfSecSubSystem infSecSubSystem in InfSecSubSystems)
            {
                s += "- " + infSecSubSystem.Name + "\n";
            }
            foreach (InfSecSubSystem infSecSubSystem in InfSecSubSystems)
            {
                s += infSecSubSystem.ToString() + "\n";
            }
            return s;
        }
        public override string ToString()
        {
            return infSecToolName;
        }



    }
}
