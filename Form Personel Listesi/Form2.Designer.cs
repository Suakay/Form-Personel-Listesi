﻿namespace Form_Personel_Listesi
{
    partial class KAYITLAR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblKayıtlar = new Label();
            panelpersonel = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lblKayıtlar
            // 
            lblKayıtlar.AutoSize = true;
            lblKayıtlar.Location = new Point(12, 9);
            lblKayıtlar.Name = "lblKayıtlar";
            lblKayıtlar.Size = new Size(89, 25);
            lblKayıtlar.TabIndex = 0;
            lblKayıtlar.Text = "KAYITLAR";
            // 
            // panelpersonel
            // 
            panelpersonel.Location = new Point(12, 71);
            panelpersonel.Name = "panelpersonel";
            panelpersonel.Size = new Size(475, 221);
            panelpersonel.TabIndex = 1;
            panelpersonel.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(102, 341);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "GERİ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(286, 342);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "TEMİZLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(462, 343);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "İLERİ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(93, 437);
            button4.Name = "button4";
            button4.Size = new Size(460, 51);
            button4.TabIndex = 5;
            button4.Text = "KAYIT EKRANINA DÖN";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // KAYITLAR
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 577);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panelpersonel);
            Controls.Add(lblKayıtlar);
            Name = "KAYITLAR";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKayıtlar;
        private Panel panelpersonel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}