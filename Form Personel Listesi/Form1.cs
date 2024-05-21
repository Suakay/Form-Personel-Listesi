using System.Windows.Forms;

namespace Form_Personel_Listesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Ad = txtadsoyad.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Birim = txtbirim.Text;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            KAYITLAR frmYeniSayfa = new KAYITLAR();
            frmYeniSayfa.MdiParent = this;
            frmYeniSayfa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Ad = txtadsoyad.Text;
            string Birim = txtbirim.Text;
            string doðumyeri = txtdoðumyeri.Text;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtadsoyad.Text = "";
            txtbirim.Text = "";
            txtdoðumyeri.Text = "";


        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KAYITLAR frmYeniSayfa = new KAYITLAR();
            frmYeniSayfa.MdiParent = this;
            frmYeniSayfa.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string doðumyeri = txtdoðumyeri.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("KIZ");

            }
            else
            {
                MessageBox.Show("Erkek");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KAYITLAR frmYeniSayfa = new KAYITLAR();
            frmYeniSayfa.MdiParent = this;
            frmYeniSayfa.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            new Form().Show(this);  
        }
    }
}
