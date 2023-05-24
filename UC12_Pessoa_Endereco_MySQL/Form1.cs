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

namespace UC12_Pessoa_Endereco_MySQL
{
    public partial class Form1 : Form
    {
        string ultimoID;
        string genero;
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public Form1()
        {
            InitializeComponent();
            //Uid:user id; Pwd: password;
            servidor = "Server=localhost;Database=pessoa_endereco;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            genero = "";
            atualizar_dataGRID();
        }
        private void atualizar_dataGRID()
        {
            //Atualizar a exibição dos dados em tabela
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT nome, cpf, logradouro, estado FROM tbl_endereco INNER JOIN tbl_pessoa ON (tbl_endereco.id = fk_endereco);";

                MySqlDataAdapter adaptadorPRODUTOS = new MySqlDataAdapter(comando);

                DataTable tabelaPRODUTOS = new DataTable();
                adaptadorPRODUTOS.Fill(tabelaPRODUTOS);

                dataGridViewPESSOA.DataSource = tabelaPRODUTOS;
                dataGridViewPESSOA.Columns["nome"].HeaderText = "Nome";
                dataGridViewPESSOA.Columns["cpf"].HeaderText = "CPF";
                dataGridViewPESSOA.Columns["logradouro"].HeaderText = "Logradouro";
                dataGridViewPESSOA.Columns["estado"].HeaderText = "Estado";
            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_endereco(logradouro, bairro, cidade, estado, uf) VALUES ('" + textBoxLOGRADOURO.Text + "', '" + textBoxBAIRRO.Text + "', '" + textBoxCIDADE.Text + "', '" + comboBoxESTADO.SelectedItem + "', '" + comboBoxUF.SelectedItem + "');";
                comando.ExecuteNonQuery();
            } 
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            } 
            finally
            {
                conexao.Close();
            }
            if (radioButtonMASCULINO.Checked)
            {
                genero = "Masculino";
            }
            if (radioButtonFEMININO.Checked)
            {
                genero = "Feminino";
            }
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT MAX(id) FROM tbl_endereco;";
                MySqlDataReader ReaderID = comando.ExecuteReader();

                if (ReaderID.Read())
                {
                    ultimoID = ReaderID.GetString(0);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_pessoa(nome, sobrenome, nome_social, rg, cpf, data_nasc, etnia, genero, fk_endereco) VALUES ('"+textBoxNOME.Text+"', '"+ textBoxSOBRENOME.Text + "', '"+textBoxNOMESOCIAL.Text+ "', '" + textBoxRG.Text + "', '" + textBoxCPF.Text + "', '" + dateTimePickerNASCIMENTO.Value.ToString("yyyy-MM-dd") + "', '" + comboBoxETNIA.Text + "', '" + genero + "', '"+ ultimoID +"');";
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
            atualizar_dataGRID();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
