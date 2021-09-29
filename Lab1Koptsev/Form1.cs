﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Koptsev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Окрасить кнопку в зеленый?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                button1.BackColor = Color.Green;
            this.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yes = Green, No = Red?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                button3.BackColor = Color.Green;
            else
                button3.BackColor = Color.Red;
            this.TopMost = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Запуск 10 MsgBox",
               "Сообщение",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                for (int i = 0; i < 9; i++)
                {
                    result = MessageBox.Show("FFFF",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            this.TopMost = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Переименовать кнопку по выбранному варианту",
               "Сообщение",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button3,
               MessageBoxOptions.DefaultDesktopOnly);
            button5.Text = result.ToString();
            this.TopMost = true;
        }
    }
}
