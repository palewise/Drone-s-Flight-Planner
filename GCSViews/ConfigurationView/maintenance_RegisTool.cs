﻿using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using log4net;
using MissionPlanner.Controls;
using System.Data.SqlClient;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class maintenance_RegisTool : UserControl, IActivate
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly Dictionary<int, int> baudmap = new Dictionary<int, int>
        {
            {57600, 7},
            {38400, 6},
            {9600, 4},
            {19200, 5},
            {115200, 8},
            {1200, 1},
            {2400, 2},
            {4800, 3}
        };

        public maintenance_RegisTool()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            if (MainV2.comPort.BaseStream.IsOpen)
            {
                Enabled = false;
            }
            Enabled = true;
        }
        SqlConnection con = new SqlConnection("Data Source=NAPAT;Initial Catalog=MissionPlanner;Integrated Security=True");

        private void BUT_ConfigLogin_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_baud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConfigLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConfigLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void mavlinkComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox_toolName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO device_list (device_id,device_name,device_position,device_startDate,device_buyDate,device_expDate,vender_name,vender_add,vender_phone,vender_responder,device_img,device_alarm) VALUES('" +textBox_num.Text + "','" + textBox_toolName.Text+ "','" +textBox_position.Text + "','" +dateTimePicker_reg.Text + "','" +dateTimePicker_start .Text + "','" +dateTimePicker_exp .Text + "','" +textBox_venName.Text + "','" +textBox_venAdd .Text + "','" +textBox_venTel .Text + "','" + textBox_respon.Text + "','" +pictureBox .Image + "','" +comboBox_alarm .Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query,con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save To DB Success!!");
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}