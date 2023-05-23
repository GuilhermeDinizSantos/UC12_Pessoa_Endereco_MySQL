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
            servidor = "Server=localhost;Database=login_bd;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }
    }
}
