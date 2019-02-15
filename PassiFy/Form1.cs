using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* PassiFy
Very simple password generator. I know well that a lot fo the techniques I use are not the best. But, this is to help
build a portfolio.
Written by anonfoxer
aka Kevin Naughton.*/


namespace PassiFy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Left blank intentionally
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //left blank intentionally
        }

        public static string GeneratorOfButt(int length, Random random) //Password generating function. Named GeneratorOfButt to give my 8:30pm, flu ridden self a giggle.
        {
            string characters = "0123456789!@#$%^&*()_+-=ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz~`;:'[]{}|,.<>/?"; //All possible characters for a password
            StringBuilder result = new StringBuilder(length); //Calls new StringBuilder
            for (int i=0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]); //Grab and append a new character for as long as the string goes. Pick randomly
            }
            return result.ToString(); // Put this result to a string.
        }

        private void generateButt_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int lenG = Int32.Parse(textBox1.Text); //Workaround to take the text of the textbox to an int. I tried lots of workarounds before I finally got was was wrong and just parsed it.
            string[] passWord = new string[lenG]; //Set length
            for (int i = 0; i < passWord.Length; i++)
            {
                passWord[i] = GeneratorOfButt(lenG, rnd); //Call the generation function and get a random string of x length
            }
            richTextBox1.Text = String.Join("", passWord); //spit out the result in the text box. Took me time to realize I had to just join it.
        }
    }
}
