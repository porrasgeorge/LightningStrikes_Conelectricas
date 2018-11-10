using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        bool disableFiringEvents = false;

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

            var dataSource = new List<Cooperativa>();
            btn_CrearCSV.Enabled = false;
            btn_crearKMLpoints.Enabled = false;
            dtp_Inicial.Value = DateTime.Today.AddDays(-1);
            dtp_final.Value = DateTime.Today;
            dataSource.Add(new Cooperativa() { Name = "Coopeguanacaste", Value = "1" });
            dataSource.Add(new Cooperativa() { Name = "Coopelesca", Value = "2" });
            dataSource.Add(new Cooperativa() { Name = "Coopealfaroruiz", Value = "3" });
            dataSource.Add(new Cooperativa() { Name = "Coopesantos", Value = "4" });
            dataSource.Add(new Cooperativa() { Name = "Canalete_Miravalles", Value = "5" });
            dataSource.Add(new Cooperativa() { Name = "ESPH", Value = "6" });
            dataSource.Add(new Cooperativa() { Name = "Costa Rica", Value = "7" });

            cb_cooperativa.DataSource = dataSource;
            cb_cooperativa.DisplayMember = "Name";
            cb_cooperativa.ValueMember = "Value";
            cb_cooperativa.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_cooperativa.SelectedIndex = 2;
            cooperativaID = Convert.ToInt32(cb_cooperativa.SelectedValue.ToString());
            
            foreach (DataGridViewColumn column in dgv_lightningZones.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

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

        private void btn_cargarDatosZonas_Click(object sender, EventArgs e)
        {
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

        private void ActualizarTablasFechas()
        {
            lbl_cargandoFechas.Visible = true;
            lbl_cargandoFechas.BringToFront();
            lbl_cargandoFechas.Update();
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
            try
            {
                fechaInicial = this.dtp_Inicial.Value;
                fechaFinal = this.dtp_final.Value;

                dgv_lightningZones.DataSource = this.getLightningsTableAdapter.GetData(fechaInicial, fechaFinal, cooperativaID);
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

        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            ActualizarTablasFechas();
            ActualizarTablasZonas();
        }

        private void dgv_lightningByMonth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

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

        private void dgv_lightningByDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            btn_CrearCSV.Enabled = true;
            btn_crearKMLpoints.Enabled = true;
            fechaCSV = dgv_lightningByDay.Rows[e.RowIndex].Cells[0].Value.ToString();
            lbl_cargandoFechas.Visible = true;
            lbl_cargandoFechas.BringToFront();
            lbl_cargandoFechas.Update();

            DateTime fecha = (DateTime)dgv_lightningByDay.Rows[e.RowIndex].Cells[0].Value;
            fechaCSV = fecha.Date.ToString("dd_MM_yyyy");
            dgv_lightningAll.DataSource = this.getAllLightningsTableAdapter.GetData(fecha, cooperativaID);
            dgv_lightningAll.ClearSelection();
            dgv_lightningAll.Sort(dgv_lightningAll.Columns[0],ListSortDirection.Ascending);

            lbl_cargandoFechas.Visible = false;
            lbl_cargandoFechas.Update();
        }

        private void btn_crearKMLpoints_Click(object sender, EventArgs e)
        {
            lbl_cargandoFechas.Visible = true;
            lbl_cargandoFechas.Text = "Creando KML";
            lbl_cargandoFechas.BringToFront();
            lbl_cargandoFechas.Update();

            List<string> lineas = new List<string>();

            lineas.Add("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            lineas.Add("<kml xmlns=\"http://www.opengis.net/kml/2.2\">");
            lineas.Add("\t<Document>");
            lineas.Add("\t\t<open>1</open>");
            lineas.Add("\t\t<name>" + fechaCSV + "</name>");

            lineas.Add("\t\t<Style id=\"Rojo\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            //lineas.Add("\t\t\t\t<scale>0.5</scale>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/red-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Rosado\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            //lineas.Add("\t\t\t\t<scale>0.5</scale>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/pink-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Amarillo\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            //lineas.Add("\t\t\t\t<scale>0.5</scale>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/ylw-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Celeste\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            //lineas.Add("\t\t\t\t<scale>0.5</scale>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/ltblu-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            lineas.Add("\t\t<Style id=\"Blanco\">");
            lineas.Add("\t\t\t<LabelStyle> <scale>0</scale></LabelStyle>");
            lineas.Add("\t\t\t<IconStyle>");
            //lineas.Add("\t\t\t\t<scale>0.5</scale>");
            lineas.Add("\t\t\t\t<Icon><href>http://maps.google.com/mapfiles/kml/paddle/wht-circle.png</href></Icon>");
            lineas.Add("\t\t\t</IconStyle>");
            lineas.Add("\t\t</Style>");

            foreach (DataGridViewRow row in dgv_lightningAll.Rows)
            {
                Double Ampl = Convert.ToDouble(row.Cells[3].Value.ToString());

                lineas.Add("\t\t<Placemark>");
                lineas.Add("\t\t\t<name>" + Convert.ToString(row.Cells[0].Value) + "</name>");
                if (Math.Abs(Ampl) > 80)
                    lineas.Add("\t\t\t\t<styleUrl>#Rojo</styleUrl>");
                else if (Math.Abs(Ampl) > 50)
                    lineas.Add("\t\t\t\t<styleUrl>#Rosado</styleUrl>");
                else if (Math.Abs(Ampl) > 35)
                    lineas.Add("\t\t\t\t<styleUrl>#Amarillo</styleUrl>");
                else if (Math.Abs(Ampl) > 20)
                    lineas.Add("\t\t\t\t<styleUrl>#Celeste</styleUrl>");
                else
                    lineas.Add("\t\t\t\t<styleUrl>#Blanco</styleUrl>");

                lineas.Add("\t\t\t<description>Amplitud: " + Convert.ToString(Ampl) + "kA</description>");
                lineas.Add("\t\t\t<Point>");
                lineas.Add("\t\t\t\t<coordinates>"+ Convert.ToString(row.Cells[1].Value) +","+ Convert.ToString(row.Cells[2].Value) + "</coordinates>");
                lineas.Add("\t\t\t</Point>");
                lineas.Add("\t\t</Placemark>");
            }
            lineas.Add("\t</Document>");
            lineas.Add("</kml>");

            string NombreCoop = this.cb_cooperativa.GetItemText(this.cb_cooperativa.SelectedItem);
            string nombreArchivo = NombreCoop + " - " + fechaCSV ;

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
                MessageBox.Show("No hay datos seleccionados\r\n" + exep.ToString(), "Error");
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
                lineas.Add("\t\t\t<PolyStyle> <color>4400ff00</color> </PolyStyle> ");
                lineas.Add("\t\t</Style>");

                lineas.Add("\t\t<Style id=\"color0\">");
                lineas.Add("\t\t\t<LineStyle> <width>0</width></LineStyle>");
                lineas.Add("\t\t\t<PolyStyle> <color>55000000</color> </PolyStyle> ");
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
                string NombreCoop = this.cb_cooperativa.GetItemText(this.cb_cooperativa.SelectedItem);
                string str3D = "";
                if (is3D)
                    str3D = "3D";
                else
                    str3D = "2D";
                string nombreArchivo = NombreCoop + " " + fechaInicial.ToString("ddMMyyyy") + "-" + fechaFinal.ToString("ddMMyyyy") + "_" + str3D;

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
            CSV_Content.Add("Fecha,Longitid,Latitud,Amplitud");
            foreach (DataGridViewRow row in dgv_lightningAll.Rows)
            {
                CSV_Content.Add(Convert.ToString(row.Cells[0].Value) +
                            "," + Convert.ToString(row.Cells[1].Value) +
                            "," + Convert.ToString(row.Cells[2].Value) +
                            "," + Convert.ToString(row.Cells[3].Value));
            }

            string NombreCoop = this.cb_cooperativa.GetItemText(this.cb_cooperativa.SelectedItem);
            string nombreArchivo = NombreCoop + " - " + fechaCSV;

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


    }
}
