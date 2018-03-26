/*Josh Degazio
 * March 26th, 2018
 * This program takes users shortform words and returns their normal form.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U2_Josh_TXTMSG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //Holds values that are later called.
    public static class Globals
    {
        public static string replacedText;
        public static string[] splitText = new string[50];
        public static int lines;
        public static int looptimes = 2;
    }
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    //Triggers when user clicks the run button
    public void Click_Run(Object sender, RoutedEventArgs e)
        {
            Globals.replacedText = txt_input.Text.Replace("\r", "");
            Globals.splitText = Globals.replacedText.Split('\n');
            Globals.lines = Globals.splitText.Length;
            Console.WriteLine(Globals.lines);
            Globals.looptimes = Globals.lines;
            txt_outpt.Text = "";

            //Reads through every line of text entered and compares it to pre-set shortforms.
            for (int i = 0; i < Globals.looptimes; i++)
            {

                //Seperates output text, acts as "enter" key.
                if (txt_outpt.Text == "")
                {
                }
                else
                {
                    txt_outpt.Text = txt_outpt.Text + "\n";
                }


                //Checks user input and whether or not it matches stated shortforms.
                if (Globals.splitText[i] == "LOL")
                {
                    //Replaces the shortform with the normal form, then sets it to the output text.
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("LOL", "Laugh out loud.");
                }
                else if (Globals.splitText[i] == "CU")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("CU", "See you.");
                }
                else if (Globals.splitText[i] == ":-)")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace(":-)", "I'm happy.");
                }
                else if (Globals.splitText[i] == ":-(")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace(":-(", "I'm sad.");
                }
                else if (Globals.splitText[i] == ";-)")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace(";-)", "Wink.");
                }
                else if (Globals.splitText[i] == ":-P")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace(":-P", "Stick out tongue.");
                }
                else if (Globals.splitText[i] == "(~.~)")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("(~.~)", "I'm sleepy.");
                }
                else if (Globals.splitText[i] == "TA")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("TA", "Totally awesome.");
                }
                else if (Globals.splitText[i] == "CCC")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("CCC", "Canadian Computing Competition.");
                }
                else if (Globals.splitText[i] == "CUZ")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("CUZ", "Because.");
                }
                else if (Globals.splitText[i] == "TY")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("TY", "Thank-you.");
                }
                else if (Globals.splitText[i] == "YW")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("YW", "You're welcome.");
                }
                else if (Globals.splitText[i] == "TTYL")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("TTYL", "Talk to you later.");
                    //Tells user that program is closing.
                    MessageBox.Show("Program closing.");
                    //Closes program.
                    Environment.Exit(0);
                }
                else if (Globals.splitText[i] == ":-(")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace(":-(", "I'm Sad.");
                }
                else if (Globals.splitText[i] == "BRB")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("BRB", "Be right back.");
                }
                else if (Globals.splitText[i] == "GTG")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("GTG", "Got to go!");
                }
                else if (Globals.splitText[i] == "SMH")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("SMH", "Shake my head.");
                }
                else if (Globals.splitText[i] == "TFW")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("TFW", "That feeling when.");
                }
                else if (Globals.splitText[i] == "MFW")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("MFW", "My face when.");
                }
                else if (Globals.splitText[i] == "CS")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("CS", "Computer Science.");
                }
                else if (Globals.splitText[i] == "ROFL")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("ROFL", "Roll on floor laughing.");
                }
                else if (Globals.splitText[i] == "JD")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("JD", "Josh Degazio.");
                }
                else if (Globals.splitText[i] == "BBL")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("BBL", "Be back later.");
                }
                else if (Globals.splitText[i] == "SUP")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("SUP", "Hello intelling human.");
                }
                else if (Globals.splitText[i] == "XD")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("XD", "Halarious.");
                }
                else if (Globals.splitText[i] == ":)")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace(":)", "I'm happy and don't have a nose.");
                }
                else if (Globals.splitText[i] == ":(")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace(":(", "I'm sad because I don't have a nose.");
                }
                else if (Globals.splitText[i] == "B)")
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i].Replace("B)", "Just reppin' these new shades.");
                }
                else
                {
                    txt_outpt.Text = txt_outpt.Text + Globals.splitText[i];
                }
            }
        }
    }
}
