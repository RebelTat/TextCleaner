using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmsCopy.Click += new System.EventHandler(this.Copybutton_Click);
            cmsPaste.Click += new System.EventHandler(this.Pastebutton_Click);

        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
          

            BasicClean();
        }
        private int Cleanchr(char c, char r)
        {
            string[] str = new string[256];
            int i = 0;
            foreach (string temp in InputTextBox.Lines)
            {
                str[i] = temp.Replace(c, r);
                i++;
            }
            InputTextBox.Lines = str;
            return 1;
        }
        private int BasicClean()
        {
            bool done = false;
            string str = InputTextBox.Text;
            int index = 0;
            StringBuilder sb = new StringBuilder(str);
            char[] ch = {'<', '>'};
            do
            {
                str = InputTextBox.Text; 
                try
                {
                    index = str.IndexOfAny(ch, 0);
                    if (index >= str.Length - 1) done = true;
                        sb.Remove(index, 1);
                }
                catch
                {
                    //MessageBox.Show("done");
                    done = true;
                }
                InputTextBox.Text = Convert.ToString(sb);
            } while (!done);

            InputTextBox.Text = Convert.ToString(sb) ;
            return 1;
        
        }

        private void Pastebutton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                InputTextBox.Text = Clipboard.GetText(TextDataFormat.Text);
            }


        }

        private void Copybutton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(InputTextBox.Text, TextDataFormat.Text);
        }

        private void CRFix_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text.Replace(Convert.ToString((char)10) , 
                Convert.ToString((char)178));
            InputTextBox.Text = InputTextBox.Text.Replace("²²", 
                Convert.ToString((char)179));
            InputTextBox.Text = InputTextBox.Text.Replace("³","\n\n");
            InputTextBox.Text = InputTextBox.Text.Replace("²"," ");
            
        }

        private void SpaceRem_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text.Replace("   ", " ");
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            bool done = false;
            string str = InputTextBox.Text;
            int index = 0;
            StringBuilder sb = new StringBuilder(str);
            do
            {
                str = InputTextBox.Text;
                try
                {
                    index = str.IndexOf(RemoveBox.Text) ;
                    if (index >= str.Length - 1 || index < 0) done = true;
                    sb.Remove(index, Remove.Text.Length);
                }
                catch
                {
                    //MessageBox.Show("done");
                    done = true;
                }
                InputTextBox.Text = Convert.ToString(sb);
            } while (!done);

            InputTextBox.Text = Convert.ToString(sb);
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = InputTextBox.Text.Replace(RemoveBox.Text, ReplaceBox.Text);

        }

        private void RemBeforeButton_Click(object sender, EventArgs e)
        {
            int lines = InputTextBox.Lines.Count();
            int RemTo, sleng;
            string[] input = new string[lines ];
            string temp;

            input = InputTextBox.Lines;
            for (int i = 0; i < lines; ++i)
            {
                RemTo = Convert.ToInt16(RemBeforeBox.Text);
                sleng = input[i].Length - RemTo;
                if (sleng < 0) sleng = 0;
                if (RemTo > sleng)
                    InputTextBox.Lines[i] = "";
                else
                {
                    temp = input[i].Substring(RemTo, sleng);
                    input[i] = temp;
                }
            }
            InputTextBox.Lines = input;
        }

        private void RemAfterButton_Click(object sender, EventArgs e)
        {
            int lines = InputTextBox.Lines.Count();
            int RemTo, sleng;
            string[] input = new string[lines];
            string temp;

            input = InputTextBox.Lines;
            for (int i = 0; i < lines; ++i)
            {
                RemTo = Convert.ToInt16(RemAfterBox.Text);
                sleng = input[i].Length - RemTo;
                if (sleng < 0) sleng = 0;
                if (RemTo < sleng)
                {
                    {
                        temp = input[i].Substring(0, RemTo);
                        input[i] = temp;
                    }
                }
                InputTextBox.Lines = input;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
