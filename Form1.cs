using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_2_b__WindowsForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Объявляем двумерный массив
            int[,] array2d = new int[5, 5];
            int[] array1d = new int[5];

            Random ran = new Random();

            // Инициализируем данный массив
            string array2d_text = "";
            string array1d_text = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array2d[i, j] = ran.Next(-15, 15);
                    array2d_text += array2d[i, j] + "   ";

                }
                Console.WriteLine();
                array2d_text += "\n";
            }

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {

                    if (array2d[i, j] > 0)
                    {
                        
                        array1d[j]++;
                        

                    }
                    
                }

            }


            for (int i = 0; i < 5; i++)
            {
                
                array1d_text += array1d[i] + " ";

            }
            richTextBox1.Text = array2d_text;
            textBox1.Text = array1d_text;
        }
    }
}
