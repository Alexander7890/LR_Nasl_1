using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR_Nasl_1
{
    public partial class Form1 : Form
    {
        private Transport[] transports;
        private Trip currentTrip;

        public Form1()
        {
            InitializeComponent();
            transports = new Transport[3];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        //кнопка для створення транспорту
        private void button1_Click_1(object sender, EventArgs e)
                {
                    string name = textBox1.Text;
                    double cost = double.Parse(textBox2.Text);

                    if (radioButton1.Checked)
                    {
                        transports[0] = new IndividualTransport(name, cost);
                    }
                    else if (radioButton2.Checked)
                    {
                        transports[1] = new PublicTransport(name, cost);
                    }
                    else
                    {
                        MessageBox.Show("Please select a transport type.");
                    }
                }
        //кнопка для створення поїздки
        private void button2_Click_1(object sender, EventArgs e)
        {
            int passengers = int.Parse(textBox3.Text);
            double distance = double.Parse(textBox4.Text);
            currentTrip = new Trip(passengers, distance);
        }
        //кнопка для розрахунку вартості поїздки
        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("uk-UA");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("uk-UA");

            int transportIndex = int.Parse(textBox5.Text) - 1;

            if (transportIndex >= 0 && transportIndex < transports.Length && transports[transportIndex] != null)
            {
                double cost = transports[transportIndex].CalculateCost(currentTrip);
                label1.Text = $"Вартість поїздки користуванням {transports[transportIndex].Name}: {cost:C}";
            }
            else
            {
                MessageBox.Show("Неправильний вибір транспорту.");
            }
        }
    }
}

