﻿using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews
{
    partial class FlightPlanner
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            if (currentMarker != null)
                currentMarker.Dispose();
            if (drawnpolygon != null)
                drawnpolygon.Dispose();
            if (kmlpolygonsoverlay != null)
                kmlpolygonsoverlay.Dispose();
            if (wppolygon != null)
                wppolygon.Dispose();
            if (top != null)
                top.Dispose();
            if (geofencepolygon != null)
                geofencepolygon.Dispose();
            if (geofenceoverlay != null)
                geofenceoverlay.Dispose();
            if (drawnpolygonsoverlay != null)
                drawnpolygonsoverlay.Dispose();
            if (center != null)
                center.Dispose();

            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightPlanner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CHK_verifyheight = new System.Windows.Forms.CheckBox();
            this.TXT_WPRad = new System.Windows.Forms.TextBox();
            this.TXT_DefaultAlt = new System.Windows.Forms.TextBox();
            this.LBL_WPRad = new System.Windows.Forms.Label();
            this.LBL_defalutalt = new System.Windows.Forms.Label();
            this.TXT_loiterrad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BUT_write = new MissionPlanner.Controls.MyButton();
            this.BUT_read = new MissionPlanner.Controls.MyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TXT_homealt = new System.Windows.Forms.TextBox();
            this.TXT_homelng = new System.Windows.Forms.TextBox();
            this.TXT_homelat = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_status = new System.Windows.Forms.Label();
            this.panelWaypoints = new BSE.Windows.Forms.Panel();
            this.splitter1 = new BSE.Windows.Forms.Splitter();
            this.panel9 = new System.Windows.Forms.Panel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripConnectionControl1 = new MissionPlanner.Controls.ToolStripConnectionControl();
            this.button_log = new MissionPlanner.Controls.MyButton();
            this.MenuConnect = new MissionPlanner.Controls.MyButton();
            this.menuTakeoff = new MissionPlanner.Controls.MyButton();
            this.MenuSimulation = new MissionPlanner.Controls.MyButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_grid = new System.Windows.Forms.CheckBox();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.lnk_kml = new System.Windows.Forms.LinkLabel();
            this.CMB_altmode = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_wpfile = new System.Windows.Forms.Label();
            this.BUT_loadwpfile = new MissionPlanner.Controls.MyButton();
            this.BUT_saveWPFile = new MissionPlanner.Controls.MyButton();
            this.BUT_Add = new MissionPlanner.Controls.MyButton();
            this.Commands = new MissionPlanner.Controls.MyDataGridView();
            this.Command = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Param1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordEasting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordNorthing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MGRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Up = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHK_splinedefault = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_altwarn = new System.Windows.Forms.TextBox();
            this.splitter2 = new BSE.Windows.Forms.Splitter();
            this.panelMap = new System.Windows.Forms.Panel();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.lbl_homedist = new System.Windows.Forms.Label();
            this.lbl_prevdist = new System.Windows.Forms.Label();
            this.MainMap = new MissionPlanner.Controls.myGMAP();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertWpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertSplineWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiterForeverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loitertimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loitercirclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpstartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpwPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolygonPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRallyPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.geoFenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.GeoFenceuploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeoFencedownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setReturnLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createWpCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSplineCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCircleSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surveyGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefetchWPPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMLOverlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevationGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseWPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileLoadSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAndAppendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSHPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poiaddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poideleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poieditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackerHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterUTMCoordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchDockingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.flightPattern = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new MissionPlanner.Controls.MyTrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.panelBASE = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_Main_farm = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.DG_Drone = new MissionPlanner.Controls.MyDataGridView();
            this.droneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dronenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.droneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drone1 = new MissionPlanner.Drone1();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DG_Farm = new MissionPlanner.Controls.MyDataGridView();
            this.farmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.farmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farm1 = new MissionPlanner.farm1();
            this.textBox_droneID = new System.Windows.Forms.TextBox();
            this.textBox_farmID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lineSeparator2 = new MissionPlanner.Controls.LineSeparator();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Main_but_farm = new System.Windows.Forms.Button();
            this.panelAction = new BSE.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.dEVICE_LIST = new MissionPlanner.DEVICE_LIST();
            this.deviceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceListTableAdapter = new MissionPlanner.DEVICE_LISTTableAdapters.DeviceListTableAdapter();
            this.droneTableAdapter = new MissionPlanner.Drone1TableAdapters.DroneTableAdapter();
            this.farmTableAdapter = new MissionPlanner.farm1TableAdapters.FarmTableAdapter();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelWaypoints.SuspendLayout();
            this.panel9.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).BeginInit();
            this.panelMap.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelBASE.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_Main_farm.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Drone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drone1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farm1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICE_LIST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CHK_verifyheight
            // 
            resources.ApplyResources(this.CHK_verifyheight, "CHK_verifyheight");
            this.CHK_verifyheight.Name = "CHK_verifyheight";
            this.CHK_verifyheight.UseVisualStyleBackColor = true;
            // 
            // TXT_WPRad
            // 
            resources.ApplyResources(this.TXT_WPRad, "TXT_WPRad");
            this.TXT_WPRad.Name = "TXT_WPRad";
            this.TXT_WPRad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_WPRad_KeyPress);
            this.TXT_WPRad.Leave += new System.EventHandler(this.TXT_WPRad_Leave);
            // 
            // TXT_DefaultAlt
            // 
            resources.ApplyResources(this.TXT_DefaultAlt, "TXT_DefaultAlt");
            this.TXT_DefaultAlt.Name = "TXT_DefaultAlt";
            this.TXT_DefaultAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_DefaultAlt_KeyPress);
            this.TXT_DefaultAlt.Leave += new System.EventHandler(this.TXT_DefaultAlt_Leave);
            // 
            // LBL_WPRad
            // 
            resources.ApplyResources(this.LBL_WPRad, "LBL_WPRad");
            this.LBL_WPRad.Name = "LBL_WPRad";
            // 
            // LBL_defalutalt
            // 
            resources.ApplyResources(this.LBL_defalutalt, "LBL_defalutalt");
            this.LBL_defalutalt.Name = "LBL_defalutalt";
            // 
            // TXT_loiterrad
            // 
            resources.ApplyResources(this.TXT_loiterrad, "TXT_loiterrad");
            this.TXT_loiterrad.Name = "TXT_loiterrad";
            this.TXT_loiterrad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_loiterrad_KeyPress);
            this.TXT_loiterrad.Leave += new System.EventHandler(this.TXT_loiterrad_Leave);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BUT_write);
            this.panel5.Controls.Add(this.BUT_read);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // BUT_write
            // 
            this.BUT_write.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.BUT_write.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.BUT_write.ColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            resources.ApplyResources(this.BUT_write, "BUT_write");
            this.BUT_write.Name = "BUT_write";
            this.BUT_write.UseVisualStyleBackColor = true;
            this.BUT_write.Click += new System.EventHandler(this.BUT_write_Click);
            // 
            // BUT_read
            // 
            this.BUT_read.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.BUT_read.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.BUT_read.ColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            resources.ApplyResources(this.BUT_read, "BUT_read");
            this.BUT_read.Name = "BUT_read";
            this.BUT_read.UseVisualStyleBackColor = true;
            this.BUT_read.Click += new System.EventHandler(this.BUT_read_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.TXT_homealt);
            this.panel1.Controls.Add(this.TXT_homelng);
            this.panel1.Controls.Add(this.TXT_homelat);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.TabStop = true;
            this.label4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label4_LinkClicked);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // TXT_homealt
            // 
            resources.ApplyResources(this.TXT_homealt, "TXT_homealt");
            this.TXT_homealt.Name = "TXT_homealt";
            this.TXT_homealt.TextChanged += new System.EventHandler(this.TXT_homealt_TextChanged);
            // 
            // TXT_homelng
            // 
            resources.ApplyResources(this.TXT_homelng, "TXT_homelng");
            this.TXT_homelng.Name = "TXT_homelng";
            this.TXT_homelng.TextChanged += new System.EventHandler(this.TXT_homelng_TextChanged);
            // 
            // TXT_homelat
            // 
            resources.ApplyResources(this.TXT_homelat, "TXT_homelat");
            this.TXT_homelat.Name = "TXT_homelat";
            this.TXT_homelat.TextChanged += new System.EventHandler(this.TXT_homelat_TextChanged);
            this.TXT_homelat.Enter += new System.EventHandler(this.TXT_homelat_Enter);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // lbl_status
            // 
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.Name = "lbl_status";
            // 
            // panelWaypoints
            // 
            this.panelWaypoints.AssociatedSplitter = this.splitter1;
            this.panelWaypoints.BackColor = System.Drawing.Color.Transparent;
            this.panelWaypoints.CaptionFont = new System.Drawing.Font("PJ Standard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelWaypoints.CaptionHeight = 21;
            this.panelWaypoints.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.panelWaypoints.Controls.Add(this.panel9);
            this.panelWaypoints.Controls.Add(this.button_log);
            this.panelWaypoints.Controls.Add(this.MenuConnect);
            this.panelWaypoints.Controls.Add(this.menuTakeoff);
            this.panelWaypoints.Controls.Add(this.MenuSimulation);
            this.panelWaypoints.Controls.Add(this.panel1);
            this.panelWaypoints.Controls.Add(this.panel5);
            this.panelWaypoints.Controls.Add(this.panel3);
            this.panelWaypoints.Controls.Add(this.CMB_altmode);
            this.panelWaypoints.Controls.Add(this.panel2);
            this.panelWaypoints.Controls.Add(this.BUT_Add);
            this.panelWaypoints.Controls.Add(this.TXT_WPRad);
            this.panelWaypoints.Controls.Add(this.Commands);
            this.panelWaypoints.Controls.Add(this.CHK_splinedefault);
            this.panelWaypoints.Controls.Add(this.label5);
            this.panelWaypoints.Controls.Add(this.CHK_verifyheight);
            this.panelWaypoints.Controls.Add(this.TXT_loiterrad);
            this.panelWaypoints.Controls.Add(this.label17);
            this.panelWaypoints.Controls.Add(this.LBL_WPRad);
            this.panelWaypoints.Controls.Add(this.TXT_DefaultAlt);
            this.panelWaypoints.Controls.Add(this.LBL_defalutalt);
            this.panelWaypoints.Controls.Add(this.TXT_altwarn);
            this.panelWaypoints.CustomColors.BorderColor = System.Drawing.Color.DarkGreen;
            this.panelWaypoints.CustomColors.CaptionCloseIcon = System.Drawing.Color.White;
            this.panelWaypoints.CustomColors.CaptionExpandIcon = System.Drawing.Color.White;
            this.panelWaypoints.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(210)))), ((int)(((byte)(70)))));
            this.panelWaypoints.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(210)))), ((int)(((byte)(70)))));
            this.panelWaypoints.CustomColors.CaptionGradientMiddle = System.Drawing.Color.Transparent;
            this.panelWaypoints.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.Transparent;
            this.panelWaypoints.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.Transparent;
            this.panelWaypoints.CustomColors.CaptionText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.panelWaypoints.CustomColors.CollapsedCaptionText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.panelWaypoints.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelWaypoints.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelWaypoints.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.panelWaypoints, "panelWaypoints");
            this.panelWaypoints.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelWaypoints.Image = null;
            this.panelWaypoints.Name = "panelWaypoints";
            this.panelWaypoints.ShowExpandIcon = true;
            this.panelWaypoints.ToolTipTextCloseIcon = null;
            this.panelWaypoints.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelWaypoints.ToolTipTextExpandIconPanelExpanded = null;
            this.panelWaypoints.CloseClick += new System.EventHandler<System.EventArgs>(this.panelWaypoints_CloseClick);
            this.panelWaypoints.ExpandClick += new System.EventHandler<System.EventArgs>(this.panelWaypoints_ExpandClick);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.MainMenu);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // MainMenu
            // 
            this.MainMenu.BackgroundImage = global::MissionPlanner.Properties.Resources.bgdark;
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripConnectionControl1});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.ShowItemToolTips = true;
            this.MainMenu.Stretch = false;
            // 
            // toolStripConnectionControl1
            // 
            this.toolStripConnectionControl1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripConnectionControl1.BackgroundImage = global::MissionPlanner.Properties.Resources.bgdark;
            this.toolStripConnectionControl1.ForeColor = System.Drawing.Color.Black;
            this.toolStripConnectionControl1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripConnectionControl1.Name = "toolStripConnectionControl1";
            resources.ApplyResources(this.toolStripConnectionControl1, "toolStripConnectionControl1");
            this.toolStripConnectionControl1.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // button_log
            // 
            resources.ApplyResources(this.button_log, "button_log");
            this.button_log.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.button_log.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.button_log.ColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            this.button_log.Name = "button_log";
            this.toolTip1.SetToolTip(this.button_log, resources.GetString("button_log.ToolTip"));
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // MenuConnect
            // 
            resources.ApplyResources(this.MenuConnect, "MenuConnect");
            this.MenuConnect.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.MenuConnect.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.MenuConnect.ColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            this.MenuConnect.Name = "MenuConnect";
            this.toolTip1.SetToolTip(this.MenuConnect, resources.GetString("MenuConnect.ToolTip"));
            this.MenuConnect.UseVisualStyleBackColor = true;
            this.MenuConnect.Click += new System.EventHandler(this.MenuConnect_Click);
            // 
            // menuTakeoff
            // 
            resources.ApplyResources(this.menuTakeoff, "menuTakeoff");
            this.menuTakeoff.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.menuTakeoff.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.menuTakeoff.ColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            this.menuTakeoff.Name = "menuTakeoff";
            this.toolTip1.SetToolTip(this.menuTakeoff, resources.GetString("menuTakeoff.ToolTip"));
            this.menuTakeoff.UseVisualStyleBackColor = true;
            this.menuTakeoff.Click += new System.EventHandler(this.menuTakeoff_Click);
            // 
            // MenuSimulation
            // 
            resources.ApplyResources(this.MenuSimulation, "MenuSimulation");
            this.MenuSimulation.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.MenuSimulation.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.MenuSimulation.ColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            this.MenuSimulation.Name = "MenuSimulation";
            this.toolTip1.SetToolTip(this.MenuSimulation, resources.GetString("MenuSimulation.ToolTip"));
            this.MenuSimulation.UseVisualStyleBackColor = true;
            this.MenuSimulation.Click += new System.EventHandler(this.MenuSimulation_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chk_grid);
            this.panel3.Controls.Add(this.lbl_status);
            this.panel3.Controls.Add(this.comboBoxMapType);
            this.panel3.Controls.Add(this.lnk_kml);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // chk_grid
            // 
            resources.ApplyResources(this.chk_grid, "chk_grid");
            this.chk_grid.Name = "chk_grid";
            this.chk_grid.UseVisualStyleBackColor = true;
            this.chk_grid.CheckedChanged += new System.EventHandler(this.chk_grid_CheckedChanged);
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMapType.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxMapType, "comboBoxMapType");
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.toolTip1.SetToolTip(this.comboBoxMapType, resources.GetString("comboBoxMapType.ToolTip"));
            // 
            // lnk_kml
            // 
            resources.ApplyResources(this.lnk_kml, "lnk_kml");
            this.lnk_kml.Name = "lnk_kml";
            this.lnk_kml.TabStop = true;
            this.lnk_kml.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_kml_LinkClicked);
            // 
            // CMB_altmode
            // 
            this.CMB_altmode.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_altmode, "CMB_altmode");
            this.CMB_altmode.Name = "CMB_altmode";
            this.CMB_altmode.SelectedIndexChanged += new System.EventHandler(this.CMB_altmode_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_wpfile);
            this.panel2.Controls.Add(this.BUT_loadwpfile);
            this.panel2.Controls.Add(this.BUT_saveWPFile);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbl_wpfile
            // 
            resources.ApplyResources(this.lbl_wpfile, "lbl_wpfile");
            this.lbl_wpfile.Name = "lbl_wpfile";
            // 
            // BUT_loadwpfile
            // 
            this.BUT_loadwpfile.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.BUT_loadwpfile.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.BUT_loadwpfile.ColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            resources.ApplyResources(this.BUT_loadwpfile, "BUT_loadwpfile");
            this.BUT_loadwpfile.Name = "BUT_loadwpfile";
            this.BUT_loadwpfile.UseVisualStyleBackColor = true;
            this.BUT_loadwpfile.Click += new System.EventHandler(this.BUT_loadwpfile_Click);
            // 
            // BUT_saveWPFile
            // 
            this.BUT_saveWPFile.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.BUT_saveWPFile.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.BUT_saveWPFile.ColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            resources.ApplyResources(this.BUT_saveWPFile, "BUT_saveWPFile");
            this.BUT_saveWPFile.Name = "BUT_saveWPFile";
            this.BUT_saveWPFile.UseVisualStyleBackColor = true;
            this.BUT_saveWPFile.Click += new System.EventHandler(this.BUT_saveWPFile_Click);
            // 
            // BUT_Add
            // 
            this.BUT_Add.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.BUT_Add.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.BUT_Add.ColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            resources.ApplyResources(this.BUT_Add, "BUT_Add");
            this.BUT_Add.Name = "BUT_Add";
            this.toolTip1.SetToolTip(this.BUT_Add, resources.GetString("BUT_Add.ToolTip"));
            this.BUT_Add.UseVisualStyleBackColor = true;
            this.BUT_Add.Click += new System.EventHandler(this.BUT_Add_Click);
            // 
            // Commands
            // 
            this.Commands.AllowUserToAddRows = false;
            resources.ApplyResources(this.Commands, "Commands");
            this.Commands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.Commands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Command,
            this.Param1,
            this.Param2,
            this.Param3,
            this.Param4,
            this.Lat,
            this.Lon,
            this.Alt,
            this.coordZone,
            this.coordEasting,
            this.coordNorthing,
            this.MGRS,
            this.Delete,
            this.Up,
            this.Down,
            this.Grad,
            this.Angle,
            this.Dist,
            this.AZ,
            this.TagData});
            this.Commands.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Commands.Name = "Commands";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Commands.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Commands.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Commands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellContentClick);
            this.Commands.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellEndEdit);
            this.Commands.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Commands_DataError);
            this.Commands.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.Commands_DefaultValuesNeeded);
            this.Commands.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Commands_EditingControlShowing);
            this.Commands.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_RowEnter);
            this.Commands.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Commands_RowsAdded);
            this.Commands.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Commands_RowValidating);
            // 
            // Command
            // 
            this.Command.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.Command.DefaultCellStyle = dataGridViewCellStyle3;
            this.Command.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            resources.ApplyResources(this.Command, "Command");
            this.Command.Name = "Command";
            // 
            // Param1
            // 
            this.Param1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Param1, "Param1");
            this.Param1.Name = "Param1";
            this.Param1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param2
            // 
            this.Param2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Param2, "Param2");
            this.Param2.Name = "Param2";
            this.Param2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param3
            // 
            this.Param3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Param3, "Param3");
            this.Param3.Name = "Param3";
            this.Param3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param4
            // 
            this.Param4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Param4, "Param4");
            this.Param4.Name = "Param4";
            this.Param4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lat
            // 
            this.Lat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Lat, "Lat");
            this.Lat.Name = "Lat";
            this.Lat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lon
            // 
            this.Lon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Lon, "Lon");
            this.Lon.Name = "Lon";
            this.Lon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Alt
            // 
            this.Alt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Alt, "Alt");
            this.Alt.Name = "Alt";
            this.Alt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // coordZone
            // 
            resources.ApplyResources(this.coordZone, "coordZone");
            this.coordZone.Name = "coordZone";
            // 
            // coordEasting
            // 
            resources.ApplyResources(this.coordEasting, "coordEasting");
            this.coordEasting.Name = "coordEasting";
            // 
            // coordNorthing
            // 
            resources.ApplyResources(this.coordNorthing, "coordNorthing");
            this.coordNorthing.Name = "coordNorthing";
            // 
            // MGRS
            // 
            resources.ApplyResources(this.MGRS, "MGRS");
            this.MGRS.Name = "MGRS";
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            // 
            // Up
            // 
            this.Up.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Up.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.Up, "Up");
            this.Up.Image = ((System.Drawing.Image)(resources.GetObject("Up.Image")));
            this.Up.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Up.Name = "Up";
            // 
            // Down
            // 
            this.Down.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Down.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.Down, "Down");
            this.Down.Image = ((System.Drawing.Image)(resources.GetObject("Down.Image")));
            this.Down.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Down.Name = "Down";
            // 
            // Grad
            // 
            this.Grad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Grad, "Grad");
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Angle
            // 
            this.Angle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Angle, "Angle");
            this.Angle.Name = "Angle";
            this.Angle.ReadOnly = true;
            this.Angle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dist
            // 
            this.Dist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.Dist, "Dist");
            this.Dist.Name = "Dist";
            this.Dist.ReadOnly = true;
            this.Dist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AZ
            // 
            this.AZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.AZ, "AZ");
            this.AZ.Name = "AZ";
            this.AZ.ReadOnly = true;
            this.AZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TagData
            // 
            resources.ApplyResources(this.TagData, "TagData");
            this.TagData.Name = "TagData";
            this.TagData.ReadOnly = true;
            // 
            // CHK_splinedefault
            // 
            resources.ApplyResources(this.CHK_splinedefault, "CHK_splinedefault");
            this.CHK_splinedefault.Name = "CHK_splinedefault";
            this.CHK_splinedefault.UseVisualStyleBackColor = true;
            this.CHK_splinedefault.CheckedChanged += new System.EventHandler(this.CHK_splinedefault_CheckedChanged);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // TXT_altwarn
            // 
            resources.ApplyResources(this.TXT_altwarn, "TXT_altwarn");
            this.TXT_altwarn.Name = "TXT_altwarn";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.splitter2, "splitter2");
            this.splitter2.Name = "splitter2";
            this.splitter2.TabStop = false;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.lbl_distance);
            this.panelMap.Controls.Add(this.lbl_homedist);
            this.panelMap.Controls.Add(this.lbl_prevdist);
            this.panelMap.Controls.Add(this.MainMap);
            this.panelMap.Controls.Add(this.trackBar1);
            this.panelMap.Controls.Add(this.label11);
            resources.ApplyResources(this.panelMap, "panelMap");
            this.panelMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMap.Name = "panelMap";
            this.panelMap.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMap_Paint);
            this.panelMap.Resize += new System.EventHandler(this.panelMap_Resize);
            // 
            // lbl_distance
            // 
            resources.ApplyResources(this.lbl_distance, "lbl_distance");
            this.lbl_distance.Name = "lbl_distance";
            this.lbl_distance.Click += new System.EventHandler(this.lbl_distance_Click);
            // 
            // lbl_homedist
            // 
            resources.ApplyResources(this.lbl_homedist, "lbl_homedist");
            this.lbl_homedist.Name = "lbl_homedist";
            // 
            // lbl_prevdist
            // 
            resources.ApplyResources(this.lbl_prevdist, "lbl_prevdist");
            this.lbl_prevdist.Name = "lbl_prevdist";
            // 
            // MainMap
            // 
            this.MainMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.ContextMenuStrip = this.contextMenuStrip1;
            this.MainMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.MainMap, "MainMap");
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 19;
            this.MainMap.MinZoom = 0;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = false;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.MainMap.SelectedArea = ((GMap.NET.RectLatLng)(resources.GetObject("MainMap.SelectedArea")));
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Zoom = 0D;
            this.MainMap.Load += new System.EventHandler(this.MainMap_Load);
            this.MainMap.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMap_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteWPToolStripMenuItem,
            this.insertWpToolStripMenuItem,
            this.insertSplineWPToolStripMenuItem,
            this.loiterToolStripMenuItem,
            this.jumpToolStripMenuItem,
            this.rTLToolStripMenuItem,
            this.landToolStripMenuItem,
            this.takeoffToolStripMenuItem,
            this.setROIToolStripMenuItem,
            this.clearMissionToolStripMenuItem,
            this.toolStripSeparator1,
            this.polygonToolStripMenuItem,
            this.rallyPointsToolStripMenuItem,
            this.geoFenceToolStripMenuItem,
            this.autoWPToolStripMenuItem,
            this.mapToolToolStripMenuItem,
            this.fileLoadSaveToolStripMenuItem,
            this.pOIToolStripMenuItem,
            this.trackerHomeToolStripMenuItem,
            this.modifyAltToolStripMenuItem,
            this.enterUTMCoordToolStripMenuItem,
            this.switchDockingToolStripMenuItem,
            this.setHomeHereToolStripMenuItem,
            this.toolStripSeparator2,
            this.flightPattern});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteWPToolStripMenuItem
            // 
            this.deleteWPToolStripMenuItem.Name = "deleteWPToolStripMenuItem";
            resources.ApplyResources(this.deleteWPToolStripMenuItem, "deleteWPToolStripMenuItem");
            this.deleteWPToolStripMenuItem.Click += new System.EventHandler(this.deleteWPToolStripMenuItem_Click);
            // 
            // insertWpToolStripMenuItem
            // 
            this.insertWpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentPositionToolStripMenuItem});
            this.insertWpToolStripMenuItem.Name = "insertWpToolStripMenuItem";
            resources.ApplyResources(this.insertWpToolStripMenuItem, "insertWpToolStripMenuItem");
            this.insertWpToolStripMenuItem.Click += new System.EventHandler(this.insertWpToolStripMenuItem_Click);
            // 
            // currentPositionToolStripMenuItem
            // 
            this.currentPositionToolStripMenuItem.Name = "currentPositionToolStripMenuItem";
            resources.ApplyResources(this.currentPositionToolStripMenuItem, "currentPositionToolStripMenuItem");
            this.currentPositionToolStripMenuItem.Click += new System.EventHandler(this.currentPositionToolStripMenuItem_Click);
            // 
            // insertSplineWPToolStripMenuItem
            // 
            this.insertSplineWPToolStripMenuItem.Name = "insertSplineWPToolStripMenuItem";
            resources.ApplyResources(this.insertSplineWPToolStripMenuItem, "insertSplineWPToolStripMenuItem");
            this.insertSplineWPToolStripMenuItem.Click += new System.EventHandler(this.insertSplineWPToolStripMenuItem_Click);
            // 
            // loiterToolStripMenuItem
            // 
            this.loiterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loiterForeverToolStripMenuItem,
            this.loitertimeToolStripMenuItem,
            this.loitercirclesToolStripMenuItem});
            this.loiterToolStripMenuItem.Name = "loiterToolStripMenuItem";
            resources.ApplyResources(this.loiterToolStripMenuItem, "loiterToolStripMenuItem");
            // 
            // loiterForeverToolStripMenuItem
            // 
            this.loiterForeverToolStripMenuItem.Name = "loiterForeverToolStripMenuItem";
            resources.ApplyResources(this.loiterForeverToolStripMenuItem, "loiterForeverToolStripMenuItem");
            this.loiterForeverToolStripMenuItem.Click += new System.EventHandler(this.loiterForeverToolStripMenuItem_Click);
            // 
            // loitertimeToolStripMenuItem
            // 
            this.loitertimeToolStripMenuItem.Name = "loitertimeToolStripMenuItem";
            resources.ApplyResources(this.loitertimeToolStripMenuItem, "loitertimeToolStripMenuItem");
            this.loitertimeToolStripMenuItem.Click += new System.EventHandler(this.loitertimeToolStripMenuItem_Click);
            // 
            // loitercirclesToolStripMenuItem
            // 
            this.loitercirclesToolStripMenuItem.Name = "loitercirclesToolStripMenuItem";
            resources.ApplyResources(this.loitercirclesToolStripMenuItem, "loitercirclesToolStripMenuItem");
            this.loitercirclesToolStripMenuItem.Click += new System.EventHandler(this.loitercirclesToolStripMenuItem_Click);
            // 
            // jumpToolStripMenuItem
            // 
            this.jumpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumpstartToolStripMenuItem,
            this.jumpwPToolStripMenuItem});
            this.jumpToolStripMenuItem.Name = "jumpToolStripMenuItem";
            resources.ApplyResources(this.jumpToolStripMenuItem, "jumpToolStripMenuItem");
            // 
            // jumpstartToolStripMenuItem
            // 
            this.jumpstartToolStripMenuItem.Name = "jumpstartToolStripMenuItem";
            resources.ApplyResources(this.jumpstartToolStripMenuItem, "jumpstartToolStripMenuItem");
            this.jumpstartToolStripMenuItem.Click += new System.EventHandler(this.jumpstartToolStripMenuItem_Click);
            // 
            // jumpwPToolStripMenuItem
            // 
            this.jumpwPToolStripMenuItem.Name = "jumpwPToolStripMenuItem";
            resources.ApplyResources(this.jumpwPToolStripMenuItem, "jumpwPToolStripMenuItem");
            this.jumpwPToolStripMenuItem.Click += new System.EventHandler(this.jumpwPToolStripMenuItem_Click);
            // 
            // rTLToolStripMenuItem
            // 
            this.rTLToolStripMenuItem.Name = "rTLToolStripMenuItem";
            resources.ApplyResources(this.rTLToolStripMenuItem, "rTLToolStripMenuItem");
            this.rTLToolStripMenuItem.Click += new System.EventHandler(this.rTLToolStripMenuItem_Click);
            // 
            // landToolStripMenuItem
            // 
            this.landToolStripMenuItem.Name = "landToolStripMenuItem";
            resources.ApplyResources(this.landToolStripMenuItem, "landToolStripMenuItem");
            this.landToolStripMenuItem.Click += new System.EventHandler(this.landToolStripMenuItem_Click);
            // 
            // takeoffToolStripMenuItem
            // 
            this.takeoffToolStripMenuItem.Name = "takeoffToolStripMenuItem";
            resources.ApplyResources(this.takeoffToolStripMenuItem, "takeoffToolStripMenuItem");
            this.takeoffToolStripMenuItem.Click += new System.EventHandler(this.takeoffToolStripMenuItem_Click);
            // 
            // setROIToolStripMenuItem
            // 
            this.setROIToolStripMenuItem.Name = "setROIToolStripMenuItem";
            resources.ApplyResources(this.setROIToolStripMenuItem, "setROIToolStripMenuItem");
            this.setROIToolStripMenuItem.Click += new System.EventHandler(this.setROIToolStripMenuItem_Click);
            // 
            // clearMissionToolStripMenuItem
            // 
            this.clearMissionToolStripMenuItem.Name = "clearMissionToolStripMenuItem";
            resources.ApplyResources(this.clearMissionToolStripMenuItem, "clearMissionToolStripMenuItem");
            this.clearMissionToolStripMenuItem.Click += new System.EventHandler(this.clearMissionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPolygonPointToolStripMenuItem,
            this.clearPolygonToolStripMenuItem,
            this.savePolygonToolStripMenuItem,
            this.loadPolygonToolStripMenuItem,
            this.fromSHPToolStripMenuItem,
            this.areaToolStripMenuItem});
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            resources.ApplyResources(this.polygonToolStripMenuItem, "polygonToolStripMenuItem");
            // 
            // addPolygonPointToolStripMenuItem
            // 
            this.addPolygonPointToolStripMenuItem.Name = "addPolygonPointToolStripMenuItem";
            resources.ApplyResources(this.addPolygonPointToolStripMenuItem, "addPolygonPointToolStripMenuItem");
            this.addPolygonPointToolStripMenuItem.Click += new System.EventHandler(this.addPolygonPointToolStripMenuItem_Click);
            // 
            // clearPolygonToolStripMenuItem
            // 
            this.clearPolygonToolStripMenuItem.Name = "clearPolygonToolStripMenuItem";
            resources.ApplyResources(this.clearPolygonToolStripMenuItem, "clearPolygonToolStripMenuItem");
            this.clearPolygonToolStripMenuItem.Click += new System.EventHandler(this.clearPolygonToolStripMenuItem_Click);
            // 
            // savePolygonToolStripMenuItem
            // 
            this.savePolygonToolStripMenuItem.Name = "savePolygonToolStripMenuItem";
            resources.ApplyResources(this.savePolygonToolStripMenuItem, "savePolygonToolStripMenuItem");
            this.savePolygonToolStripMenuItem.Click += new System.EventHandler(this.savePolygonToolStripMenuItem_Click);
            // 
            // loadPolygonToolStripMenuItem
            // 
            this.loadPolygonToolStripMenuItem.Name = "loadPolygonToolStripMenuItem";
            resources.ApplyResources(this.loadPolygonToolStripMenuItem, "loadPolygonToolStripMenuItem");
            this.loadPolygonToolStripMenuItem.Click += new System.EventHandler(this.loadPolygonToolStripMenuItem_Click);
            // 
            // fromSHPToolStripMenuItem
            // 
            this.fromSHPToolStripMenuItem.Name = "fromSHPToolStripMenuItem";
            resources.ApplyResources(this.fromSHPToolStripMenuItem, "fromSHPToolStripMenuItem");
            this.fromSHPToolStripMenuItem.Click += new System.EventHandler(this.fromSHPToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            resources.ApplyResources(this.areaToolStripMenuItem, "areaToolStripMenuItem");
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // rallyPointsToolStripMenuItem
            // 
            this.rallyPointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setRallyPointToolStripMenuItem,
            this.getRallyPointsToolStripMenuItem,
            this.saveRallyPointsToolStripMenuItem,
            this.clearRallyPointsToolStripMenuItem,
            this.saveToFileToolStripMenuItem1,
            this.loadFromFileToolStripMenuItem1});
            this.rallyPointsToolStripMenuItem.Name = "rallyPointsToolStripMenuItem";
            resources.ApplyResources(this.rallyPointsToolStripMenuItem, "rallyPointsToolStripMenuItem");
            // 
            // setRallyPointToolStripMenuItem
            // 
            this.setRallyPointToolStripMenuItem.Name = "setRallyPointToolStripMenuItem";
            resources.ApplyResources(this.setRallyPointToolStripMenuItem, "setRallyPointToolStripMenuItem");
            this.setRallyPointToolStripMenuItem.Click += new System.EventHandler(this.setRallyPointToolStripMenuItem_Click);
            // 
            // getRallyPointsToolStripMenuItem
            // 
            this.getRallyPointsToolStripMenuItem.Name = "getRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.getRallyPointsToolStripMenuItem, "getRallyPointsToolStripMenuItem");
            this.getRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.getRallyPointsToolStripMenuItem_Click);
            // 
            // saveRallyPointsToolStripMenuItem
            // 
            this.saveRallyPointsToolStripMenuItem.Name = "saveRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.saveRallyPointsToolStripMenuItem, "saveRallyPointsToolStripMenuItem");
            this.saveRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.saveRallyPointsToolStripMenuItem_Click);
            // 
            // clearRallyPointsToolStripMenuItem
            // 
            this.clearRallyPointsToolStripMenuItem.Name = "clearRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.clearRallyPointsToolStripMenuItem, "clearRallyPointsToolStripMenuItem");
            this.clearRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.clearRallyPointsToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem1
            // 
            this.saveToFileToolStripMenuItem1.Name = "saveToFileToolStripMenuItem1";
            resources.ApplyResources(this.saveToFileToolStripMenuItem1, "saveToFileToolStripMenuItem1");
            this.saveToFileToolStripMenuItem1.Click += new System.EventHandler(this.saveToFileToolStripMenuItem1_Click);
            // 
            // loadFromFileToolStripMenuItem1
            // 
            this.loadFromFileToolStripMenuItem1.Name = "loadFromFileToolStripMenuItem1";
            resources.ApplyResources(this.loadFromFileToolStripMenuItem1, "loadFromFileToolStripMenuItem1");
            this.loadFromFileToolStripMenuItem1.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem1_Click);
            // 
            // geoFenceToolStripMenuItem
            // 
            this.geoFenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator4,
            this.GeoFenceuploadToolStripMenuItem,
            this.GeoFencedownloadToolStripMenuItem,
            this.setReturnLocationToolStripMenuItem,
            this.loadFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.geoFenceToolStripMenuItem.Name = "geoFenceToolStripMenuItem";
            resources.ApplyResources(this.geoFenceToolStripMenuItem, "geoFenceToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // GeoFenceuploadToolStripMenuItem
            // 
            this.GeoFenceuploadToolStripMenuItem.Name = "GeoFenceuploadToolStripMenuItem";
            resources.ApplyResources(this.GeoFenceuploadToolStripMenuItem, "GeoFenceuploadToolStripMenuItem");
            this.GeoFenceuploadToolStripMenuItem.Click += new System.EventHandler(this.GeoFenceuploadToolStripMenuItem_Click);
            // 
            // GeoFencedownloadToolStripMenuItem
            // 
            this.GeoFencedownloadToolStripMenuItem.Name = "GeoFencedownloadToolStripMenuItem";
            resources.ApplyResources(this.GeoFencedownloadToolStripMenuItem, "GeoFencedownloadToolStripMenuItem");
            this.GeoFencedownloadToolStripMenuItem.Click += new System.EventHandler(this.GeoFencedownloadToolStripMenuItem_Click);
            // 
            // setReturnLocationToolStripMenuItem
            // 
            this.setReturnLocationToolStripMenuItem.Name = "setReturnLocationToolStripMenuItem";
            resources.ApplyResources(this.setReturnLocationToolStripMenuItem, "setReturnLocationToolStripMenuItem");
            this.setReturnLocationToolStripMenuItem.Click += new System.EventHandler(this.setReturnLocationToolStripMenuItem_Click);
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            resources.ApplyResources(this.loadFromFileToolStripMenuItem, "loadFromFileToolStripMenuItem");
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            resources.ApplyResources(this.saveToFileToolStripMenuItem, "saveToFileToolStripMenuItem");
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // autoWPToolStripMenuItem
            // 
            this.autoWPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createWpCircleToolStripMenuItem,
            this.createSplineCircleToolStripMenuItem,
            this.areaToolStripMenuItem1,
            this.textToolStripMenuItem,
            this.createCircleSurveyToolStripMenuItem,
            this.surveyGridToolStripMenuItem});
            this.autoWPToolStripMenuItem.Name = "autoWPToolStripMenuItem";
            resources.ApplyResources(this.autoWPToolStripMenuItem, "autoWPToolStripMenuItem");
            // 
            // createWpCircleToolStripMenuItem
            // 
            this.createWpCircleToolStripMenuItem.Checked = true;
            this.createWpCircleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.createWpCircleToolStripMenuItem.Name = "createWpCircleToolStripMenuItem";
            resources.ApplyResources(this.createWpCircleToolStripMenuItem, "createWpCircleToolStripMenuItem");
            this.createWpCircleToolStripMenuItem.Click += new System.EventHandler(this.createWpCircleToolStripMenuItem_Click);
            // 
            // createSplineCircleToolStripMenuItem
            // 
            this.createSplineCircleToolStripMenuItem.Name = "createSplineCircleToolStripMenuItem";
            resources.ApplyResources(this.createSplineCircleToolStripMenuItem, "createSplineCircleToolStripMenuItem");
            this.createSplineCircleToolStripMenuItem.Click += new System.EventHandler(this.createSplineCircleToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem1
            // 
            this.areaToolStripMenuItem1.Name = "areaToolStripMenuItem1";
            resources.ApplyResources(this.areaToolStripMenuItem1, "areaToolStripMenuItem1");
            this.areaToolStripMenuItem1.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            resources.ApplyResources(this.textToolStripMenuItem, "textToolStripMenuItem");
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // createCircleSurveyToolStripMenuItem
            // 
            this.createCircleSurveyToolStripMenuItem.Name = "createCircleSurveyToolStripMenuItem";
            resources.ApplyResources(this.createCircleSurveyToolStripMenuItem, "createCircleSurveyToolStripMenuItem");
            this.createCircleSurveyToolStripMenuItem.Click += new System.EventHandler(this.createCircleSurveyToolStripMenuItem_Click);
            // 
            // surveyGridToolStripMenuItem
            // 
            this.surveyGridToolStripMenuItem.Name = "surveyGridToolStripMenuItem";
            resources.ApplyResources(this.surveyGridToolStripMenuItem, "surveyGridToolStripMenuItem");
            this.surveyGridToolStripMenuItem.Click += new System.EventHandler(this.surveyGridToolStripMenuItem_Click);
            // 
            // mapToolToolStripMenuItem
            // 
            this.mapToolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMeasure,
            this.rotateMapToolStripMenuItem,
            this.zoomToToolStripMenuItem,
            this.prefetchToolStripMenuItem,
            this.prefetchWPPathToolStripMenuItem,
            this.kMLOverlayToolStripMenuItem,
            this.elevationGraphToolStripMenuItem,
            this.reverseWPsToolStripMenuItem});
            this.mapToolToolStripMenuItem.Name = "mapToolToolStripMenuItem";
            resources.ApplyResources(this.mapToolToolStripMenuItem, "mapToolToolStripMenuItem");
            // 
            // ContextMeasure
            // 
            this.ContextMeasure.Name = "ContextMeasure";
            resources.ApplyResources(this.ContextMeasure, "ContextMeasure");
            this.ContextMeasure.Click += new System.EventHandler(this.ContextMeasure_Click);
            // 
            // rotateMapToolStripMenuItem
            // 
            this.rotateMapToolStripMenuItem.Name = "rotateMapToolStripMenuItem";
            resources.ApplyResources(this.rotateMapToolStripMenuItem, "rotateMapToolStripMenuItem");
            this.rotateMapToolStripMenuItem.Click += new System.EventHandler(this.rotateMapToolStripMenuItem_Click);
            // 
            // zoomToToolStripMenuItem
            // 
            this.zoomToToolStripMenuItem.Name = "zoomToToolStripMenuItem";
            resources.ApplyResources(this.zoomToToolStripMenuItem, "zoomToToolStripMenuItem");
            this.zoomToToolStripMenuItem.Click += new System.EventHandler(this.zoomToToolStripMenuItem_Click);
            // 
            // prefetchToolStripMenuItem
            // 
            this.prefetchToolStripMenuItem.Name = "prefetchToolStripMenuItem";
            resources.ApplyResources(this.prefetchToolStripMenuItem, "prefetchToolStripMenuItem");
            this.prefetchToolStripMenuItem.Click += new System.EventHandler(this.prefetchToolStripMenuItem_Click);
            // 
            // prefetchWPPathToolStripMenuItem
            // 
            this.prefetchWPPathToolStripMenuItem.Name = "prefetchWPPathToolStripMenuItem";
            resources.ApplyResources(this.prefetchWPPathToolStripMenuItem, "prefetchWPPathToolStripMenuItem");
            this.prefetchWPPathToolStripMenuItem.Click += new System.EventHandler(this.prefetchWPPathToolStripMenuItem_Click);
            // 
            // kMLOverlayToolStripMenuItem
            // 
            this.kMLOverlayToolStripMenuItem.Name = "kMLOverlayToolStripMenuItem";
            resources.ApplyResources(this.kMLOverlayToolStripMenuItem, "kMLOverlayToolStripMenuItem");
            this.kMLOverlayToolStripMenuItem.Click += new System.EventHandler(this.kMLOverlayToolStripMenuItem_Click);
            // 
            // elevationGraphToolStripMenuItem
            // 
            this.elevationGraphToolStripMenuItem.Name = "elevationGraphToolStripMenuItem";
            resources.ApplyResources(this.elevationGraphToolStripMenuItem, "elevationGraphToolStripMenuItem");
            this.elevationGraphToolStripMenuItem.Click += new System.EventHandler(this.elevationGraphToolStripMenuItem_Click);
            // 
            // reverseWPsToolStripMenuItem
            // 
            this.reverseWPsToolStripMenuItem.Name = "reverseWPsToolStripMenuItem";
            resources.ApplyResources(this.reverseWPsToolStripMenuItem, "reverseWPsToolStripMenuItem");
            this.reverseWPsToolStripMenuItem.Click += new System.EventHandler(this.reverseWPsToolStripMenuItem_Click);
            // 
            // fileLoadSaveToolStripMenuItem
            // 
            this.fileLoadSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWPFileToolStripMenuItem,
            this.loadAndAppendToolStripMenuItem,
            this.saveWPFileToolStripMenuItem,
            this.loadKMLFileToolStripMenuItem,
            this.loadSHPFileToolStripMenuItem});
            this.fileLoadSaveToolStripMenuItem.Name = "fileLoadSaveToolStripMenuItem";
            resources.ApplyResources(this.fileLoadSaveToolStripMenuItem, "fileLoadSaveToolStripMenuItem");
            // 
            // loadWPFileToolStripMenuItem
            // 
            this.loadWPFileToolStripMenuItem.Name = "loadWPFileToolStripMenuItem";
            resources.ApplyResources(this.loadWPFileToolStripMenuItem, "loadWPFileToolStripMenuItem");
            this.loadWPFileToolStripMenuItem.Click += new System.EventHandler(this.loadWPFileToolStripMenuItem_Click);
            // 
            // loadAndAppendToolStripMenuItem
            // 
            this.loadAndAppendToolStripMenuItem.Name = "loadAndAppendToolStripMenuItem";
            resources.ApplyResources(this.loadAndAppendToolStripMenuItem, "loadAndAppendToolStripMenuItem");
            this.loadAndAppendToolStripMenuItem.Click += new System.EventHandler(this.loadAndAppendToolStripMenuItem_Click);
            // 
            // saveWPFileToolStripMenuItem
            // 
            this.saveWPFileToolStripMenuItem.Name = "saveWPFileToolStripMenuItem";
            resources.ApplyResources(this.saveWPFileToolStripMenuItem, "saveWPFileToolStripMenuItem");
            this.saveWPFileToolStripMenuItem.Click += new System.EventHandler(this.saveWPFileToolStripMenuItem_Click);
            // 
            // loadKMLFileToolStripMenuItem
            // 
            this.loadKMLFileToolStripMenuItem.Name = "loadKMLFileToolStripMenuItem";
            resources.ApplyResources(this.loadKMLFileToolStripMenuItem, "loadKMLFileToolStripMenuItem");
            this.loadKMLFileToolStripMenuItem.Click += new System.EventHandler(this.loadKMLFileToolStripMenuItem_Click);
            // 
            // loadSHPFileToolStripMenuItem
            // 
            this.loadSHPFileToolStripMenuItem.Name = "loadSHPFileToolStripMenuItem";
            resources.ApplyResources(this.loadSHPFileToolStripMenuItem, "loadSHPFileToolStripMenuItem");
            this.loadSHPFileToolStripMenuItem.Click += new System.EventHandler(this.loadSHPFileToolStripMenuItem_Click);
            // 
            // pOIToolStripMenuItem
            // 
            this.pOIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poiaddToolStripMenuItem,
            this.poideleteToolStripMenuItem,
            this.poieditToolStripMenuItem});
            this.pOIToolStripMenuItem.Name = "pOIToolStripMenuItem";
            resources.ApplyResources(this.pOIToolStripMenuItem, "pOIToolStripMenuItem");
            // 
            // poiaddToolStripMenuItem
            // 
            this.poiaddToolStripMenuItem.Name = "poiaddToolStripMenuItem";
            resources.ApplyResources(this.poiaddToolStripMenuItem, "poiaddToolStripMenuItem");
            this.poiaddToolStripMenuItem.Click += new System.EventHandler(this.poiaddToolStripMenuItem_Click);
            // 
            // poideleteToolStripMenuItem
            // 
            this.poideleteToolStripMenuItem.Name = "poideleteToolStripMenuItem";
            resources.ApplyResources(this.poideleteToolStripMenuItem, "poideleteToolStripMenuItem");
            this.poideleteToolStripMenuItem.Click += new System.EventHandler(this.poideleteToolStripMenuItem_Click);
            // 
            // poieditToolStripMenuItem
            // 
            this.poieditToolStripMenuItem.Name = "poieditToolStripMenuItem";
            resources.ApplyResources(this.poieditToolStripMenuItem, "poieditToolStripMenuItem");
            this.poieditToolStripMenuItem.Click += new System.EventHandler(this.poieditToolStripMenuItem_Click);
            // 
            // trackerHomeToolStripMenuItem
            // 
            this.trackerHomeToolStripMenuItem.Name = "trackerHomeToolStripMenuItem";
            resources.ApplyResources(this.trackerHomeToolStripMenuItem, "trackerHomeToolStripMenuItem");
            this.trackerHomeToolStripMenuItem.Click += new System.EventHandler(this.trackerHomeToolStripMenuItem_Click);
            // 
            // modifyAltToolStripMenuItem
            // 
            this.modifyAltToolStripMenuItem.Name = "modifyAltToolStripMenuItem";
            resources.ApplyResources(this.modifyAltToolStripMenuItem, "modifyAltToolStripMenuItem");
            this.modifyAltToolStripMenuItem.Click += new System.EventHandler(this.modifyAltToolStripMenuItem_Click);
            // 
            // enterUTMCoordToolStripMenuItem
            // 
            this.enterUTMCoordToolStripMenuItem.Name = "enterUTMCoordToolStripMenuItem";
            resources.ApplyResources(this.enterUTMCoordToolStripMenuItem, "enterUTMCoordToolStripMenuItem");
            this.enterUTMCoordToolStripMenuItem.Click += new System.EventHandler(this.enterUTMCoordToolStripMenuItem_Click);
            // 
            // switchDockingToolStripMenuItem
            // 
            this.switchDockingToolStripMenuItem.Name = "switchDockingToolStripMenuItem";
            resources.ApplyResources(this.switchDockingToolStripMenuItem, "switchDockingToolStripMenuItem");
            this.switchDockingToolStripMenuItem.Click += new System.EventHandler(this.switchDockingToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem
            // 
            this.setHomeHereToolStripMenuItem.Name = "setHomeHereToolStripMenuItem";
            resources.ApplyResources(this.setHomeHereToolStripMenuItem, "setHomeHereToolStripMenuItem");
            this.setHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // flightPattern
            // 
            this.flightPattern.Name = "flightPattern";
            resources.ApplyResources(this.flightPattern, "flightPattern");
            this.flightPattern.Click += new System.EventHandler(this.flightPattern_Click);
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.LargeChange = 0.005F;
            this.trackBar1.Maximum = 24F;
            this.trackBar1.Minimum = 1F;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.SmallChange = 0.001F;
            this.trackBar1.TickFrequency = 1F;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 2F;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // panelBASE
            // 
            this.panelBASE.Controls.Add(this.panelMap);
            this.panelBASE.Controls.Add(this.panelWaypoints);
            this.panelBASE.Controls.Add(this.panel4);
            this.panelBASE.Controls.Add(this.splitter2);
            this.panelBASE.Controls.Add(this.splitter1);
            this.panelBASE.Controls.Add(this.panelAction);
            this.panelBASE.Controls.Add(this.label6);
            resources.ApplyResources(this.panelBASE, "panelBASE");
            this.panelBASE.Name = "panelBASE";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel_Main_farm);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel_Main_farm
            // 
            this.panel_Main_farm.BackColor = System.Drawing.Color.White;
            this.panel_Main_farm.Controls.Add(this.panel8);
            this.panel_Main_farm.Controls.Add(this.panel7);
            this.panel_Main_farm.Controls.Add(this.textBox_droneID);
            this.panel_Main_farm.Controls.Add(this.textBox_farmID);
            this.panel_Main_farm.Controls.Add(this.label7);
            this.panel_Main_farm.Controls.Add(this.label8);
            this.panel_Main_farm.Controls.Add(this.lineSeparator2);
            this.panel_Main_farm.Controls.Add(this.panel6);
            resources.ApplyResources(this.panel_Main_farm, "panel_Main_farm");
            this.panel_Main_farm.Name = "panel_Main_farm";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.DG_Drone);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrone_Paint);
            // 
            // DG_Drone
            // 
            this.DG_Drone.AllowUserToOrderColumns = true;
            this.DG_Drone.AutoGenerateColumns = false;
            this.DG_Drone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Drone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Drone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.droneidDataGridViewTextBoxColumn,
            this.dronenameDataGridViewTextBoxColumn});
            this.DG_Drone.DataSource = this.droneBindingSource;
            resources.ApplyResources(this.DG_Drone, "DG_Drone");
            this.DG_Drone.Name = "DG_Drone";
            this.DG_Drone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Drone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_drone_CellContentClick);
            // 
            // droneidDataGridViewTextBoxColumn
            // 
            this.droneidDataGridViewTextBoxColumn.DataPropertyName = "drone_id";
            resources.ApplyResources(this.droneidDataGridViewTextBoxColumn, "droneidDataGridViewTextBoxColumn");
            this.droneidDataGridViewTextBoxColumn.Name = "droneidDataGridViewTextBoxColumn";
            // 
            // dronenameDataGridViewTextBoxColumn
            // 
            this.dronenameDataGridViewTextBoxColumn.DataPropertyName = "drone_name";
            resources.ApplyResources(this.dronenameDataGridViewTextBoxColumn, "dronenameDataGridViewTextBoxColumn");
            this.dronenameDataGridViewTextBoxColumn.Name = "dronenameDataGridViewTextBoxColumn";
            // 
            // droneBindingSource
            // 
            this.droneBindingSource.DataMember = "Drone";
            this.droneBindingSource.DataSource = this.drone1;
            // 
            // drone1
            // 
            this.drone1.DataSetName = "Drone1";
            this.drone1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.DG_Farm);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPflightPlanner_farm_Paint);
            // 
            // DG_Farm
            // 
            this.DG_Farm.AllowUserToOrderColumns = true;
            this.DG_Farm.AutoGenerateColumns = false;
            this.DG_Farm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            this.DG_Farm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Farm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.farmidDataGridViewTextBoxColumn,
            this.farmnameDataGridViewTextBoxColumn});
            this.DG_Farm.DataSource = this.farmBindingSource;
            resources.ApplyResources(this.DG_Farm, "DG_Farm");
            this.DG_Farm.Name = "DG_Farm";
            this.DG_Farm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Farm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_farm_CellContentClick);
            // 
            // farmidDataGridViewTextBoxColumn
            // 
            this.farmidDataGridViewTextBoxColumn.DataPropertyName = "farm_id";
            resources.ApplyResources(this.farmidDataGridViewTextBoxColumn, "farmidDataGridViewTextBoxColumn");
            this.farmidDataGridViewTextBoxColumn.Name = "farmidDataGridViewTextBoxColumn";
            // 
            // farmnameDataGridViewTextBoxColumn
            // 
            this.farmnameDataGridViewTextBoxColumn.DataPropertyName = "farm_name";
            resources.ApplyResources(this.farmnameDataGridViewTextBoxColumn, "farmnameDataGridViewTextBoxColumn");
            this.farmnameDataGridViewTextBoxColumn.Name = "farmnameDataGridViewTextBoxColumn";
            // 
            // farmBindingSource
            // 
            this.farmBindingSource.DataMember = "Farm";
            this.farmBindingSource.DataSource = this.farm1;
            // 
            // farm1
            // 
            this.farm1.DataSetName = "farm1";
            this.farm1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_droneID
            // 
            resources.ApplyResources(this.textBox_droneID, "textBox_droneID");
            this.textBox_droneID.Name = "textBox_droneID";
            // 
            // textBox_farmID
            // 
            resources.ApplyResources(this.textBox_farmID, "textBox_farmID");
            this.textBox_farmID.Name = "textBox_farmID";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // lineSeparator2
            // 
            resources.ApplyResources(this.lineSeparator2, "lineSeparator2");
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Main_but_farm);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // Main_but_farm
            // 
            this.Main_but_farm.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Main_but_farm, "Main_but_farm");
            this.Main_but_farm.FlatAppearance.BorderSize = 0;
            this.Main_but_farm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.Main_but_farm.Name = "Main_but_farm";
            this.Main_but_farm.UseVisualStyleBackColor = false;
            // 
            // panelAction
            // 
            this.panelAction.AssociatedSplitter = null;
            this.panelAction.BackColor = System.Drawing.Color.Transparent;
            this.panelAction.CaptionFont = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.panelAction.CaptionHeight = 27;
            this.panelAction.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panelAction.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panelAction.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panelAction.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelAction.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panelAction.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelAction.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelAction.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelAction.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panelAction.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panelAction.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelAction.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelAction.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panelAction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelAction.Image = null;
            resources.ApplyResources(this.panelAction, "panelAction");
            this.panelAction.Name = "panelAction";
            this.panelAction.ToolTipTextCloseIcon = null;
            this.panelAction.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelAction.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dEVICE_LIST
            // 
            this.dEVICE_LIST.DataSetName = "DEVICE_LIST";
            this.dEVICE_LIST.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceListBindingSource
            // 
            this.deviceListBindingSource.DataMember = "DeviceList";
            this.deviceListBindingSource.DataSource = this.dEVICE_LIST;
            // 
            // deviceListTableAdapter
            // 
            this.deviceListTableAdapter.ClearBeforeFill = true;
            // 
            // droneTableAdapter
            // 
            this.droneTableAdapter.ClearBeforeFill = true;
            // 
            // farmTableAdapter
            // 
            this.farmTableAdapter.ClearBeforeFill = true;
            // 
            // FlightPlanner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelBASE);
            resources.ApplyResources(this, "$this");
            this.Name = "FlightPlanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightPlanner_FormClosing);
            this.Load += new System.EventHandler(this.FlightPlanner1_Load);
            this.Resize += new System.EventHandler(this.Planner_Resize);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelWaypoints.ResumeLayout(false);
            this.panelWaypoints.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).EndInit();
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelBASE.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel_Main_farm.ResumeLayout(false);
            this.panel_Main_farm.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Drone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.droneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drone1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Farm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farm1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dEVICE_LIST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Controls.MyButton BUT_read;
        private Controls.MyButton BUT_write;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TXT_homealt;
        private System.Windows.Forms.TextBox TXT_homelng;
        private System.Windows.Forms.TextBox TXT_homelat;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label lbl_status;
        private Controls.MyDataGridView Commands;
        private Controls.MyButton BUT_Add;
        private System.Windows.Forms.Label LBL_WPRad;
        private System.Windows.Forms.Label LBL_defalutalt;
        private System.Windows.Forms.Label label5;
        public BSE.Windows.Forms.Panel panelWaypoints;
        private System.Windows.Forms.Panel panelMap;
        public Controls.myGMAP MainMap;
        private Controls.MyTrackBar trackBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_distance;
        private System.Windows.Forms.Label lbl_prevdist;
        private BSE.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelBASE;
        private System.Windows.Forms.Label lbl_homedist;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem clearMissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPolygonPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPolygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loiterForeverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loitertimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loitercirclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpstartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpwPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteWPToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem geoFenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GeoFencedownloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setReturnLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem GeoFenceuploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem setROIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoWPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createWpCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextMeasure;
        private System.Windows.Forms.ToolStripMenuItem rotateMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prefetchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kMLOverlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elevationGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeoffToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxMapType;
        private System.Windows.Forms.ToolStripMenuItem fileLoadSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWPFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWPFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackerHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseWPsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAndAppendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePolygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPolygonToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox chk_grid;
        private System.Windows.Forms.ToolStripMenuItem insertWpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rallyPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getRallyPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRallyPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setRallyPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearRallyPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadKMLFileToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnk_kml;
        private System.Windows.Forms.ToolStripMenuItem modifyAltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prefetchWPPathToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TXT_altwarn;
        private System.Windows.Forms.ToolStripMenuItem pOIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poiaddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poideleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poieditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterUTMCoordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSHPFileToolStripMenuItem;
        private Controls.MyButton BUT_loadwpfile;
        private Controls.MyButton BUT_saveWPFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem switchDockingToolStripMenuItem;
        private BSE.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStripMenuItem insertSplineWPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSplineCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromSHPToolStripMenuItem;
        private System.Windows.Forms.Label lbl_wpfile;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        public System.Windows.Forms.CheckBox CHK_verifyheight;
        public System.Windows.Forms.TextBox TXT_WPRad;
        public System.Windows.Forms.TextBox TXT_DefaultAlt;
        public System.Windows.Forms.TextBox TXT_loiterrad;
        public System.Windows.Forms.CheckBox CHK_splinedefault;
        public System.Windows.Forms.ComboBox CMB_altmode;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCircleSurveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surveyGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem flightPattern;
        private MyButton MenuSimulation;
        private MyButton menuTakeoff;
        private System.Windows.Forms.DataGridViewComboBoxColumn Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alt;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordEasting;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordNorthing;
        private System.Windows.Forms.DataGridViewTextBoxColumn MGRS;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Up;
        private System.Windows.Forms.DataGridViewImageColumn Down;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dist;
        private System.Windows.Forms.DataGridViewTextBoxColumn AZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagData;

        /// <summary>
        /// added connect drone function
        /// </summary>
        private Controls.ToolStripConnectionControl toolStripConnectionControl1;
        //private Controls.ConnectionControl ConnectionControl;
        public System.Windows.Forms.ToolTip toolTip2;
        public MyButton MenuConnect;
        private MyButton button_log;
        public BSE.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_Main_farm;
        private MyDataGridView DG_Drone;
        private LineSeparator lineSeparator2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Main_but_farm;
        private DEVICE_LIST dEVICE_LIST;
        private System.Windows.Forms.BindingSource deviceListBindingSource;
        private DEVICE_LISTTableAdapters.DeviceListTableAdapter deviceListTableAdapter;
        private MyDataGridView DG_Farm;
        private System.Windows.Forms.TextBox textBox_droneID;
        private System.Windows.Forms.TextBox textBox_farmID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn droneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dronenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource droneBindingSource;
        private Drone1 drone1;
        private Drone1TableAdapters.DroneTableAdapter droneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn farmnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource farmBindingSource;
        private farm1 farm1;
        private farm1TableAdapters.FarmTableAdapter farmTableAdapter;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.MenuStrip MainMenu;
    }
}