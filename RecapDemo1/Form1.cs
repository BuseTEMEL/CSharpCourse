using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)  // 0. boyut için
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)  // 1. boyut için
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;   //left i soldan uzaklığı demek.
                    buttons[i, j].Top = top;    
                    left += 50;   //ikinci satırda lefti sıfırlıyoruz.
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                        buttons[i, j].Visible = true;   //false olsa görünmez.
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0;
            }
        }
    }
}
