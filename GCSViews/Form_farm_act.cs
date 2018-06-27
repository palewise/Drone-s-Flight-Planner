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
using Dapper;

namespace MissionPlanner.GCSViews
{
    public partial class Form_farm_act : Form
    {
        public Form_farm_act()
        {
            InitializeComponent();
        }
        
        public Form_farm_act(string id_farm)
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
        
        private void DG_Farm_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {   
            
        }

        private void But_add_act_Click(object sender, EventArgs e)
        { 
            // pass to add act
            Form_Add_farm_act form_Add_Farm_Act = new Form_Add_farm_act();
            form_Add_Farm_Act.ShowDialog();
        }

        private void panelFarm_Act_Paint(object sender, PaintEventArgs e)
        {
            //show data to DataGridView
            con.Open();
            string format = "yyyy-MM-dd";
            //string dateNow = String.Format("{0:yyyy-MM-dd}", DateTime.Now);

            String query = "SELECT * FROM AfterFlight WHERE farm_id = '" + id_farm + "' ";

            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            DG_afterFlight.DataSource = dt;
            con.Close();
        }

        private void Form_farm_act_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'droneFlightPlannerDataSet7.AfterFlight' table. You can move, or remove it, as needed.
            this.afterFlightTableAdapter.Fill(this.droneFlightPlannerDataSet7.AfterFlight);
            // TODO: This line of code loads data into the 'activitySchedule.FlightSchedule' table. You can move, or remove it, as needed.
            //this.flightScheduleTableAdapter1.Fill(this.activitySchedule.FlightSchedule);
            // TODO: This line of code loads data into the 'flightSchedule.FlightSchedule' table. You can move, or remove it, as needed.
            //this.flightScheduleTableAdapter.Fill(this.flightSchedule.FlightSchedule);
            // TODO: This line of code loads data into the 'droneFlightPlannerDataSet1.schedule_action' table. You can move, or remove it, as needed.
            //this.schedule_actionTableAdapter.Fill(this.droneFlightPlannerDataSet1.schedule_action);

        }

        //private void button_delete_Click(object sender, EventArgs e)
        //{
        //    // delete
        //    if (MessageBox.Show("Are you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        con.Open();
        //        string query = "DELETE FROM FlightSchedule where action_id = '" + textBox_actID.Text + "' ";
        //        SqlDataAdapter SDA = new SqlDataAdapter(query, con);
        //        SDA.SelectCommand.ExecuteNonQuery();
        //        con.Close();
        //        MessageBox.Show("DELETE Record From DB Success!!");
        //    }

        //}

        private void button_edit_Click(object sender, EventArgs e)
        {
            // pass to edit act
            Form_Edit_farm_act form_edit_farm_act = new Form_Edit_farm_act(id_farm);
            form_edit_farm_act.ShowDialog();

        }

        private void Form_farm_act_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessDialogKey(e.KeyData);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void textBox_cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_show_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString)) // if napat change cn to cn1
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                //Execute query to get data from farm_act data
                string format = "yyyy-MM-dd";
                String query = "SELECT * FROM AfterFlight WHERE farm_id = '" + id_farm + "' AND af_datetime between '{dateTimePicker_startDate.Value.ToString(format)}'  and '{dateTimePicker_stopDate.Value.ToString(format)}'   ";

                f
                afterFlightBindingSource.DataSource = db.Query<Farm_act>(query, commandType: CommandType.Text);
            }          

        }

        private void button_print_Click(object sender, EventArgs e)
        {
            Farm_Act obj = afterFlightBindingSource.Current as Farm_act;
            if (obj != null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    //Execute query to get Farm data
                    string format = "yyyy-MM-dd";
                    String query = "SELECT * FROM Farm WHERE farm_id = '" + id_farm + "' ";
                    List<Farm> list = db.Query<Farm>(query, commandType: CommandType.Text).ToList();
                    using (frmPrint frm = new frmPrint(obj, list))
                    {
                        frm.ShowDialog();
                    }
                }
            }
        }
    }
}
