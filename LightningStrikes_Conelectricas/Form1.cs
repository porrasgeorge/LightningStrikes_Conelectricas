using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightningStrikes_Conelectricas
{
    public partial class Form1 : Form
    {
        DateTime fechaInicial;
        string fechaCSV = "";
        DateTime fechaFinal;
        int cooperativaID;
        int cooperativaIDArea;
        bool disableFiringEvents = true;
        double UP_limit;
        double LOW_limit;
        double LEFT_limit;
        double RIGHT_limit;
        int NumFilas = 0;
        List<LightningStrike> listaRayos;

        public Boolean etiquetaCorrectaBool;
        public Boolean formatoCorrectoBool;
        public Boolean ArchivoCorrectoBool;

        public double MaxValue(int columna)
        {
            double max = 0;
            for (int i = 0; i < dgv_lightningZones.Rows.Count - 1; i++)
            {
                double cellValue = Convert.ToDouble(dgv_lightningZones.Rows[i].Cells[columna].Value.ToString());
                if (max < cellValue)
                {
                    max = cellValue;
                }
            }
            return max;
        }


        public Form1()
        {
            InitializeComponent();

            btn_CrearCSV.Enabled = false;
            btn_crearKMLpoints.Enabled = false;
            dtp_Inicial.Value = DateTime.Today.AddDays(-1);
            dtp_final.Value = DateTime.Today;

            string conString = "Data Source=192.168.4.2;Initial Catalog=LightningStrikes;User ID=jorge;Password=ERR100189";
            SqlConnection conn = new SqlConnection(conString);
            DataSet ds = new DataSet();
            DataSet ds2 = new DataSet();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Id as Value, Name from Locations order by Id", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                da.Fill(ds2);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion a la BD");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            cb_cooperativa.DataSource = ds.Tables[0];
            cb_cooperativa.DisplayMember = "Name";
            cb_cooperativa.ValueMember = "Value";
            cb_cooperativa.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_cooperativa.SelectedIndex = 1;
            cooperativaID = Convert.ToInt32(cb_cooperativa.SelectedValue.ToString());

            cb_cooperativaArea.DataSource = ds2.Tables[0];
            cb_cooperativaArea.DisplayMember = "Name";
            cb_cooperativaArea.ValueMember = "Value";
            cb_cooperativaArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_cooperativaArea.SelectedIndex = 1;
            cooperativaIDArea = Convert.ToInt32(cb_cooperativaArea.SelectedValue.ToString());

            listaRayos = new List<LightningStrike>();
            pb_completado.Visible = false;
            btn_leer.Enabled = true;
            btn_GuardarDB.Enabled = false;

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            //pb_completado.Maximum = listaRayos.Count;
            pb_completado.Step = 1;
            pb_completado.Value = 0;
            pb_completado.Visible = false;
            disableFiringEvents = false;

            foreach (DataGridViewColumn column in dgv_lightningAll.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv_lightningByDay.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_lightningByMonth.Columns[0].DefaultCellStyle.Format = "MM/yyyy";
            dgv_lightningAll.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            

        }

        private void cb_cooperativa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cooperativaID = Convert.ToInt32(cb_cooperativa.SelectedValue.ToString());
            ActualizarTablasFechas();
            dgv_lightningByMonth.Update();
            dgv_lightningByDay.Update();
            dgv_lightningAll.Update();

        }


        private void cb_cooperativaArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!disableFiringEvents)
                ActualizarTablasZonas();
        }

        private void dtp_Inicial_ValueChanged(object sender, EventArgs e)
        {
            if (!disableFiringEvents)
                ActualizarTablasZonas();
        }

        private void dtp_final_ValueChanged(object sender, EventArgs e)
        {
            if (!disableFiringEvents)
                ActualizarTablasZonas();
        }


        private void btn_createKML_Click(object sender, EventArgs e)
        {
            dgv_lightningZones.Sort(dgv_lightningZones.Columns[0], ListSortDirection.Descending);
            CrearKMLporDescargas(0);// por cantidad de descargas
        }

        private void btn_KML_AVG_Click(object sender, EventArgs e)
        {
            dgv_lightningZones.Sort(dgv_lightningZones.Columns[3], ListSortDirection.Descending);
            CrearKMLporDescargas(3); //por amplitud promedio
        }

        private void btn_KML_MAX_Click(object sender, EventArgs e)
        {
            dgv_lightningZones.Sort(dgv_lightningZones.Columns[4], ListSortDirection.Descending);
            CrearKMLporDescargas(4); //por amplitud promedio
        }


        private void dgv_lightningByMonth_Sorted(object sender, EventArgs e)
        {
            this.dgv_lightningByMonth.FirstDisplayedCell = this.dgv_lightningByMonth.CurrentCell;
        }

        private void ActualizarTablasFechas()
        {
            lbl_cargandoFechas.Visible = true;
            lbl_cargandoFechas.BringToFront();
            lbl_cargandoFechas.Update();
            cooperativaID = Convert.ToInt32(cb_cooperativa.SelectedValue.ToString());
            try
            {
                dgv_lightningByMonth.DataSource = this.countLightningsByMonthTableAdapter.GetData(cooperativaID);
                dgv_lightningByMonth.ClearSelection();
                dgv_lightningAll.DataSource = null;
                dgv_lightningByDay.DataSource = null;
                dgv_lightningByMonth.Sort(dgv_lightningByMonth.Columns[0], ListSortDirection.Descending);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            lbl_cargandoFechas.Visible = false;
            lbl_cargandoFechas.Update();

        }

        private void ActualizarTablasZonas()
        {
            lbl_cargandoZonas.Visible = true;
            lbl_cargandoZonas.BringToFront();
            lbl_cargandoZonas.Update();

            cooperativaIDArea = Convert.ToInt32(cb_cooperativaArea.SelectedValue.ToString());
            try
            {
                
                fechaInicial = this.dtp_Inicial.Value.Date;
                fechaFinal = this.dtp_final.Value.Date;

                dgv_lightningZones.DataSource = this.getLightningsTableAdapter.GetData(fechaInicial, fechaFinal, cooperativaIDArea);
                dgv_lightningByMonth.ClearSelection();
                dgv_lightningAll.DataSource = null;
                dgv_lightningByDay.DataSource = null;
                dgv_lightningZones.ClearSelection();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            lbl_cargandoZonas.Visible = false;
            lbl_cargandoZonas.Update();

            if (dgv_lightningZones.Rows.Count > 0)
            { 
                btn_KML_Descargas.Enabled = true;
                btn_KML_AVG.Enabled = true;
                btn_KML_MAX.Enabled = true;
            }
            else
            {
                btn_KML_Descargas.Enabled = false;
                btn_KML_AVG.Enabled = false;
                btn_KML_MAX.Enabled = false;
            }
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            ActualizarTablasFechas();
            ActualizarTablasZonas();
        }

        private void dgv_lightningByMonth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            cooperativaID = Convert.ToInt32(cb_cooperativa.SelectedValue.ToString());

            btn_CrearCSV.Enabled = false;
            btn_crearKMLpoints.Enabled = false;
            lbl_cargandoFechas.Visible = true;
            lbl_cargandoFechas.BringToFront();
            lbl_cargandoFechas.Update();

            DateTime fecha = (DateTime)dgv_lightningByMonth.Rows[e.RowIndex].Cells[0].Value;
            dgv_lightningByDay.DataSource = this.countLightningsByDayTableAdapter.GetData(fecha, cooperativaID);
            dgv_lightningAll.DataSource = null;
            dgv_lightningByDay.ClearSelection();

            lbl_cargandoFechas.Visible = false;
            lbl_cargandoFechas.Update();
        }
        private void dgv_lightningByMonth_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            cooperativaID = Convert.ToInt32(cb_cooperativa.SelectedValue.ToString());

            btn_CrearCSV.Enabled = true;
            btn_crearKMLpoints.Enabled = true;
            lbl_cargandoFechas.Visible = true;
            lbl_cargandoFechas.BringToFront();
            lbl_cargandoFechas.Update();
            fechaCSV = dgv_lightningByMonth.Rows[e.RowIndex].Cells[0].Value.ToString();

            DateTime fecha = (DateTime)dgv_lightningByMonth.Rows[e.RowIndex].Cells[0].Value;
            fechaCSV = fecha.Date.ToString("MM_yyyy");
            dgv_lightningAll.DataSource = this.getAllLightningsTableAdapter.GetData(fecha, cooperativaID, 2);
            dgv_lightningAll.ClearSelection();
            dgv_lightningAll.Sort(dgv_lightningAll.Columns[0], ListSortDirection.Ascending);

            lbl_cargandoFechas.Visible = false;
            lbl_cargandoFechas.Update();
            
        }

        private void dgv_lightningByDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            cooperativaID = Convert.ToInt32(cb_cooperativa.SelectedValue.ToString());
            btn_CrearCSV.Enabled = true;
            btn_crearKMLpoints.Enabled = true;
            lbl_cargandoFechas.Visible = true;
            lbl_cargandoFechas.BringToFront();
            lbl_cargandoFechas.Update();

            DateTime fecha = (DateTime)dgv_lightningByDay.Rows[e.RowIndex].Cells[0].Value;
            fechaCSV = fecha.Date.ToString("dd_MM_yyyy");
            dgv_lightningAll.DataSource = this.getAllLightningsTableAdapter.GetData(fecha, cooperativaID, 1);
            dgv_lightningAll.ClearSelection();
            dgv_lightningAll.Sort(dgv_lightningAll.Columns[0],ListSortDirection.Ascending);

            lbl_cargandoFechas.Visible = false;
            lbl_cargandoFechas.Update();
            lbl_DescargasDiariasCount.Text = dgv_lightningAll.Rows.Count.ToString();
        }

        private void btn_crearKMLpoints_Click(object sender, EventArgs e)
        {
            lbl_cargandoFechas.Visible = true;
            lbl_cargandoFechas.Text = "Creando KML";
            lbl_cargandoFechas.BringToFront();
            lbl_cargandoFechas.Update();

            List <List<LightningStrike>> ListaRayos = new List<List<LightningStrike>> {
            new List<LightningStrike>{ },
            new List<LightningStrike>{ },
            new List<LightningStrike>{ },
            new List<LightningStrike>{ },
            new List<LightningStrike>{ }};

            dgv_lightningAll.Sort(dgv_lightningAll.Columns[3], ListSortDirection.Ascending);
            dgv_lightningAll.Update();
            foreach (DataGridViewRow row in dgv_lightningAll.Rows)
            {
                LightningStrike rayo = new LightningStrike((DateTime)row.Cells[0].Value, (double)row.Cells[2].Value, (double)row.Cells[1].Value, (double)row.Cells[3].Value);
                double AbsAmplitud = Math.Abs(rayo.amplitud);

                if (AbsAmplitud >= 80)
                    ListaRayos.ElementAt(4).Add(rayo);
                else if (AbsAmplitud >= 60)
                    ListaRayos.ElementAt(3).Add(rayo);
                else if(AbsAmplitud >= 40)
                    ListaRayos.ElementAt(2).Add(rayo);
                else if (AbsAmplitud >= 20)
                    ListaRayos.ElementAt(1).Add(rayo);
                else
                    ListaRayos.ElementAt(0).Add(rayo);
            }

            

            List<string> lineas = new List<string>();

            lineas.Add("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            lineas.Add("<kml xmlns=\"http://www.opengis.net/kml/2.2\">");
            lineas.Add("\t<Document>");
            lineas.Add("\t\t<open>1</open>");
            lineas.Add("\t\t<name>" + fechaCSV + "</name>");



            lineas.Add("\t\t<Style id=\"Color4\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/red-blank.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color3\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/ylw-blank.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color2\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/blu-blank.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color1\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/wht-blank.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color0\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/purple-blank.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");


            lineas.Add("\t\t<Style id=\"Color4p\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/red-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color3p\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/ylw-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color2p\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/blu-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color1p\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/wht-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color0p\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/purple-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            int iteracion = 0;

            foreach (List<LightningStrike> ListaNiveles in ListaRayos)
            {

                lineas.Add("\t\t<Folder>");
                if (iteracion == 4)
                    lineas.Add("\t\t\t<name>Más de 80kA</name>");
                else if(iteracion == 3)
                    lineas.Add("\t\t\t<name>Entre 60kA y 80kA</name>");
                else if(iteracion == 2)
                    lineas.Add("\t\t\t<name>Entre 40kA y 60kA</name>");
                else if(iteracion == 1)
                    lineas.Add("\t\t\t<name>Entre 20kA y 40kA</name>");
                else
                    lineas.Add("\t\t\t<name>Menos de 20kA</name>");

                lineas.Add("\t\t\t<visibility>1</visibility>");
                lineas.Add("\t\t\t<open>0</open>");


                foreach (LightningStrike lightning in ListaNiveles)
                {
                    double Ampl = lightning.amplitud;

                    lineas.Add("\t\t\t<Placemark>");
                    lineas.Add("\t\t\t\t<name>" + Convert.ToString(lightning.FechaHora) + "</name>");
                    if (Ampl >= 80)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color4p</styleUrl>");
                    else if (Ampl >= 60)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color3p</styleUrl>");
                    else if (Ampl >= 40)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color2p</styleUrl>");
                    else if (Ampl >= 20)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color1p</styleUrl>");
                    else if (Ampl >= 0)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color0p</styleUrl>");
                    else if (Ampl > -20)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color0</styleUrl>");
                    else if (Ampl > -40)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color1</styleUrl>");
                    else if (Ampl > -60)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color2</styleUrl>");
                    else if (Ampl > -80)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color3</styleUrl>");
                    else
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color4</styleUrl>");

                    lineas.Add("\t\t\t\t<description>Amplitud: " + Convert.ToString(lightning.amplitud) + "kA</description>");
                    lineas.Add("\t\t\t\t<Point>");
                    lineas.Add("\t\t\t\t\t<coordinates>" + Convert.ToString(lightning.longitud) + "," + Convert.ToString(lightning.latitud) + "</coordinates>");
                    lineas.Add("\t\t\t\t</Point>");
                    lineas.Add("\t\t\t</Placemark>");
                }
                lineas.Add("\t\t</Folder>");

                iteracion++;

            }

            lineas.Add("\t</Document>");
            lineas.Add("</kml>");

            string NombreCoop = this.cb_cooperativa.GetItemText(this.cb_cooperativa.SelectedItem);
            string nombreArchivo = NombreCoop.Trim() + " - " + fechaCSV ;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.FileName = nombreArchivo;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "kml";
            saveFileDialog1.Filter = "KML files (*.kml)|*.kml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nombreArchivo = saveFileDialog1.FileName;
                System.IO.File.WriteAllLines(nombreArchivo, lineas);
                MessageBox.Show(nombreArchivo + " \n\nCREADO SATISFACTORIAMENTE", "KML");
            }


            lbl_cargandoFechas.Visible = false;
            lbl_cargandoFechas.Text = "Cargando ......";
            lbl_cargandoFechas.Update();
        }

        private void CrearKMLporDescargas(int columna)
        {
            
            bool IntConvertido = false;
            double ValorMaximo = MaxValue(columna);
            int Valor4 = (int)ValorMaximo * 7 / 10;
            int Valor3 = (int)ValorMaximo * 5 / 10;
            int Valor2 = (int)ValorMaximo * 25 / 100;
            int Valor1 = (int)ValorMaximo * 1 / 10;
            int ContFila = 0;
            int NumFilas = dgv_lightningZones.Rows.Count;
            int alturaColumna = 10;
            double factorAltura = 10000.0 / (ValorMaximo * ValorMaximo);
            double ValorGraficar = 0;

            const double anchoBase = 0.004;
            bool is3D = Convert.ToBoolean(this.Check3D.Checked);
            bool NoConvError = false;

            try
            {
                IntConvertido = Double.TryParse(dgv_lightningZones.Rows[ContFila].Cells[columna].Value.ToString(), out ValorGraficar);
                NoConvError = true;
            }
            catch (Exception exep)
            {
                MessageBox.Show("No hay datos seleccionados\r\n", "Error");
                NoConvError = false;
            }

            if (NoConvError)
            {
                List<string> lineas = new List<string>();

                lineas.Add("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                lineas.Add("<kml xmlns=\"http://www.opengis.net/kml/2.2\">");
                lineas.Add("\t<Document>");

                lineas.Add("\t\t<open>1</open>");

                lineas.Add("\t\t<Style id=\"color4\">");
                lineas.Add("\t\t\t<LineStyle> <width>0</width></LineStyle>");
                lineas.Add("\t\t\t<PolyStyle> <color>770000ff</color> </PolyStyle> ");
                lineas.Add("\t\t</Style>");

                lineas.Add("\t\t<Style id=\"color3\">");
                lineas.Add("\t\t\t<LineStyle> <width>0</width></LineStyle>");
                lineas.Add("\t\t\t<PolyStyle> <color>6614F0FF</color> </PolyStyle> ");
                lineas.Add("\t\t</Style>");

                lineas.Add("\t\t<Style id=\"color2\">");
                lineas.Add("\t\t\t<LineStyle> <width>0</width></LineStyle>");
                lineas.Add("\t\t\t<PolyStyle> <color>55ff0000</color> </PolyStyle> ");
                lineas.Add("\t\t</Style>");

                lineas.Add("\t\t<Style id=\"color1\">");
                lineas.Add("\t\t\t<LineStyle> <width>0</width></LineStyle>");
                lineas.Add("\t\t\t<PolyStyle> <color>55FFFFFF</color> </PolyStyle> ");
                lineas.Add("\t\t</Style>");

                lineas.Add("\t\t<Style id=\"color0\">");
                lineas.Add("\t\t\t<LineStyle> <width>0</width></LineStyle>");
                lineas.Add("\t\t\t<PolyStyle> <color>55FF78B4</color> </PolyStyle> ");
                lineas.Add("\t\t</Style>");

                lineas.Add("\t\t<LookAt>");
                lineas.Add("\t\t\t<longitude> -84.170951 </longitude>");
                lineas.Add("\t\t\t<latitude>   9.569499 </latitude>");
                lineas.Add("\t\t\t<altitude> 0 </altitude>");
                lineas.Add("\t\t\t<heading> 0 </heading>");
                lineas.Add("\t\t\t<tilt> 38.000000 </tilt>");
                lineas.Add("\t\t\t<range> 354392 </range>");
                lineas.Add("\t\t\t<altitudeMode> relativeToSeaFloor </altitudeMode>");
                lineas.Add("\t\t</LookAt>");

                ///////////////////////////////////////////////////////////////////////////////////
                /// Nivel 4
                /// 
                lineas.Add("\t\t<Folder>");
                if (columna == 0)
                    lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor4 + 1) + " y " + Convert.ToString(ValorMaximo) + " Descargas Atmosfericas</name>");
                else if (columna == 3)
                    lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor4 + 1) + " y " + Convert.ToString(ValorMaximo) + " kA Promedio</name>");
                else
                    lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor4 + 1) + " y " + Convert.ToString(ValorMaximo) + " kA Maximo</name>");

                lineas.Add("\t\t\t<visibility>1</visibility>");
                lineas.Add("\t\t\t<open>0</open>");


                if (ContFila < NumFilas - 1)
                    IntConvertido = Double.TryParse(dgv_lightningZones.Rows[ContFila].Cells[columna].Value.ToString(), out ValorGraficar);
                double numDescargas = 0.0;
                double latitud = 0.0;
                double longitud = 0.0;
                double AVG_Amp = 0.0;
                double MAX_Amp = 0.0;

                IntConvertido = Double.TryParse(dgv_lightningZones.Rows[ContFila].Cells[columna].Value.ToString(), out ValorGraficar);
                numDescargas = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[0].Value.ToString());
                latitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[1].Value.ToString());
                longitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[2].Value.ToString());
                AVG_Amp = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[3].Value.ToString());
                MAX_Amp = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[4].Value.ToString());


                while (ValorGraficar > Valor4 && IntConvertido == true && ContFila < NumFilas - 1)
                {
                    if (IntConvertido)
                    {

                        lineas.Add("\t\t\t<Placemark>");
                        lineas.Add("\t\t\t\t<name>" + Convert.ToString(ValorGraficar) + " - " + Convert.ToString(ContFila) + "</name>");
                        lineas.Add("\t\t\t\t<description>");
                        lineas.Add("\t\t\t\t\tNumero de Descargas: " + Convert.ToString(numDescargas)+"\r\n"+ 
                            "Amplitud Promedio: " + Convert.ToString(AVG_Amp) + "kA\r\n" +
                            "Amplitud Maxima: " + Convert.ToString(MAX_Amp) + "kA");
                        lineas.Add("\t\t\t\t</description>");
                        lineas.Add("\t\t\t\t<styleUrl>#color4</styleUrl>");
                        lineas.Add("\t\t\t\t<Polygon>");
                        if (is3D)
                        {
                            lineas.Add("\t\t\t\t\t<extrude>1</extrude>");
                            alturaColumna = Convert.ToInt32(factorAltura * ValorGraficar * ValorGraficar);
                        }
                        else
                        {
                            lineas.Add("\t\t\t\t\t<extrude>0</extrude>");
                        }
                        lineas.Add("\t\t\t\t\t<extrude>1</extrude>");
                        lineas.Add("\t\t\t\t\t<altitudeMode>relativeToGround</altitudeMode>");
                        lineas.Add("\t\t\t\t\t<outerBoundaryIs>");
                        lineas.Add("\t\t\t\t\t\t<LinearRing>");
                        lineas.Add("\t\t\t\t\t\t\t<coordinates>");

                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud - anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud - anchoBase) + "," + Convert.ToString(latitud - anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud - anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));


                        lineas.Add("\t\t\t\t\t\t\t</coordinates>");
                        lineas.Add("\t\t\t\t\t\t</LinearRing>");
                        lineas.Add("\t\t\t\t\t</outerBoundaryIs>");
                        lineas.Add("\t\t\t\t</Polygon>");
                        lineas.Add("\t\t\t</Placemark>");


                    }

                    ValorGraficar = 0;
                    ContFila++;
                    IntConvertido = Double.TryParse(dgv_lightningZones.Rows[ContFila].Cells[columna].Value.ToString(), out ValorGraficar);
                    numDescargas = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[0].Value.ToString());
                    latitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[2].Value.ToString());
                    AVG_Amp = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[3].Value.ToString());
                    MAX_Amp = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[4].Value.ToString());

                }
                lineas.Add("\t\t</Folder>");


                ///////////////////////////////////////////////////////////////////////////////////
                /// Nivel 3
                /// 
                lineas.Add("\t\t<Folder>");
                if (columna == 0)
                    lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor3) + " y " + Convert.ToString(Valor4) + " Descargas Atmosfericas</name>");
                else if (columna == 3)
                    lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor3) + " y " + Convert.ToString(Valor4) + " kA Promedio</name>");
                else
                    lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor3) + " y " + Convert.ToString(Valor4) + " kA Maximo</name>");
                lineas.Add("\t\t\t<visibility>1</visibility>");
                lineas.Add("\t\t\t<open>0</open>");

                ValorGraficar = 0;
                if (ContFila < NumFilas - 1)
                {
                    IntConvertido = Double.TryParse(dgv_lightningZones.Rows[ContFila].Cells[columna].Value.ToString(), out ValorGraficar);
                    numDescargas = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[0].Value.ToString());
                    latitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[2].Value.ToString());
                }

                while (ValorGraficar > Valor3 && IntConvertido == true && ContFila < NumFilas - 1)
                {

                    if (IntConvertido)
                    {
                        lineas.Add("\t\t\t<Placemark>");
                        lineas.Add("\t\t\t\t<visibility>0</visibility>");
                        lineas.Add("\t\t\t\t<name>" + Convert.ToString(ValorGraficar) + " - " + Convert.ToString(ContFila) + "</name>");
                        lineas.Add("\t\t\t\t<description>");
                        lineas.Add("\t\t\t\t\tNumero de Descargas: " + Convert.ToString(numDescargas) + "\r\n" +
                                    "Amplitud Promedio: " + Convert.ToString(AVG_Amp) + "kA\r\n" +
                                    "Amplitud Maxima: " + Convert.ToString(MAX_Amp) + "kA");
                        lineas.Add("\t\t\t\t</description>");
                        lineas.Add("\t\t\t\t<styleUrl>#color3</styleUrl>");
                        lineas.Add("\t\t\t\t<Polygon>");
                        if (is3D)
                        {
                            lineas.Add("\t\t\t\t\t<extrude>1</extrude>");
                            alturaColumna = Convert.ToInt32(factorAltura * ValorGraficar * ValorGraficar);
                        }
                        else
                        {
                            lineas.Add("\t\t\t\t\t<extrude>0</extrude>");
                        }
                        lineas.Add("\t\t\t\t\t<altitudeMode>relativeToGround</altitudeMode>");
                        lineas.Add("\t\t\t\t\t<outerBoundaryIs>");
                        lineas.Add("\t\t\t\t\t\t<LinearRing>");
                        lineas.Add("\t\t\t\t\t\t\t<coordinates>");

                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud - anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud - anchoBase) + "," + Convert.ToString(latitud - anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud - anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));


                        lineas.Add("\t\t\t\t\t\t\t</coordinates>");
                        lineas.Add("\t\t\t\t\t\t</LinearRing>");
                        lineas.Add("\t\t\t\t\t</outerBoundaryIs>");
                        lineas.Add("\t\t\t\t</Polygon>");
                        lineas.Add("\t\t\t</Placemark>");


                    }
                    ValorGraficar = 0;
                    ContFila++;
                    IntConvertido = Double.TryParse(dgv_lightningZones.Rows[ContFila].Cells[columna].Value.ToString(), out ValorGraficar);
                    numDescargas = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[0].Value.ToString());
                    latitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[2].Value.ToString());
                    AVG_Amp = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[3].Value.ToString());
                    MAX_Amp = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[4].Value.ToString());

                }
                lineas.Add("\t\t</Folder>");


                ///////////////////////////////////////////////////////////////////////////////////
                /// Nivel 2
                /// 
                lineas.Add("\t\t<Folder>");
                if (columna == 0)
                    lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor2) + " y " + Convert.ToString(Valor3) + " Descargas Atmosfericas</name>");
                else if (columna == 3)
                    lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor2) + " y " + Convert.ToString(Valor3) + " kA Promedio</name>");
                else
                    lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor2) + " y " + Convert.ToString(Valor3) + " kA Maximo</name>");
                lineas.Add("\t\t\t<visibility>1</visibility>");
                lineas.Add("\t\t\t<open>0</open>");

                ValorGraficar = 0;
                if (ContFila < NumFilas - 1)
                {
                    IntConvertido = Double.TryParse(dgv_lightningZones.Rows[ContFila].Cells[columna].Value.ToString(), out ValorGraficar);
                    numDescargas = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[0].Value.ToString());
                    latitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[2].Value.ToString());
                }

                while (ValorGraficar > Valor2 && IntConvertido == true && ContFila < NumFilas - 1)
                {
                    if (IntConvertido)
                    {
                        lineas.Add("\t\t\t<Placemark>");
                        lineas.Add("\t\t\t\t<visibility>0</visibility>");
                        lineas.Add("\t\t\t\t<name>" + Convert.ToString(ValorGraficar) + " - " + Convert.ToString(ContFila) + "</name>");
                        lineas.Add("\t\t\t\t<description>");
                        lineas.Add("\t\t\t\t\tNumero de Descargas: " + Convert.ToString(numDescargas) + "\r\n" +
                                    "Amplitud Promedio: " + Convert.ToString(AVG_Amp) + "kA\r\n" +
                                    "Amplitud Maxima: " + Convert.ToString(MAX_Amp) + "kA");
                        lineas.Add("\t\t\t\t</description>");
                        lineas.Add("\t\t\t\t<styleUrl>#color2</styleUrl>");
                        lineas.Add("\t\t\t\t<Polygon>");
                        if (is3D)
                        {
                            lineas.Add("\t\t\t\t\t<extrude>1</extrude>");
                            alturaColumna = Convert.ToInt32(factorAltura * ValorGraficar * ValorGraficar);
                        }
                        else
                        {
                            lineas.Add("\t\t\t\t\t<extrude>0</extrude>");
                        }
                        lineas.Add("\t\t\t\t\t<altitudeMode>relativeToGround</altitudeMode>");
                        lineas.Add("\t\t\t\t\t<outerBoundaryIs>");
                        lineas.Add("\t\t\t\t\t\t<LinearRing>");
                        lineas.Add("\t\t\t\t\t\t\t<coordinates>");

                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud - anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud - anchoBase) + "," + Convert.ToString(latitud - anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud - anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));


                        lineas.Add("\t\t\t\t\t\t\t</coordinates>");
                        lineas.Add("\t\t\t\t\t\t</LinearRing>");
                        lineas.Add("\t\t\t\t\t</outerBoundaryIs>");
                        lineas.Add("\t\t\t\t</Polygon>");
                        lineas.Add("\t\t\t</Placemark>");
                    }

                    ValorGraficar = 0;
                    ContFila++;

                    IntConvertido = Double.TryParse(dgv_lightningZones.Rows[ContFila].Cells[columna].Value.ToString(), out ValorGraficar);
                    numDescargas = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[0].Value.ToString());
                    latitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[2].Value.ToString());
                    AVG_Amp = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[3].Value.ToString());
                    MAX_Amp = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[4].Value.ToString());


                }
                lineas.Add("\t\t</Folder>");

                ///////////////////////////////////////////////////////////////////////////////////
                /// Nivel 1
                /// 
                lineas.Add("\t\t<Folder>");
                if (columna == 0)
                    lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor1) + " y " + Convert.ToString(Valor2) + " Descargas Atmosfericas</name>");
                else if (columna == 3)
                    lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor1) + " y " + Convert.ToString(Valor2) + " kA Promedio</name>");
                else
                    lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor1) + " y " + Convert.ToString(Valor2) + " kA Maximo</name>");
                lineas.Add("\t\t\t<visibility>1</visibility>");
                lineas.Add("\t\t\t<open>0</open>");

                ValorGraficar = 0;
                if (ContFila < NumFilas - 1)
                {
                    IntConvertido = Double.TryParse(dgv_lightningZones.Rows[ContFila].Cells[columna].Value.ToString(), out ValorGraficar);
                    numDescargas = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[0].Value.ToString());
                    latitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[2].Value.ToString());
                }
                while (ValorGraficar > Valor1 && IntConvertido == true && ContFila < NumFilas - 1)
                {
                    if (IntConvertido)
                    {
                        lineas.Add("\t\t\t<Placemark>");
                        lineas.Add("\t\t\t\t<visibility>0</visibility>");
                        lineas.Add("\t\t\t\t<name>" + Convert.ToString(ValorGraficar) + " - " + Convert.ToString(ContFila) + "</name>");
                        lineas.Add("\t\t\t\t<description>");
                        lineas.Add("\t\t\t\t\tNumero de Descargas: " + Convert.ToString(numDescargas) + "\r\n" +
                                    "Amplitud Promedio: " + Convert.ToString(AVG_Amp) + "kA\r\n" +
                                    "Amplitud Maxima: " + Convert.ToString(MAX_Amp) + "kA");
                        lineas.Add("\t\t\t\t</description>");
                        lineas.Add("\t\t\t\t<styleUrl>#color1</styleUrl>");
                        lineas.Add("\t\t\t\t<Polygon>");
                        if (is3D)
                        {
                            lineas.Add("\t\t\t\t\t<extrude>1</extrude>");
                            alturaColumna = Convert.ToInt32(factorAltura * ValorGraficar * ValorGraficar);
                        }
                        else
                        {
                            lineas.Add("\t\t\t\t\t<extrude>0</extrude>");
                        }
                        lineas.Add("\t\t\t\t\t<altitudeMode>relativeToGround</altitudeMode>");
                        lineas.Add("\t\t\t\t\t<outerBoundaryIs>");
                        lineas.Add("\t\t\t\t\t\t<LinearRing>");
                        lineas.Add("\t\t\t\t\t\t\t<coordinates>");

                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud - anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud - anchoBase) + "," + Convert.ToString(latitud - anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud - anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));


                        lineas.Add("\t\t\t\t\t\t\t</coordinates>");
                        lineas.Add("\t\t\t\t\t\t</LinearRing>");
                        lineas.Add("\t\t\t\t\t</outerBoundaryIs>");
                        lineas.Add("\t\t\t\t</Polygon>");
                        lineas.Add("\t\t\t</Placemark>");
                    }

                    ValorGraficar = 0;
                    ContFila++;
                    IntConvertido = Double.TryParse(dgv_lightningZones.Rows[ContFila].Cells[columna].Value.ToString(), out ValorGraficar);
                    numDescargas = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[0].Value.ToString());
                    latitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[2].Value.ToString());
                    AVG_Amp = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[3].Value.ToString());
                    MAX_Amp = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[4].Value.ToString());
                }
                lineas.Add("\t\t</Folder>");

                ///////////////////////////////////////////////////////////////////////////////////
                /// Nivel 0
                /// 
                lineas.Add("\t\t<Folder>");
                if (columna == 0)
                    lineas.Add("\t\t\t<name>Menos de " + Convert.ToString(Valor1) + " Descargas Atmosfericas</name>");
                else if (columna == 3)
                    lineas.Add("\t\t\t<name>Menos de " + Convert.ToString(Valor1) + " kA Promedio</name>");
                else
                    lineas.Add("\t\t\t<name>Menos de " + Convert.ToString(Valor1) + " kA Maximo</name>");

                lineas.Add("\t\t\t<visibility>1</visibility>");
                lineas.Add("\t\t\t<open>0</open>");

                ValorGraficar = 0;
                if (ContFila < NumFilas - 1)
                {
                    IntConvertido = Double.TryParse(dgv_lightningZones.Rows[ContFila].Cells[columna].Value.ToString(), out ValorGraficar);
                    numDescargas = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[0].Value.ToString());
                    latitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightningZones.Rows[ContFila].Cells[2].Value.ToString());
                }
                while (ValorGraficar > 0 && IntConvertido == true && ContFila < NumFilas - 1)
                {
                    if (IntConvertido)
                    {
                        lineas.Add("\t\t\t<Placemark>");
                        lineas.Add("\t\t\t\t<visibility>0</visibility>");
                        lineas.Add("\t\t\t\t<name>" + Convert.ToString(ValorGraficar) + " - " + Convert.ToString(ContFila) + "</name>");
                        lineas.Add("\t\t\t\t<description>");
                        lineas.Add("\t\t\t\t\tNumero de Descargas: " + Convert.ToString(numDescargas) + "\r\n" +
                                    "Amplitud Promedio: " + Convert.ToString(AVG_Amp) + "kA\r\n" +
                                    "Amplitud Maxima: " + Convert.ToString(MAX_Amp) + "kA");
                        lineas.Add("\t\t\t\t</description>");
                        lineas.Add("\t\t\t\t<styleUrl>#color0</styleUrl>");
                        lineas.Add("\t\t\t\t<Polygon>");
                        if (is3D)
                        {
                            lineas.Add("\t\t\t\t\t<extrude>1</extrude>");
                            alturaColumna = Convert.ToInt32(factorAltura * ValorGraficar * ValorGraficar);
                        }
                        else
                        {
                            lineas.Add("\t\t\t\t\t<extrude>0</extrude>");
                        }
                        lineas.Add("\t\t\t\t\t<altitudeMode>relativeToGround</altitudeMode>");
                        lineas.Add("\t\t\t\t\t<outerBoundaryIs>");
                        lineas.Add("\t\t\t\t\t\t<LinearRing>");
                        lineas.Add("\t\t\t\t\t\t\t<coordinates>");

                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud - anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud - anchoBase) + "," + Convert.ToString(latitud - anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud - anchoBase) + "," + Convert.ToString(alturaColumna));
                        lineas.Add("\t\t\t\t\t\t\t\t" + Convert.ToString(longitud + anchoBase) + "," + Convert.ToString(latitud + anchoBase) + "," + Convert.ToString(alturaColumna));


                        lineas.Add("\t\t\t\t\t\t\t</coordinates>");
                        lineas.Add("\t\t\t\t\t\t</LinearRing>");
                        lineas.Add("\t\t\t\t\t</outerBoundaryIs>");
                        lineas.Add("\t\t\t\t</Polygon>");
                        lineas.Add("\t\t\t</Placemark>");
                    }
                    ValorGraficar = 0;
                    ContFila++;

                }
                lineas.Add("\t\t</Folder>");

                ///////////////////////////////////////////////////////////////////////////////////
                /// Fin de Niveles
                /// 


                lineas.Add("\t</Document>");
                lineas.Add("</kml>");
                string NombreCoop = this.cb_cooperativaArea.GetItemText(this.cb_cooperativaArea.SelectedItem);
                string str3D = "";
                string str_botonPresionado = "";
                if (is3D)
                    str3D = "3D";
                else
                    str3D = "2D";

                if (columna == 3)
                    str_botonPresionado = "Amplitud Promedio";
                else if (columna == 4)
                    str_botonPresionado = "Amplitud Maxima";
                else
                    str_botonPresionado = "Cantidad";

                string nombreArchivo = NombreCoop.Trim() + " (" + str_botonPresionado+ ") " + fechaInicial.ToString("ddMMyyyy") + "-" + fechaFinal.ToString("ddMMyyyy") + "_" + str3D;

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog1.Title = "Guardar Archivo";
                saveFileDialog1.FileName = nombreArchivo;
                saveFileDialog1.CheckFileExists = false;
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "kml";
                saveFileDialog1.Filter = "KML files (*.kml)|*.kml|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    nombreArchivo = saveFileDialog1.FileName;
                    System.IO.File.WriteAllLines(nombreArchivo, lineas);
                    MessageBox.Show(nombreArchivo + " \n\nCREADO SATISFACTORIAMENTE", "KML");
                }
            }
        }

        private void btn_CrearCSV_Click(object sender, EventArgs e)
        {

            lbl_cargandoFechas.Visible = true;
            lbl_cargandoFechas.Text = "Creando CSV";
            lbl_cargandoFechas.BringToFront();
            lbl_cargandoFechas.Update();
            List<string> CSV_Content = new List<string>();
            CSV_Content.Add("Descargas Diarias");
            CSV_Content.Add("Fecha,Longitid,Latitud,Amplitud (kA)");
            foreach (DataGridViewRow row in dgv_lightningAll.Rows)
            {
                CSV_Content.Add(Convert.ToString(row.Cells[0].Value) +
                            "," + Convert.ToString(row.Cells[1].Value) +
                            "," + Convert.ToString(row.Cells[2].Value) +
                            "," + Convert.ToString(row.Cells[3].Value));
            }

            string NombreCoop = this.cb_cooperativa.GetItemText(this.cb_cooperativa.SelectedItem);
            string nombreArchivo = NombreCoop.Trim() + " - " + fechaCSV;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Title = "Guardar Archivo";
            saveFileDialog1.FileName = nombreArchivo;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nombreArchivo = saveFileDialog1.FileName;
                System.IO.File.WriteAllLines(nombreArchivo, CSV_Content);
                //System.IO.File.WriteAllText(nombreArchivo, CSV_Content);
                MessageBox.Show(nombreArchivo + " \n\nCREADO SATISFACTORIAMENTE", "CSV");
            }

            lbl_cargandoFechas.Visible = false;
            lbl_cargandoFechas.Text = "Cargando ......";
            lbl_cargandoFechas.Update();

        }

        private void btn_ActualizarBordes_Click(object sender, EventArgs e)
        {
            lbl_cargandoBordes.Visible = true;
            lbl_cargandoBordes.BringToFront();
            lbl_cargandoBordes.Update();
            try
            {
                fechaInicial = this.dtp_InicialBordes.Value.Date;
                fechaFinal = this.dtp_FinalBordes.Value.Date;
                UP_limit = Convert.ToDouble(txt_UP.Text);
                LOW_limit = Convert.ToDouble(txt_LOW.Text);
                LEFT_limit = Convert.ToDouble(txt_LEFT.Text);
                RIGHT_limit = Convert.ToDouble(txt_RIGHT.Text);


                dgv_lightningsBorders.DataSource = this.getAllLightningsByBoundsTableAdapter.GetData(fechaInicial, fechaFinal, LEFT_limit, RIGHT_limit, UP_limit, LOW_limit);
                dgv_lightningsBorders.ClearSelection();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            };
            lbl_TotalRegistros.Text = dgv_lightningsBorders.Rows.Count.ToString();
            lbl_cargandoBordes.Visible = false;
            lbl_cargandoBordes.Update();

            lbl_Actualizar.Visible = false;
            lbl_Actualizar.Update();


        }

        private void btn_CrearKmlBordes_Click(object sender, EventArgs e)
        {
            List<List<LightningStrike>> ListaRayos = new List<List<LightningStrike>> {
            new List<LightningStrike>{ },
            new List<LightningStrike>{ },
            new List<LightningStrike>{ },
            new List<LightningStrike>{ },
            new List<LightningStrike>{ }};

            dgv_lightningsBorders.Sort(dgv_lightningsBorders.Columns[3], ListSortDirection.Ascending);
            dgv_lightningsBorders.Update();

            foreach (DataGridViewRow row in dgv_lightningsBorders.Rows)
            {
                LightningStrike rayo = new LightningStrike((DateTime)row.Cells[0].Value, (double)row.Cells[2].Value, (double)row.Cells[1].Value, (double)row.Cells[3].Value);
                double AbsAmplitud = Math.Abs(rayo.amplitud);

                if (AbsAmplitud >= 80)
                    ListaRayos.ElementAt(4).Add(rayo);
                else if (AbsAmplitud >= 60)
                    ListaRayos.ElementAt(3).Add(rayo);
                else if (AbsAmplitud >= 40)
                    ListaRayos.ElementAt(2).Add(rayo);
                else if (AbsAmplitud >= 20)
                    ListaRayos.ElementAt(1).Add(rayo);
                else
                    ListaRayos.ElementAt(0).Add(rayo);
            }

            List<string> lineas = new List<string>();

            lineas.Add("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            lineas.Add("<kml xmlns=\"http://www.opengis.net/kml/2.2\">");
            lineas.Add("\t<Document>");
            lineas.Add("\t\t<open>1</open>");
            lineas.Add("\t\t<name>Descargas Atmosfericas</name>");

            lineas.Add("\t\t<Style id=\"Color4\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/red-blank.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color3\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/ylw-blank.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color2\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/blu-blank.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color1\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/wht-blank.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color0\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/purple-blank.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");


            lineas.Add("\t\t<Style id=\"Color4p\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/red-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color3p\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/ylw-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color2p\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/blu-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color1p\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/wht-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Color0p\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/purple-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            int iteracion = 0;

            foreach (List<LightningStrike> ListaNiveles in ListaRayos)
            {

                lineas.Add("\t\t<Folder>");
                if (iteracion == 4)
                    lineas.Add("\t\t\t<name>Más de 80kA</name>");
                else if (iteracion == 3)
                    lineas.Add("\t\t\t<name>Entre 60kA y 80kA</name>");
                else if (iteracion == 2)
                    lineas.Add("\t\t\t<name>Entre 40kA y 60kA</name>");
                else if (iteracion == 1)
                    lineas.Add("\t\t\t<name>Entre 20kA y 40kA</name>");
                else
                    lineas.Add("\t\t\t<name>Menos de 20kA</name>");

                lineas.Add("\t\t\t<visibility>1</visibility>");
                lineas.Add("\t\t\t<open>0</open>");


                foreach (LightningStrike lightning in ListaNiveles)
                {
                    double Ampl = lightning.amplitud;

                    lineas.Add("\t\t\t<Placemark>");
                    lineas.Add("\t\t\t\t<name>" + Convert.ToString(lightning.FechaHora) + "</name>");
                    if (Ampl >= 80)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color4p</styleUrl>");
                    else if (Ampl >= 60)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color3p</styleUrl>");
                    else if (Ampl >= 40)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color2p</styleUrl>");
                    else if (Ampl >= 20)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color1p</styleUrl>");
                    else if (Ampl >= 0)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color0p</styleUrl>");
                    else if (Ampl > -20)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color0</styleUrl>");
                    else if (Ampl > -40)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color1</styleUrl>");
                    else if (Ampl > -60)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color2</styleUrl>");
                    else if (Ampl > -80)
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color3</styleUrl>");
                    else
                        lineas.Add("\t\t\t\t\t<styleUrl>#Color4</styleUrl>");

                    lineas.Add("\t\t\t\t<description>Amplitud: " + Convert.ToString(lightning.amplitud) + "kA</description>");
                    lineas.Add("\t\t\t\t<Point>");
                    lineas.Add("\t\t\t\t\t<coordinates>" + Convert.ToString(lightning.longitud) + "," + Convert.ToString(lightning.latitud) + "</coordinates>");
                    lineas.Add("\t\t\t\t</Point>");
                    lineas.Add("\t\t\t</Placemark>");
                }
                lineas.Add("\t\t</Folder>");

                iteracion++;

            }

            lineas.Add("\t</Document>");
            lineas.Add("</kml>");

            string nombreArchivo = "Descargas Atmosfericas";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.FileName = nombreArchivo;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "kml";
            saveFileDialog1.Filter = "KML files (*.kml)|*.kml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nombreArchivo = saveFileDialog1.FileName;
                System.IO.File.WriteAllLines(nombreArchivo, lineas);
                MessageBox.Show(nombreArchivo + " \n\nCREADO SATISFACTORIAMENTE", "KML");
            }

        }

        private void txt_RIGHT_TextChanged(object sender, EventArgs e)
        {
            lbl_Actualizar.Visible = true;
            lbl_Actualizar.BringToFront();
            lbl_Actualizar.Update();
        }

        private void txt_LOW_TextChanged(object sender, EventArgs e)
        {
            lbl_Actualizar.Visible = true;
            lbl_Actualizar.BringToFront();
            lbl_Actualizar.Update();
        }

        private void txt_LEFT_TextChanged(object sender, EventArgs e)
        {
            lbl_Actualizar.Visible = true;
            lbl_Actualizar.BringToFront();
            lbl_Actualizar.Update();
        }

        private void txt_UP_TextChanged(object sender, EventArgs e)
        {
            lbl_Actualizar.Visible = true;
            lbl_Actualizar.BringToFront();
            lbl_Actualizar.Update();
        }

        private void dtp_InicialBordes_ValueChanged(object sender, EventArgs e)
        {
            lbl_Actualizar.Visible = true;
            lbl_Actualizar.BringToFront();
            lbl_Actualizar.Update();
        }

        private void dtp_FinalBordes_ValueChanged(object sender, EventArgs e)
        {
            lbl_Actualizar.Visible = true;
            lbl_Actualizar.BringToFront();
            lbl_Actualizar.Update();
        }

        private void btn_leer_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            string log = "";
            int counter = 0;
            NumFilas = 0;
            listaRayos.Clear();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                //openFileDialog.Multiselect = true;


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    formatoCorrectoBool = true;
                    ArchivoCorrectoBool = false;

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();

                    }

                    if (!string.IsNullOrEmpty(fileContent))
                    {
                        string[] lineasArchivo = fileContent.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                        counter = 0;


                        foreach (String linea in lineasArchivo)
                        {
                            if (counter != 0)
                            {
                                if (!string.IsNullOrEmpty(linea))
                                {
                                    string[] columnas = linea.Split(",".ToCharArray());

                                    DateTime Fecha = DateTime.Parse("2000-01-01");
                                    double latitud = 0.0;
                                    double longitud = 0.0;
                                    double amplitud = 0.0;
                                    double altura = 0.0;

                                    bool Fecha_Ok = false;
                                    bool latitud_OK = false;
                                    bool longitud_OK = false;
                                    bool amplitud_OK = false;
                                    bool altura_OK = false;

                                    if (columnas.Length > 4)
                                    {
                                        Fecha_Ok = DateTime.TryParse(columnas[0], out Fecha);
                                        latitud_OK = Double.TryParse(columnas[1], out latitud);
                                        longitud_OK = Double.TryParse(columnas[2], out longitud);
                                        amplitud_OK = Double.TryParse(columnas[3], out amplitud);
                                        altura_OK = Double.TryParse(columnas[4], out altura);

                                    }

                                    if (latitud_OK && longitud_OK && Fecha_Ok && amplitud_OK)
                                    {
                                        //log += "Linea " + Convert.ToString(counter + 1) + " OK";
                                        Fecha = Fecha.AddHours(-6);
                                        if (latitud < 9 || latitud > 12)
                                        {
                                            log += Convert.ToString(counter + 1) + " Lat no CR\r\n";
                                        }
                                        else if (longitud < -86 || longitud > -82)
                                        {
                                            log += Convert.ToString(counter + 1) + ", Long no CR\r\n";
                                        }
                                        else
                                        {
                                            LightningStrike rayo = new LightningStrike(Fecha, latitud, longitud, amplitud, altura);
                                            listaRayos.Add(rayo);
                                        }

                                    }
                                    else
                                    {
                                        log += Convert.ToString(counter + 1) + " ERRONEA\r\n";
                                        formatoCorrectoBool = false;
                                    }

                                }
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(linea))
                                {
                                    string[] columnas = linea.Split(",".ToCharArray());

                                    if (columnas[0] == "LIGHTNING-Conelec24hr")
                                    {
                                        //log += "Linea " + Convert.ToString(counter + 1) + " OK\r\n";
                                        lbl_etiquetaCorrecta.Text = "SI";
                                        ArchivoCorrectoBool = true;
                                    }

                                    else
                                    {
                                        log += "Linea " + Convert.ToString(counter + 1) + " ERRONEA\r\n";
                                        lbl_etiquetaCorrecta.Text = "NO";
                                        ArchivoCorrectoBool = false;
                                    }
                                    if (!string.IsNullOrEmpty(columnas[1]))
                                    {
                                        string[] fecha_txt = columnas[1].Split("_".ToCharArray());
                                        lbl_fechaArchivo.Text = fecha_txt[2] + "/" + fecha_txt[1] + "/" + fecha_txt[0];
                                    }
                                }
                            }
                            counter++;
                        }
                        NumFilas = listaRayos.Count - 1;
                    }
                }

                if (formatoCorrectoBool)
                {
                    log += "\r\nFormato Correcto\r\n";
                    log += Convert.ToString(listaRayos.Count) + " lineas Correctas\r\n";
                    log += Convert.ToString(counter - listaRayos.Count - 1) + " lineas Incorrectas\r\n";
                    btn_GuardarDB.Enabled = true;

                }
            }
            txt_log.Text = log;
        }

        private void btn_GuardarDB_Click(object sender, EventArgs e)
        {
            pb_completado.Visible = true;
            btn_GuardarDB.Enabled = false;
            btn_leer.Enabled = false;

            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int j = 0;

            if (ArchivoCorrectoBool)
            {
                string connetionString = null;
                SqlConnection cnn;
                connetionString = "Data Source=192.168.4.2;Initial Catalog=LightningStrikes;User ID=jorge;Password=ERR100189";
                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    foreach (LightningStrike lightning in listaRayos)
                    {
                        j++;
                        SqlCommand cmd = new SqlCommand("InsertLightning", cnn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fechaHora", lightning.FechaHora);
                        cmd.Parameters.AddWithValue("@latitud", lightning.latitud);
                        cmd.Parameters.AddWithValue("@longitud", lightning.longitud);
                        cmd.Parameters.AddWithValue("@amplitud", lightning.amplitud);
                        cmd.Parameters.AddWithValue("@altura", lightning.altura);

                        cmd.ExecuteNonQuery();

                        backgroundWorker1.ReportProgress(j * 100 / (NumFilas + 1), new System.Tuple<int>(j));

                    }
                    cnn.Close();

                    //MessageBox.Show("Archivo Cargado Correctamente", "Cargado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection ! \r\n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Archivo Incorrecto", "Error");
            }


            System.Threading.Thread.Sleep(500);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb_completado.Value = e.ProgressPercentage;
            lbl_progress.Text = e.UserState.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                label3.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                label3.Text = "Error: " + e.Error.Message;
            }
            else
            {
                pb_completado.Visible = false;
                btn_GuardarDB.Enabled = false;
                btn_leer.Enabled = true;
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_LightningsByDayP6.DataSource = this.countLightningsByDayP6TableAdapter.GetData();
        }

        private void dgv_lightningAll_DataSourceChanged(object sender, EventArgs e)
        {
            lbl_DescargasDiariasCount.Text = dgv_lightningAll.Rows.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
