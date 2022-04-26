namespace MessageBox_ShowFullName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trisha Camille D. Galicia", "Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}