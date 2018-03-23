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
using System.Data.Sql;
using System.IO;

namespace MissionPlanner.GCSViews
{
    public partial class Form_Add_drone_part : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=cs-rabbit;Initial Catalog=DroneFlightPlanner;Integrated Security=True");
        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        string imgLocation = "";
        SqlCommand cmd;
        private string id_drone;

        public Form_Add_drone_part()
        {
            InitializeComponent();

        }

        public Form_Add_drone_part(string id_drone)
        {
            this.id_drone = id_drone;
            InitializeComponent();
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

            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);
            MemoryStream memStream = new MemoryStream();
            byte[] imgBytes = memStream.GetBuffer();

            comboBox_alarm.SelectedItem.ToString();
            string format = "yyyy-MM-dd";

            String query = "INSERT INTO DeviceList (device_id,device_name,device_position,device_startDate,device_buyDate,device_expDate,vender_name,vender_add,vender_phone,device_responder,device_pic,device_alarm,device_price,drone_id) "
                                       + "VALUES('" + textBox_partID.Text + "','" + textBox_partName.Text + "','" + textBox_partPosition.Text + "','" + dateTimePicker_startDate.Value.ToString(format) + "','" + dateTimePicker_reg.Value.ToString(format) + "','" + dateTimePicker_ExpDate.Value.ToString(format) + "','" + textBox_VenName.Text + "','" + textBox_venAdd.Text + "','" + textBox_venPhone.Text + "','" + textBox_respond.Text + "',@images,'" + comboBox_alarm.SelectedItem.ToString() + "','" + textBox_price.Text + "','" + id_drone + "')";
            //SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            //SDA.SelectCommand.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.Parameters.Add("@Images", SqlDbType.Image, imgBytes.Length);
            cmd.Parameters["@Images"].Value = imgBytes;
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Save To DB Success!!");

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png file(*.png)|*.png|.jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox.ImageLocation = imgLocation;
            }
        }
    }
}
