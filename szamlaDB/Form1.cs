using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace szamlaDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=szamlak;port=3306;password=");
        #region db_stuff
        public void DBHandler(MySqlConnection connection, string command, Action<MySqlCommand> Method)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(command, connection);
                Method(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void UpdateList(MySqlCommand cmd)
        {
            MySqlDataReader dr = cmd.ExecuteReader();
            szamlaList.Items.Clear();
            while (dr.Read())
            {
                szamlak szamla = new szamlak(dr.GetInt32("id"), dr.GetString("tulajdonosNeve"), dr.GetDecimal("egyenleg"), dr.GetMySqlDateTime("nyitasdatum"));
                szamlaList.Items.Add(szamla);
            }
        }

        public void SQLUpload(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@tulajdonosNeve", nameCont.Text);
            cmd.Parameters.AddWithValue("@egyenleg", egysegarCont.Text);
            cmd.Parameters.AddWithValue("@nyitasdatum", nyitasPicker.Value);
            cmd.ExecuteNonQuery();
        }

        public void SQLDelete(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@id", idCont.Text);
            cmd.ExecuteNonQuery();
        }

        public void Fill(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@tulajdonosNeve", szamlaList.Text.Split(':')[0]);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            idCont.Value = dr.GetInt32("id");
            nameCont.Text = dr.GetString("tulajdonosNeve");
            egysegarCont.Text = dr.GetDecimal("egyenleg").ToString();
            nyitasPicker.Value = dr.GetMySqlDateTime("nyitasdatum").GetDateTime();
        }

        public void SQLModify(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@tulajdonosNeve", nameCont.Text);
            cmd.Parameters.AddWithValue("@egyenleg", egysegarCont.Text);
            cmd.Parameters.AddWithValue("@nyitasdatum", nyitasPicker.Value);
            cmd.Parameters.AddWithValue("@id", idCont.Value);
            cmd.ExecuteNonQuery();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            DBHandler(conn, "SELECT * FROM szamlak", UpdateList);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            DBHandler(conn, "INSERT INTO szamlak (id, tulajdonosNeve, egyenleg, nyitasdatum) VALUES (NULL, @tulajdonosNeve, @egyenleg, @nyitasdatum)", SQLUpload);
            DBHandler(conn, "SELECT * FROM szamlak", UpdateList);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DBHandler(conn, "DELETE FROM szamlak WHERE id = @id", SQLDelete);
            DBHandler(conn, "SELECT * FROM szamlak", UpdateList);
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            DBHandler(conn, "UPDATE szamlak SET tulajdonosNeve = @tulajdonosNeve, egyenleg = @egyenleg, nyitasdatum = @nyitasdatum WHERE szamlak.id = @id", SQLModify);
            DBHandler(conn, "SELECT * FROM szamlak", UpdateList);
        }

        private void szamlaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBHandler(conn, "SELECT * FROM szamlak WHERE tulajdonosNeve = @tulajdonosNeve", Fill);
        }
    }
}
