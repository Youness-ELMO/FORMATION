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
    public partial class Professeur : Form
    {
        public Professeur()
        {
            InitializeComponent();
        }

        string str;
        SqlConnection cnx;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void affichage()
        {
            dataGridView1.Rows.Clear();

            cnx.Open();
            string AF = "select Idprofesseur , nomProfesseur ,Email ,Etatcivil ,nbrEnfants,nomLycee   from professeur join lycee on professeur.IdLycee = lycee.IdLycee ";
            SqlCommand cmd = new SqlCommand(AF, cnx);


            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                dataGridView1.Rows.Add(r[0], r[1], r[2], r[3], r[4],r[5]);
            }
            cnx.Close();
            r.Close();

            int a = dataGridView1.Rows.Count - 1;
            label5.Text = a.ToString();
        }

        public int confirmation()
        {

            string AF = "select count(Idprofesseur ) from professeur where Idprofesseur = " + textBox1.Text + " ";
            SqlCommand cmd = new SqlCommand(AF, cnx);

            return (int)cmd.ExecuteScalar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Donner l'id de professeur ");
            }
            else
            {
                cnx.Close();
                cnx.Open();
                
                if (confirmation() == 0)
                {
                    //string nb = "0";
                    //if(textBox4.Enabled == true)
                    //{
                    //    nb= textBox4.Text ;
                    //}
                    string AJ = "insert into professeur values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "',"+textBox4.Text+"," + comboBox2.SelectedValue + ")";
                    SqlCommand cmd = new SqlCommand(AJ, cnx);
                    MessageBox.Show(""+AJ);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajout bien fait !");
                }

                else
                {
                    MessageBox.Show("exist deja !!");
                }
                cnx.Close();
                affichage();
            }
        }

        private void Professeur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'fORMATIONDataSet2.lycee'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.lyceeTableAdapter.Fill(this.fORMATIONDataSet2.lycee);
            str = @"Data Source=DESKTOP-A7ECOHN\SQLEXPRESS;Initial Catalog=FORMATION;Integrated Security=True";
            cnx = new SqlConnection(str);


            dataGridView1.Columns.Add("Idprofesseur ", "Idprofesseur ");
            dataGridView1.Columns.Add("nomProfesseur ", "nomProfesseur ");
            dataGridView1.Columns.Add("Email  ", "Email  ");
            dataGridView1.Columns.Add("Etatcivil  ", "Etatcivil  ");
            dataGridView1.Columns.Add("nbrEnfants  ", "nbrEnfants  ");
            dataGridView1.Columns.Add("IdLycee  ", "IdLycee  ");

            textBox4.Enabled = false;

            affichage();



            //cnx.Open();
            //string AF = "select nomLycee  from lycee ";
            //SqlCommand cmd = new SqlCommand(AF, cnx);


            //SqlDataReader r = cmd.ExecuteReader();
            //while (r.Read())
            //{
            //    comboBox2.Items.Add(r[0]);
            //}
            //cnx.Close();
            //r.Close();

            DataTable tb = new DataTable();
            cnx.Open();
            string AF = "select IdLycee,nomLycee from lycee ";
            SqlCommand cmd = new SqlCommand(AF, cnx);

            SqlDataReader r = cmd.ExecuteReader();
            tb.Load(r);
            
         
            comboBox2.DataSource = null;
            comboBox2.DataSource = tb;
            comboBox2.DisplayMember = "nomLycee";
            comboBox2.ValueMember = "IdLycee";


            



            







            comboBox1.Items.Add("Marié");
            comboBox1.Items.Add("célibataire");
            comboBox1.Items.Add("divorcé");
            comboBox1.Items.Add("veuf");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Donner l'id");
            }
            else
            {
                cnx.Open();
                if (confirmation() != 0)
                {
                    string S = "delete professeur  where Idprofesseur = " + textBox1.Text + "";
                    SqlCommand cmd = new SqlCommand(S, cnx);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression bien fait !");
                }

                else
                {
                    MessageBox.Show("n'existe pas");
                }
                cnx.Close();
                affichage();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Donner l'id");
            }
            else
            {
                cnx.Open();
                if (confirmation() != 0)
                {
                    string M = "update professeur set nomProfesseur  = '" + textBox2.Text + "',Email ='" + textBox3.Text + "',Etatcivil ='" + comboBox1.Text + "',nbrEnfants =" + textBox4.Text + ",IdLycee ='" + comboBox2.SelectedValue + "' where Idprofesseur = " + textBox1.Text + "";
                    SqlCommand cmd = new SqlCommand(M, cnx);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification bien fait !");
                }

                else
                {
                    MessageBox.Show("n'existe pas");
                }
                cnx.Close();
                affichage();

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "célibataire")
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
            else
            {
                textBox4.Enabled = true;
            }
        }
        static int pos;
        public void navigation()
        {
            textBox1.Text = dataGridView1.Rows[pos].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[pos].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[pos].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[pos].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[pos].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[pos].Cells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox2.ResetText();
            comboBox1.ResetText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pos = 0;
            navigation();
            label4.Text = pos + 1.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pos = dataGridView1.Rows.Count - 2;
            navigation();

            label4.Text = (pos + 1).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                pos--;
                navigation();
                label4.Text = (pos + 1).ToString();

            }
            catch
            {
                MessageBox.Show("fin !!!");
                pos++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                pos++;
                navigation();
                label4.Text = (pos + 1).ToString();

            }
            catch
            {
                MessageBox.Show("fin !!!");
                pos--;
            }
        }
    }
}
