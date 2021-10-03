using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace aircraftSale
{
    public partial class FormAircraft : Form
    {
        public FormAircraft()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "aircraftsale";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            textBoxID.Clear();
            textBoxAircraft.Clear();
            textBoxManufacturing.Clear();
            textBoxTurbulence.Clear();
            textBoxPassenger.Clear();
        }

        private void FormAircraft_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM inventory";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridInventory.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridInventory.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetString(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetString(4);
                    dataGridInventory.Rows.Add(row);
                }
                realizaConexaoBD.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can not opne connection !");
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO inventory (aircraft, manufacturing, wakeTurbulenceCategory, passengerCapacity)" + "VALUES('" + textBoxAircraft.Text + "', " + Convert.ToInt16(textBoxManufacturing.Text) + ", '" + textBoxTurbulence.Text + "', " + Convert.ToInt16(textBoxPassenger.Text) + ")";
                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close();
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "UPDATE `inventory` SET `aircraft` = '" + textBoxAircraft.Text + "', `manufacturing` = '" + textBoxManufacturing.Text + "', `wakeTurbulenceCategory` = '" + textBoxTurbulence.Text + "', `passengerCapacity` = '" + Convert.ToInt16(textBoxPassenger.Text) + "' WHERE `inventory`.`idAircraft` = "+ textBoxID.Text +";";

                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close();
                MessageBox.Show("successfully updated");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "DELETE FROM `inventory` WHERE `inventory`.`idAircraft` = " + textBoxID.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close();
                MessageBox.Show("successfully deleted");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridInventory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridInventory.CurrentRow.Selected = true;

                textBoxAircraft.Text = dataGridInventory.Rows[e.RowIndex].Cells["colName"].FormattedValue.ToString();
                textBoxManufacturing.Text = dataGridInventory.Rows[e.RowIndex].Cells["colManufacturing"].FormattedValue.ToString();
                textBoxTurbulence.Text = dataGridInventory.Rows[e.RowIndex].Cells["colTurbulence"].FormattedValue.ToString();
                textBoxPassenger.Text = dataGridInventory.Rows[e.RowIndex].Cells["colPassenger"].FormattedValue.ToString();
                textBoxID.Text = dataGridInventory.Rows[e.RowIndex].Cells["colID"].FormattedValue.ToString();
            }
        }
    }
}
