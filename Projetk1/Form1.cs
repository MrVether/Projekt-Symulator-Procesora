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

        private void Reset_button(object sender, EventArgs e)
        {
            AX_Text.Text = "0000";
            BX_Text.Text = "0000";
            CX_Text.Text = "0000";
            DX_Text.Text = "0000";
            Okno_Błędu.Text = "Wartości wyzerowane";
        }
        private void MOV_AX_BX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in BX_Text.Text.ToUpper().ToArray())
            {
                if (!CharsArray.Contains(Char_Test))
                {
                    AX_Text.Text = "0000";
                    Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    CheckChars = false;
                }
                else if (CheckChars == true)
                {
                    AX_Text.Text = BX_Text.Text;
                    Okno_Błędu.Text = "Brak błędu";
                }
            }

        }

        private void MOV_AX_CX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in CX_Text.Text.ToUpper().ToArray())
            {
                if (!CharsArray.Contains(Char_Test))
                {
                    CX_Text.Text = "0000";
                    Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    CheckChars = false;
                }
                else if (CheckChars == true)
                {
                    AX_Text.Text = CX_Text.Text;
                    Okno_Błędu.Text = "Brak błędu";
                }
            }
        }

        private void MOV_AX_DX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in DX_Text.Text.ToUpper().ToArray())
            {
                if (!CharsArray.Contains(Char_Test))
                {
                    DX_Text.Text = "0000";
                    Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    CheckChars = false;
                }
                else if (CheckChars == true)
                {
                    AX_Text.Text = DX_Text.Text;
                    Okno_Błędu.Text = "Brak błędu";
                }
            }
        }

        private void MOV_BX_AX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in AX_Text.Text.ToUpper().ToArray())
            {
                if (!CharsArray.Contains(Char_Test))
                {
                    AX_Text.Text = "0000";
                    Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    CheckChars = false;
                }
                else if (CheckChars == true)
                {
                    BX_Text.Text = AX_Text.Text;
                    Okno_Błędu.Text = "Brak błędu";
                }
            }
        }

        private void MOV_BX_CX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in CX_Text.Text.ToUpper().ToArray())
            {
                if (!CharsArray.Contains(Char_Test))
                {
                    CX_Text.Text = "0000";
                    Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    CheckChars = false;
                }
                else if (CheckChars == true)
                {
                    BX_Text.Text = CX_Text.Text;
                    Okno_Błędu.Text = "Brak błędu";
                }
            }
        }

        private void MOV_BX_DX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in DX_Text.Text.ToUpper().ToArray())
            {
                if (!CharsArray.Contains(Char_Test))
                {
                    DX_Text.Text = "0000";
                    Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    CheckChars = false;
                }
                else if (CheckChars == true)
                {
                    BX_Text.Text = DX_Text.Text;
                    Okno_Błędu.Text = "Brak błędu";
                }
            }
        }

        private void MOV_CX_AX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in AX_Text.Text.ToUpper().ToArray())
            {
                if (!CharsArray.Contains(Char_Test))
                {
                    AX_Text.Text = "0000";
                    Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    CheckChars = false;
                }
                else if (CheckChars == true)
                {
                    CX_Text.Text = AX_Text.Text;
                    Okno_Błędu.Text = "Brak błędu";
                }
            }
        }

        private void MOV_CX_BX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in BX_Text.Text.ToUpper().ToArray())
            {
                if (!CharsArray.Contains(Char_Test))
                {
                    BX_Text.Text = "0000";
                    Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    CheckChars = false;
                }
                else if (CheckChars == true)
                {
                    CX_Text.Text = BX_Text.Text;
                    Okno_Błędu.Text = "Brak błędu";
                }
            }
        }

        private void MOV_CX_DX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in DX_Text.Text.ToUpper().ToArray())
            {
                if (!CharsArray.Contains(Char_Test))
                {
                    DX_Text.Text = "0000";
                    Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    CheckChars = false;
                }
                else if (CheckChars == true)
                {
                    CX_Text.Text = DX_Text.Text;
                    Okno_Błędu.Text = "Brak błędu";
                }
            }
        }

        private void MOV_DX_AX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in AX_Text.Text.ToUpper().ToArray())
            {
                if (!CharsArray.Contains(Char_Test))
                {
                    AX_Text.Text = "0000";
                    Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    CheckChars = false;
                }
                else if (CheckChars == true)
                {
                    DX_Text.Text = AX_Text.Text;
                    Okno_Błędu.Text = "Brak błędu";
                }
            }
        }

        private void MOV_DX_BX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in BX_Text.Text.ToUpper().ToArray())
            {
                if (!CharsArray.Contains(Char_Test))
                {
                    BX_Text.Text = "0000";
                    Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    CheckChars = false;
                }
                else if (CheckChars == true)
                {
                    DX_Text.Text = BX_Text.Text;
                    Okno_Błędu.Text = "Brak błędu";
                }
            }
        }

        private void MOV_DX_CX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in CX_Text.Text.ToUpper().ToArray())
            {
                if (!CharsArray.Contains(Char_Test))
                {
                    CX_Text.Text = "0000";
                    Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                    CheckChars = false;
                }
                else if (CheckChars == true)
                {
                    DX_Text.Text = CX_Text.Text;
                    Okno_Błędu.Text = "Brak bledu";
                }
            }
        }

        private void XCHG_AX_BX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in AX_Text.Text.ToUpper().ToArray())
                foreach (char characterB in BX_Text.Text.ToUpper().ToArray())
                {
                    if (!CharsArray.Contains(Char_Test))
                    {
                        AX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        CheckChars = false;

                    }
                    else if (!CharsArray.Contains(characterB))
                    {
                        CheckChars = false;
                        BX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (CheckChars == true)
            {
                string Wartosc;
                Wartosc = AX_Text.Text;
                AX_Text.Text = BX_Text.Text;
                BX_Text.Text = Wartosc;
                Okno_Błędu.Text = "Brak bledu";
            }
        }

        private void XCHG_AX_CX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in AX_Text.Text.ToUpper().ToArray())
                foreach (char characterB in CX_Text.Text.ToUpper().ToArray())
                {
                    if (!CharsArray.Contains(Char_Test))
                    {
                        AX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        CheckChars = false;

                    }
                    else if (!CharsArray.Contains(characterB))
                    {
                        CheckChars = false;
                        CX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (CheckChars == true)
            {
                string Wartosc;
                Wartosc = AX_Text.Text;
                AX_Text.Text = CX_Text.Text;
                CX_Text.Text = Wartosc;
                Okno_Błędu.Text = "Brak bledu";
            }
        }

        private void XCHG_AX_DX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in AX_Text.Text.ToUpper().ToArray())
                foreach (char characterB in DX_Text.Text.ToUpper().ToArray())
                {
                    if (!CharsArray.Contains(Char_Test))
                    {
                        AX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        CheckChars = false;

                    }
                    else if (!CharsArray.Contains(characterB))
                    {
                        CheckChars = false;
                        DX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (CheckChars == true)
            {
                string Wartosc;
                Wartosc = AX_Text.Text;
                AX_Text.Text = DX_Text.Text;
                DX_Text.Text = Wartosc;
                Okno_Błędu.Text = "Brak bledu";
            }
        }

        private void XCHG_BX_AX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in BX_Text.Text.ToUpper().ToArray())
                foreach (char characterB in AX_Text.Text.ToUpper().ToArray())
                {
                    if (!CharsArray.Contains(Char_Test))
                    {
                        BX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        CheckChars = false;

                    }
                    else if (!CharsArray.Contains(characterB))
                    {
                        CheckChars = false;
                        AX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (CheckChars == true)
            {
                string Wartosc;
                Wartosc = BX_Text.Text;
                BX_Text.Text = AX_Text.Text;
                AX_Text.Text = Wartosc;
                Okno_Błędu.Text = "Brak bledu";
            }
        }

        private void XCHG_BX_CX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in BX_Text.Text.ToUpper().ToArray())
                foreach (char characterB in CX_Text.Text.ToUpper().ToArray())
                {
                    if (!CharsArray.Contains(Char_Test))
                    {
                        BX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        CheckChars = false;

                    }
                    else if (!CharsArray.Contains(characterB))
                    {
                        CheckChars = false;
                        CX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (CheckChars == true)
            {
                string Wartosc;
                Wartosc = BX_Text.Text;
                BX_Text.Text = CX_Text.Text;
                CX_Text.Text = Wartosc;
                Okno_Błędu.Text = "Brak bledu";
            }
        }

        private void XCHG_BX_DX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in BX_Text.Text.ToUpper().ToArray())
                foreach (char characterB in DX_Text.Text.ToUpper().ToArray())
                {
                    if (!CharsArray.Contains(Char_Test))
                    {
                        BX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        CheckChars = false;

                    }
                    else if (!CharsArray.Contains(characterB))
                    {
                        CheckChars = false;
                        DX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (CheckChars == true)
            {
                string Wartosc;
                Wartosc = BX_Text.Text;
                BX_Text.Text = DX_Text.Text;
                DX_Text.Text = Wartosc;
                Okno_Błędu.Text = "Brak bledu";
            }
        }

        private void XCHG_CX_AX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in CX_Text.Text.ToUpper().ToArray())
                foreach (char characterB in AX_Text.Text.ToUpper().ToArray())
                {
                    if (!CharsArray.Contains(Char_Test))
                    {
                        CX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        CheckChars = false;

                    }
                    else if (!CharsArray.Contains(characterB))
                    {
                        CheckChars = false;
                        AX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (CheckChars == true)
            {
                string Wartosc;
                Wartosc = CX_Text.Text;
                CX_Text.Text = AX_Text.Text;
                AX_Text.Text = Wartosc;
                Okno_Błędu.Text = "Brak bledu";
            }
        }

        private void XCHG_CX_BX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in CX_Text.Text.ToUpper().ToArray())
                foreach (char characterB in BX_Text.Text.ToUpper().ToArray())
                {
                    if (!CharsArray.Contains(Char_Test))
                    {
                        CX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        CheckChars = false;

                    }
                    else if (!CharsArray.Contains(characterB))
                    {
                        CheckChars = false;
                        BX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (CheckChars == true)
            {
                string Wartosc;
                Wartosc = CX_Text.Text;
                CX_Text.Text = BX_Text.Text;
                BX_Text.Text = Wartosc;
                Okno_Błędu.Text = "Brak bledu";
            }
        }

        private void XCHG_CX_DX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in CX_Text.Text.ToUpper().ToArray())
                foreach (char characterB in DX_Text.Text.ToUpper().ToArray())
                {
                    if (!CharsArray.Contains(Char_Test))
                    {
                        CX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        CheckChars = false;

                    }
                    else if (!CharsArray.Contains(characterB))
                    {
                        CheckChars = false;
                        DX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (CheckChars == true)
            {
                string Wartosc;
                Wartosc = CX_Text.Text;
                CX_Text.Text = DX_Text.Text;
                DX_Text.Text = Wartosc;
                Okno_Błędu.Text = "Brak bledu";
            }
        }

        private void XCHG_DX_AX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in DX_Text.Text.ToUpper().ToArray())
                foreach (char characterB in AX_Text.Text.ToUpper().ToArray())
                {
                    if (!CharsArray.Contains(Char_Test))
                    {
                        DX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        CheckChars = false;

                    }
                    else if (!CharsArray.Contains(characterB))
                    {
                        CheckChars = false;
                        AX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (CheckChars == true)
            {
                string Wartosc;
                Wartosc = DX_Text.Text;
                DX_Text.Text = AX_Text.Text;
                AX_Text.Text = Wartosc;
                Okno_Błędu.Text = "Brak bledu";
            }
        }

        private void XCHG_DX_BX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in DX_Text.Text.ToUpper().ToArray())
                foreach (char characterB in BX_Text.Text.ToUpper().ToArray())
                {
                    if (!CharsArray.Contains(Char_Test))
                    {
                        DX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        CheckChars = false;

                    }
                    else if (!CharsArray.Contains(characterB))
                    {
                        CheckChars = false;
                        BX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (CheckChars == true)
            {
                string Wartosc;
                Wartosc = DX_Text.Text;
                DX_Text.Text = BX_Text.Text;
                BX_Text.Text = Wartosc;
                Okno_Błędu.Text = "Brak bledu";
            }
        }

        private void XCHG_DX_CX_Click(object sender, EventArgs e)
        {
            char[] CharsArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            bool CheckChars = true;
            foreach (char Char_Test in DX_Text.Text.ToUpper().ToArray())
                foreach (char characterB in CX_Text.Text.ToUpper().ToArray())
                {
                    if (!CharsArray.Contains(Char_Test))
                    {
                        DX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";
                        CheckChars = false;

                    }
                    else if (!CharsArray.Contains(characterB))
                    {
                        CheckChars = false;
                        CX_Text.Text = "0000";
                        Okno_Błędu.Text = "WARTOŚCI ZAPISZ W SYSTEMIE SZESNASTKOWYM";

                    }
                }
            if (CheckChars == true)
            {
                string Wartosc;
                Wartosc = DX_Text.Text;
                DX_Text.Text = CX_Text.Text;
                CX_Text.Text = Wartosc;
                Okno_Błędu.Text = "Brak bledu";
            }
        }
    }
}
