namespace Form_Personel_Listesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtadsoyad = new TextBox();
            label2 = new Label();
            txtbirim = new TextBox();
            label3 = new Label();
            txtdoğumyeri = new TextBox();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            btnKaydıGörüntüle = new Button();
            menuStrip1 = new MenuStrip();
            personelListesiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 45);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // txtadsoyad
            // 
            txtadsoyad.Location = new Point(214, 42);
            txtadsoyad.Name = "txtadsoyad";
            txtadsoyad.Size = new Size(150, 31);
            txtadsoyad.TabIndex = 1;
            txtadsoyad.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 91);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 2;
            label2.Text = "Birim";
            // 
            // txtbirim
            // 
            txtbirim.Location = new Point(214, 90);
            txtbirim.Name = "txtbirim";
            txtbirim.Size = new Size(187, 31);
            txtbirim.TabIndex = 3;
            txtbirim.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 150);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 4;
            label3.Text = "Doğum Yeri";
            // 
            // txtdoğumyeri
            // 
            txtdoğumyeri.Location = new Point(214, 150);
            txtdoğumyeri.Name = "txtdoğumyeri";
            txtdoğumyeri.Size = new Size(213, 31);
            txtdoğumyeri.TabIndex = 5;
            txtdoğumyeri.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 224);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 6;
            label4.Text = "Cinsiyet";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(223, 224);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 29);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kız";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(454, 224);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 29);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Erkek";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(125, 304);
            button1.Name = "button1";
            button1.Size = new Size(129, 91);
            button1.TabIndex = 9;
            button1.Text = "TEMİZLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(343, 294);
            button2.Name = "button2";
            button2.Size = new Size(130, 101);
            button2.TabIndex = 10;
            button2.Text = "KAYDET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnKaydıGörüntüle
            // 
            btnKaydıGörüntüle.CausesValidation = false;
            btnKaydıGörüntüle.Location = new Point(548, 294);
            btnKaydıGörüntüle.Name = "btnKaydıGörüntüle";
            btnKaydıGörüntüle.Size = new Size(136, 101);
            btnKaydıGörüntüle.TabIndex = 11;
            btnKaydıGörüntüle.Text = "KAYDI GÖRÜNTÜLE";
            btnKaydıGörüntüle.UseVisualStyleBackColor = true;
            btnKaydıGörüntüle.Click += button3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { personelListesiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1068, 33);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // personelListesiToolStripMenuItem
            // 
            personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            personelListesiToolStripMenuItem.Size = new Size(146, 29);
            personelListesiToolStripMenuItem.Text = "Personel Listesi";
            personelListesiToolStripMenuItem.Click += personelListesiToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 450);
            Controls.Add(btnKaydıGörüntüle);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(txtdoğumyeri);
            Controls.Add(label3);
            Controls.Add(txtbirim);
            Controls.Add(label2);
            Controls.Add(txtadsoyad);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "PERSONEL LİSTESİ";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtadsoyad;
        private Label label2;
        private TextBox txtbirim;
        private Label label3;
        private TextBox txtdoğumyeri;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private Button btnKaydıGörüntüle;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem personelListesiToolStripMenuItem;
    }
}
