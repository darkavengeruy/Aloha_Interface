using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Limilabs.FTP.Client;
using System.Data.SqlClient;

namespace CSVParsers
{
    public partial class Principal : Form
    {
        // Las variables que usaremos en este ejemplo
        private DataTable dt;
        private SqlDataAdapter da;
        private int fila;

        public Principal()
        {
            InitializeComponent();       
                                                   
        }

        private void dtpFechaVenta_ValueChanged(object sender, EventArgs e)
        {
            string ubicacion;
            
            string fecha;
            ubicacion = "D:\\BOOTDRV\\Aloha\\";
            fecha = dtpFechaVenta.Value.ToString("yyyyMMdd");
            txtFechaElegida.Text = ubicacion + fecha;
        }
              

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            //string ruta = txtFechaElegida.Text;

            // Conectar y mostrar los datos
            //
            // La cadena de conexión
            string sCnn = "Data Source=" + txtServerSQL.Text +
                    "; " + "Initial Catalog=" + txtBaseDatosSQL.Text +
                    "; " + "User ID=" + txtUsuarioSQL.Text +
                    "; " + "Password=" + txtPasswordSQL.Text +"";
            

            SqlConnection cnn = new SqlConnection(sCnn);
            if (existeTabla(cnn, "Interface_SD") == false)
            {
                if (MessageBox.Show("NO existe la tabla Interface_SD, que es la usada para este ejemplo.\n" +
                    "¿Quieres crearla?", "No existe la tabla", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (crearTablaPrueba() == false)
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            // La cadena de selección
            string sSel = "SELECT * FROM Interface_SD";
            //
            // Comprobar si hay algún error
            try
            {
                // Crear un nuevo objeto del tipo DataAdapter
                da = new SqlDataAdapter(sSel, sCnn);
                // Crear los comandos de insertar, actualizar y eliminar
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                // Como hay campos con caracteres especiales,
                // al usarlos incluirlos entre corchetes.
                //cb.QuotePrefix = "[";
                //cb.QuoteSuffix = "]";
                // Asignar los comandos al DataAdapter
                // (se supone que lo hace automáticamente, pero...)
                //da.UpdateCommand = cb.GetUpdateCommand();
                //da.InsertCommand = cb.GetInsertCommand();
                //da.DeleteCommand = cb.GetDeleteCommand();
                //
                // Esta base de datos usa el ID con valores automáticos
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                //
                dt = new DataTable();
                // Llenar la tabla con los datos indicados
                da.Fill(dt);

                this.dataGridView1.DataSource = dt;
                //
                //// Habilitar los controles
                //foreach (Control c in this.GroupBox1.Controls)
                //{
                //    c.Enabled = true;
                //}
                //this.GroupBox1.Enabled = true;
                //this.GroupBox1.Text = "Conexión realizada";

                //// Y mostrar el primer registro
                //if (dt.Rows.Count > 0)
                //{
                //    btnFirst_Click(null, null);
                //}
                //else
                //{
                //    fila = -1;
                //    btnActualizar.Enabled = false;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR al conectar o recuperar los datos:\n" +
                    ex.Message, "Conectar con la base",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool existeTabla(SqlConnection cnn, string nombreTabla)
        {
            // Devuelve true si la tabla indicada está en la base usada con la conexión
            DataTable dt = new DataTable();
            bool existe = false;
            //
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT * FROM INFORMATION_SCHEMA.TABLES " +
                        "WHERE TABLE_TYPE = 'BASE TABLE' " +
                        "ORDER BY TABLE_TYPE", cnn);
                //
                da.Fill(dt);
                if (nombreTabla == null)
                    nombreTabla = "Interface_SD";
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["TABLE_NAME"].ToString() == nombreTabla)
                    {
                        return true;
                    }
                }
                //
                return existe;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Comprobar tabla");
                return false;
            }
        }

        private bool crearTablaPrueba()
        {
            // Crear la tabla de prueba en la base e instancias seleccionadas
            // Devuelve true si todo fue bien
            bool creada = false;
            string sCnn = "Server=" + txtServerSQL.Text + "; database=" + txtBaseDatosSQL.Text + "; integrated security=yes";
            string sCmd = "CREATE TABLE [dbo].[Prueba]( " +
                        "[ID] [int] IDENTITY(1,1) NOT NULL, " + "[Nombre] [nvarchar](50) COLLATE Modern_Spanish_CI_AS NULL," +
                        "[e-mail] [nvarchar](128) COLLATE Modern_Spanish_CI_AS NULL," +
                        "[FechaAlta] [datetime] NULL," + "[Comentario] [nvarchar](2048) COLLATE Modern_Spanish_CI_AS NULL," +
                        "CONSTRAINT [PK_Prueba] PRIMARY KEY CLUSTERED (" +
                        "[ID] ASC)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY])" +
                        " ON [PRIMARY]";
            SqlConnection cnn = null;
            try
            {
                cnn = new SqlConnection(sCnn);
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sCmd, cnn);

                cmd.ExecuteNonQuery();
                creada = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la tabla:\n" + ex.Message);

            }
            finally
            {
                if (cnn != null)
                {
                    if (cnn.State == ConnectionState.Open)
                    {
                        cnn.Close();
                    }
                }
            }

            return creada;
        }


        private void btnSubirFtp_Click(object sender, EventArgs e)
        {
            string p2;
            ExportarDatos(txtFechaElegida.Text, "01");
            
            SubidaFTP();         
        }

        private void ExportarDatos(string fecha, string p2)
        {
            using (SqlConnection con = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Exporta_Datos_Txt", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = txtFechaElegida.Text;
                    cmd.Parameters.Add("@Corr", SqlDbType.VarChar).Value = "01";

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
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
            Utilidades proUtilidades = new Utilidades();
            cifrarAES cifrarAES = new cifrarAES();

            //datos del local
            txtIdTienda.Text = proUtilidades.leerValorConfiguracion("Tienda.Id");
            txtNombreTienda.Text = proUtilidades.leerValorConfiguracion("Tienda.Nombre");

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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            
    }
}
