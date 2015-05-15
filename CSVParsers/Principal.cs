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
using Limilabs.FTP.Client;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace CSVParsers
{
    public partial class Principal : Form
    {
        // Las variables que usaremos en este ejemplo
        private DataTable dt;
        private SqlDataAdapter da;
        private int fila;
        public string fecha;
        public string fecha1;
        
        //private static ILog Log = LogManager.GetLogger("AlohaMallSalesExportEOD");
        //private frmShowFullScreenMessage frmMsg = new frmShowFullScreenMessage();
        private string sqlConectionString = "Data Source=" + Environment.MachineName + ConfigurationManager.ConnectionStrings["DBAlohaExport"].ConnectionString.ToString();
        private string sqlConectionCreate = "Data Source=" + Environment.MachineName + ConfigurationManager.ConnectionStrings["DBAlohaExportCreate"].ConnectionString.ToString();
        private Button BtExportar;
        
        
        public Principal()
        {
            InitializeComponent();       
                                                   
        }
      
        private void dtDesde_ValueChanged(object sender, EventArgs e)
        {
            //Generamosa la fecha para pasarsela al Store Procedure        

            fecha = dtDesde.Value.ToString("yyyyMMdd");
            txtFechaDesde.Text = fecha;
        }
        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            //Generamosa la fecha para pasarsela al Store Procedure        

            fecha1 = dtDesde.Value.ToString("yyyyMMdd");
            txtFechaHasta.Text = fecha1;
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            //string ruta = txtFechaElegida.Text;
            ConexionDatos();
        }

        private void ConexionDatos()
        {
            // Conectar y mostrar los datos
            //
            // La cadena de conexión
            string sCnn = "Data Source=" + txtServerSQL.Text +
                    "; " + "Initial Catalog=" + txtBaseDatosSQL.Text +
                    "; " + "User ID=" + txtUsuarioSQL.Text +
                    "; " + "Password=" + txtPasswordSQL.Text + "";

            SqlConnection cnn = new SqlConnection(sCnn);        
            
            // La cadena de selección
            string sSel = "SELECT * FROM Interface_SD";
            //
            // Comprobar si hay algún error
            try
            {
                // Crear un nuevo objeto del tipo DataAdapter
                da = new SqlDataAdapter(sSel, sCnn);                
                dt = new DataTable();
                // Llenar la tabla con los datos indicados
                da.Fill(dt);
                //Llenar el datagrid con datos
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al conectar o recuperar los datos:\n" +
                    ex.Message, "Conectar con la base",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubirFtp_Click(object sender, EventArgs e)
        {
          if (txtFechaDesde.Text == "")
            {
                MessageBox.Show("Debe elegir una fecha del venta a ser exportada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            //------------------------------
              DateTime dateTime1 = new DateTime(this.dtDesde.Value.Year, this.dtDesde.Value.Month, this.dtDesde.Value.Day);
              DateTime dateTime2 = new DateTime(this.dtHasta.Value.Year, this.dtHasta.Value.Month, this.dtHasta.Value.Day);
              if (dateTime1 == DateTime.Now)
              {
                int num1 = (int) MessageBox.Show("La fecha Desde debe ser diferente a la fecha actual", "Interface Aloha Export", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
              else if (dateTime1 == dateTime2)
              {
                int num2 = (int) MessageBox.Show("La fecha Desde debe ser diferente a la fecha Hasta", "Interface Aloha Export", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
              else if (dateTime2 < dateTime1)
              {
                  int num3 = (int)MessageBox.Show("La fecha Hasta no debe ser menor que la fecha Desde", "Interface Aloha Export", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
                  DateTime dateTime3 = new DateTime();
        try
        {
          //CLADataExporterClient dataExporterClient = new CLADataExporterClient();
          //dataExporterClient.Open();
          bool flag = false;
          StringBuilder stringBuilder = new StringBuilder();
          for (DateTime dateTime4 = this.dtDesde.Value; dateTime4 <= this.dtHasta.Value; dateTime4 = dateTime4.AddDays(1.0))
          {
            DateTime dob = dateTime4;
            if (dataExporterClient.Generaterefransales(dob))
            {
              Form1.Log.Info((object) string.Format("Fecha Exportada correctamente: {0}", (object) dob.ToString("yyyyMMdd")));
              flag = true;
            }
            else
            {
              Form1.Log.Error((object) string.Format("Fecha no pudo ser exportada :(   {0}", (object) dob.ToString("yyyyMMdd")));
              flag = false;
              stringBuilder.Append(dob.ToShortDateString() + "\n");
            }
          }
          if (flag && string.IsNullOrEmpty(stringBuilder.ToString()))
          {
            int num4 = (int) MessageBox.Show("Ventas Exportadas Correctamente.", "Aloha Sales Export", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else
          {
            int num5 = (int) MessageBox.Show("No se exportaron las siguientes fechas: \n" + stringBuilder.ToString(), "Aloha Sales Export", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
          this.frmMsg.Hide();
          Application.DoEvents();
          this.frmMsg.Close();
        }
        catch (Exception ex)
        {
          this.frmMsg.Hide();
          Application.DoEvents();
          this.frmMsg.Close();
          Form1.Log.Error((object) string.Format("No se pudo establecer conexion con el servicio WCF \n{0}", (object) ex));
          int num4 = (int) MessageBox.Show("No se pudo establecer conexion con el servicio WCF ", "Aloha Sales Export", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

                    //ExportarDatos(fecha);
                  //SubidaFTP();
      }
          
              
                  
                                           
     
        
         //Exportamos los datos usando un Store Procedure   
        private void ExportarDatos(string p1)
        {
            string sCnn = "Data Source=" + txtServerSQL.Text +
                    "; " + "Initial Catalog=" + txtBaseDatosSQL.Text +
                    "; " + "User ID=" + txtUsuarioSQL.Text +
                    "; " + "Password=" + txtPasswordSQL.Text + "";

            using (SqlConnection con = new SqlConnection())            
            {
                con.ConnectionString = sCnn;

                if (chkBoletaFiscal.Checked)
                {
                    using (SqlCommand cmd = new SqlCommand("Exporta_Datos_Txt", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = p1;

                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (SqlException e)
                        {
                            MessageBox.Show("Error: " + e.Message);
                        }
                    }
                }
                
                else
                {
                    using (SqlCommand cmd = new SqlCommand("Exporta_Datos_Txt_Sin_Fiscal", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = p1;

                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (SqlException e)
                        {
                            MessageBox.Show("Error: " + e.Message);
                        }
                    }
                }
                
                MessageBox.Show("Archivo grabado con exito" ,"Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void SubidaFTP()
        {
            // definimos las variables para el ftp
            string FTPServer;
            string Username;
            string Password;
            string CarpetaDestino;

            // asignamos los textbox a las variables del ftp
            FTPServer = txtServerFTP.Text;
            Username = txtUsuarioFTP.Text;
            Password = txtClaveFTP.Text;
            CarpetaDestino = txtDirectorioFTP.Text;

            try
            {
                using (Ftp client = new Ftp())
                {
                    client.Connect(FTPServer);

                    client.Login(Username, Password);

                    client.CreateFolder(CarpetaDestino);

                    LocalSearchOptions options = new LocalSearchOptions("*.txt", true);

                    client.UploadFiles(CarpetaDestino, @"D:\Bootdrv\Interface\", options);

                    client.Close();
                }
            MessageBox.Show("La informacion se subio correctamente", "Servidor FTP", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("FTP Error: " + ex.Message, "Servidor FTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            Utilidades proUtilidades = new Utilidades();
            cifrarAES cifrarAES = new cifrarAES();

            //DATOS DEL LOCAL
            proUtilidades.guardarValorConfiguracion("Tienda.Id", txtIdTienda.Text);
            proUtilidades.guardarValorConfiguracion("Tienda.Nombre", txtNombreTienda.Text);
            proUtilidades.guardarValorConfiguracion("Tienda.Correlativo", txtCorrelativo1.Text);


            //datos del FTP
            proUtilidades.guardarValorConfiguracion("FTP.Servidor", txtServerFTP.Text);
            proUtilidades.guardarValorConfiguracion("FTP.Usuario", txtUsuarioFTP.Text);
            proUtilidades.guardarValorConfiguracion("FTP.Contraseña",
                cifrarAES.cifrarTextoAES(txtClaveFTP.Text,
                "AjpdSoft_Frase_Encriptado", "AjpdSoft_Frase_Encriptado",
                "MD5", 22, "1234567891234567", 128));
            proUtilidades.guardarValorConfiguracion("FTP.Directorio", txtDirectorioFTP.Text);

            //DATOS DE LA BASE DE DATOS
            proUtilidades.guardarValorConfiguracion("BD.Servidor", txtServerSQL.Text);
            proUtilidades.guardarValorConfiguracion("BD.Usuario", txtUsuarioSQL.Text);            
            proUtilidades.guardarValorConfiguracion("BD.Contraseña", 
                cifrarAES.cifrarTextoAES (txtPasswordSQL.Text,
                "AjpdSoft_Frase_Encriptado", "AjpdSoft_Frase_Encriptado",
                "MD5", 22, "1234567891234567", 128));
            proUtilidades.guardarValorConfiguracion("BD.Base_Datos", txtBaseDatosSQL.Text);
            
            MessageBox.Show("La Configuracion se guardo correctamente.!!","Configuracion", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Principal_Load(object sender, EventArgs e)
        
        {
            CargarConfiguracion();
            this.BtExportar.Enabled = false;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      if (!this.ServiceIsRuning("SQL") || !this.ServiceIsRuning("Aloha Sales Export"))
        return;
      if (!this.TestSqlConnection(this.sqlConectionString, "VentasAloha"))
      {
        Form1.Log.Error((object) "Servidor Sql Server no disponible (Es posible que el servicio de SQLSERVER no haya iniciado en este punto). El 'Servicio Aloha Mall Export' seguira ejecutandose.");
        switch (MessageBox.Show("La base de datos SQL no existe desea crearla", "Aloha Sales Export", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
        {
          case DialogResult.Yes:
            if (this.CreateDataBase())
            {
              Form1.Log.Info((object) "Se Creo con exito la base de datos VentasAloha en el servidor SQL");
              int num = (int) MessageBox.Show("Se Creo con exito la base de datos VentasAloha en el servidor SQL.", "Aloha Sales Export", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              this.StartProcessExport();
              break;
            }
            Form1.Log.Info((object) "No se pudo crear la base de datos VentasAloha en el servidor SQL");
            int num1 = (int) MessageBox.Show("No se pudo Crear la base de datos VentasAloha en el servidor SQL,\n Contacte a su administrador para revisar que los servicios SQL estan corriendo", "Aloha Sales Export", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          case DialogResult.No:
            this.Close();
            break;
        }
      }
      else
        this.StartProcessExport();
    }

    private void StartProcessExport()
    {
      this.lblMjs.Text = "Aloha Sales Export EOD  " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
      this.dtHasta.MaxDate = Functions2.GetDobDt();
      this.BtExportar.Enabled = true;
    }

    #region Chequeo de servicio sql corriendo
    //private bool ServiceIsRuning(string serviceName)
    //{
    //  try
    //  {
    //    if (serviceName == "SQL")
    //    {
    //      if (Enumerable.FirstOrDefault<ServiceController>((IEnumerable<ServiceController>) ServiceController.GetServices(), (Func<ServiceController, bool>) (s => string.Compare(s.ServiceName, "MSSQL$SQLEXPRESS", false) == 0)) == null)
    //      {
    //        Enumerable.FirstOrDefault<ServiceController>((IEnumerable<ServiceController>) ServiceController.GetServices(), (Func<ServiceController, bool>) (s => string.Compare(s.ServiceName, "MSSQLSERVER", false) == 0));
    //        serviceName = "MSSQLSERVER";
    //      }
    //      else
    //        serviceName = "MSSQL$SQLEXPRESS";
    //    }
    //    ServiceController serviceController = new ServiceController(serviceName);
    //    if (serviceController.Status.Equals((object) ServiceControllerStatus.Stopped) || serviceController.Status.Equals((object) ServiceControllerStatus.StopPending))
    //    {
    //      Form1.Log.Error((object) string.Format("El servicio: {0}, no se estaba ejecutando", (object) serviceName));
    //      serviceController.Start();
    //      Form1.Log.Error((object) string.Format("Se inicio el servicio: {0}", (object) serviceName));
    //    }
    //    return true;
    //  }
    //  catch (Exception ex)
    //  {
    //    string text = string.Format("No se pudo iniciar el servicio: {0}", (object) serviceName);
    //    Form1.Log.Error((object) text);
    //    int num = (int) MessageBox.Show(text, "Aloha Sales Export", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    //    return false;
    //  }
    //}
    #endregion

    private bool TestSqlConnection(string ConnString, string DatabaseName)
    {
      bool flag = false;
      try
      {
        Form1.Log.Info((object) string.Format("Testing Connection String for Database {0} - Connection String: {1}", (object) DatabaseName, (object) ConnString));
        using (SqlConnection sqlConnection = new SqlConnection(ConnString))
        {
          sqlConnection.Open();
          Form1.Log.Info((object) string.Format("Conexion a base de datos {0} correcta.", (object) DatabaseName));
          flag = true;
        }
      }
      catch (Exception ex)
      {
        Form1.Log.Error((object) string.Format("Fallo conexion con base de datos {0}: {1}", (object) DatabaseName, (object) ex.Message));
      }
      return flag;
    }


    private bool CreateDataBase()
    {
      try
      {
        string input = File.ReadAllText(Functions.GetAlohaPath() + "\\AlohaSalesExport\\SQL Refran DB.sql");
        Form1.Log.Info((object) "Ejecutando query para crear la base de datos VentasAloha en el servidor SQL");
        IEnumerable<string> enumerable = (IEnumerable<string>) Regex.Split(input, "^\\s*GO\\s*$", RegexOptions.IgnoreCase | RegexOptions.Multiline);
        SqlConnection connection = new SqlConnection(this.sqlConectionCreate);
        connection.Open();
        foreach (string cmdText in enumerable)
        {
          if (cmdText.Trim() != "")
          {
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, connection))
              sqlCommand.ExecuteNonQuery();
          }
        }
        connection.Close();
        return true;
      }
      catch (Exception ex)
      {
        Form1.Log.Error((object) string.Format("No se pudo Crear la base de datos VentasAloha en el servidor SQL, Error{0}", (object) ex));
        return false;
      }
    }

#region Cargar Configuracion
        private void CargarConfiguracion()
        {
            Utilidades proUtilidades = new Utilidades();
            cifrarAES cifrarAES = new cifrarAES();

            //datos del local
            txtIdTienda.Text = proUtilidades.leerValorConfiguracion("Tienda.Id");
            txtNombreTienda.Text = proUtilidades.leerValorConfiguracion("Tienda.Nombre");
            txtCorrelativo1.Text = proUtilidades.leerValorConfiguracion("Tienda.Correlativo");

            //datos del ftp
            txtServerFTP.Text = proUtilidades.leerValorConfiguracion("FTP.Servidor");
            txtUsuarioFTP.Text = proUtilidades.leerValorConfiguracion("FTP.Usuario");
            txtClaveFTP.Text =
                cifrarAES.descifrarTextoAES(
                proUtilidades.leerValorConfiguracion("FTP.Contraseña"),
                "AjpdSoft_Frase_Encriptado", "AjpdSoft_Frase_Encriptado",
                "MD5", 22, "1234567891234567", 128);
            txtDirectorioFTP.Text = proUtilidades.leerValorConfiguracion("FTP.Directorio");


            //datos de la base de datos
            txtServerSQL.Text = proUtilidades.leerValorConfiguracion("BD.Servidor");
            txtUsuarioSQL.Text = proUtilidades.leerValorConfiguracion("BD.Usuario");
            txtPasswordSQL.Text = cifrarAES.descifrarTextoAES(
                proUtilidades.leerValorConfiguracion("BD.Contraseña"),
                "AjpdSoft_Frase_Encriptado", "AjpdSoft_Frase_Encriptado",
                "MD5", 22, "1234567891234567", 128);
            txtBaseDatosSQL.Text = proUtilidades.leerValorConfiguracion("BD.Base_Datos");
        }
#endregion

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subirAlFTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubidaFTP();
        }
    }
}
