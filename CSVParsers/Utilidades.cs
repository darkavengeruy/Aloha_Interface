﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace CSVParsers
{
    class Utilidades
    {
        public string leerValorConfiguracion(string clave)
        {
            try
            {
                string resultado = ConfigurationManager.AppSettings[clave].ToString();
                return resultado;
            }
            catch
            {
                
                return"";
            }
        }

        public void guardarValorConfiguracion(string clave, string valor)
        {
            try
            {
                //La línea siguiente no funcionará bien en tiempo de diseño 
                //pues VC# usa el fichero xxx.vshost.config en la depuración 
                //Configuration config = 
                //    ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); 
                //sí pues la cambiamos por: 
                Configuration ficheroConfXML =
                    ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

                //eliminamos la clave actual (si existe), si no la eliminamos 
                //los valores se irán acumulando separados por coma 
                ficheroConfXML.AppSettings.Settings.Remove(clave);

                //asignamos el valor en la clave indicada 
                ficheroConfXML.AppSettings.Settings.Add(clave, valor);

                //guardamos los cambios definitivamente en el fichero de configuración 
                ficheroConfXML.Save(ConfigurationSaveMode.Modified);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar valor de configuracion: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

    }
}
