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
    public partial class InfSecRequirementConf : Form
    {
        int idRequirement = 0;
        List<Requirement> requirements;

        public List<Requirement> Requirements { get => requirements; set => requirements = value; }

        public InfSecRequirementConf(ref List<Requirement> requirements, string name)
        {
            
            InitializeComponent(name);
            
            this.requirements = requirements;
            foreach(Requirement requirement in requirements)
            {
                listBox1.Items.Add(requirement);
            }
        }

        public Requirement AddNewRequirement(int idRequirement, string requirementDescription, string requirementText)
        {
            Requirement requirement = new Requirement(idRequirement,requirementDescription, requirementText);
            return requirement;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (listBox1.Items.Count > 0)
            {
                Requirement req = listBox1.SelectedItem as Requirement;
                if (req != null && req.RequirementDescription == richTextBox1.Text )
                {
                    ChangeRequirement();
                }
                else AddNewRequirement();
                
            }
            else AddNewRequirement();


        }

        public void AddNewRequirement()
        {
            string requirementDescription = richTextBox1.Text;
            string requirementText = richTextBox2.Text;
            Requirement requirement = new Requirement(idRequirement, requirementDescription, requirementText);
            Requirements.Add(requirement);
            listBox1.Items.Add(requirement);
        }

        public void ChangeRequirement()
        {
            Requirement requirement = listBox1.SelectedItem as Requirement;
            requirement.RequirementDescription = richTextBox1.Text;
            requirement.RequirementText = richTextBox2.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Requirement selectedRequirement = listBox1.SelectedItem as Requirement;
            richTextBox1.Text = selectedRequirement.RequirementDescription;
            richTextBox2.Text = selectedRequirement.RequirementText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        }
    }
}
