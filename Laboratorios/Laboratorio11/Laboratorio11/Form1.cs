namespace Laboratorio11
{
    public partial class btnClickThis : Form
    {
        public btnClickThis()
        {
            InitializeComponent();
        }

        private void btnClickThis_Load(object sender, EventArgs e)
        {
           
        }
        private void lblHelloWord_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHelloWord.Text = "Hello World!";
        }
    }
}
