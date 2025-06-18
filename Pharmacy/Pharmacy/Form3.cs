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
using System.Xml.Linq;

namespace Pharmacy
{
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\PharmacyProj.mdf;Integrated Security=True;Connect Timeout=30";
        public Form3()
        {
            InitializeComponent();
        }
        Image[] imageaa = { Properties.Resources.panadol, Properties.Resources.cinapsin, Properties.Resources.infl, Properties.Resources.trah, Properties.Resources.efiz, Properties.Resources.aspirin
        ,Properties.Resources.exprs,Properties.Resources.stopkold,Properties.Resources.neo,Properties.Resources.novanight,
        Properties.Resources.kruvno1,Properties.Resources.kruvno2,Properties.Resources.kruvno3,Properties.Resources.kruvno4,Properties.Resources.kruvno5,};
        
        private void button5_Click(object sender, EventArgs e)
            
        {
            string name = textBox1.Text;
            string number = textBox2.Text;
            string adress = richTextBox1.Text;
            string product = comboBox1.Text;
           



            if (comboBox1.Text == "Panadol") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[0]; label8.Text = "5$"; }
            if (comboBox1.Text == "Cinabsin") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[1]; label8.Text = "4$"; }
            if (comboBox1.Text == "Influcid") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[2]; label8.Text = "4$"; }
            if (comboBox1.Text == "Trahisan") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[3]; label8.Text = "7$"; }
            if (comboBox1.Text == "Efizol") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[4]; label8.Text = "9$"; }
            if (comboBox1.Text == "Aspirin") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[5]; label8.Text = "6$"; }
            if (comboBox1.Text == "Nurofen") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[6]; label8.Text = "5.50$"; }
            if (comboBox1.Text == "Stopcold") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[7]; label8.Text = "5.50$"; }
            if (comboBox1.Text == "Neo Angin") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[8]; label8.Text = "3.50$"; }
            if (comboBox1.Text == "Night") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[9]; label8.Text = "5$"; }
            if (comboBox1.Text == "Avernol") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[10]; label8.Text = "13$"; }
            if (comboBox1.Text == "Amlovask") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[11]; label8.Text = "15$"; }
            if (comboBox1.Text == "Bizogamma") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[12]; label8.Text = "15$"; }
            if (comboBox1.Text == "Belipril") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[13]; label8.Text = "12$"; }
            if (comboBox1.Text == "Renovia") { pictureBox1.Visible = true; pictureBox1.Image = imageaa[14]; label8.Text = "17$"; }
            MessageBox.Show("Name:" + textBox1.Text + "\n" + "Phone number:" + textBox2.Text + "\n" + "Adress:" + richTextBox1.Text + "\n" + "Arrival date:" + dateTimePicker1.Text+"\n"+"Your product:"+comboBox1.Text+"\n"+"Price:"+label8.Text, "Info about order");

            SqlConnection conn = new SqlConnection(connectionString);
            {
                string query = "INSERT INTO Table_Pharma (Name,Number,Adress,Product) VALUES (@Name,@Number,@Adress,@Product)";
                SqlCommand cmd = new SqlCommand(query, conn);
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Number", number);
                    cmd.Parameters.AddWithValue("@Adress", adress);
                    cmd.Parameters.AddWithValue("@Product", product);
                   

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Данните са записани успешно!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Грешка " + ex.Message);

                    }

                }
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 ffrour=new Form4();
            ffrour.Show();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ftwo =new Form2();
            ftwo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 =new Form1();
            f1.Show();
            this.Close();
        }
    }

}

