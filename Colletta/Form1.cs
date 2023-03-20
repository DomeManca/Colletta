using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colletta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.Columns.Add("Nome", 100);
            listView1.Columns.Add("Saldo", 100);
        }

        Dictionary<Persona, Soldi> collette = new Dictionary<Persona, Soldi>();
        Persona temp;
        Soldi temp2;

        string[] titolari = new string[] { "Meret","Di Lorenzo", "Rrahmani", "Kim", "Mario Rui" , "Anguissa", "Lobotka", "Zielinski" , "Lozano", "Osimhen", "Kvaratskhelia" };
        double SaldoTot = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < titolari.Length; i++)
            {
                temp = new Persona(titolari[i]);
                temp2 = new Soldi(0, "euro");
                collette.Add(temp, temp2);
            }

            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            Reload_ListView();
        }

        public void Reload_ListView()
        {
            foreach (KeyValuePair<Persona, Soldi> kvp in collette)
            {
                string[] val = new string[] { Convert.ToString(kvp.Key.Nome), Convert.ToString(kvp.Value.Importo) };

                ListViewItem item = new ListViewItem(val);
                listView1.Items.Add(item);

                label3.Text = $"Saldo totale: {SaldoTot}";
            }
        }

        private void button1_Click(object sender, EventArgs e)//aggiungi
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text) || !String.IsNullOrWhiteSpace(textBox2.Text))
            {
                try
                {
                    double quota = double.Parse(textBox2.Text);
                    bool ver = false;
                    for (int i = 0; i < titolari.Length; i++)
                        if (textBox1.Text == titolari[i])
                            ver = true;

                    if (ver)
                    {
                        temp = new Persona(textBox1.Text);
                        temp2 = collette[temp];
                        double oldimp = temp2.Importo;
                        temp2 = new Soldi(oldimp + quota, "€");
                        collette[temp] = temp2;
                    }
                    else
                    {
                        textBox1.Text = String.Empty;
                        throw new Exception("Persona non Esistente");
                    }

                    SaldoTot += quota;
                    listView1.Items.Clear();
                    Reload_ListView();

                    textBox1.Text = String.Empty;
                    textBox2.Text = String.Empty;
                }
                catch
                {
                    textBox2.Text = String.Empty;
                    throw new Exception("Quota non Valida");
                }
            }
            else
                throw new Exception("Inserire Valori");
        }

        private void button2_Click(object sender, EventArgs e)//togli
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text) || !String.IsNullOrWhiteSpace(textBox2.Text))
            {
                try
                {
                    double quota = double.Parse(textBox2.Text);
                    bool ver = false;
                    for (int i = 0; i < titolari.Length; i++)
                        if (textBox1.Text == titolari[i])
                            ver = true;

                    if (ver)
                    {
                        temp = new Persona(textBox1.Text);
                        temp2 = collette[temp];
                        double oldimp = temp2.Importo;

                        if (oldimp >= quota)
                        {
                            temp2 = new Soldi(temp2.Importo - quota, "€");
                            collette[temp] = temp2;
                        }
                        else
                            throw new Exception("Valore troppo alto");
                    }
                    else
                    {
                        textBox1.Text = String.Empty;
                        throw new Exception("Persona non Esistente");
                    }

                    SaldoTot -= quota;
                    listView1.Items.Clear();
                    Reload_ListView();

                    textBox1.Text = String.Empty;
                    textBox2.Text = String.Empty;
                }
                catch
                {
                    textBox2.Text = String.Empty;
                    throw new Exception("Quota non Valida");
                }
            }
            else
                throw new Exception("Inserire Valori");
        }

        private void button3_Click(object sender, EventArgs e) //ordina per nome
        {
            SortedDictionary<Persona, Soldi> temprino = new SortedDictionary<Persona, Soldi>(collette);
            collette = new Dictionary<Persona, Soldi>(temprino);

            listView1.Items.Clear();
            Reload_ListView();
        }

        private void button4_Click(object sender, EventArgs e) // ordina per importo
        {
            SortedDictionary<Persona, Soldi> temprino = new SortedDictionary<Persona, Soldi>(collette);
            collette = new Dictionary<Persona, Soldi>(temprino);

            listView1.Items.Clear();
            Reload_ListView();
        }
    }
}