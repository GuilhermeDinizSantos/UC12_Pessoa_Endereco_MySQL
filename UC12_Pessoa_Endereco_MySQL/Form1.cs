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
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_pessoa(nome, sobrenome, nome_social, rg, cpf, data_nasc, etnia, genero) VALUES ('" + textBoxNOME.Text + "', '" + textBoxSOBRENOME.Text + "', '" + textBoxNOMESOCIAL.Text + "', '" + textBoxRG.Text + "', '" + textBoxCPF.Text + "', '" + dateTimePickerNASCIMENTO.Text + "', '" + comboBoxETNIA.SelectedItem + "', '" + dataGridViewGENERO.ProductVersion + "');";
                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void groupBoxGENERO_Enter(object sender, EventArgs e)
        {

        }
    }
}
