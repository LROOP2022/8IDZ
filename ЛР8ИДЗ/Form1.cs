using program;
namespace ЛР8ИДЗ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x= int.Parse(textBox1.Text);
            int n= int.Parse(textBox2.Text);
            int r=int.Parse(textBox3.Text);
            if (radioButton1.Checked)
            {
                textBox4.Text = Уравнение.Уравнение1(x,n,r).ToString();
            }
            else
            {
                textBox4.Text = Уравнение.Уравнение2(n, r).ToString();
            }
        }
    }
}