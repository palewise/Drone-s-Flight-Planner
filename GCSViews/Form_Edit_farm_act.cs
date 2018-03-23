﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MissionPlanner.GCSViews
{
    public partial class Form_Edit_farm_act : Form
    {
        public Form_Edit_farm_act()
        {
            InitializeComponent();
            
        }

        public Form_Edit_farm_act(string id_farm)
        {
            this.id_farm = id_farm;
            InitializeComponent();
        }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        private string id_farm;

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

            String query2 = "UPDATE schedule_action SET action_no,action_name,action_capacity,action_cost) " 
                + "VALUES('" + textBox_actID.Text + "','" + textBox_actName.Text + "','" + textBox_cap.Text + "','" + textBox_cost.Text + "')";

            String query = "UPDATE FlightSchedule SET farm_id = '" + id_farm + "',drone_id = '" + textBox_droneID.Text + "',action_no = '" + textBox_actID.Text + "',schedule_date = '" + dateTimePicker.Value.ToString(format) + "') "
                + "VALUES(,,,)";

            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            SDA2.SelectCommand.ExecuteNonQuery();

            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Edit To DB Success!!");

            this.Close();
        }
    }
}
