using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FORMATION
{
    public partial class Delegation : Form
    {
        public Delegation()
        {
            InitializeComponent();
        }

        string str;
        SqlConnection cnx;

        private void Delegation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'fORMATIONDataSet1.academie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.academieTableAdapter1.Fill(this.fORMATIONDataSet1.academie);
            // TODO: cette ligne de code charge les données dans la table 'fORMATIONDataSet.academie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.academieTableAdapter.Fill(this.fORMATIONDataSet.academie);

            str = @"Data Source=DESKTOP-A7ECOHN\SQLEXPRESS;Initial Catalog=FORMATION;Integrated Security=True";
            cnx = new SqlConnection(str);



            //cnx.Open();
            //string AF = "select nomAcademie   from academie ";
            //SqlCommand cmd = new SqlCommand(AF, cnx);


            //SqlDataReader r = cmd.ExecuteReader();
            //while (r.Read())
            //{
            //    comboBox1.Items.Add(r[0]);
            //}
            //cnx.Close();
            //r.Close();

        }

        public int confirmation()
        {

            string AF = "select count(IdAcademi) from academie where IdAcademi= " + textBox1.Text + " ";
            SqlCommand cmd = new SqlCommand(AF, cnx);

            return (int)cmd.ExecuteScalar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Donner l'id");
            }
            else
            {
                cnx.Open();
                if (confirmation() == 0)
                {
                    string AJ = "insert into academie values (" + textBox1.Text + ",'" + textBox2.Text + "','" + comboBox1.SelectedValue + "')";
                    SqlCommand cmd = new SqlCommand(AJ, cnx);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajout bien fait !");
                }

                else
                {
                    MessageBox.Show("exist deja !!");
                }
                cnx.Close();
                //affichage();
            }
        }
    }
}
