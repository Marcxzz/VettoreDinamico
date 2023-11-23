namespace InterfacciaElenco
{
    public partial class Form1 : Form
    {
        VettoreDinamico Vettore = new VettoreDinamico();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Vettore.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonGetItemAt_Click(object sender, EventArgs e)
        {
            labelItemAt.Text = Vettore.GetItemAt(Convert.ToInt32(textBox1.Text));
        }

        private void buttonRemoveAt_Click(object sender, EventArgs e)
        {
            Vettore.RemoveAt(Convert.ToInt32(textBox1.Text));
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Vettore.Remove(textBox1.Text);
        }
    }
}
