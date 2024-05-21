using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Form_Personel_Listesi
{
    public partial class KAYITLAR : Form
    {
        public KAYITLAR()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            KAYITLAR form2 = new KAYITLAR();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(50, 50);
            textBox.Size = new Size(100, 20);
            panelpersonel.Controls.Add(textBox);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KAYITLAR form2 = new KAYITLAR();
            form2.Show();
        }

        public void SaveDataAndReturn(string newData)
        {
            
            MessageBox.Show("Veriler kaydedildi: " + newData);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form2 = new Form1();

            form2.Show();
        }
    }
}
