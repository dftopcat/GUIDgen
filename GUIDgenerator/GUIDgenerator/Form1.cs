using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDgenerator
{
    public partial class GUIDgen : Form
    {
        Random rnd = new Random();
        float chanceOfChar = 40;
        char[] text = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        public static char GetRandomCharacter(char[] text, Random rng)
        {
            int index = rng.Next(text.Length);
            return text[index];
        }
        public GUIDgen()
        {
            InitializeComponent();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What is a GUID? GUID (aka UUID) is an acronym for 'Globally Unique Identifier' (or 'Universally Unique Identifier'. It is a 128 - bit integer number used to identify resources. The term GUID is generally used by developers working with Microsoft technologies, while UUID is used everywhere else. How unique is a GUID? 128 - bits is big enough and the generation algorithm is unique enough that if 1,000,000,000 GUIDs per second were generated for 1 year the probability of a duplicate would be only 50 %.Or if every human on Earth generated 600,000,000 GUIDs there would only be a 50 % probability of a duplicate. How are GUIDs used? GUIDs are used in enterprise software development in C#, Java, and C++ as database keys, component identifiers, or just about anywhere else a truly unique identifier is required. GUIDs are also used to identify all interfaces and objects in COM programming.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GUIDtext.Text);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            GUIDtext.Text = "";
            if (BraceCheckBox.Checked == true)
            {
                GUIDtext.Text += "{";
            }
            if (hyphensCheckBox.Checked == true)
            {
                for (int i = 0; i < 36; i++)
                {
                    if (i != 8 && i != 13 && i != 18 && i != 23)
                    {
                        if (rnd.NextDouble() > chanceOfChar / 100)
                        {
                            GUIDtext.Text += rnd.Next(1, 9);
                        }
                        else
                        {
                            GUIDtext.Text += GetRandomCharacter(text, rnd);
                        }
                    }
                    else
                    {
                        GUIDtext.Text += "-";
                    }
                }
            }
            else
            {
                for (int i = 0; i < 32; i++)
                {
                    if (rnd.NextDouble() > chanceOfChar / 100)
                    {
                        GUIDtext.Text += rnd.Next(1, 9);
                    }
                    else
                    {
                        GUIDtext.Text += GetRandomCharacter(text, rnd);
                    }
                }
            }
            if (CapitalizedCheckBox.Checked == true)
            {
                GUIDtext.Text = GUIDtext.Text.ToUpper();
            }
            if (BraceCheckBox.Checked == true)
            {
                GUIDtext.Text += "}";
            }
        }
    }
}
