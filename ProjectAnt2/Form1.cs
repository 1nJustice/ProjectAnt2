namespace ProjectAnt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InfSecDescriptionConf infSecDescriptionConf = new InfSecDescriptionConf();
            infSecDescriptionConf.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {

            }
        }
    }


    
    

    
}