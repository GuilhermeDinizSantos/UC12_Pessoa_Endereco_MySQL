﻿using System;
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

        string id_pessoa = "";
        string id_endereco = "";

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
                comando.CommandText = "SELECT * FROM tbl_endereco INNER JOIN tbl_pessoa ON (tbl_endereco.id = fk_endereco);";

                MySqlDataAdapter adaptadorPRODUTOS = new MySqlDataAdapter(comando);

                DataTable tabelaPRODUTOS = new DataTable();
                adaptadorPRODUTOS.Fill(tabelaPRODUTOS);

                dataGridViewPESSOA.DataSource = tabelaPRODUTOS;
                dataGridViewPESSOA.Columns["id"].HeaderText = "ID";
                dataGridViewPESSOA.Columns["id"].HeaderText = "ID";
                dataGridViewPESSOA.Columns["nome"].HeaderText = "Nome";
                dataGridViewPESSOA.Columns["cpf"].HeaderText = "CPF";
                dataGridViewPESSOA.Columns["logradouro"].HeaderText = "Logradouro";
                dataGridViewPESSOA.Columns["estado"].HeaderText = "Estado";
                dataGridViewPESSOA.Columns["nome_social"].HeaderText = "Nome Social";
                dataGridViewPESSOA.Columns["rg"].HeaderText = "RG";
                dataGridViewPESSOA.Columns["data_nasc"].HeaderText = "Data de Nascimento";
                dataGridViewPESSOA.Columns["etnia"].HeaderText = "Etnia";
                dataGridViewPESSOA.Columns["genero"].HeaderText = "Gênero";
                dataGridViewPESSOA.Columns["bairro"].HeaderText = "Bairro";
                dataGridViewPESSOA.Columns["cidade"].HeaderText = "Cidade";
                dataGridViewPESSOA.Columns["uf"].HeaderText = "UF";
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

        private void dataGridViewPESSOA_MouseClick(object sender, MouseEventArgs e)
        {
            id_endereco = dataGridViewPESSOA.CurrentRow.Cells[0].Value.ToString();
            textBoxLOGRADOURO.Text = dataGridViewPESSOA.CurrentRow.Cells[1].Value.ToString();
            textBoxBAIRRO.Text = dataGridViewPESSOA.CurrentRow.Cells[2].Value.ToString();
            textBoxCIDADE.Text = dataGridViewPESSOA.CurrentRow.Cells[3].Value.ToString();
            comboBoxESTADO.Text = dataGridViewPESSOA.CurrentRow.Cells[4].Value.ToString();
            comboBoxUF.Text = dataGridViewPESSOA.CurrentRow.Cells[5].Value.ToString();
            id_pessoa = dataGridViewPESSOA.CurrentRow.Cells[6].Value.ToString();
            textBoxNOME.Text = dataGridViewPESSOA.CurrentRow.Cells[7].Value.ToString();
            textBoxSOBRENOME.Text = dataGridViewPESSOA.CurrentRow.Cells[8].Value.ToString();
            textBoxNOMESOCIAL.Text = dataGridViewPESSOA.CurrentRow.Cells[9].Value.ToString();
            textBoxRG.Text = dataGridViewPESSOA.CurrentRow.Cells[10].Value.ToString();
            textBoxCPF.Text = dataGridViewPESSOA.CurrentRow.Cells[11].Value.ToString();
            dateTimePickerNASCIMENTO.Text = dataGridViewPESSOA.CurrentRow.Cells[12].Value.ToString();
            comboBoxETNIA.Text = dataGridViewPESSOA.CurrentRow.Cells[13].Value.ToString();


            if (dataGridViewPESSOA.CurrentRow.Cells[14].Value.ToString() == "Masculino")
            {
                radioButtonMASCULINO.Checked = true;

            }
            if (dataGridViewPESSOA.CurrentRow.Cells[14].Value.ToString() == "Feminino")
            {
                radioButtonFEMININO.Checked = true;
            }
        }

        private void radioButtonMASCULINO_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMASCULINO.Checked)
            {
                genero = "Masculino";
            }
        }

        private void radioButtonFEMININO_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFEMININO.Checked)
            {
                genero = "Feminino";
            }
        }

        private void buttonEXCLUIR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "DELETE FROM tbl_pessoa WHERE id = " + id_pessoa + ";";
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
            atualizar_dataGRID();
        }

        private void buttonALTERAR_Click(object sender, EventArgs e)
        {
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
                comando.CommandText = "UPDATE tbl_pessoa SET nome = '" + textBoxNOME.Text + "', sobrenome = '" + textBoxSOBRENOME.Text + "', nome_social = '" + textBoxNOMESOCIAL.Text + "', rg = '" + textBoxRG.Text + "', cpf = '" + textBoxCPF.Text + "', data_nasc = '" + dateTimePickerNASCIMENTO.Value.ToString("yyyy-MM-dd") + "', etnia = '" + comboBoxETNIA.Text + "', genero = '" + genero + "' WHERE tbl_pessoa.id = " + id_pessoa + ";";
                comando.ExecuteNonQuery();
            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE tbl_endereco SET logradouro = '" + textBoxLOGRADOURO.Text + "', bairro = '" + textBoxBAIRRO.Text + "', cidade = '" + textBoxCIDADE.Text + "', estado = '" + comboBoxESTADO.Text + "', uf = '" + comboBoxUF.Text + "' WHERE tbl_endereco.id = " + id_endereco + ";"; 
                comando.ExecuteNonQuery();
            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
            atualizar_dataGRID();
        }
    }
}


