using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zaj3_warun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.Checked = true;
            checkBox1.Checked = false;
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBox1.Enabled = true;
                label1.Enabled = true;
                numericUpDown1.Enabled = false;
                button6.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
            }
            else
            {
                textBox1.Enabled = false;
                label1.Enabled = false;
                numericUpDown1.Enabled = true;
                button6.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                string liczby = textBox1.Text;
                int[] uuh = TextToIntTable(liczby);

                uuh = SortBoubble(uuh);

                string porvalo = IntTableToString(uuh);
                label1.Text = porvalo;
            }
            else
            {

                var watch = new Stopwatch();
                watch.Start();
                SortBoubble(tablica);
                watch.Stop();
                double czas = 1000.0 * watch.ElapsedTicks / Stopwatch.Frequency;
                string czas_zwracany = czas.ToString();
                //string wtf = IntTableToString(tablica);
                label3.Text = czas_zwracany;
            }

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
            if (checkBox1.Checked == false)
            {
                string liczby = textBox1.Text;
                int[] uuh = TextToIntTable(liczby);

                uuh = SortSelection(uuh);

                string porvalo = IntTableToString(uuh);
                label1.Text = porvalo;
            }
            else
            {

                var watch = new Stopwatch();
                watch.Start();
                SortSelection(tablica);
                watch.Stop();
                double czas = 1000.0 * watch.ElapsedTicks / Stopwatch.Frequency;
                string czas_zwracany = czas.ToString();
                //string wtf = IntTableToString(tablica);
                label3.Text = czas_zwracany;
            }
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
            if (checkBox1.Checked == false)
            {
                string liczby = textBox1.Text;
                int[] uuh = TextToIntTable(liczby);

                uuh = SortInsertion(uuh);

                string porvalo = IntTableToString(uuh);
                label1.Text = porvalo;
            }
            else
            {

                var watch = new Stopwatch();
                watch.Start();
                SortInsertion(tablica);
                watch.Stop();
                double czas = 1000.0 * watch.ElapsedTicks / Stopwatch.Frequency;
                string czas_zwracany = czas.ToString();
                //string wtf = IntTableToString(tablica);
                label3.Text = czas_zwracany;
            }
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
            if (checkBox1.Checked == false)
            {
                string liczby = textBox1.Text;
                int[] uuh = TextToIntTable(liczby);

                uuh = SortMerge(uuh);

                string porvalo = IntTableToString(uuh);
                label1.Text = porvalo;
            }
            else
            {

                var watch = new Stopwatch();
                watch.Start();
                SortMerge(tablica);
                watch.Stop();
                double czas = 1000.0 * watch.ElapsedTicks / Stopwatch.Frequency;
                string czas_zwracany = czas.ToString();
                //string wtf = IntTableToString(tablica);
                label3.Text = czas_zwracany;
            }
        }

        int[] SortMerge(int[] lista)
        {
            if (lista.Length > 1)
            {
                int mid = lista.Length / 2;
                int[] left = new int[mid];

                for (int i1 = 0; i1 < mid; i1++)
                {
                    left[i1] = lista[i1];
                }

                int[] right = new int[lista.Length - mid];

                for (int i2 = 0; i2 < lista.Length - mid; i2++)
                {
                    right[i2] = lista[i2 + mid];
                }

                SortMerge(left);
                SortMerge(right);

                int i = 0;
                int j = 0;
                int k = 0;

                while (i < left.Length && j < right.Length)
                {
                    if ((left[i] < right[j]))
                    {
                        lista[k] = left[i];
                        i += 1;
                    }
                    else
                    {
                        lista[k] = right[j];
                        j += 1;
                    }
                    k += 1;

                }
                while (i < left.Length)
                {
                    lista[k] = left[i];
                    i += 1;
                    k += 1;
                }
                while (j < right.Length)
                {
                    lista[k] = right[j];
                    j += 1;
                    k += 1;
                }
                return lista;
            }
            return lista;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                string liczby = textBox1.Text;
                int[] uuh = TextToIntTable(liczby);

                uuh = SortQuick(uuh);

                string porvalo = IntTableToString(uuh);
                label1.Text = porvalo;
            }
            else
            {

                var watch = new Stopwatch();
                watch.Start();
                SortQuick(tablica);
                watch.Stop();
                double czas = 1000.0 * watch.ElapsedTicks / Stopwatch.Frequency;
                string czas_zwracany = czas.ToString();
                //string wtf = IntTableToString(tablica);
                label3.Text = czas_zwracany;
            }
        }
        int[] SortQuick(int[] lista)
        {
            int pivot = lista.Length - 1;
            int granica = 0;
            int wskaznik = 0;

            while (wskaznik != pivot)
            {
                if (lista[pivot] >= lista[wskaznik])
                {
                    int temp1 = lista[wskaznik];
                    lista[wskaznik] = lista[granica];
                    lista[granica] = temp1;
                    wskaznik++;
                    granica++;
                }
                else
                {
                    wskaznik++;
                }
            }
            int temp = lista[pivot];
            lista[pivot] = lista[granica];
            lista[granica] = temp;

            int[] left = new int[granica];

            for (int i1 = 0; i1 < granica; i1++)
            {
                left[i1] = lista[i1];
            }

            int[] right = new int[lista.Length - granica];

            for (int i2 = 0; i2 < lista.Length - granica; i2++)
            {
                right[i2] = lista[i2 + granica];
            }

            if (left.Length > 1)
            {
                left = SortQuick(left);
                for (int i1 = 0; i1 < granica; i1++)
                {
                    lista[i1] = left[i1];
                }
            }

            if (right.Length > 1)
            {
                right = SortQuick(right);
                for (int i2 = 0; i2 < lista.Length - granica; i2++)
                {
                    lista[i2 + granica] = right[i2];
                }
            }

            return lista;
        }
        int wartosc;
        int[] tablica;
        public void button6_Click(object sender, EventArgs e)
        {
            wartosc = (int)numericUpDown1.Value;
            tablica = new int[wartosc];

            for (int i = 0; i < wartosc; i++)
            {
                Random rnd = new Random();
                tablica[i] = rnd.Next(1000);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}