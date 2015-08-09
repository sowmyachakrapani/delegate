using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void BankProcess();  //declaration 

        BankProcess ptr;
        
        class Bank
        {

            public static void startup()
            {
            
            }
            public static void Door()
            {
                MessageBox.Show("Main doors ,Bank lockers door , Cash lockers door.");
            }

            public static void Lights()
            {
                MessageBox.Show("Controlling lights by turning OFF");
            }

            public static void Powermanagement()
            {
                MessageBox.Show("Power down...");
            }

            public static void Mail()
            {
                MessageBox.Show("Send mail..");
            }

            public static void Backup ( )
            {
                MessageBox.Show("Data backup process..");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ptr += Bank.Door;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ptr += Bank.Mail;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ptr = new BankProcess(Bank.startup);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ptr += Bank.Lights;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ptr += Bank.Powermanagement;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ptr += Bank.Backup;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ptr.Invoke();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ptr = new BankProcess(Bank.startup);
        }
    }
}
