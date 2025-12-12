namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //solo escribir aqui
            this.txtNombre.Location = new Point(10,30);
            this.txtNombre.Text = "Soy un texto nuevo!!!";
            this.txtNombre.Width = 220;
            this.txtNombre.BackColor = Color.Fuchsia;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
