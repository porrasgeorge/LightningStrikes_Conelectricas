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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPorDia = new System.Windows.Forms.TabPage();
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
            this.tabConteo = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_cooperativaArea = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_KML_MAX = new System.Windows.Forms.Button();
            this.btn_KML_AVG = new System.Windows.Forms.Button();
            this.lbl_cargandoZonas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabBorders = new System.Windows.Forms.TabPage();
            this.btn_ActualizarBordes = new System.Windows.Forms.Button();
            this.txt_RIGHT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_UP = new System.Windows.Forms.TextBox();
            this.dtp_FinalBordes = new System.Windows.Forms.DateTimePicker();
            this.txt_LOW = new System.Windows.Forms.TextBox();
            this.dtp_InicialBordes = new System.Windows.Forms.DateTimePicker();
            this.txt_LEFT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Actualizar = new System.Windows.Forms.Label();
            this.lbl_TotalRegistros = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_cargandoBordes = new System.Windows.Forms.Label();
            this.dgv_lightningsBorders = new System.Windows.Forms.DataGridView();
            this.fechaHoraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amplitudDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getAllLightningsByBoundsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_CrearKmlBordes = new System.Windows.Forms.Button();
            this.tabSubir = new System.Windows.Forms.TabPage();
            this.pb_completado = new System.Windows.Forms.ProgressBar();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.lbl_fechaArchivo = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dgv_LightningsByDayP6 = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countLightningsByDayP6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lightningStrikesDataSet2 = new LightningStrikes_Conelectricas.LightningStrikesDataSet();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.btn_GuardarDB = new System.Windows.Forms.Button();
            this.btn_leer = new System.Windows.Forms.Button();
            this.lbl_etiquetaCorrecta = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.countLightningsByDayP6TableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.CountLightningsByDayP6TableAdapter();
            this.countLightningsByDayTableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.CountLightningsByDayTableAdapter();
            this.getLightningsTableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.GetLightningsTableAdapter();
            this.lightningStrikesDataSet1 = new LightningStrikes_Conelectricas.LightningStrikesDataSet();
            this.countLightningsByMonthTableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.CountLightningsByMonthTableAdapter();
            this.getAllLightningsTableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.GetAllLightningsTableAdapter();
            this.getAllLightningsByBoundsTableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.GetAllLightningsByBoundsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningZones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLightningsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightningStrikesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningByDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLightningsByDayBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPorDia.SuspendLayout();
            this.panel_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllLightningsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLightningsByMonthBindingSource)).BeginInit();
            this.tabConteo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabBorders.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningsBorders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllLightningsByBoundsBindingSource)).BeginInit();
            this.tabSubir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LightningsByDayP6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLightningsByDayP6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightningStrikesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightningStrikesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LightningStrikes_Conelectricas.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_Inicial
            // 
            this.dtp_Inicial.CustomFormat = "";
            this.dtp_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Inicial.Location = new System.Drawing.Point(238, 31);
            this.dtp_Inicial.Name = "dtp_Inicial";
            this.dtp_Inicial.Size = new System.Drawing.Size(115, 20);
            this.dtp_Inicial.TabIndex = 1;
            this.dtp_Inicial.ValueChanged += new System.EventHandler(this.dtp_Inicial_ValueChanged);
            // 
            // dtp_final
            // 
            this.dtp_final.CustomFormat = "";
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(239, 70);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(115, 20);
            this.dtp_final.TabIndex = 2;
            this.dtp_final.ValueChanged += new System.EventHandler(this.dtp_final_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial  >=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final  <";
            // 
            // cb_cooperativa
            // 
            this.cb_cooperativa.FormattingEnabled = true;
            this.cb_cooperativa.Location = new System.Drawing.Point(110, 50);
            this.cb_cooperativa.Name = "cb_cooperativa";
            this.cb_cooperativa.Size = new System.Drawing.Size(186, 21);
            this.cb_cooperativa.TabIndex = 5;
            this.cb_cooperativa.SelectionChangeCommitted += new System.EventHandler(this.cb_cooperativa_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
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
            this.dgv_lightningZones.Location = new System.Drawing.Point(15, 46);
            this.dgv_lightningZones.Name = "dgv_lightningZones";
            this.dgv_lightningZones.ReadOnly = true;
            this.dgv_lightningZones.RowHeadersVisible = false;
            this.dgv_lightningZones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lightningZones.Size = new System.Drawing.Size(350, 373);
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
            this.dgv_lightningByDay.Size = new System.Drawing.Size(164, 185);
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
            this.btn_CrearCSV.Location = new System.Drawing.Point(16, 469);
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
            this.lbl_cargandoFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargandoFechas.ForeColor = System.Drawing.Color.Red;
            this.lbl_cargandoFechas.Location = new System.Drawing.Point(44, 358);
            this.lbl_cargandoFechas.Name = "lbl_cargandoFechas";
            this.lbl_cargandoFechas.Size = new System.Drawing.Size(270, 44);
            this.lbl_cargandoFechas.TabIndex = 20;
            this.lbl_cargandoFechas.Text = "Cargando ......";
            this.lbl_cargandoFechas.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Descargas diarias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Descargas por ubicación";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPorDia);
            this.tabControl1.Controls.Add(this.tabConteo);
            this.tabControl1.Controls.Add(this.tabBorders);
            this.tabControl1.Controls.Add(this.tabSubir);
            this.tabControl1.Location = new System.Drawing.Point(26, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 658);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPorDia
            // 
            this.tabPorDia.Controls.Add(this.panel_datos);
            this.tabPorDia.Controls.Add(this.label3);
            this.tabPorDia.Controls.Add(this.cb_cooperativa);
            this.tabPorDia.Location = new System.Drawing.Point(4, 22);
            this.tabPorDia.Name = "tabPorDia";
            this.tabPorDia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorDia.Size = new System.Drawing.Size(404, 632);
            this.tabPorDia.TabIndex = 0;
            this.tabPorDia.Text = "Diario";
            this.tabPorDia.UseVisualStyleBackColor = true;
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
            this.panel_datos.Location = new System.Drawing.Point(10, 110);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(390, 520);
            this.panel_datos.TabIndex = 25;
            // 
            // btn_crearKMLpoints
            // 
            this.btn_crearKMLpoints.Location = new System.Drawing.Point(219, 469);
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
            this.dgv_lightningAll.Location = new System.Drawing.Point(16, 256);
            this.dgv_lightningAll.MultiSelect = false;
            this.dgv_lightningAll.Name = "dgv_lightningAll";
            this.dgv_lightningAll.ReadOnly = true;
            this.dgv_lightningAll.RowHeadersVisible = false;
            this.dgv_lightningAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lightningAll.Size = new System.Drawing.Size(350, 207);
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
            this.dgv_lightningByMonth.Size = new System.Drawing.Size(150, 185);
            this.dgv_lightningByMonth.TabIndex = 23;
            this.dgv_lightningByMonth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lightningByMonth_CellClick);
            this.dgv_lightningByMonth.Sorted += new System.EventHandler(this.dgv_lightningByMonth_Sorted);
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
            this.label7.Location = new System.Drawing.Point(12, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Descargas mensuales";
            // 
            // tabConteo
            // 
            this.tabConteo.Controls.Add(this.label2);
            this.tabConteo.Controls.Add(this.dtp_final);
            this.tabConteo.Controls.Add(this.dtp_Inicial);
            this.tabConteo.Controls.Add(this.label9);
            this.tabConteo.Controls.Add(this.label1);
            this.tabConteo.Controls.Add(this.cb_cooperativaArea);
            this.tabConteo.Controls.Add(this.panel2);
            this.tabConteo.Location = new System.Drawing.Point(4, 22);
            this.tabConteo.Name = "tabConteo";
            this.tabConteo.Padding = new System.Windows.Forms.Padding(3);
            this.tabConteo.Size = new System.Drawing.Size(404, 632);
            this.tabConteo.TabIndex = 1;
            this.tabConteo.Text = "Areas";
            this.tabConteo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Cooperativa";
            // 
            // cb_cooperativaArea
            // 
            this.cb_cooperativaArea.FormattingEnabled = true;
            this.cb_cooperativaArea.Location = new System.Drawing.Point(41, 56);
            this.cb_cooperativaArea.Name = "cb_cooperativaArea";
            this.cb_cooperativaArea.Size = new System.Drawing.Size(130, 21);
            this.cb_cooperativaArea.TabIndex = 27;
            this.cb_cooperativaArea.SelectionChangeCommitted += new System.EventHandler(this.cb_cooperativaArea_SelectionChangeCommitted);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_KML_MAX);
            this.panel2.Controls.Add(this.btn_KML_AVG);
            this.panel2.Controls.Add(this.lbl_cargandoZonas);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dgv_lightningZones);
            this.panel2.Controls.Add(this.btn_KML_Descargas);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Check3D);
            this.panel2.Location = new System.Drawing.Point(10, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 520);
            this.panel2.TabIndex = 26;
            // 
            // btn_KML_MAX
            // 
            this.btn_KML_MAX.Location = new System.Drawing.Point(269, 425);
            this.btn_KML_MAX.Name = "btn_KML_MAX";
            this.btn_KML_MAX.Size = new System.Drawing.Size(92, 34);
            this.btn_KML_MAX.TabIndex = 30;
            this.btn_KML_MAX.Text = "KML MAX";
            this.btn_KML_MAX.UseVisualStyleBackColor = true;
            this.btn_KML_MAX.Click += new System.EventHandler(this.btn_KML_MAX_Click);
            // 
            // btn_KML_AVG
            // 
            this.btn_KML_AVG.Location = new System.Drawing.Point(158, 425);
            this.btn_KML_AVG.Name = "btn_KML_AVG";
            this.btn_KML_AVG.Size = new System.Drawing.Size(92, 34);
            this.btn_KML_AVG.TabIndex = 29;
            this.btn_KML_AVG.Text = "KML AVG";
            this.btn_KML_AVG.UseVisualStyleBackColor = true;
            this.btn_KML_AVG.Click += new System.EventHandler(this.btn_KML_AVG_Click);
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
            this.label8.Location = new System.Drawing.Point(11, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Datos por Zonas";
            // 
            // tabBorders
            // 
            this.tabBorders.Controls.Add(this.btn_ActualizarBordes);
            this.tabBorders.Controls.Add(this.txt_RIGHT);
            this.tabBorders.Controls.Add(this.label10);
            this.tabBorders.Controls.Add(this.txt_UP);
            this.tabBorders.Controls.Add(this.dtp_FinalBordes);
            this.tabBorders.Controls.Add(this.txt_LOW);
            this.tabBorders.Controls.Add(this.dtp_InicialBordes);
            this.tabBorders.Controls.Add(this.txt_LEFT);
            this.tabBorders.Controls.Add(this.label11);
            this.tabBorders.Controls.Add(this.label12);
            this.tabBorders.Controls.Add(this.panel3);
            this.tabBorders.Location = new System.Drawing.Point(4, 22);
            this.tabBorders.Name = "tabBorders";
            this.tabBorders.Size = new System.Drawing.Size(404, 632);
            this.tabBorders.TabIndex = 2;
            this.tabBorders.Text = "Fronteras";
            this.tabBorders.UseVisualStyleBackColor = true;
            // 
            // btn_ActualizarBordes
            // 
            this.btn_ActualizarBordes.Location = new System.Drawing.Point(40, 76);
            this.btn_ActualizarBordes.Name = "btn_ActualizarBordes";
            this.btn_ActualizarBordes.Size = new System.Drawing.Size(151, 27);
            this.btn_ActualizarBordes.TabIndex = 31;
            this.btn_ActualizarBordes.Text = "Actualizar";
            this.btn_ActualizarBordes.UseMnemonic = false;
            this.btn_ActualizarBordes.UseVisualStyleBackColor = true;
            this.btn_ActualizarBordes.Click += new System.EventHandler(this.btn_ActualizarBordes_Click);
            // 
            // txt_RIGHT
            // 
            this.txt_RIGHT.Location = new System.Drawing.Point(144, 31);
            this.txt_RIGHT.Name = "txt_RIGHT";
            this.txt_RIGHT.Size = new System.Drawing.Size(47, 20);
            this.txt_RIGHT.TabIndex = 38;
            this.txt_RIGHT.Text = "-84";
            this.txt_RIGHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_RIGHT.TextChanged += new System.EventHandler(this.txt_RIGHT_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Fecha Final  <";
            // 
            // txt_UP
            // 
            this.txt_UP.Location = new System.Drawing.Point(91, 10);
            this.txt_UP.Name = "txt_UP";
            this.txt_UP.Size = new System.Drawing.Size(47, 20);
            this.txt_UP.TabIndex = 36;
            this.txt_UP.Text = "11";
            this.txt_UP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_UP.TextChanged += new System.EventHandler(this.txt_UP_TextChanged);
            // 
            // dtp_FinalBordes
            // 
            this.dtp_FinalBordes.CustomFormat = "";
            this.dtp_FinalBordes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FinalBordes.Location = new System.Drawing.Point(258, 75);
            this.dtp_FinalBordes.Name = "dtp_FinalBordes";
            this.dtp_FinalBordes.Size = new System.Drawing.Size(115, 20);
            this.dtp_FinalBordes.TabIndex = 30;
            this.dtp_FinalBordes.ValueChanged += new System.EventHandler(this.dtp_FinalBordes_ValueChanged);
            // 
            // txt_LOW
            // 
            this.txt_LOW.Location = new System.Drawing.Point(93, 50);
            this.txt_LOW.Name = "txt_LOW";
            this.txt_LOW.Size = new System.Drawing.Size(47, 20);
            this.txt_LOW.TabIndex = 37;
            this.txt_LOW.Text = "10";
            this.txt_LOW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_LOW.TextChanged += new System.EventHandler(this.txt_LOW_TextChanged);
            // 
            // dtp_InicialBordes
            // 
            this.dtp_InicialBordes.CustomFormat = "";
            this.dtp_InicialBordes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_InicialBordes.Location = new System.Drawing.Point(258, 35);
            this.dtp_InicialBordes.Name = "dtp_InicialBordes";
            this.dtp_InicialBordes.Size = new System.Drawing.Size(115, 20);
            this.dtp_InicialBordes.TabIndex = 29;
            this.dtp_InicialBordes.ValueChanged += new System.EventHandler(this.dtp_InicialBordes_ValueChanged);
            // 
            // txt_LEFT
            // 
            this.txt_LEFT.Location = new System.Drawing.Point(40, 31);
            this.txt_LEFT.Name = "txt_LEFT";
            this.txt_LEFT.Size = new System.Drawing.Size(47, 20);
            this.txt_LEFT.TabIndex = 35;
            this.txt_LEFT.Text = "-85";
            this.txt_LEFT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_LEFT.TextChanged += new System.EventHandler(this.txt_LEFT_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 18);
            this.label11.TabIndex = 34;
            this.label11.Text = "Limites";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(279, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Fecha Inicial  >=";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_Actualizar);
            this.panel3.Controls.Add(this.lbl_TotalRegistros);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lbl_cargandoBordes);
            this.panel3.Controls.Add(this.dgv_lightningsBorders);
            this.panel3.Controls.Add(this.btn_CrearKmlBordes);
            this.panel3.Location = new System.Drawing.Point(10, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 520);
            this.panel3.TabIndex = 26;
            // 
            // lbl_Actualizar
            // 
            this.lbl_Actualizar.AutoSize = true;
            this.lbl_Actualizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Actualizar.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Actualizar.Location = new System.Drawing.Point(110, 179);
            this.lbl_Actualizar.Name = "lbl_Actualizar";
            this.lbl_Actualizar.Size = new System.Drawing.Size(171, 39);
            this.lbl_Actualizar.TabIndex = 35;
            this.lbl_Actualizar.Text = "Actualizar";
            this.lbl_Actualizar.Visible = false;
            // 
            // lbl_TotalRegistros
            // 
            this.lbl_TotalRegistros.AutoSize = true;
            this.lbl_TotalRegistros.Location = new System.Drawing.Point(118, 31);
            this.lbl_TotalRegistros.Name = "lbl_TotalRegistros";
            this.lbl_TotalRegistros.Size = new System.Drawing.Size(13, 13);
            this.lbl_TotalRegistros.TabIndex = 34;
            this.lbl_TotalRegistros.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Total de Registros";
            // 
            // lbl_cargandoBordes
            // 
            this.lbl_cargandoBordes.AutoSize = true;
            this.lbl_cargandoBordes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cargandoBordes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_cargandoBordes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargandoBordes.ForeColor = System.Drawing.Color.Red;
            this.lbl_cargandoBordes.Location = new System.Drawing.Point(75, 218);
            this.lbl_cargandoBordes.Name = "lbl_cargandoBordes";
            this.lbl_cargandoBordes.Size = new System.Drawing.Size(239, 39);
            this.lbl_cargandoBordes.TabIndex = 32;
            this.lbl_cargandoBordes.Text = "Cargando ......";
            this.lbl_cargandoBordes.Visible = false;
            // 
            // dgv_lightningsBorders
            // 
            this.dgv_lightningsBorders.AllowUserToAddRows = false;
            this.dgv_lightningsBorders.AllowUserToDeleteRows = false;
            this.dgv_lightningsBorders.AutoGenerateColumns = false;
            this.dgv_lightningsBorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lightningsBorders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaHoraDataGridViewTextBoxColumn1,
            this.longitudDataGridViewTextBoxColumn2,
            this.latitudDataGridViewTextBoxColumn2,
            this.amplitudDataGridViewTextBoxColumn1});
            this.dgv_lightningsBorders.DataSource = this.getAllLightningsByBoundsBindingSource;
            this.dgv_lightningsBorders.Location = new System.Drawing.Point(22, 47);
            this.dgv_lightningsBorders.Name = "dgv_lightningsBorders";
            this.dgv_lightningsBorders.ReadOnly = true;
            this.dgv_lightningsBorders.RowHeadersVisible = false;
            this.dgv_lightningsBorders.Size = new System.Drawing.Size(350, 400);
            this.dgv_lightningsBorders.TabIndex = 31;
            // 
            // fechaHoraDataGridViewTextBoxColumn1
            // 
            this.fechaHoraDataGridViewTextBoxColumn1.DataPropertyName = "Fecha_Hora";
            this.fechaHoraDataGridViewTextBoxColumn1.HeaderText = "Fecha_Hora";
            this.fechaHoraDataGridViewTextBoxColumn1.Name = "fechaHoraDataGridViewTextBoxColumn1";
            this.fechaHoraDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaHoraDataGridViewTextBoxColumn1.Width = 120;
            // 
            // longitudDataGridViewTextBoxColumn2
            // 
            this.longitudDataGridViewTextBoxColumn2.DataPropertyName = "Longitud";
            this.longitudDataGridViewTextBoxColumn2.HeaderText = "Longitud";
            this.longitudDataGridViewTextBoxColumn2.Name = "longitudDataGridViewTextBoxColumn2";
            this.longitudDataGridViewTextBoxColumn2.ReadOnly = true;
            this.longitudDataGridViewTextBoxColumn2.Width = 70;
            // 
            // latitudDataGridViewTextBoxColumn2
            // 
            this.latitudDataGridViewTextBoxColumn2.DataPropertyName = "Latitud";
            this.latitudDataGridViewTextBoxColumn2.HeaderText = "Latitud";
            this.latitudDataGridViewTextBoxColumn2.Name = "latitudDataGridViewTextBoxColumn2";
            this.latitudDataGridViewTextBoxColumn2.ReadOnly = true;
            this.latitudDataGridViewTextBoxColumn2.Width = 70;
            // 
            // amplitudDataGridViewTextBoxColumn1
            // 
            this.amplitudDataGridViewTextBoxColumn1.DataPropertyName = "Amplitud";
            this.amplitudDataGridViewTextBoxColumn1.HeaderText = "Amplitud";
            this.amplitudDataGridViewTextBoxColumn1.Name = "amplitudDataGridViewTextBoxColumn1";
            this.amplitudDataGridViewTextBoxColumn1.ReadOnly = true;
            this.amplitudDataGridViewTextBoxColumn1.Width = 50;
            // 
            // getAllLightningsByBoundsBindingSource
            // 
            this.getAllLightningsByBoundsBindingSource.DataMember = "GetAllLightningsByBounds";
            this.getAllLightningsByBoundsBindingSource.DataSource = this.lightningStrikesDataSet;
            // 
            // btn_CrearKmlBordes
            // 
            this.btn_CrearKmlBordes.Location = new System.Drawing.Point(22, 453);
            this.btn_CrearKmlBordes.Name = "btn_CrearKmlBordes";
            this.btn_CrearKmlBordes.Size = new System.Drawing.Size(350, 34);
            this.btn_CrearKmlBordes.TabIndex = 30;
            this.btn_CrearKmlBordes.Text = "Crear KML";
            this.btn_CrearKmlBordes.UseVisualStyleBackColor = true;
            this.btn_CrearKmlBordes.Click += new System.EventHandler(this.btn_CrearKmlBordes_Click);
            // 
            // tabSubir
            // 
            this.tabSubir.Controls.Add(this.pb_completado);
            this.tabSubir.Controls.Add(this.lbl_progress);
            this.tabSubir.Controls.Add(this.lbl_fechaArchivo);
            this.tabSubir.Controls.Add(this.btn_actualizar);
            this.tabSubir.Controls.Add(this.label15);
            this.tabSubir.Controls.Add(this.dgv_LightningsByDayP6);
            this.tabSubir.Controls.Add(this.txt_log);
            this.tabSubir.Controls.Add(this.btn_GuardarDB);
            this.tabSubir.Controls.Add(this.btn_leer);
            this.tabSubir.Controls.Add(this.lbl_etiquetaCorrecta);
            this.tabSubir.Controls.Add(this.label14);
            this.tabSubir.Location = new System.Drawing.Point(4, 22);
            this.tabSubir.Name = "tabSubir";
            this.tabSubir.Size = new System.Drawing.Size(404, 632);
            this.tabSubir.TabIndex = 3;
            this.tabSubir.Text = "Subir Datos";
            this.tabSubir.UseVisualStyleBackColor = true;
            // 
            // pb_completado
            // 
            this.pb_completado.Location = new System.Drawing.Point(37, 130);
            this.pb_completado.Name = "pb_completado";
            this.pb_completado.Size = new System.Drawing.Size(312, 23);
            this.pb_completado.TabIndex = 25;
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Location = new System.Drawing.Point(16, 199);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(13, 13);
            this.lbl_progress.TabIndex = 24;
            this.lbl_progress.Text = "--";
            // 
            // lbl_fechaArchivo
            // 
            this.lbl_fechaArchivo.AutoSize = true;
            this.lbl_fechaArchivo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaArchivo.ForeColor = System.Drawing.Color.Red;
            this.lbl_fechaArchivo.Location = new System.Drawing.Point(188, 4);
            this.lbl_fechaArchivo.Name = "lbl_fechaArchivo";
            this.lbl_fechaArchivo.Size = new System.Drawing.Size(22, 21);
            this.lbl_fechaArchivo.TabIndex = 23;
            this.lbl_fechaArchivo.Text = "--";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(287, 256);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(82, 24);
            this.btn_actualizar.TabIndex = 22;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Datos Cargados en DB";
            // 
            // dgv_LightningsByDayP6
            // 
            this.dgv_LightningsByDayP6.AllowUserToAddRows = false;
            this.dgv_LightningsByDayP6.AllowUserToDeleteRows = false;
            this.dgv_LightningsByDayP6.AutoGenerateColumns = false;
            this.dgv_LightningsByDayP6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LightningsByDayP6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn1,
            this.cantidadDataGridViewTextBoxColumn3});
            this.dgv_LightningsByDayP6.DataSource = this.countLightningsByDayP6BindingSource;
            this.dgv_LightningsByDayP6.Location = new System.Drawing.Point(19, 286);
            this.dgv_LightningsByDayP6.Name = "dgv_LightningsByDayP6";
            this.dgv_LightningsByDayP6.ReadOnly = true;
            this.dgv_LightningsByDayP6.RowHeadersVisible = false;
            this.dgv_LightningsByDayP6.Size = new System.Drawing.Size(350, 329);
            this.dgv_LightningsByDayP6.TabIndex = 20;
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            this.fechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            this.fechaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn3
            // 
            this.cantidadDataGridViewTextBoxColumn3.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn3.Name = "cantidadDataGridViewTextBoxColumn3";
            this.cantidadDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // countLightningsByDayP6BindingSource
            // 
            this.countLightningsByDayP6BindingSource.DataMember = "CountLightningsByDayP6";
            this.countLightningsByDayP6BindingSource.DataSource = this.lightningStrikesDataSet2;
            // 
            // lightningStrikesDataSet2
            // 
            this.lightningStrikesDataSet2.DataSetName = "LightningStrikesDataSet";
            this.lightningStrikesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(19, 75);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(350, 121);
            this.txt_log.TabIndex = 16;
            this.txt_log.TabStop = false;
            // 
            // btn_GuardarDB
            // 
            this.btn_GuardarDB.Location = new System.Drawing.Point(161, 28);
            this.btn_GuardarDB.Name = "btn_GuardarDB";
            this.btn_GuardarDB.Size = new System.Drawing.Size(115, 24);
            this.btn_GuardarDB.TabIndex = 15;
            this.btn_GuardarDB.Text = "Guardar en BD";
            this.btn_GuardarDB.UseVisualStyleBackColor = true;
            this.btn_GuardarDB.Click += new System.EventHandler(this.btn_GuardarDB_Click);
            // 
            // btn_leer
            // 
            this.btn_leer.Location = new System.Drawing.Point(19, 28);
            this.btn_leer.Name = "btn_leer";
            this.btn_leer.Size = new System.Drawing.Size(115, 24);
            this.btn_leer.TabIndex = 14;
            this.btn_leer.Text = "Leer Archivo";
            this.btn_leer.UseVisualStyleBackColor = true;
            this.btn_leer.Click += new System.EventHandler(this.btn_leer_Click);
            // 
            // lbl_etiquetaCorrecta
            // 
            this.lbl_etiquetaCorrecta.AutoSize = true;
            this.lbl_etiquetaCorrecta.Location = new System.Drawing.Point(111, 12);
            this.lbl_etiquetaCorrecta.Name = "lbl_etiquetaCorrecta";
            this.lbl_etiquetaCorrecta.Size = new System.Drawing.Size(23, 13);
            this.lbl_etiquetaCorrecta.TabIndex = 6;
            this.lbl_etiquetaCorrecta.Text = "NO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Etiqueta Correcta";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // countLightningsByDayP6TableAdapter
            // 
            this.countLightningsByDayP6TableAdapter.ClearBeforeFill = true;
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
            // getAllLightningsByBoundsTableAdapter
            // 
            this.getAllLightningsByBoundsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 799);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPorDia.ResumeLayout(false);
            this.tabPorDia.PerformLayout();
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllLightningsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLightningsByMonthBindingSource)).EndInit();
            this.tabConteo.ResumeLayout(false);
            this.tabConteo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabBorders.ResumeLayout(false);
            this.tabBorders.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningsBorders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getAllLightningsByBoundsBindingSource)).EndInit();
            this.tabSubir.ResumeLayout(false);
            this.tabSubir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LightningsByDayP6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLightningsByDayP6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightningStrikesDataSet2)).EndInit();
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
        private System.Windows.Forms.Panel panel_datos;
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
        private System.Windows.Forms.Label lbl_cargandoZonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVG_Amp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAX_Amp;
        private System.Windows.Forms.Button btn_KML_AVG;
        private System.Windows.Forms.Button btn_KML_MAX;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPorDia;
        private System.Windows.Forms.TabPage tabConteo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_cooperativaArea;
        private System.Windows.Forms.TabPage tabBorders;
        private System.Windows.Forms.TabPage tabSubir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_FinalBordes;
        private System.Windows.Forms.DateTimePicker dtp_InicialBordes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_RIGHT;
        private System.Windows.Forms.TextBox txt_UP;
        private System.Windows.Forms.TextBox txt_LOW;
        private System.Windows.Forms.TextBox txt_LEFT;
        private System.Windows.Forms.Button btn_ActualizarBordes;
        private System.Windows.Forms.DataGridView dgv_lightningsBorders;
        private System.Windows.Forms.Button btn_CrearKmlBordes;
        private System.Windows.Forms.Label lbl_cargandoBordes;
        private System.Windows.Forms.BindingSource getAllLightningsByBoundsBindingSource;
        private LightningStrikesDataSetTableAdapters.GetAllLightningsByBoundsTableAdapter getAllLightningsByBoundsTableAdapter;
        private System.Windows.Forms.Label lbl_TotalRegistros;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_Actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amplitudDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ProgressBar pb_completado;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.Label lbl_fechaArchivo;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgv_LightningsByDayP6;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Button btn_GuardarDB;
        private System.Windows.Forms.Button btn_leer;
        private System.Windows.Forms.Label lbl_etiquetaCorrecta;
        private System.Windows.Forms.Label label14;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private LightningStrikesDataSet lightningStrikesDataSet2;
        private System.Windows.Forms.BindingSource countLightningsByDayP6BindingSource;
        private LightningStrikesDataSetTableAdapters.CountLightningsByDayP6TableAdapter countLightningsByDayP6TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn3;
    }
}

