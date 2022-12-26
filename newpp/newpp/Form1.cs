using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using newpp.chessclubDataSet1TableAdapters;

namespace newpp
{

    public partial class Form1 : Form
    {
    static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\\Users\\allan\\Documents\\chessclub.accdb");
    static OleDbCommand cmd = con.CreateCommand();
    static OleDbDataReader reader;
    int count = 0;
    
        public Form1()
        {

            InitializeComponent();
            this.chess1dbTableAdapter.Fill(this.chessclubDataSet.chess1db);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chessclubDataSet.chess1db' table. You can move, or remove it, as needed.
            this.chess1dbTableAdapter.Fill(this.chessclubDataSet.chess1db);
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            try
            { 
                con.Open();
                cmd.CommandText = "INSERT INTO chess1db( [names] , schoolid , major , gender)  VALUES ( '" + txtname.Text + "','" + int.Parse(txtid.Text) + "','" + txtmajor.Text + "','" + txtgndr.Text + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Submitted ");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            count = 0;

            con.Open();
            cmd.CommandText = "select * from chess1db";
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                nametxt.Text = reader.GetString(1);
                idtxt.Text = reader.GetValue(2).ToString();
                
            }
            reader.Close();
            con.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit?","Attention!",  MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK){
                this.Close();
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            con.Open();
            cmd.Connection=con;
            String query="SELECT * FROM chess1db";
            cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dataGridView1.DataSource = tb;
            con.Close();

        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;
            label12.Text = "Note: Press details to view";
            label12.BackColor=Color.White;
            label12.ForeColor = Color.Black;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (con.State.Equals(System.Data.ConnectionState.Open))
                con.Close();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from chess1db", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "chess1db");
            if (count < ds.Tables[0].Rows.Count)
            {
                nametxt.Text = ds.Tables[0].Rows[count]["names"].ToString();
                idtxt.Text = ds.Tables[0].Rows[count]["schoolid"].ToString();
                count++;
            }
            else
            {
                MessageBox.Show("End of file reached");
                count--;
            }
            con.Close();

        }

        private void btnprev_Click(object sender, EventArgs e)
        {
                if (con.State.Equals(System.Data.ConnectionState.Open))
                    con.Close();
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from chess1db", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "chess1db");
                if (count > -1)
                {
                    nametxt.Text = ds.Tables[0].Rows[count]["names"].ToString();
                    idtxt.Text = ds.Tables[0].Rows[count]["schoolid"].ToString();
                    count--;
                }
                else
                {
                    MessageBox.Show("Beginning of file reached");
                    count++;
                }
                con.Close();

        }

        private void btnassign_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            String quers= "UPDATE chess1db SET activity='" + txtactivity.Text +"' WHERE [names]='" + nametxt.Text + "'";
            cmd.CommandText = quers;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Submitted ");
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("You are about to remove a member", "Proceed?", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    con.Open();
                    cmd.Connection = con;
                    String del = "DELETE FROM chess1db WHERE [names]='" + nametxt.Text + "'";
                    cmd.CommandText = del;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member removed");
                    con.Close();
                }
            
        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            label12.BackColor=Color.Black;
            label12.ForeColor=Color.White;
            label12.Text = "!!Note!!\n**Do not use special characters in \n\t  the text fields,only names and \n\t  numbers  are allowed. Periods are\n  allowed\n**Use  numbers only in the School \n\t  ID field";
        }
    }
}
