using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MorseCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] characters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                                                        'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 
                                                        'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0' };

        string[] codeMorse = new string[] { "*–", "–***", "-*-*", "-**", 
                                                        "*", "**-*", "--*", "****",
                                                        "**", "*–––", "–*–", "*–**",
                                                        "––", "–*", "–––", "*––*", 
                                                        "--*-", "*-*", "***", "–", 
                                                        "**–", "***-", "*--",
                                                        "-**-", "–*––", "−−**",
                                                        "*−−−−",
                                                        "**−−−", "***−−", "****−",
                                                        "*****", "−****", "−−***",
                                                        "−−−**", "−−−−*", "−−−−−" };

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            input = input.ToUpper();
            string output = "";
            int index;
            foreach(char c in input)
            {
                if (c != ' ')
                {
                    index = Array.IndexOf(characters, c);
                    output += codeMorse[index] + " ";
                }
            }
            output = output.Remove(output.Length - 1);
            textBox2.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox3.Text;
            string[] split = input.Split(' ');
            string output = "";
            int index;
            foreach (string s in split)
            {
                index = Array.IndexOf(codeMorse, s);
                output += characters[index] + " ";
            }
            output = output.Remove(output.Length - 1);
            textBox4.Text = output;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        //аналог кода Морзе 
        //# = *
        //@ = -

        string[] betta = new string[] {"#*", "*--", "@@-", "*@",
                                                        "=@*", "=", "+-=", "*=",
                                                        "@-*", "*-", "+=", "=-",
                                                        "##-", "-++", "++@", "##@",
                                                        "==", "++", "***", "--*",
                                                        "@*", "+*", "===",
                                                        "=*=*", "*+=", "*#",
                                                        "###",
                                                        "##*", "@@@", "---@",
                                                        "@-@", "#-#", "*@*",
                                                        "---", "=*", "+@#"};

    
     string[] gamma = new string[] { "#@", "@###", "@#@#", "@##",
                                                        "#", "##@#", "@@*", "####",
                                                        "##", "#@@@", "@*@", "#@##",
                                                        "@@", "@#", "@@@", "#@@*",
                                                        "@@*@", "#@#", "###", "@",
                                                        "##@", "###@", "#@@",
                                                        "@##@", "@#@@", "@@##",
                                                        "#@@@@",
                                                        "##@@@", "###@@", "###@",
                                                        "#####", "@####", "@@###",
                                                        "@@@##", "@@@@#", "@@@@@" };
        
         string[] bravo = new string[] {"1", "5", "7", "9",
                                                        "13", "17", "21"};

        char[] charli = new char[] {'A', 'B', 'C', 'D',
                                                        'E', 'F', 'G'};

        private void button6_Click(object sender, EventArgs e)
        {
            /*
            string input = textBox12.Text;
            string[] split = input.Split(' ');
            string output = "";
            int index;
            foreach (string s in split)
            {
                index = Array.IndexOf(characters, s);
                output += gamma[index] + " ";
            }
            output = output.Remove(output.Length - 1);
            textBox11.Text = output;
            */
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            string input = textBox8.Text;
            input = input.ToUpper();
            string output = "";
            int index;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    index = Array.IndexOf(characters, c);
                    output += betta[index] + " ";
                }
            }
            output = output.Remove(output.Length - 1);
            textBox7.Text = output;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = textBox6.Text;
            string[] split = input.Split(' ');
            string output = "";
            int index;
            foreach (string c in split)
            {
                index = Array.IndexOf(betta, c);
                output += characters[index] + " ";
            }
            output = output.Remove(output.Length - 1);
            textBox5.Text = output;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string input = textBox10.Text;
            string[] split = input.Split(' ');
            string output = "";
            int index;
            foreach (string s in split)
            {
                index = Array.IndexOf(codeMorse, s);
                output += betta[index] + " ";
            }
            output = output.Remove(output.Length - 1);
            textBox9.Text = output;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    string input = textBox12.Text;
        //    string[] split = input.Split(' ');
        //    string output = "";
        //    int index;
        //    foreach (string s in split)
        //    {
        //        index = Array.IndexOf(gamma, s);
        //        output += characters[index] + " ";
        //    }
        //    output = output.Remove(output.Length - 1);
        //    textBox11.Text = output;
        // }

        
        private void button7_Click(object sender, EventArgs e)
        {
            /*
            string input = textBox14.Text;
            string[] split = input.Split(' ');
            string output = "";
            int index;
            foreach (string c in split)
            {
                index = Array.IndexOf(charli, c);
                output += bravo[index] + " ";
            }
            output = output.Remove(output.Length - 1);
            textBox13.Text = output;
            */
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string line;
            StreamReader reader = new StreamReader("C:\\Users\\User\\Desktop\\MorseCode\\LOL.txt");
            line=reader.ReadLine();
            while(line!=null)
            {
                listBox1.Items.Add(line);
                line = reader.ReadLine();

            }
            reader.Close();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                textBox8.Text = listBox1.Items[i].ToString();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
