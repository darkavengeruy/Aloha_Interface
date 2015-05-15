using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CSVParsers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        

        private void btnDatosOriginales_Click(object sender, EventArgs e)
        {
            string origen = this.txtOrigen.Text; 
            var parsedData = ReadAndParseData(origen, ',');
                             
            DrawDataGridView(parsedData);
            this.btnDatosOriginales.Enabled = false;
            this.btnDatosBoletas.Enabled = false;
            this.btnDatosAlterados.Enabled = true;
            this.btnDatosSalvados.Enabled = true;

        }
        private void btnDatosBoletas_Click(object sender, EventArgs e)
        {
            string origen = this.txtOrigen.Text;
            var parsedData = ReadAndParseData(origen, ',');
                               
            DrawDataGridView1(parsedData);
            this.btnDatosOriginales.Enabled = false;
            this.btnDatosBoletas.Enabled = false;
            this.btnDatosAlterados.Enabled = true;
            this.btnDatosSalvados.Enabled = true;
        }

        private void btnDatosAlterados_Click(object sender, EventArgs e)
        {
            string destino = this.txtDestino.Text;
            //var parsedData = ReadAndParseData(@"d:\desarrollo\CSVParsers\CSVParsers\ventas_nuevos.csv", ',');
            var parsedData = ReadAndParseData(destino, ',');

            if (rbCuentas.Checked)
            {
                DrawDataGridView(parsedData);
            }
            else if (rbBoletas.Checked)
            {
                DrawDataGridView1(parsedData);
            }

       }
            
        private void btnDatosSalvados_Click(object sender, EventArgs e)
        {
            string origen = this.txtOrigen.Text;
            string destino = this.txtDestino.Text;
            var parsedData = ReadAndParseData(origen, ',');
            
            //var parsedData = ReadAndParseData(@"d:\desarrollo\CSVParsers\CSVParsers\ventas.csv", ',');            
            //using (var sw = new StreamWriter(@"d:\desarrollo\CSVParsers\CSVParsers\ventas_nuevos.csv"))

            using (var sw = new StreamWriter(destino))
            {
                foreach (string[] row in parsedData)
	            {
                    var sb = new StringBuilder();
                    foreach (string s in row)
	                {
                        sb.Replace('_', ' ');
                        sb.Replace("\"", "");
                        sb.Append(s + ",");		 
	                }
                    sb.Remove(sb.Length-1, 1);
                    sw.WriteLine(sb.ToString());		 
	            }
            }
        }

        private void btnOrigen_Click(object sender, EventArgs e)
        {
            // Al pulsar el botón Buscar, busca la ubicación del archivo csv.
            dataGridView1.Rows.Clear();
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Title = "Seleccionar fichero";
            oFD.Filter = "Documentos de texto (*.csv)|*.csv" + "|Todos los archivos (*.*)|*.*";
            oFD.FileName = this.txtOrigen.Text;
            if (oFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtOrigen.Text = oFD.FileName;
                }            
        }

        private void btndestino_Click(object sender, EventArgs e)
        {
            // Al pulsar el botón Buscar, busca destino del archivo csv modificado.
            SaveFileDialog oFD = new SaveFileDialog();
            oFD.Title = "Seleccionar fichero";
            oFD.Filter = "Documentos de texto (*.csv)|*.csv" + "|Todos los archivos (*.*)|*.*";
            oFD.FileName = this.txtDestino.Text;
            if (oFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtDestino.Text = oFD.FileName;
            } 
        }

        private void brnSalir_Click(object sender, EventArgs e)
        {
            this.Close();//salimos de la aplicacion
        }         
     
        //Aqui comienzan los metodos

        //aqui leemos los encabezados y los datos
        private static List<string[]> ReadAndParseData(string path, char separator)
        {
            var parsedData = new List<string[]>();
            using (var sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] row = line.Split(separator);
                    parsedData.Add(row);
                }
            }
            return parsedData;
        }

        //aqui leemos los datos del archivo y le quitamos las comillas y otros caracteres
        private void DrawDataGridView(List<string[]> parsedData)
        {
            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 41;
            for (int i = 0; i < 41; i++)

            //for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                var sb = new StringBuilder(parsedData[0][i]);
                sb.Replace('_', ' ');
                sb.Replace("\"", "");
                dataGridView1.Columns[i].Name = sb.ToString();
            }
            foreach (string[] row in parsedData)
            {
                dataGridView1.Rows.Add(row);
            }
            dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
        }

        private void DrawDataGridView1(List<string[]> parsedData)
        {
            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 35;
            for (int i = 0; i < 35; i++)

            
            {
                var sb = new StringBuilder(parsedData[0][i]);
                sb.Replace('_', ' ');
                sb.Replace("\"", "");
                dataGridView1.Columns[i].Name = sb.ToString();
            }
            foreach (string[] row in parsedData)
            {
                dataGridView1.Rows.Add(row);
            }
            
            dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
        }
        

        private void rbCuentas_CheckedChanged(object sender, EventArgs e)
        {
            this.btnDatosOriginales.Enabled = true;
            this.btnDatosBoletas.Enabled = false;
        }

        private void rbBoletas_CheckedChanged(object sender, EventArgs e)
        {
            this.btnDatosOriginales.Enabled = false;
            this.btnDatosBoletas.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnDatosOriginales.Enabled = false;
            this.btnDatosBoletas.Enabled = false;
            this.btnDatosAlterados.Enabled = false;
            this.btnDatosSalvados.Enabled = false;
        }
    }
}
