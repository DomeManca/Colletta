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
        Dictionary<Persona, Soldi> quote;
        int newIndex = 0, selectedIndex = 0;
        bool selected = false;
        double totale = 0, totaleQuote = 0, deltaQuote = 0;
        public Form1()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(Soldi.ValuteAccettate);
            comboBox2.Items.AddRange(Soldi.ValuteAccettate);
            comboBox2.Text = comboBox1.Text = Soldi.ValuteAccettate[2];

            dataGridView1.Columns.Add("Name", "NOME");
            dataGridView1.Columns.Add("Surname", "COGNOME");
            dataGridView1.Columns.Add("Amount", "IMPORTO");
            dataGridView1.Columns.Add("Currency", "VALUTA");
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = (dataGridView1.Width * 22) / 100;
            }

            dataGridView1.ReadOnly = true;

            butNewData.Enabled = false;
            butDelete.Enabled = false;
            comboBox1.Enabled = false;

            quote = new Dictionary<Persona, Soldi>();
        }

        private void butNewUser_Click(object sender, EventArgs e)
        { /*inserisci*/
            if ((!String.IsNullOrWhiteSpace(textName.Text)) && (!String.IsNullOrWhiteSpace(textSurname.Text) && (!String.IsNullOrWhiteSpace(textPrice.Text)) && textPrice.Text.All(char.IsDigit)))
            {

                Persona p = new Persona(textName.Text, textSurname.Text);
                Soldi s = new Soldi(float.Parse(textPrice.Text), comboBox1.Text);

                if (quote.ContainsKey(p) && selected == false)
                { /*se è lo stesso nome già esistente ma la riga non è stata selezionata*/
                    MessageBox.Show("Per modificare un valore selezionare la sua linea");
                }
                else
                {
                    quote[p] = s;
                    AddRow(textName.Text, textSurname.Text, textPrice.Text, comboBox1.Text);
                    ChangeLabels();
                    ClearTextBox();
                    dataGridView1.ClearSelection();
                    selected = false;
                }
            }
            else
            {
                MessageBox.Show("Inserire dei dati validi");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { /*tot da pagare*/
            if (String.IsNullOrWhiteSpace(textBox1.Text) || (!textBox1.Text.All(char.IsDigit)))
            {
                butNewData.Enabled = false;
                comboBox1.Enabled = false;
            }
            else
            {
                butNewData.Enabled = true;
                comboBox1.Enabled = true;
                totale = float.Parse(textBox1.Text);
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {/*elimina*/
            if (!dataGridView1.SelectedRows[0].IsNewRow && dataGridView1.SelectedRows.Count == 1)
            {
                Persona a = new Persona(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                MessageBox.Show($"[{a.Id}]");
                quote.Remove(a);
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

                dataGridView1.ClearSelection();
                ChangeLabels();
                ClearTextBox();

                butDelete.Enabled = false;
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!dataGridView1.SelectedRows[0].IsNewRow)
            {
                butDelete.Enabled = true;
                selected = true;

                selectedIndex = dataGridView1.SelectedRows[0].Index;

                textName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textSurname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textPrice.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void AddRow(params string[] listuccia)
        {
            if (!selected)
            {
                dataGridView1.Rows.Insert(newIndex, listuccia);
                newIndex++;
            }
            else
            { /*qui sot modificando un valore già esistente*/
                dataGridView1.Rows[selectedIndex].SetValues(listuccia);
            }
        }
        private void ChangeLabels()
        {
            totaleQuote = 0;
            foreach (KeyValuePair<Persona, Soldi> kvp in quote)
            {
                totaleQuote += Soldi.CambiaValuta(kvp.Value.Valuta, comboBox2.Text, kvp.Value.Importo);
            }
            deltaQuote = totale - totaleQuote;

            labTot.Text = $"TOT:{totaleQuote} {comboBox2.Text}";
            labDelta.Text = $"D: {deltaQuote}";
        }
        private void ClearTextBox()
        {
            textName.Text = textSurname.Text = textPrice.Text = String.Empty;
        }
    }
}
