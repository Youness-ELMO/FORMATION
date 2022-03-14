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
    public partial class Academie : Form
    {
        public Academie()
        {
            InitializeComponent();
        }

        string str;
        SqlConnection cnx;
        private void Academie_Load(object sender, EventArgs e)
        {
            str = @"Data Source=DESKTOP-A7ECOHN\SQLEXPRESS;Initial Catalog=FORMATION;Integrated Security=True";
            cnx = new SqlConnection(str);


            dataGridView1.Columns.Add("IdAcademi", "IdAcademi");
            dataGridView1.Columns.Add("nomAcademie", "nomAcademie");


           

            affichage();

            
            
        }

        public int confirmation()
        {
            
            string AF = "select count(IdAcademi) from academie where IdAcademi= " + textBox1.Text + " ";
            SqlCommand cmd = new SqlCommand(AF, cnx);

            return (int)cmd.ExecuteScalar();
        }
        public void affichage()
        {
            dataGridView1.Rows.Clear();

            cnx.Open();
            string AF = "select * from academie ";
            SqlCommand cmd = new SqlCommand(AF, cnx);
           

            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                dataGridView1.Rows.Add(r[0],r[1]);
            }
            cnx.Close();
            r.Close();

            int a = dataGridView1.Rows.Count- 1;
            label5.Text = a.ToString();
        }


        public static int pos;
        public void navigation()
        {
            textBox1.Text = dataGridView1.Rows[pos].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[pos].Cells[1].Value.ToString();
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
                    string AJ = "insert into academie values (" + textBox1.Text + ",'" + textBox2.Text + "')";
                    SqlCommand cmd = new SqlCommand(AJ, cnx);
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
                    string M = "update academie set nomAcademie = '" + textBox2.Text + "' where IdAcademi= " + textBox1.Text + "";
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
                    string S = "delete academie  where IdAcademi= " + textBox1.Text + "";
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            
                pos = 0;
                navigation();
            label4.Text = pos + 1.ToString();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                pos++;
                navigation();
                label4.Text = (pos+1) .ToString();

            }
            catch
            {
                MessageBox.Show("fin !!!");
                pos--;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //pos++;
            //if (pos == dataGridView1.Rows.Count - 1)
            //{
            //    pos = pos - 1;
            //    MessageBox.Show("vous etes sur le dernier enregistrement ");
            //}
            //naviguer();
            try
            {
                pos--;
                navigation();
                label4.Text = (pos+1) .ToString();

            }
            catch { MessageBox.Show("fin !!!");
                pos++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
                pos = dataGridView1.Rows.Count - 2;
                navigation();

                label4.Text = (pos+1) .ToString();
                

        }
    }
}
