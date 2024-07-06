using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAnt2
{
    public partial class InfSecDescriptionConf : Form
    {
        List<InfSecSubSystem> infSecSubSystems = new List<InfSecSubSystem>();
        public InfSecDescriptionConf()
        {
            InitializeComponent();
            List<Requirement> requirements = new List<Requirement>();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                InfSecSubSystem subSystem = listBox1.SelectedItem as InfSecSubSystem;
                if (subSystem != null && subSystem.Name == textBox1.Text)
                {
                    ChangeInfSecSubSystem();
                }
                else AddNewInfSecSubSystem();

            }
            else AddNewInfSecSubSystem();
        }
        public void AddNewInfSecSubSystem()
        {
            string subSystemName = textBox1.Text;
            List<Requirement> requirements = new List<Requirement>();
            using (InfSecRequirementConf infSecRequirementConf = new InfSecRequirementConf(ref requirements))
            {
                if (infSecRequirementConf.ShowDialog() == DialogResult.OK)
                {
                    InfSecSubSystem requirement = new InfSecSubSystem(subSystemName, requirements);
            
                    infSecSubSystems.Add(requirement);
                    listBox1.Items.Add(requirement);
                }
            }

            
            
        }

        public void ChangeInfSecSubSystem()
        {
            InfSecSubSystem secSubSystem = listBox1.SelectedItem as InfSecSubSystem;
            List<Requirement> requirements = secSubSystem.Requirements;
            using (InfSecRequirementConf infSecRequirementConf = new InfSecRequirementConf(ref requirements))
            {
                if (infSecRequirementConf.ShowDialog() == DialogResult.OK)
                {
                    
                    secSubSystem.Requirements = requirements;

                }
            }
            //Requirement requirement = listBox1.SelectedItem as Requirement;
            //requirement.RequirementDescription = richTextBox1.Text;
            //requirement.RequirementText = richTextBox2.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InfSecSubSystem infSecSubSystem = listBox1.SelectedItem as InfSecSubSystem;
            textBox1.Text = infSecSubSystem.Name;
        }
    }
}
