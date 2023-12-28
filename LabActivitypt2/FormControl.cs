namespace LabActivitypt2
{
    public partial class FormControl : Form
    {
        public FormControl()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDisplayPlace.Text = ListBoxPlaces.SelectedItem.ToString();
        }

        private void lblSelectPlace_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplayPlace_Click(object sender, EventArgs e)
        {

        }
    }
}