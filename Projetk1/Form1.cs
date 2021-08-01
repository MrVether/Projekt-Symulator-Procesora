using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetk1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1a.Text = "0000";
            textBox2b.Text = "0000";
            textBox3c.Text = "0000";
            textBox4d.Text = "0000";
            blad1.Text = "Wartości wyzerowane";
        }
        private void MOV_AX_BX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox2b.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox1a.Text = "0000";
                    blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox1a.Text = textBox2b.Text;
                    blad1.Text = "Brak błędu";
                }
            }

        }

        private void MOV_AX_CX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox3c.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox3c.Text = "0000";
                    blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox1a.Text = textBox3c.Text;
                    blad1.Text = "Brak błędu";
                }
            }
        }

        private void MOV_AX_DX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox4d.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox4d.Text = "0000";
                    blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox1a.Text = textBox4d.Text;
                    blad1.Text = "Brak błędu";
                }
            }
        }

        private void MOV_BX_AX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox1a.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox1a.Text = "0000";
                    blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox2b.Text = textBox1a.Text;
                    blad1.Text = "Brak błędu";
                }
            }
        }

        private void MOV_BX_CX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox3c.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox3c.Text = "0000";
                    blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox2b.Text = textBox3c.Text;
                    blad1.Text = "Brak błędu";
                }
            }
        }

        private void MOV_BX_DX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox4d.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox4d.Text = "0000";
                    blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox2b.Text = textBox4d.Text;
                    blad1.Text = "Brak błędu";
                }
            }
        }

        private void MOV_CX_AX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox1a.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox1a.Text = "0000";
                    blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox3c.Text = textBox1a.Text;
                    blad1.Text = "Brak błędu";
                }
            }
        }

        private void MOV_CX_BX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox2b.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox2b.Text = "0000";
                    blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox3c.Text = textBox2b.Text;
                    blad1.Text = "Brak błędu";
                }
            }
        }

        private void MOV_CX_DX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox4d.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox4d.Text = "0000";
                    blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox3c.Text = textBox4d.Text;
                    blad1.Text = "Brak błędu";
                }
            }
        }

        private void MOV_DX_AX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox1a.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox1a.Text = "0000";
                    blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox4d.Text = textBox1a.Text;
                    blad1.Text = "Brak błędu";
                }
            }
        }

        private void MOV_DX_BX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox2b.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox2b.Text = "0000";
                    blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox4d.Text = textBox2b.Text;
                    blad1.Text = "Brak błędu";
                }
            }
        }

        private void MOV_DX_CX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox3c.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(characterA))
                {
                    textBox3c.Text = "0000";
                    blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    proper = false;
                }
                else if (proper == true)
                {
                    textBox4d.Text = textBox3c.Text;
                    blad1.Text = "Brak bledu";
                }
            }
        }

        private void XCHG_AX_BX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox1a.Text.ToUpper().ToArray())
                foreach (char characterB in textBox2b.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox1a.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox2b.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (proper == true)
            {
                string Wartosc;
                Wartosc = textBox1a.Text;
                textBox1a.Text = textBox2b.Text;
                textBox2b.Text = Wartosc;
                blad1.Text = "Brak bledu";
            }
        }

        private void XCHG_AX_CX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox1a.Text.ToUpper().ToArray())
                foreach (char characterB in textBox3c.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox1a.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox3c.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (proper == true)
            {
                string Wartosc;
                Wartosc = textBox1a.Text;
                textBox1a.Text = textBox3c.Text;
                textBox3c.Text = Wartosc;
                blad1.Text = "Brak bledu";
            }
        }

        private void XCHG_AX_DX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox1a.Text.ToUpper().ToArray())
                foreach (char characterB in textBox4d.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox1a.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox4d.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (proper == true)
            {
                string Wartosc;
                Wartosc = textBox1a.Text;
                textBox1a.Text = textBox4d.Text;
                textBox4d.Text = Wartosc;
                blad1.Text = "Brak bledu";
            }
        }

        private void XCHG_BX_AX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox2b.Text.ToUpper().ToArray())
                foreach (char characterB in textBox1a.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox2b.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox1a.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (proper == true)
            {
                string Wartosc;
                Wartosc = textBox2b.Text;
                textBox2b.Text = textBox1a.Text;
                textBox1a.Text = Wartosc;
                blad1.Text = "Brak bledu";
            }
        }

        private void XCHG_BX_CX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox2b.Text.ToUpper().ToArray())
                foreach (char characterB in textBox3c.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox2b.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox3c.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (proper == true)
            {
                string Wartosc;
                Wartosc = textBox2b.Text;
                textBox2b.Text = textBox3c.Text;
                textBox3c.Text = Wartosc;
                blad1.Text = "Brak bledu";
            }
        }

        private void XCHG_BX_DX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox2b.Text.ToUpper().ToArray())
                foreach (char characterB in textBox4d.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox2b.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox4d.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (proper == true)
            {
                string Wartosc;
                Wartosc = textBox2b.Text;
                textBox2b.Text = textBox4d.Text;
                textBox4d.Text = Wartosc;
                blad1.Text = "Brak bledu";
            }
        }

        private void XCHG_CX_AX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox3c.Text.ToUpper().ToArray())
                foreach (char characterB in textBox1a.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox3c.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox1a.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (proper == true)
            {
                string Wartosc;
                Wartosc = textBox3c.Text;
                textBox3c.Text = textBox1a.Text;
                textBox1a.Text = Wartosc;
                blad1.Text = "Brak bledu";
            }
        }

        private void XCHG_CX_BX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox3c.Text.ToUpper().ToArray())
                foreach (char characterB in textBox2b.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox3c.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox2b.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (proper == true)
            {
                string Wartosc;
                Wartosc = textBox3c.Text;
                textBox3c.Text = textBox2b.Text;
                textBox2b.Text = Wartosc;
                blad1.Text = "Brak bledu";
            }
        }

        private void XCHG_CX_DX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox3c.Text.ToUpper().ToArray())
                foreach (char characterB in textBox4d.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox3c.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox4d.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (proper == true)
            {
                string Wartosc;
                Wartosc = textBox3c.Text;
                textBox3c.Text = textBox4d.Text;
                textBox4d.Text = Wartosc;
                blad1.Text = "Brak bledu";
            }
        }

        private void XCHG_DX_AX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox4d.Text.ToUpper().ToArray())
                foreach (char characterB in textBox1a.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox4d.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox1a.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (proper == true)
            {
                string Wartosc;
                Wartosc = textBox4d.Text;
                textBox4d.Text = textBox1a.Text;
                textBox1a.Text = Wartosc;
                blad1.Text = "Brak bledu";
            }
        }

        private void XCHG_DX_BX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox4d.Text.ToUpper().ToArray())
                foreach (char characterB in textBox2b.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox4d.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox2b.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (proper == true)
            {
                string Wartosc;
                Wartosc = textBox4d.Text;
                textBox4d.Text = textBox2b.Text;
                textBox2b.Text = Wartosc;
                blad1.Text = "Brak bledu";
            }
        }

        private void XCHG_DX_CX_Click(object sender, EventArgs e)
        {
            char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool proper = true;
            foreach (char characterA in textBox4d.Text.ToUpper().ToArray())
                foreach (char characterB in textBox3c.Text.ToUpper().ToArray())
                {
                    if (!allowedChars.Contains(characterA))
                    {
                        textBox4d.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        proper = false;

                    }
                    else if (!allowedChars.Contains(characterB))
                    {
                        proper = false;
                        textBox3c.Text = "0000";
                        blad1.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (proper == true)
            {
                string Wartosc;
                Wartosc = textBox4d.Text;
                textBox4d.Text = textBox3c.Text;
                textBox3c.Text = Wartosc;
                blad1.Text = "Brak bledu";
            }
        }
    }
}
