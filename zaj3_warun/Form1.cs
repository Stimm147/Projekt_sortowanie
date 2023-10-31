using System.CodeDom.Compiler;

namespace zaj3_warun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string liczby = textBox1.Text;
            int[] uuh = TextToIntTable(liczby);

            uuh = SortBoubble(uuh);

            string porvalo = IntTableToString(uuh);
            label1.Text = porvalo;
        }

        int[] SortBoubble(int[] lista)
        {
            int issorted = 0;

            while (issorted != lista.Length - 1)
            {
                for (int i = 0; i < lista.Length - 1; i++)
                {
                    if (lista[i] <= lista[i + 1])
                    {
                        issorted++;
                    }
                    else
                    {
                        continue;
                    }

                }
                if (issorted < lista.Length - 1)
                    issorted = 0;
                for (int i = 0; i < lista.Length - 1; i++)
                {
                    if (lista[i] > lista[i + 1])
                    {
                        int temp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = temp;
                    }
                }
            }
            return lista;
        }

        string IntTableToString(int[] uuh)
        {
            string[] tekst = new string[uuh.Length];
            //label1.Text = uuh.ToString();
            for (int i = 0; i < uuh.Length; i++)
            {
                tekst[i] = uuh[i].ToString();
            }
            string porvalo = string.Join(' ', tekst);
            return porvalo;
        }
        int[] TextToIntTable(string napis)
        {
            var LiczbyS = napis.Trim().Split(' ');
            var liczby = new int[LiczbyS.Length];
            for (int i = 0; i < LiczbyS.Length; i++)
            {
                liczby[i] = int.Parse(LiczbyS[i]);
            }
            return liczby;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string liczby = textBox1.Text;
            int[] uuh = TextToIntTable(liczby);

            uuh = SortSelection(uuh);

            string porvalo = IntTableToString(uuh);
            label1.Text = porvalo;
        }


        int[] SortSelection(int[] lista)
        {
            int issorted = 0;
            int minimum = lista[0];

            while (issorted != lista.Length - 1)
            {
                for (int i = 0; i < lista.Length - 1; i++)
                {
                    if (lista[i] <= lista[i + 1])
                    {
                        issorted++;
                    }
                    else
                    {
                        continue;
                    }

                }
                if (issorted < lista.Length - 1)
                    issorted = 0;
                for (int i = 0; i < lista.Length; i++)
                {
                    for (int j = i + 1; j < lista.Length; j++)
                    {
                        if (lista[i] > lista[j])
                        {
                            int temp = lista[i];
                            lista[i] = lista[j];
                            lista[j] = temp;
                            break;
                        }
                    }

                }
            }

            return lista;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string liczby = textBox1.Text;
            int[] uuh = TextToIntTable(liczby);

            uuh = SortInsertion(uuh);

            string porvalo = IntTableToString(uuh);
            label1.Text = porvalo;
        }

        int[] SortInsertion(int[] lista)
        {
            int issorted = 0;
            int minimum = lista[0];

            while (issorted != lista.Length - 1)
            {
                for (int i = 0; i < lista.Length - 1; i++)
                {
                    if (lista[i] <= lista[i + 1])
                    {
                        issorted++;
                    }
                    else
                    {
                        continue;
                    }

                }
                if (issorted < lista.Length - 1)
                    issorted = 0;
                for (int i = 0; i < lista.Length - 1; i++)
                {
                    if (lista[i] > lista[i + 1])
                    {
                        for (int j = i; j >= 0; j--)
                        {
                            int temp = lista[j];
                            lista[j] = lista[j + 1];
                            lista[j + 1] = temp;
                            if (lista[j] < lista[i])
                            {
                                break;
                            }
                        }
                    }
                }
            }

            return lista;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string liczby = textBox1.Text;
            int[] uuh = TextToIntTable(liczby);

            uuh = SortMerge(uuh);

            string porvalo = IntTableToString(uuh);
            label1.Text = porvalo;
        }

        int[] SortMerge(int[] lista)
        {
            int issorted = 0;

            while (issorted != lista.Length - 1)
            {
                for (int i = 0; i < lista.Length - 1; i++)
                {
                    if (lista[i] <= lista[i + 1])
                    {
                        issorted++;
                    }
                    else
                    {
                        continue;
                    }

                }
                if (issorted < lista.Length - 1)
                    issorted = 0;
                for (int i = 0; i < lista.Length - 1; i++)
                {
                    if (lista[i] > lista[i + 1])
                    {
                        int temp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = temp;
                    }
                }
            }
            return lista;
        }
    }
}