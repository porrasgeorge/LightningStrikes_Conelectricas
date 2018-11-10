namespace LightningStrikes_Conelectricas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_Inicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_cooperativa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_lightningZones = new System.Windows.Forms.DataGridView();
            this.cantidadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVG_Amp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAX_Amp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getLightningsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lightningStrikesDataSet = new LightningStrikes_Conelectricas.LightningStrikesDataSet();
            this.btn_KML_Descargas = new System.Windows.Forms.Button();
            this.Check3D = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_lightningByDay = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countLightningsByDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_CrearCSV = new System.Windows.Forms.Button();
            this.lbl_cargandoFechas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_fechas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_cargandoZonas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cargarDatosZonas = new System.Windows.Forms.Button();
            this.panel_datos = new System.Windows.Forms.Panel();
            this.btn_crearKMLpoints = new System.Windows.Forms.Button();
            this.dgv_lightningAll = new System.Windows.Forms.DataGridView();
            this.fechaHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amplitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllLightningsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_lightningByMonth = new System.Windows.Forms.DataGridView();
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countLightningsByMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.countLightningsByDayTableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.CountLightningsByDayTableAdapter();
            this.getLightningsTableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.GetLightningsTableAdapter();
            this.lightningStrikesDataSet1 = new LightningStrikes_Conelectricas.LightningStrikesDataSet();
            this.countLightningsByMonthTableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.CountLightningsByMonthTableAdapter();
            this.getAllLightningsTableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.GetAllLightningsTableAdapter();
            this.btn_KML_AVG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningZones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLightningsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightningStrikesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningByDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLightningsByDayBindingSource)).BeginInit();
            this.panel_fechas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllLightningsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLightningsByMonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightningStrikesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LightningStrikes_Conelectricas.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(131, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_Inicial
            // 
            this.dtp_Inicial.CustomFormat = "";
            this.dtp_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Inicial.Location = new System.Drawing.Point(8, 32);
            this.dtp_Inicial.Name = "dtp_Inicial";
            this.dtp_Inicial.Size = new System.Drawing.Size(115, 20);
            this.dtp_Inicial.TabIndex = 1;
            this.dtp_Inicial.ValueChanged += new System.EventHandler(this.dtp_Inicial_ValueChanged);
            // 
            // dtp_final
            // 
            this.dtp_final.CustomFormat = "";
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(129, 32);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(115, 20);
            this.dtp_final.TabIndex = 2;
            this.dtp_final.ValueChanged += new System.EventHandler(this.dtp_final_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial  >=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final  <";
            // 
            // cb_cooperativa
            // 
            this.cb_cooperativa.FormattingEnabled = true;
            this.cb_cooperativa.Location = new System.Drawing.Point(663, 48);
            this.cb_cooperativa.Name = "cb_cooperativa";
            this.cb_cooperativa.Size = new System.Drawing.Size(186, 21);
            this.cb_cooperativa.TabIndex = 5;
            this.cb_cooperativa.SelectionChangeCommitted += new System.EventHandler(this.cb_cooperativa_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(693, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cooperativa / Lugar";
            // 
            // dgv_lightningZones
            // 
            this.dgv_lightningZones.AllowUserToAddRows = false;
            this.dgv_lightningZones.AllowUserToDeleteRows = false;
            this.dgv_lightningZones.AllowUserToResizeColumns = false;
            this.dgv_lightningZones.AllowUserToResizeRows = false;
            this.dgv_lightningZones.AutoGenerateColumns = false;
            this.dgv_lightningZones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lightningZones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidadDataGridViewTextBoxColumn1,
            this.latitudDataGridViewTextBoxColumn,
            this.longitudDataGridViewTextBoxColumn,
            this.AVG_Amp,
            this.MAX_Amp});
            this.dgv_lightningZones.DataSource = this.getLightningsBindingSource;
            this.dgv_lightningZones.Location = new System.Drawing.Point(15, 104);
            this.dgv_lightningZones.Name = "dgv_lightningZones";
            this.dgv_lightningZones.ReadOnly = true;
            this.dgv_lightningZones.RowHeadersVisible = false;
            this.dgv_lightningZones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lightningZones.Size = new System.Drawing.Size(346, 315);
            this.dgv_lightningZones.TabIndex = 7;
            // 
            // cantidadDataGridViewTextBoxColumn1
            // 
            this.cantidadDataGridViewTextBoxColumn1.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn1.Name = "cantidadDataGridViewTextBoxColumn1";
            this.cantidadDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn1.Width = 60;
            // 
            // latitudDataGridViewTextBoxColumn
            // 
            this.latitudDataGridViewTextBoxColumn.DataPropertyName = "Latitud";
            this.latitudDataGridViewTextBoxColumn.HeaderText = "Latitud";
            this.latitudDataGridViewTextBoxColumn.Name = "latitudDataGridViewTextBoxColumn";
            this.latitudDataGridViewTextBoxColumn.ReadOnly = true;
            this.latitudDataGridViewTextBoxColumn.Width = 60;
            // 
            // longitudDataGridViewTextBoxColumn
            // 
            this.longitudDataGridViewTextBoxColumn.DataPropertyName = "Longitud";
            this.longitudDataGridViewTextBoxColumn.HeaderText = "Longitud";
            this.longitudDataGridViewTextBoxColumn.Name = "longitudDataGridViewTextBoxColumn";
            this.longitudDataGridViewTextBoxColumn.ReadOnly = true;
            this.longitudDataGridViewTextBoxColumn.Width = 60;
            // 
            // AVG_Amp
            // 
            this.AVG_Amp.DataPropertyName = "AVG_Amp";
            this.AVG_Amp.HeaderText = "AVG (kA)";
            this.AVG_Amp.Name = "AVG_Amp";
            this.AVG_Amp.ReadOnly = true;
            this.AVG_Amp.Width = 75;
            // 
            // MAX_Amp
            // 
            this.MAX_Amp.DataPropertyName = "MAX_Amp";
            this.MAX_Amp.HeaderText = "MAX (kA)";
            this.MAX_Amp.Name = "MAX_Amp";
            this.MAX_Amp.ReadOnly = true;
            this.MAX_Amp.Width = 75;
            // 
            // getLightningsBindingSource
            // 
            this.getLightningsBindingSource.DataMember = "GetLightnings";
            this.getLightningsBindingSource.DataSource = this.lightningStrikesDataSet;
            // 
            // lightningStrikesDataSet
            // 
            this.lightningStrikesDataSet.DataSetName = "LightningStrikesDataSet";
            this.lightningStrikesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_KML_Descargas
            // 
            this.btn_KML_Descargas.Location = new System.Drawing.Point(47, 425);
            this.btn_KML_Descargas.Name = "btn_KML_Descargas";
            this.btn_KML_Descargas.Size = new System.Drawing.Size(92, 34);
            this.btn_KML_Descargas.TabIndex = 8;
            this.btn_KML_Descargas.Text = "KML Descargas";
            this.btn_KML_Descargas.UseVisualStyleBackColor = true;
            this.btn_KML_Descargas.Click += new System.EventHandler(this.btn_createKML_Click);
            // 
            // Check3D
            // 
            this.Check3D.AutoSize = true;
            this.Check3D.Checked = true;
            this.Check3D.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check3D.Location = new System.Drawing.Point(23, 441);
            this.Check3D.Name = "Check3D";
            this.Check3D.Size = new System.Drawing.Size(15, 14);
            this.Check3D.TabIndex = 9;
            this.Check3D.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(20, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "3D";
            // 
            // dgv_lightningByDay
            // 
            this.dgv_lightningByDay.AllowUserToAddRows = false;
            this.dgv_lightningByDay.AllowUserToDeleteRows = false;
            this.dgv_lightningByDay.AutoGenerateColumns = false;
            this.dgv_lightningByDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lightningByDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn2});
            this.dgv_lightningByDay.DataSource = this.countLightningsByDayBindingSource;
            this.dgv_lightningByDay.Location = new System.Drawing.Point(202, 29);
            this.dgv_lightningByDay.MultiSelect = false;
            this.dgv_lightningByDay.Name = "dgv_lightningByDay";
            this.dgv_lightningByDay.ReadOnly = true;
            this.dgv_lightningByDay.RowHeadersVisible = false;
            this.dgv_lightningByDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lightningByDay.Size = new System.Drawing.Size(164, 430);
            this.dgv_lightningByDay.TabIndex = 18;
            this.dgv_lightningByDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lightningByDay_CellClick);
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 70;
            // 
            // cantidadDataGridViewTextBoxColumn2
            // 
            this.cantidadDataGridViewTextBoxColumn2.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn2.Name = "cantidadDataGridViewTextBoxColumn2";
            this.cantidadDataGridViewTextBoxColumn2.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn2.Width = 60;
            // 
            // countLightningsByDayBindingSource
            // 
            this.countLightningsByDayBindingSource.DataMember = "CountLightningsByDay";
            this.countLightningsByDayBindingSource.DataSource = this.lightningStrikesDataSet;
            // 
            // btn_CrearCSV
            // 
            this.btn_CrearCSV.Location = new System.Drawing.Point(397, 425);
            this.btn_CrearCSV.Name = "btn_CrearCSV";
            this.btn_CrearCSV.Size = new System.Drawing.Size(147, 34);
            this.btn_CrearCSV.TabIndex = 19;
            this.btn_CrearCSV.Text = "Crear CSV";
            this.btn_CrearCSV.UseVisualStyleBackColor = true;
            this.btn_CrearCSV.Click += new System.EventHandler(this.btn_CrearCSV_Click);
            // 
            // lbl_cargandoFechas
            // 
            this.lbl_cargandoFechas.AutoSize = true;
            this.lbl_cargandoFechas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cargandoFechas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_cargandoFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargandoFechas.ForeColor = System.Drawing.Color.Red;
            this.lbl_cargandoFechas.Location = new System.Drawing.Point(131, 217);
            this.lbl_cargandoFechas.Name = "lbl_cargandoFechas";
            this.lbl_cargandoFechas.Size = new System.Drawing.Size(474, 78);
            this.lbl_cargandoFechas.TabIndex = 20;
            this.lbl_cargandoFechas.Text = "Cargando ......";
            this.lbl_cargandoFechas.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Descargas diarias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Descargas por ubicación";
            // 
            // panel_fechas
            // 
            this.panel_fechas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_fechas.Controls.Add(this.panel2);
            this.panel_fechas.Controls.Add(this.pictureBox1);
            this.panel_fechas.Controls.Add(this.panel_datos);
            this.panel_fechas.Controls.Add(this.label3);
            this.panel_fechas.Controls.Add(this.cb_cooperativa);
            this.panel_fechas.Location = new System.Drawing.Point(12, 12);
            this.panel_fechas.Name = "panel_fechas";
            this.panel_fechas.Size = new System.Drawing.Size(1149, 571);
            this.panel_fechas.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_KML_AVG);
            this.panel2.Controls.Add(this.lbl_cargandoZonas);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dgv_lightningZones);
            this.panel2.Controls.Add(this.btn_KML_Descargas);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Check3D);
            this.panel2.Location = new System.Drawing.Point(764, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 474);
            this.panel2.TabIndex = 26;
            // 
            // lbl_cargandoZonas
            // 
            this.lbl_cargandoZonas.AutoSize = true;
            this.lbl_cargandoZonas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cargandoZonas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_cargandoZonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargandoZonas.ForeColor = System.Drawing.Color.Red;
            this.lbl_cargandoZonas.Location = new System.Drawing.Point(71, 237);
            this.lbl_cargandoZonas.Name = "lbl_cargandoZonas";
            this.lbl_cargandoZonas.Size = new System.Drawing.Size(239, 39);
            this.lbl_cargandoZonas.TabIndex = 28;
            this.lbl_cargandoZonas.Text = "Cargando ......";
            this.lbl_cargandoZonas.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Datos por Zonas";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_cargarDatosZonas);
            this.panel1.Controls.Add(this.dtp_Inicial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp_final);
            this.panel1.Location = new System.Drawing.Point(15, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 69);
            this.panel1.TabIndex = 26;
            // 
            // btn_cargarDatosZonas
            // 
            this.btn_cargarDatosZonas.Location = new System.Drawing.Point(250, 8);
            this.btn_cargarDatosZonas.Name = "btn_cargarDatosZonas";
            this.btn_cargarDatosZonas.Size = new System.Drawing.Size(75, 44);
            this.btn_cargarDatosZonas.TabIndex = 5;
            this.btn_cargarDatosZonas.Text = "Cargar";
            this.btn_cargarDatosZonas.UseVisualStyleBackColor = true;
            this.btn_cargarDatosZonas.Click += new System.EventHandler(this.btn_cargarDatosZonas_Click);
            // 
            // panel_datos
            // 
            this.panel_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_datos.Controls.Add(this.lbl_cargandoFechas);
            this.panel_datos.Controls.Add(this.btn_crearKMLpoints);
            this.panel_datos.Controls.Add(this.dgv_lightningAll);
            this.panel_datos.Controls.Add(this.dgv_lightningByMonth);
            this.panel_datos.Controls.Add(this.label7);
            this.panel_datos.Controls.Add(this.dgv_lightningByDay);
            this.panel_datos.Controls.Add(this.label6);
            this.panel_datos.Controls.Add(this.label5);
            this.panel_datos.Controls.Add(this.btn_CrearCSV);
            this.panel_datos.Location = new System.Drawing.Point(3, 89);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(755, 474);
            this.panel_datos.TabIndex = 25;
            // 
            // btn_crearKMLpoints
            // 
            this.btn_crearKMLpoints.Location = new System.Drawing.Point(587, 425);
            this.btn_crearKMLpoints.Name = "btn_crearKMLpoints";
            this.btn_crearKMLpoints.Size = new System.Drawing.Size(147, 34);
            this.btn_crearKMLpoints.TabIndex = 27;
            this.btn_crearKMLpoints.Text = "Crear KML";
            this.btn_crearKMLpoints.UseVisualStyleBackColor = true;
            this.btn_crearKMLpoints.Click += new System.EventHandler(this.btn_crearKMLpoints_Click);
            // 
            // dgv_lightningAll
            // 
            this.dgv_lightningAll.AllowUserToAddRows = false;
            this.dgv_lightningAll.AllowUserToDeleteRows = false;
            this.dgv_lightningAll.AutoGenerateColumns = false;
            this.dgv_lightningAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lightningAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaHoraDataGridViewTextBoxColumn,
            this.longitudDataGridViewTextBoxColumn1,
            this.latitudDataGridViewTextBoxColumn1,
            this.amplitudDataGridViewTextBoxColumn});
            this.dgv_lightningAll.DataSource = this.getAllLightningsBindingSource;
            this.dgv_lightningAll.Location = new System.Drawing.Point(397, 29);
            this.dgv_lightningAll.MultiSelect = false;
            this.dgv_lightningAll.Name = "dgv_lightningAll";
            this.dgv_lightningAll.ReadOnly = true;
            this.dgv_lightningAll.RowHeadersVisible = false;
            this.dgv_lightningAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lightningAll.Size = new System.Drawing.Size(337, 390);
            this.dgv_lightningAll.TabIndex = 26;
            // 
            // fechaHoraDataGridViewTextBoxColumn
            // 
            this.fechaHoraDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Hora";
            this.fechaHoraDataGridViewTextBoxColumn.HeaderText = "Fecha_Hora";
            this.fechaHoraDataGridViewTextBoxColumn.Name = "fechaHoraDataGridViewTextBoxColumn";
            this.fechaHoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaHoraDataGridViewTextBoxColumn.Width = 120;
            // 
            // longitudDataGridViewTextBoxColumn1
            // 
            this.longitudDataGridViewTextBoxColumn1.DataPropertyName = "Longitud";
            this.longitudDataGridViewTextBoxColumn1.HeaderText = "Longitud";
            this.longitudDataGridViewTextBoxColumn1.Name = "longitudDataGridViewTextBoxColumn1";
            this.longitudDataGridViewTextBoxColumn1.ReadOnly = true;
            this.longitudDataGridViewTextBoxColumn1.Width = 70;
            // 
            // latitudDataGridViewTextBoxColumn1
            // 
            this.latitudDataGridViewTextBoxColumn1.DataPropertyName = "Latitud";
            this.latitudDataGridViewTextBoxColumn1.HeaderText = "Latitud";
            this.latitudDataGridViewTextBoxColumn1.Name = "latitudDataGridViewTextBoxColumn1";
            this.latitudDataGridViewTextBoxColumn1.ReadOnly = true;
            this.latitudDataGridViewTextBoxColumn1.Width = 70;
            // 
            // amplitudDataGridViewTextBoxColumn
            // 
            this.amplitudDataGridViewTextBoxColumn.DataPropertyName = "Amplitud";
            this.amplitudDataGridViewTextBoxColumn.HeaderText = "Amplitud";
            this.amplitudDataGridViewTextBoxColumn.Name = "amplitudDataGridViewTextBoxColumn";
            this.amplitudDataGridViewTextBoxColumn.ReadOnly = true;
            this.amplitudDataGridViewTextBoxColumn.Width = 50;
            // 
            // getAllLightningsBindingSource
            // 
            this.getAllLightningsBindingSource.DataMember = "GetAllLightnings";
            this.getAllLightningsBindingSource.DataSource = this.lightningStrikesDataSet;
            // 
            // dgv_lightningByMonth
            // 
            this.dgv_lightningByMonth.AllowUserToAddRows = false;
            this.dgv_lightningByMonth.AllowUserToDeleteRows = false;
            this.dgv_lightningByMonth.AutoGenerateColumns = false;
            this.dgv_lightningByMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lightningByMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dgv_lightningByMonth.DataSource = this.countLightningsByMonthBindingSource;
            this.dgv_lightningByMonth.Location = new System.Drawing.Point(16, 29);
            this.dgv_lightningByMonth.MultiSelect = false;
            this.dgv_lightningByMonth.Name = "dgv_lightningByMonth";
            this.dgv_lightningByMonth.ReadOnly = true;
            this.dgv_lightningByMonth.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_lightningByMonth.RowHeadersVisible = false;
            this.dgv_lightningByMonth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lightningByMonth.Size = new System.Drawing.Size(150, 430);
            this.dgv_lightningByMonth.TabIndex = 23;
            this.dgv_lightningByMonth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lightningByMonth_CellClick);
            // 
            // mesDataGridViewTextBoxColumn
            // 
            this.mesDataGridViewTextBoxColumn.DataPropertyName = "Mes";
            this.mesDataGridViewTextBoxColumn.HeaderText = "Mes";
            this.mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            this.mesDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesDataGridViewTextBoxColumn.Width = 60;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 60;
            // 
            // countLightningsByMonthBindingSource
            // 
            this.countLightningsByMonthBindingSource.DataMember = "CountLightningsByMonth";
            this.countLightningsByMonthBindingSource.DataSource = this.lightningStrikesDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Descargas mensuales";
            // 
            // countLightningsByDayTableAdapter
            // 
            this.countLightningsByDayTableAdapter.ClearBeforeFill = true;
            // 
            // getLightningsTableAdapter
            // 
            this.getLightningsTableAdapter.ClearBeforeFill = true;
            // 
            // lightningStrikesDataSet1
            // 
            this.lightningStrikesDataSet1.DataSetName = "LightningStrikesDataSet";
            this.lightningStrikesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countLightningsByMonthTableAdapter
            // 
            this.countLightningsByMonthTableAdapter.ClearBeforeFill = true;
            // 
            // getAllLightningsTableAdapter
            // 
            this.getAllLightningsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_KML_AVG
            // 
            this.btn_KML_AVG.Location = new System.Drawing.Point(168, 425);
            this.btn_KML_AVG.Name = "btn_KML_AVG";
            this.btn_KML_AVG.Size = new System.Drawing.Size(92, 34);
            this.btn_KML_AVG.TabIndex = 29;
            this.btn_KML_AVG.Text = "KML AVG";
            this.btn_KML_AVG.UseVisualStyleBackColor = true;
            this.btn_KML_AVG.Click += new System.EventHandler(this.btn_KML_AVG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 593);
            this.Controls.Add(this.panel_fechas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Descargas Atmosféricas";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningZones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLightningsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightningStrikesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningByDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLightningsByDayBindingSource)).EndInit();
            this.panel_fechas.ResumeLayout(false);
            this.panel_fechas.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllLightningsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLightningsByMonthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightningStrikesDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_Inicial;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_cooperativa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_lightningZones;
        private System.Windows.Forms.Button btn_KML_Descargas;
        private System.Windows.Forms.CheckBox Check3D;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_lightningByDay;
        private System.Windows.Forms.Button btn_CrearCSV;
        private System.Windows.Forms.BindingSource getLightningsBindingSource;
        private LightningStrikesDataSet lightningStrikesDataSet;
        private System.Windows.Forms.BindingSource countLightningsByDayBindingSource;
        private LightningStrikesDataSetTableAdapters.CountLightningsByDayTableAdapter countLightningsByDayTableAdapter;
        private LightningStrikesDataSetTableAdapters.GetLightningsTableAdapter getLightningsTableAdapter;
        private System.Windows.Forms.Label lbl_cargandoFechas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_fechas;
        private System.Windows.Forms.Panel panel_datos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_lightningByMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_lightningAll;
        private LightningStrikesDataSet lightningStrikesDataSet1;
        private LightningStrikesDataSetTableAdapters.CountLightningsByMonthTableAdapter countLightningsByMonthTableAdapter;
        private System.Windows.Forms.Button btn_crearKMLpoints;
        private System.Windows.Forms.BindingSource countLightningsByMonthBindingSource;
        private System.Windows.Forms.BindingSource getAllLightningsBindingSource;
        private LightningStrikesDataSetTableAdapters.GetAllLightningsTableAdapter getAllLightningsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amplitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cargarDatosZonas;
        private System.Windows.Forms.Label lbl_cargandoZonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVG_Amp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAX_Amp;
        private System.Windows.Forms.Button btn_KML_AVG;
    }
}

