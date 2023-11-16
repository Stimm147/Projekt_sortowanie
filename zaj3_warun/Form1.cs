using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zaj3_warun
{
    public partial class Form1 : Form
    {
        int wartosc;
        int[] tablica;
        Stopwatch stopwatch = new Stopwatch();
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
                stopwatch.Start();
                SortBoubble(tablica);
                stopwatch.Stop();
                double czas = Math.Round(stopwatch.Elapsed.TotalSeconds, 2);
                label3.Text = czas.ToString() + " sekund";
                stopwatch.Reset();
            }

        }

        int[] SortBoubble(int[] lista)
        {
            int max = lista.Length;

            while (max > 1)
            {
                for (int i = 0; i < max - 1; i++)
                {
                    if (lista[i] > lista[i + 1])
                    {
                        int temp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = temp;
                    }
                }
                max--;
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
            try
            {
                for (int i = 0; i < LiczbyS.Length; i++)
                {
                    liczby[i] = int.Parse(LiczbyS[i]);
                }
            }
            catch
            {
                MessageBox.Show("U¿yto nieprawid³owego typu danych");
                liczby[0] = 0;
                return liczby;
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

                stopwatch.Start();
                SortSelection(tablica);
                stopwatch.Stop();
                double czas = Math.Round(stopwatch.Elapsed.TotalSeconds, 2);
                label3.Text = czas.ToString() + " sekund";
                stopwatch.Reset();
            }
        }


        int[] SortSelection(int[] lista)
        {
            int current_minimum = 0;
            for (int j = 0; j < lista.Length; j++)
            {
                for (int i = j + 1; i < lista.Length; i++)
                {
                    if (lista[current_minimum] > lista[i])
                    {
                        current_minimum = i;
                    }
                }
                int temp = lista[j];
                lista[j] = lista[current_minimum];
                lista[current_minimum] = temp;
                current_minimum = j + 1;
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

                stopwatch.Start();
                SortInsertion(tablica);
                stopwatch.Stop();
                double czas = Math.Round(stopwatch.Elapsed.TotalSeconds, 2);
                label3.Text = czas.ToString() + " sekund";
                stopwatch.Reset();
            }
        }

        int[] SortInsertion(int[] lista)
        {
            int issorted = 0;
            int minimum = lista[0];

            for (int i = 0; i < lista.Length - 1; i++)
            {
                if (lista[i] > lista[i + 1])
                {
                    for (int j = i; j >= 0; j--)
                    {
                        if (lista[j] < lista[j + 1])
                        {
                            break;
                        }
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;

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

                stopwatch.Start();
                SortMerge(tablica);
                stopwatch.Stop();
                double czas = Math.Round(stopwatch.Elapsed.TotalSeconds, 2);
                label3.Text = czas.ToString() + " sekund";
                stopwatch.Reset();
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

                stopwatch.Start();
                SortQuick(tablica);
                stopwatch.Stop();
                double czas = Math.Round(stopwatch.Elapsed.TotalSeconds, 2);
                label3.Text = czas.ToString() + " sekund";
                stopwatch.Reset();
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