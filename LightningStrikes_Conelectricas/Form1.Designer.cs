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
            this.dgv_lightning1 = new System.Windows.Forms.DataGridView();
            this.cantidadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getLightningsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lightningStrikesDataSet = new LightningStrikes_Conelectricas.LightningStrikesDataSet();
            this.btn_createKML = new System.Windows.Forms.Button();
            this.Check3D = new System.Windows.Forms.CheckBox();
            this.btn_MesActual = new System.Windows.Forms.Button();
            this.btn_mesAtras = new System.Windows.Forms.Button();
            this.btn_mesAdelante = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_lightningByDay = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countLightningsByDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_CrearCSV = new System.Windows.Forms.Button();
            this.countLightningsByDayTableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.CountLightningsByDayTableAdapter();
            this.getLightningsTableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.GetLightningsTableAdapter();
            this.lbl_cargando = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_fechas = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_diaAtras = new System.Windows.Forms.Button();
            this.btn_diaUltimo = new System.Windows.Forms.Button();
            this.btn_diaAdelante = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_datos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightning1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLightningsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightningStrikesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningByDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLightningsByDayBindingSource)).BeginInit();
            this.panel_fechas.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LightningStrikes_Conelectricas.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_Inicial
            // 
            this.dtp_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Inicial.Location = new System.Drawing.Point(47, 24);
            this.dtp_Inicial.Name = "dtp_Inicial";
            this.dtp_Inicial.Size = new System.Drawing.Size(115, 20);
            this.dtp_Inicial.TabIndex = 1;
            this.dtp_Inicial.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtp_Inicial.ValueChanged += new System.EventHandler(this.dtp_Inicial_ValueChanged);
            // 
            // dtp_final
            // 
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(256, 24);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(115, 20);
            this.dtp_final.TabIndex = 2;
            this.dtp_final.ValueChanged += new System.EventHandler(this.dtp_final_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial  >=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final  <";
            // 
            // cb_cooperativa
            // 
            this.cb_cooperativa.FormattingEnabled = true;
            this.cb_cooperativa.Location = new System.Drawing.Point(22, 47);
            this.cb_cooperativa.Name = "cb_cooperativa";
            this.cb_cooperativa.Size = new System.Drawing.Size(210, 21);
            this.cb_cooperativa.TabIndex = 5;
//            this.cb_cooperativa.SelectedIndexChanged += new System.EventHandler(this.cb_cooperativa_SelectedIndexChanged);
            this.cb_cooperativa.SelectionChangeCommitted += new System.EventHandler(this.cb_cooperativa_SelectionChangeCommitted);
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lugar";
            // 
            // dgv_lightning1
            // 
            this.dgv_lightning1.AllowUserToAddRows = false;
            this.dgv_lightning1.AllowUserToDeleteRows = false;
            this.dgv_lightning1.AllowUserToResizeColumns = false;
            this.dgv_lightning1.AllowUserToResizeRows = false;
            this.dgv_lightning1.AutoGenerateColumns = false;
            this.dgv_lightning1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lightning1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidadDataGridViewTextBoxColumn1,
            this.latitudDataGridViewTextBoxColumn,
            this.longitudDataGridViewTextBoxColumn});
            this.dgv_lightning1.DataSource = this.getLightningsBindingSource;
            this.dgv_lightning1.Location = new System.Drawing.Point(301, 60);
            this.dgv_lightning1.Name = "dgv_lightning1";
            this.dgv_lightning1.ReadOnly = true;
            this.dgv_lightning1.Size = new System.Drawing.Size(363, 420);
            this.dgv_lightning1.TabIndex = 7;
            // 
            // cantidadDataGridViewTextBoxColumn1
            // 
            this.cantidadDataGridViewTextBoxColumn1.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn1.Name = "cantidadDataGridViewTextBoxColumn1";
            this.cantidadDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // latitudDataGridViewTextBoxColumn
            // 
            this.latitudDataGridViewTextBoxColumn.DataPropertyName = "Latitud";
            this.latitudDataGridViewTextBoxColumn.HeaderText = "Latitud";
            this.latitudDataGridViewTextBoxColumn.Name = "latitudDataGridViewTextBoxColumn";
            this.latitudDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // longitudDataGridViewTextBoxColumn
            // 
            this.longitudDataGridViewTextBoxColumn.DataPropertyName = "Longitud";
            this.longitudDataGridViewTextBoxColumn.HeaderText = "Longitud";
            this.longitudDataGridViewTextBoxColumn.Name = "longitudDataGridViewTextBoxColumn";
            this.longitudDataGridViewTextBoxColumn.ReadOnly = true;
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
            // btn_createKML
            // 
            this.btn_createKML.Location = new System.Drawing.Point(330, 499);
            this.btn_createKML.Name = "btn_createKML";
            this.btn_createKML.Size = new System.Drawing.Size(334, 34);
            this.btn_createKML.TabIndex = 8;
            this.btn_createKML.Text = "Crear KML";
            this.btn_createKML.UseVisualStyleBackColor = true;
            this.btn_createKML.Click += new System.EventHandler(this.btn_createKML_Click);
            // 
            // Check3D
            // 
            this.Check3D.AutoSize = true;
            this.Check3D.Checked = true;
            this.Check3D.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check3D.Location = new System.Drawing.Point(306, 519);
            this.Check3D.Name = "Check3D";
            this.Check3D.Size = new System.Drawing.Size(15, 14);
            this.Check3D.TabIndex = 9;
            this.Check3D.UseVisualStyleBackColor = true;
            // 
            // btn_MesActual
            // 
            this.btn_MesActual.Location = new System.Drawing.Point(69, 6);
            this.btn_MesActual.Name = "btn_MesActual";
            this.btn_MesActual.Size = new System.Drawing.Size(74, 20);
            this.btn_MesActual.TabIndex = 11;
            this.btn_MesActual.Text = "Ult. Mes";
            this.btn_MesActual.UseVisualStyleBackColor = true;
            this.btn_MesActual.Click += new System.EventHandler(this.btn_MesActual_Click);
            // 
            // btn_mesAtras
            // 
            this.btn_mesAtras.Location = new System.Drawing.Point(33, 6);
            this.btn_mesAtras.Name = "btn_mesAtras";
            this.btn_mesAtras.Size = new System.Drawing.Size(31, 20);
            this.btn_mesAtras.TabIndex = 12;
            this.btn_mesAtras.Text = "<<";
            this.btn_mesAtras.UseVisualStyleBackColor = true;
            this.btn_mesAtras.Click += new System.EventHandler(this.btn_mesAtras_Click);
            // 
            // btn_mesAdelante
            // 
            this.btn_mesAdelante.Location = new System.Drawing.Point(148, 6);
            this.btn_mesAdelante.Name = "btn_mesAdelante";
            this.btn_mesAdelante.Size = new System.Drawing.Size(31, 20);
            this.btn_mesAdelante.TabIndex = 13;
            this.btn_mesAdelante.Text = ">>";
            this.btn_mesAdelante.UseVisualStyleBackColor = true;
            this.btn_mesAdelante.Click += new System.EventHandler(this.btn_mesAdelante_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(303, 503);
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
            this.cantidadDataGridViewTextBoxColumn});
            this.dgv_lightningByDay.DataSource = this.countLightningsByDayBindingSource;
            this.dgv_lightningByDay.Location = new System.Drawing.Point(17, 60);
            this.dgv_lightningByDay.Name = "dgv_lightningByDay";
            this.dgv_lightningByDay.ReadOnly = true;
            this.dgv_lightningByDay.Size = new System.Drawing.Size(261, 420);
            this.dgv_lightningByDay.TabIndex = 18;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countLightningsByDayBindingSource
            // 
            this.countLightningsByDayBindingSource.DataMember = "CountLightningsByDay";
            this.countLightningsByDayBindingSource.DataSource = this.lightningStrikesDataSet;
            // 
            // btn_CrearCSV
            // 
            this.btn_CrearCSV.Location = new System.Drawing.Point(17, 499);
            this.btn_CrearCSV.Name = "btn_CrearCSV";
            this.btn_CrearCSV.Size = new System.Drawing.Size(261, 34);
            this.btn_CrearCSV.TabIndex = 19;
            this.btn_CrearCSV.Text = "Crear CSV";
            this.btn_CrearCSV.UseVisualStyleBackColor = true;
            this.btn_CrearCSV.Click += new System.EventHandler(this.btn_CrearCSV_Click);
            // 
            // countLightningsByDayTableAdapter
            // 
            this.countLightningsByDayTableAdapter.ClearBeforeFill = true;
            // 
            // getLightningsTableAdapter
            // 
            this.getLightningsTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_cargando
            // 
            this.lbl_cargando.AutoSize = true;
            this.lbl_cargando.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cargando.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_cargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargando.ForeColor = System.Drawing.Color.Red;
            this.lbl_cargando.Location = new System.Drawing.Point(98, 257);
            this.lbl_cargando.Name = "lbl_cargando";
            this.lbl_cargando.Size = new System.Drawing.Size(474, 78);
            this.lbl_cargando.TabIndex = 20;
            this.lbl_cargando.Text = "Cargando ......";
            this.lbl_cargando.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Descargas por fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Descargas por ubicación";
            // 
            // panel_fechas
            // 
            this.panel_fechas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_fechas.Controls.Add(this.panel3);
            this.panel_fechas.Controls.Add(this.panel2);
            this.panel_fechas.Controls.Add(this.panel1);
            this.panel_fechas.Location = new System.Drawing.Point(16, 120);
            this.panel_fechas.Name = "panel_fechas";
            this.panel_fechas.Size = new System.Drawing.Size(685, 96);
            this.panel_fechas.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cb_cooperativa);
            this.panel3.Location = new System.Drawing.Point(431, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 88);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_MesActual);
            this.panel2.Controls.Add(this.btn_diaAtras);
            this.panel2.Controls.Add(this.btn_mesAdelante);
            this.panel2.Controls.Add(this.btn_mesAtras);
            this.panel2.Controls.Add(this.btn_diaUltimo);
            this.panel2.Controls.Add(this.btn_diaAdelante);
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 34);
            this.panel2.TabIndex = 26;
            // 
            // btn_diaAtras
            // 
            this.btn_diaAtras.Location = new System.Drawing.Point(242, 7);
            this.btn_diaAtras.Name = "btn_diaAtras";
            this.btn_diaAtras.Size = new System.Drawing.Size(31, 20);
            this.btn_diaAtras.TabIndex = 15;
            this.btn_diaAtras.Text = "<";
            this.btn_diaAtras.UseVisualStyleBackColor = true;
            this.btn_diaAtras.Click += new System.EventHandler(this.btn_diaAtras_Click);
            // 
            // btn_diaUltimo
            // 
            this.btn_diaUltimo.Location = new System.Drawing.Point(278, 7);
            this.btn_diaUltimo.Name = "btn_diaUltimo";
            this.btn_diaUltimo.Size = new System.Drawing.Size(74, 20);
            this.btn_diaUltimo.TabIndex = 14;
            this.btn_diaUltimo.Text = "Ult. Dia";
            this.btn_diaUltimo.UseVisualStyleBackColor = true;
            this.btn_diaUltimo.Click += new System.EventHandler(this.btn_diaUltimo_Click);
            // 
            // btn_diaAdelante
            // 
            this.btn_diaAdelante.Location = new System.Drawing.Point(357, 7);
            this.btn_diaAdelante.Name = "btn_diaAdelante";
            this.btn_diaAdelante.Size = new System.Drawing.Size(31, 20);
            this.btn_diaAdelante.TabIndex = 16;
            this.btn_diaAdelante.Text = ">";
            this.btn_diaAdelante.UseVisualStyleBackColor = true;
            this.btn_diaAdelante.Click += new System.EventHandler(this.btn_diaAdelante_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtp_Inicial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp_final);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 48);
            this.panel1.TabIndex = 26;
            // 
            // panel_datos
            // 
            this.panel_datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_datos.Controls.Add(this.dgv_lightningByDay);
            this.panel_datos.Controls.Add(this.dgv_lightning1);
            this.panel_datos.Controls.Add(this.btn_createKML);
            this.panel_datos.Controls.Add(this.label6);
            this.panel_datos.Controls.Add(this.Check3D);
            this.panel_datos.Controls.Add(this.label5);
            this.panel_datos.Controls.Add(this.label4);
            this.panel_datos.Controls.Add(this.lbl_cargando);
            this.panel_datos.Controls.Add(this.btn_CrearCSV);
            this.panel_datos.Location = new System.Drawing.Point(16, 222);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.Size = new System.Drawing.Size(685, 554);
            this.panel_datos.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 792);
            this.Controls.Add(this.panel_datos);
            this.Controls.Add(this.panel_fechas);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Descargas Atmosféricas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightning1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLightningsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightningStrikesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightningByDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countLightningsByDayBindingSource)).EndInit();
            this.panel_fechas.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgv_lightning1;
        private System.Windows.Forms.Button btn_createKML;
        private System.Windows.Forms.CheckBox Check3D;
        private System.Windows.Forms.Button btn_MesActual;
        private System.Windows.Forms.Button btn_mesAtras;
        private System.Windows.Forms.Button btn_mesAdelante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_lightningByDay;
        private System.Windows.Forms.Button btn_CrearCSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getLightningsBindingSource;
        private LightningStrikesDataSet lightningStrikesDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource countLightningsByDayBindingSource;
        private LightningStrikesDataSetTableAdapters.CountLightningsByDayTableAdapter countLightningsByDayTableAdapter;
        private LightningStrikesDataSetTableAdapters.GetLightningsTableAdapter getLightningsTableAdapter;
        private System.Windows.Forms.Label lbl_cargando;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_fechas;
        private System.Windows.Forms.Panel panel_datos;
        private System.Windows.Forms.Button btn_diaAtras;
        private System.Windows.Forms.Button btn_diaUltimo;
        private System.Windows.Forms.Button btn_diaAdelante;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

