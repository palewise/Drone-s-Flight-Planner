﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MissionPlanner.GCSViews
{
    public partial class Form_Add_drone_pre : Form
    {
        SqlConnection con = new SqlConnection("Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlCommand cmd;

        public Form_Add_drone_pre()
        {
            InitializeComponent();

            add_DG();

            void add_DG()
            {

            }
        }

        private void Main_but_farm_Click(object sender, EventArgs e)
        {

        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DG_Farm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel_Main_farm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void But_save_Click(object sender, EventArgs e)
        {
            con.Open();

            
            string format = "yyyy-MM-dd";

            String query = "INSERT INTO Maintainance (maintain_id,maintain_activity,maintain_price,maintain_venderName,maintain_vendorPhone,maintain_venderAdd,maintain_length,maintain_responder,maintain_date) "
                                       + "VALUES('" + textBox_id.Text + "','" + textBox_activity.Text + "','" + textBox_price.Text + "','" + textBox_venName.Text + "','" + textBox_venPhone.Text + "','" + textBox_venAdd.Text + "','" + textBox_time.Text + "','" + textBox_respond.Text + "','" + dateTimePicker.Value.ToString(format) + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save To DB Success!!");

            this.Close();
        }
    }
}
