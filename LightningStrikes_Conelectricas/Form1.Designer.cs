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
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getLightningsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lightningStrikesDataSet = new LightningStrikes_Conelectricas.LightningStrikesDataSet();
            this.getLightningsTableAdapter = new LightningStrikes_Conelectricas.LightningStrikesDataSetTableAdapters.GetLightningsTableAdapter();
            this.btn_createKML = new System.Windows.Forms.Button();
            this.Check3D = new System.Windows.Forms.CheckBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_MesActual = new System.Windows.Forms.Button();
            this.btn_mesAtras = new System.Windows.Forms.Button();
            this.btn_mesAdelante = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightning1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLightningsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightningStrikesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LightningStrikes_Conelectricas.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_Inicial
            // 
            this.dtp_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Inicial.Location = new System.Drawing.Point(90, 118);
            this.dtp_Inicial.Name = "dtp_Inicial";
            this.dtp_Inicial.Size = new System.Drawing.Size(115, 20);
            this.dtp_Inicial.TabIndex = 1;
            this.dtp_Inicial.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // dtp_final
            // 
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(90, 144);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(115, 20);
            this.dtp_final.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final";
            // 
            // cb_cooperativa
            // 
            this.cb_cooperativa.FormattingEnabled = true;
            this.cb_cooperativa.Location = new System.Drawing.Point(90, 170);
            this.cb_cooperativa.Name = "cb_cooperativa";
            this.cb_cooperativa.Size = new System.Drawing.Size(115, 21);
            this.cb_cooperativa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cooperativa";
            // 
            // dgv_lightning1
            // 
            this.dgv_lightning1.AllowUserToDeleteRows = false;
            this.dgv_lightning1.AutoGenerateColumns = false;
            this.dgv_lightning1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lightning1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidadDataGridViewTextBoxColumn,
            this.latitudDataGridViewTextBoxColumn,
            this.longitudDataGridViewTextBoxColumn});
            this.dgv_lightning1.DataSource = this.getLightningsBindingSource;
            this.dgv_lightning1.Location = new System.Drawing.Point(20, 237);
            this.dgv_lightning1.Name = "dgv_lightning1";
            this.dgv_lightning1.ReadOnly = true;
            this.dgv_lightning1.Size = new System.Drawing.Size(372, 526);
            this.dgv_lightning1.TabIndex = 7;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
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
            // getLightningsTableAdapter
            // 
            this.getLightningsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_createKML
            // 
            this.btn_createKML.Location = new System.Drawing.Point(243, 186);
            this.btn_createKML.Name = "btn_createKML";
            this.btn_createKML.Size = new System.Drawing.Size(118, 34);
            this.btn_createKML.TabIndex = 8;
            this.btn_createKML.Text = "Crear KML";
            this.btn_createKML.UseVisualStyleBackColor = true;
            this.btn_createKML.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // Check3D
            // 
            this.Check3D.AutoSize = true;
            this.Check3D.Location = new System.Drawing.Point(90, 202);
            this.Check3D.Name = "Check3D";
            this.Check3D.Size = new System.Drawing.Size(15, 14);
            this.Check3D.TabIndex = 9;
            this.Check3D.UseVisualStyleBackColor = true;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(119, 197);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(86, 23);
            this.btn_Consultar.TabIndex = 10;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click_1);
            // 
            // btn_MesActual
            // 
            this.btn_MesActual.Location = new System.Drawing.Point(243, 145);
            this.btn_MesActual.Name = "btn_MesActual";
            this.btn_MesActual.Size = new System.Drawing.Size(118, 35);
            this.btn_MesActual.TabIndex = 11;
            this.btn_MesActual.Text = "Ult. Mes";
            this.btn_MesActual.UseVisualStyleBackColor = true;
            this.btn_MesActual.Click += new System.EventHandler(this.btn_MesActual_Click);
            // 
            // btn_mesAtras
            // 
            this.btn_mesAtras.Location = new System.Drawing.Point(243, 116);
            this.btn_mesAtras.Name = "btn_mesAtras";
            this.btn_mesAtras.Size = new System.Drawing.Size(43, 23);
            this.btn_mesAtras.TabIndex = 12;
            this.btn_mesAtras.Text = "<<";
            this.btn_mesAtras.UseVisualStyleBackColor = true;
            this.btn_mesAtras.Click += new System.EventHandler(this.btn_mesAtras_Click);
            // 
            // btn_mesAdelante
            // 
            this.btn_mesAdelante.Location = new System.Drawing.Point(318, 116);
            this.btn_mesAdelante.Name = "btn_mesAdelante";
            this.btn_mesAdelante.Size = new System.Drawing.Size(43, 23);
            this.btn_mesAdelante.TabIndex = 13;
            this.btn_mesAdelante.Text = ">>";
            this.btn_mesAdelante.UseVisualStyleBackColor = true;
            this.btn_mesAdelante.Click += new System.EventHandler(this.btn_mesAdelante_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(63, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "3D";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 775);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_mesAdelante);
            this.Controls.Add(this.btn_mesAtras);
            this.Controls.Add(this.btn_MesActual);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.Check3D);
            this.Controls.Add(this.btn_createKML);
            this.Controls.Add(this.dgv_lightning1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_cooperativa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_final);
            this.Controls.Add(this.dtp_Inicial);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Descargas Atmosféricas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lightning1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLightningsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightningStrikesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getLightningsBindingSource;
        private LightningStrikesDataSet lightningStrikesDataSet;
        private LightningStrikesDataSetTableAdapters.GetLightningsTableAdapter getLightningsTableAdapter;
        private System.Windows.Forms.Button btn_createKML;
        private System.Windows.Forms.CheckBox Check3D;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_MesActual;
        private System.Windows.Forms.Button btn_mesAtras;
        private System.Windows.Forms.Button btn_mesAdelante;
        private System.Windows.Forms.Label label4;
    }
}

