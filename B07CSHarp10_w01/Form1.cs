using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B07CSHarp10_w01
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<int> Token=new Queue<int>();
        int counter = 0;
       
        private void button1_Click(object sender, EventArgs e)
        {

            Token.Enqueue(++counter);
            //MessageBox.Show(counter.ToString());
            if (Token.Count > 0)
            {
                listBox1.DataSource = Token.ToList();
                this.btncounter1.Enabled = true;
                this.btnCnt2.Enabled = true;
                this.btnctn3.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.Token.Count == 0)
            {
                this.btncounter1.Enabled = false;
                this.btnCnt2.Enabled = false;
                this.btnctn3.Enabled = false;
            }

        }

        private void btncounter1_Click(object sender, EventArgs e)
        {
            this.ManageToken(txtc1, "1");
        }

        private void ManageToken(TextBox t, string n)
        {
            if (Token.Count > 0)
            {

                string fitem = Token.Peek().ToString();
                t.Text = fitem;
                this.lblmsg.Text = $" No   {fitem} please come at Counter 1";
                Token.Dequeue();
                this.listBox1.DataSource = Token.ToList();
            }
            else
            {
                MessageBox.Show("Token list empty");
            }
        }

        private void btnCnt2_Click(object sender, EventArgs e)
        {
            //if (Token.Count > 0)
            //{

            //    string fitem = Token.Peek().ToString();
            //    this.txtc2.Text = fitem;
            //    this.lblmsg.Text = $" No {fitem} please come at Counter 2";
            //    Token.Dequeue();
            //    this.listBox1.DataSource = Token.ToList();
            //}
            //else
            //{
            //    MessageBox.Show("Token list empty");
            //}
            this.ManageToken(txtc2, "2");
        }

        private void txtc3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnctn3_Click(object sender, EventArgs e)
        {
            //if (Token.Count > 0)
            //{

            //    string fitem = Token.Peek().ToString();
            //    this.txtc3.Text = fitem;
            //    this.lblmsg.Text = $" No {fitem} please come at Counter 3";
            //    Token.Dequeue();
            //    this.listBox1.DataSource = Token.ToList();
            //}
            //else
            //{
            //    MessageBox.Show("Token list empty");
            //}
            this.ManageToken(txtc3,"3");
        }
    }
}
