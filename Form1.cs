using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const string ConnectionString = "server=127.0.0.1;uid=programma;pwd=12345;database=cinematografia";
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadTabelle();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn= new MySqlConnection(ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT film.nome, film.durata, film.genere, registi.nome as nomeRegista, registi.cognome as cognomeRegsita FROM film join registi on film.id_regista=registi.id;", conn);
            cmd.ExecuteNonQuery();
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = cmd;
            DataTable dati = new DataTable();
            MyAdapter.Fill(dati);
            dataGridView1.DataSource = dati;
            conn.Close();
        }
        private void LoadTabelle()
        {
            DataGridView[] dataGrids = new DataGridView[] { dataGridView1, dataGridView2, dataGridView3, dataGridView4 };
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            int x = tabControl1.SelectedIndex;
            string[] queryComplete = new string[] { "SELECT film.nome, film.durata, film.genere, registi.nome as nomeRegista, registi.cognome as cognomeRegsita FROM film join registi on film.id_regista=registi.id;", "SELECT attori.nome,attori.cognome,attori.data_di_nascita,attori.data_di_morte FROM attori;", "SELECT registi.nome,registi.cognome,registi.data_di_nascita,registi.data_di_morte FROM registi;", "SELECT attori.nome as nomeAttore,attori.cognome as cognomeAttore,film.nome as Film FROM (partecipazioni join film on film.id=partecipazioni.id_film) right join attori on partecipazioni.id_attore=attori.id;" };
            MySqlCommand cmd1 = new MySqlCommand(queryComplete[tabControl1.SelectedIndex], conn);
            cmd1.ExecuteNonQuery();
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = cmd1;
            DataTable dati = new DataTable();
            MyAdapter.Fill(dati);
            dataGrids[tabControl1.SelectedIndex].DataSource = dati;
            conn.Close();
        }
        private void CaricaQuery(DataGridView dataGrid, string query)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            int x = tabControl1.SelectedIndex;
            MySqlCommand cmd1 = new MySqlCommand(query, conn);
            cmd1.ExecuteNonQuery();
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = cmd1;
            DataTable dati = new DataTable();
            MyAdapter.Fill(dati);
            dataGrid.DataSource = dati;
            conn.Close();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CaricaQuery(dataGridView1, "SELECT film.nome, film.durata, film.genere, registi.nome as nomeRegista, registi.cognome as cognomeRegsita FROM film join registi on film.id_regista=registi.id where film.durata<2.0;");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                CaricaQuery(dataGridView1, $"SELECT film.nome, film.durata, film.genere, registi.nome as nomeRegista, registi.cognome as cognomeRegsita FROM film join registi on film.id_regista=registi.id where film.genere=\"{textBox1.Text.Trim()}\";");
            }
            else MessageBox.Show("Valore inserito non valido");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                CaricaQuery(dataGridView1, $"SELECT film.nome, film.durata, film.genere, registi.nome as nomeRegista, registi.cognome as cognomeRegsita FROM film join registi on film.id_regista=registi.id where registi.cognome=\"{textBox2.Text.Trim()}\";");
            }
            else MessageBox.Show("Valore inserito non valido");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadTabelle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CaricaQuery(dataGridView1, "SELECT film.nome, film.durata, film.genere, registi.nome as nomeRegista, registi.cognome as cognomeRegsita FROM film join registi on film.id_regista=registi.id where film.durata>2.0;");
        }

        private void attoriMorti_Click(object sender, EventArgs e)
        {
            CaricaQuery(dataGridView2, "SELECT attori.nome,attori.cognome,attori.data_di_nascita,attori.data_di_morte FROM attori where attori.data_di_morte IS NOT null AND attori.data_di_morte <= CURRENT_DATE;");
        }

        private void dopoData_Click(object sender, EventArgs e)
        {
            string data=monthCalendar1.SelectionStart.ToString();
            DateTime date = new DateTime();
            data=DateTime.Parse(data).ToString("yyyy/MM/dd");
            CaricaQuery(dataGridView2, $"SELECT attori.nome,attori.cognome,attori.data_di_nascita,attori.data_di_morte FROM attori where attori.data_di_nascita >\"{data}\" ");
        }

        private void preData_Click(object sender, EventArgs e)
        {
            string data = monthCalendar1.SelectionStart.ToString();
            DateTime date = new DateTime();
            data = DateTime.Parse(data).ToString("yyyy/MM/dd");
            CaricaQuery(dataGridView2, $"SELECT attori.nome,attori.cognome,attori.data_di_nascita,attori.data_di_morte FROM attori where attori.data_di_nascita <\"{data}\" ");
        
        }

        private void annullaFiltri_Click(object sender, EventArgs e)
        {
            LoadTabelle();
        }

        private void dopoDataReg_Click(object sender, EventArgs e)
        {
            string data = monthCalendar2.SelectionStart.ToString();
            DateTime date = new DateTime();
            data = DateTime.Parse(data).ToString("yyyy/MM/dd");
            CaricaQuery(dataGridView3, $"SELECT registi.nome,registi.cognome,registi.data_di_nascita,registi.data_di_morte FROM registi where registi.data_di_nascita >\"{data}\" ");

        }

        private void preDataReg_Click(object sender, EventArgs e)
        {
            string data = monthCalendar2.SelectionStart.ToString();
            DateTime date = new DateTime();
            data = DateTime.Parse(data).ToString("yyyy/MM/dd");
            CaricaQuery(dataGridView3, $"SELECT registi.nome,registi.cognome,registi.data_di_nascita,registi.data_di_morte FROM registi where registi.data_di_nascita <\"{data}\" ");
        }

        private void annullaFiltriReg_Click(object sender, EventArgs e)
        {
            LoadTabelle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CaricaQuery(dataGridView3, "SELECT registi.nome,registi.cognome,registi.data_di_nascita,registi.data_di_morte FROM registi where registi.data_di_morte IS NOT null AND registi.data_di_morte <= CURRENT_DATE;");
        }

        private void piuDiFilm_Click(object sender, EventArgs e)
        {
            CaricaQuery(dataGridView4, "SELECT attori.nome as nomeAttore,attori.cognome as cognomeAttore,film.nome as Film FROM (partecipazioni join film on film.id=partecipazioni.id_film) right join attori on partecipazioni.id_attore=attori.id except (SELECT attori.nome,attori.cognome,film.nome from (partecipazioni join film on film.id=partecipazioni.id_film) right join attori on partecipazioni.id_attore=attori.id group by attori.id having COUNT(film.id)<2) ; ");
        }

        private void nessunFilm_Click(object sender, EventArgs e)
        {
            CaricaQuery(dataGridView4, "SELECT attori.nome as nomeAttore,attori.cognome as cognomeAttore,film.nome as Film FROM (partecipazioni join film on film.id=partecipazioni.id_film) right join attori on partecipazioni.id_attore=attori.id group by attori.id having COUNT(film.id)=0 ");

        }

        private void unFilm_Click(object sender, EventArgs e)
        {
            CaricaQuery(dataGridView4, "SELECT attori.nome as nomeAttore,attori.cognome as cognomeAttore,film.nome as Film FROM (partecipazioni join film on film.id=partecipazioni.id_film) right join attori on partecipazioni.id_attore=attori.id group by attori.id having COUNT(film.id)=1 ");

        }

        private void filmFiltro_Click(object sender, EventArgs e)
        {
            CaricaQuery(dataGridView4, $"SELECT attori.nome as nomeAttore,attori.cognome as cognomeAttore,film.nome as Film FROM (partecipazioni join film on film.id=partecipazioni.id_film) right join attori on partecipazioni.id_attore=attori.id where (film.nome=\"{filmBox.Text.Trim()}\"); ");

        }

        private void attoreFiltro_Click(object sender, EventArgs e)
        {
            CaricaQuery(dataGridView4, $"SELECT attori.nome as nomeAttore,attori.cognome as cognomeAttore,film.nome as Film FROM (partecipazioni join film on film.id=partecipazioni.id_film) right join attori on partecipazioni.id_attore=attori.id where (attori.cognome=\"{attoreBox.Text.Trim()}\"); ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadTabelle();
        }
    }
    
}
