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
        string fechaInicial;
        string fechaCSV = "";
        string fechaFinal;
        int cooperativaID;
        bool disableFiringEvents = false;

        public int MaxValue()
        {
            int max = 0;
            for (int i = 0; i < dgv_lightning1.Rows.Count - 1; i++)
            {
                int cellValue = Convert.ToInt32(dgv_lightning1.Rows[i].Cells[0].Value.ToString());
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
            //cb_cooperativa.SelectedIndex = cb_cooperativa.Items.Count - 1;
            cb_cooperativa.SelectedIndex = 2;
            cooperativaID = Convert.ToInt32(cb_cooperativa.SelectedValue.ToString());
            
            foreach (DataGridViewColumn column in dgv_lightning1.Columns)
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

        private void btn_createKML_Click(object sender, EventArgs e)
        {
            int NumeroRayos = 0;
            bool IntConvertido = false;
            int ValorMaximo = MaxValue();
            int Valor4 = ValorMaximo * 7 / 10;
            int Valor3 = ValorMaximo * 5 / 10;
            int Valor2 = ValorMaximo * 25 / 100;
            int Valor1 = ValorMaximo * 1 / 10;
            int ContFila = 0;
            int NumFilas = dgv_lightning1.Rows.Count;
            int alturaColumna = 10;
            double factorAltura = 10000.0 / (MaxValue() * MaxValue());

            const double anchoBase = 0.004;
            bool is3D = Convert.ToBoolean(this.Check3D.Checked);
            bool NoConvError = false;



            try
            {
                IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
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
                lineas.Add("\t\t\t<gx:altitudeMode> relativeToSeaFloor </gx:altitudeMode>");
                lineas.Add("\t\t</LookAt>");

                ///////////////////////////////////////////////////////////////////////////////////
                /// Nivel 4
                /// 
                lineas.Add("\t\t<Folder>");
                lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor4 + 1) + " y " + Convert.ToString(ValorMaximo) + " Descargas</name>");
                lineas.Add("\t\t\t<visibility>1</visibility>");
                lineas.Add("\t\t\t<open>0</open>");


                if (ContFila < NumFilas - 1)
                    IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                double latitud = 0.0;
                double longitud = 0.0;

                IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                latitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[1].Value.ToString());
                longitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[2].Value.ToString());

                while (NumeroRayos > Valor4 && IntConvertido == true && ContFila < NumFilas - 1)
                {
                    if (IntConvertido)
                    {

                        lineas.Add("\t\t\t<Placemark>");
                        lineas.Add("\t\t\t\t<name>" + Convert.ToString(NumeroRayos) + " - " + Convert.ToString(ContFila) + "</name>");
                        lineas.Add("\t\t\t\t<description>" + Convert.ToString(NumeroRayos) + " Descargas atmosfericas</description>");
                        lineas.Add("\t\t\t\t<styleUrl>#color4</styleUrl>");
                        lineas.Add("\t\t\t\t<Polygon>");
                        if (is3D)
                        {
                            lineas.Add("\t\t\t\t\t<extrude>1</extrude>");
                            alturaColumna = Convert.ToInt32(factorAltura * NumeroRayos * NumeroRayos);
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

                    NumeroRayos = 0;
                    ContFila++;
                    IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                    latitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[2].Value.ToString());
                    
                }
                lineas.Add("\t\t</Folder>");


                ///////////////////////////////////////////////////////////////////////////////////
                /// Nivel 3
                /// 
                lineas.Add("\t\t<Folder>");
                lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor3 + 1) + " y " + Convert.ToString(Valor4) + " Descargas</name>");
                lineas.Add("\t\t\t<visibility>1</visibility>");
                lineas.Add("\t\t\t<open>0</open>");

                NumeroRayos = 0;
                if (ContFila < NumFilas - 1)
                    IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                latitud = 0.0;
                longitud = 0.0;
                IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                latitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[1].Value.ToString());
                longitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[2].Value.ToString());

                while (NumeroRayos > Valor3 && IntConvertido == true && ContFila < NumFilas - 1)
                {

                    if (IntConvertido)
                    {
                        lineas.Add("\t\t\t<Placemark>");
                        lineas.Add("\t\t\t\t<name>" + Convert.ToString(NumeroRayos) + " - " + Convert.ToString(ContFila) + "</name>");
                        lineas.Add("\t\t\t\t<description>" + Convert.ToString(NumeroRayos) + " Descargas atmosfericas</description>");
                        lineas.Add("\t\t\t\t<styleUrl>#color3</styleUrl>");
                        lineas.Add("\t\t\t\t<Polygon>");
                        if (is3D)
                        {
                            lineas.Add("\t\t\t\t\t<extrude>1</extrude>");
                            alturaColumna = Convert.ToInt32(factorAltura * NumeroRayos * NumeroRayos);
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
                    NumeroRayos = 0;
                    ContFila++;
                    IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                    latitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[2].Value.ToString());
                    
                }
                lineas.Add("\t\t</Folder>");


                ///////////////////////////////////////////////////////////////////////////////////
                /// Nivel 2
                /// 
                lineas.Add("\t\t<Folder>");
                lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor2 + 1) + " y " + Convert.ToString(Valor3) + " Descargas</name>");
                lineas.Add("\t\t\t<visibility>1</visibility>");
                lineas.Add("\t\t\t<open>0</open>");

                NumeroRayos = 0;
                if (ContFila < NumFilas - 1)
                    IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                latitud = 0.0;
                longitud = 0.0;
                IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                latitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[1].Value.ToString());
                longitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[2].Value.ToString());

                while (NumeroRayos > Valor2 && IntConvertido == true && ContFila < NumFilas - 1)
                {
                    if (IntConvertido)
                    {
                        lineas.Add("\t\t\t<Placemark>");
                        lineas.Add("\t\t\t\t<name>" + Convert.ToString(NumeroRayos) + " - " + Convert.ToString(ContFila) + "</name>");
                        lineas.Add("\t\t\t\t<description>" + Convert.ToString(NumeroRayos) + " Descargas atmosfericas</description>");
                        lineas.Add("\t\t\t\t<styleUrl>#color2</styleUrl>");
                        lineas.Add("\t\t\t\t<Polygon>");
                        if (is3D)
                        {
                            lineas.Add("\t\t\t\t\t<extrude>1</extrude>");
                            alturaColumna = Convert.ToInt32(factorAltura * NumeroRayos * NumeroRayos);
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

                    NumeroRayos = 0;
                    ContFila++;

                    IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                    latitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[2].Value.ToString());

                    
                }
                lineas.Add("\t\t</Folder>");

                ///////////////////////////////////////////////////////////////////////////////////
                /// Nivel 1
                /// 
                lineas.Add("\t\t<Folder>");
                lineas.Add("\t\t\t<name>Entre " + Convert.ToString(Valor1 + 1) + " y " + Convert.ToString(Valor2) + " Descargas</name>");
                lineas.Add("\t\t\t<visibility>1</visibility>");
                lineas.Add("\t\t\t<open>0</open>");

                NumeroRayos = 0;
                if (ContFila < NumFilas - 1)
                {
                    IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                    latitud = 0.0;
                    longitud = 0.0;
                    IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                    latitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[2].Value.ToString());
                }
                while (NumeroRayos > Valor1 && IntConvertido == true && ContFila < NumFilas - 1)
                {
                    if (IntConvertido)
                    {
                        lineas.Add("\t\t\t<Placemark>");
                        lineas.Add("\t\t\t\t<name>" + Convert.ToString(NumeroRayos) + " - " + Convert.ToString(ContFila) + "</name>");
                        lineas.Add("\t\t\t\t<description>" + Convert.ToString(NumeroRayos) + " Descargas atmosfericas</description>");
                        lineas.Add("\t\t\t\t<styleUrl>#color1</styleUrl>");
                        lineas.Add("\t\t\t\t<Polygon>");
                        if (is3D)
                        {
                            lineas.Add("\t\t\t\t\t<extrude>1</extrude>");
                            alturaColumna = Convert.ToInt32(factorAltura * NumeroRayos * NumeroRayos);
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

                    NumeroRayos = 0;
                    ContFila++;
                    IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                    latitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[2].Value.ToString());
                }
                lineas.Add("\t\t</Folder>");

                ///////////////////////////////////////////////////////////////////////////////////
                /// Nivel 0
                /// 
                lineas.Add("\t\t<Folder>");
                lineas.Add("\t\t\t<name>Menos de "+ Convert.ToString(Valor1) + " Descargas</name>");
                lineas.Add("\t\t\t<visibility>1</visibility>");
                lineas.Add("\t\t\t<open>0</open>");

                NumeroRayos = 0;
                if (ContFila < NumFilas - 1)
                { 
                    IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                    latitud = 0.0;
                    longitud = 0.0;
                    IntConvertido = Int32.TryParse(dgv_lightning1.Rows[ContFila].Cells[0].Value.ToString(), out NumeroRayos);
                    latitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[1].Value.ToString());
                    longitud = Convert.ToDouble(dgv_lightning1.Rows[ContFila].Cells[2].Value.ToString());
                }
                while (NumeroRayos > 0 && IntConvertido == true && ContFila < NumFilas - 1)
                {
                    if (IntConvertido)
                    {
                        lineas.Add("\t\t\t<Placemark>");
                        lineas.Add("\t\t\t\t<name>" + Convert.ToString(NumeroRayos) + " - " + Convert.ToString(ContFila) + "</name>");
                        lineas.Add("\t\t\t\t<description>" + Convert.ToString(NumeroRayos) + " Descargas atmosfericas</description>");
                        lineas.Add("\t\t\t\t<styleUrl>#color0</styleUrl>");
                        lineas.Add("\t\t\t\t<Polygon>");
                        if (is3D)
                        {
                            lineas.Add("\t\t\t\t\t<extrude>1</extrude>");
                            alturaColumna = Convert.ToInt32(factorAltura * NumeroRayos * NumeroRayos);
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
                    NumeroRayos = 0;
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
                string nombreArchivo = NombreCoop + " " + fechaInicial + " - " + fechaFinal + "_" + str3D;

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
        }

        private void btn_CrearCSV_Click(object sender, EventArgs e)
        {

            lbl_cargando.Visible = true;
            lbl_cargando.Text = "Creando CSV";
            lbl_cargando.BringToFront();
            lbl_cargando.Update();
            List<string> CSV_Content = new List<string>();
            //string CSV_Content = "";

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
            saveFileDialog1.Title = "Save text Files";
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

            lbl_cargando.Visible = false;
            lbl_cargando.Text = "Cargando ......";
            lbl_cargando.Update();

        }


        private void cb_cooperativa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cooperativaID = Convert.ToInt32(cb_cooperativa.SelectedValue.ToString());
            ActualizarTablas();

        }

        private void dtp_Inicial_ValueChanged(object sender, EventArgs e)
        {
            if (!disableFiringEvents)
                ActualizarTablas();
        }

        private void dtp_final_ValueChanged(object sender, EventArgs e)
        {
            if (!disableFiringEvents)
                ActualizarTablas();
        }

        private void ActualizarTablas()
        {
            lbl_cargando.Visible = true;
            lbl_cargando.BringToFront();
            lbl_cargando.Update();
            try
            {
                fechaInicial = this.dtp_Inicial.Value.ToString("yyyy-MM-dd");
                fechaFinal = this.dtp_final.Value.ToString("yyyy-MM-dd");

                dgv_lightningByMonth.DataSource = this.countLightningsByMonthTableAdapter.GetData(fechaInicial,fechaFinal, cooperativaID);
                dgv_lightningByMonth.ClearSelection();
                dgv_lightningAll.DataSource = null;
                dgv_lightningByDay.DataSource = null;
                dgv_lightning1.ClearSelection();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            lbl_cargando.Visible = false;
            lbl_cargando.Update();

        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            ActualizarTablas();
        }

        private void dgv_lightningByMonth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            btn_CrearCSV.Enabled = false;
            btn_crearKMLpoints.Enabled = false;
            lbl_cargando.Visible = true;
            lbl_cargando.BringToFront();
            lbl_cargando.Update();

            string fecha = dgv_lightningByMonth.Rows[e.RowIndex].Cells[0].Value.ToString();
            dgv_lightningByDay.DataSource = this.countLightningsByDayTableAdapter.GetData(fecha, cooperativaID);
            dgv_lightningAll.DataSource = null;
            dgv_lightningByDay.ClearSelection();

            lbl_cargando.Visible = false;
            lbl_cargando.Update();
        }

        private void dgv_lightningByDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            btn_CrearCSV.Enabled = true;
            btn_crearKMLpoints.Enabled = true;
            fechaCSV = dgv_lightningByDay.Rows[e.RowIndex].Cells[0].Value.ToString();
            lbl_cargando.Visible = true;
            lbl_cargando.BringToFront();
            lbl_cargando.Update();

            string fecha = dgv_lightningByDay.Rows[e.RowIndex].Cells[0].Value.ToString();

            DateTime aa = (DateTime)dgv_lightningByDay.Rows[e.RowIndex].Cells[0].Value;
            fechaCSV = aa.Date.ToString("dd_MM_yyyy");
            dgv_lightningAll.DataSource = this.getAllLightningsTableAdapter.GetData(fecha, cooperativaID);
            dgv_lightningAll.ClearSelection();
            dgv_lightningAll.Sort(dgv_lightningAll.Columns[0],ListSortDirection.Ascending);

            lbl_cargando.Visible = false;
            lbl_cargando.Update();
        }

        private void btn_crearKMLpoints_Click(object sender, EventArgs e)
        {
            lbl_cargando.Visible = true;
            lbl_cargando.Text = "Creando KML";
            lbl_cargando.BringToFront();
            lbl_cargando.Update();

            List<string> lineas = new List<string>();

            lineas.Add("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            lineas.Add("<kml xmlns=\"http://www.opengis.net/kml/2.2\">");
            lineas.Add("\t<Document>");
            lineas.Add("\t\t<open>1</open>");
            lineas.Add("\t\t<name>" + fechaCSV + "</name>");

            foreach (DataGridViewRow row in dgv_lightningAll.Rows)
            {
                lineas.Add("\t\t<Placemark>");
                lineas.Add("\t\t\t<name>" + Convert.ToString(row.Cells[0].Value) + "</name>");
                lineas.Add("\t\t\t<description>Amplitud: " + Convert.ToString(row.Cells[3].Value) + "kA</description>");
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


            lbl_cargando.Visible = false;
            lbl_cargando.Text = "Cargando ......";
            lbl_cargando.Update();
        }
    }
}
