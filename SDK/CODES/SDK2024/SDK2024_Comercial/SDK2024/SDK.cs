using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace SDK_PRODUCTOS
{
    class SDK
    {
        #region METODOS DE WINDOWS
        [DllImport("KERNEL32")]
        public static extern int SetCurrentDirectory(string pPtrDirActual);
        #endregion

        #region METODOS DE CONEXION
        [DllImport("MGWServicios.dll")]
        public static extern void fInicioSesionSDK(string aUsuario, string aContrasenia);

        [DllImport("MGWServicios.dll")]
        public static extern void fTerminaSDK();

        [DllImport("MGWServicios.DLL")]
        public static extern int fSetNombrePAQ(String aNombrePAQ);

        [DllImport("MGWServicios.dll")]
        public static extern int fAbreEmpresa(string Directorio);

        [DllImport("MGWServicios.dll")]
        public static extern void fCierraEmpresa();

        [DllImport("MGWServicios.dll")]
        public static extern Int32 fPosPrimerEmpresa(ref int lIdEmpresa, StringBuilder lNombreEmpresa, StringBuilder lDirectorioEmpresa);

        [DllImport("MGWServicios.dll")]
        public static extern Int32 fPosSiguienteEmpresa(ref int lIdEmpresa, StringBuilder lNombreEmpresa, StringBuilder lDirectorioEmpresa);
        #endregion

        public static string fconexion(EventArgs e)
        {
            string sMensaje = "";
            int lError;

            //asignar la Ruta de DLL MGWServicios - Establece la ruta donde se encuentar el archivo MGWSERVICIOS.DLL
            RegistryKey keySistema = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Computación en Acción, SA CV\\CONTPAQ I COMERCIAL");
            object lEntrada = keySistema.GetValue("DirectorioBase");
            SetCurrentDirectory(lEntrada.ToString());

            //Aquí utilizamos la función mencionada fInicioSesionSDK
            fInicioSesionSDK("SUPERVISOR", "");

            //Sistemas : CONTPAQi® Comercial
            lError = fSetNombrePAQ("CONTPAQ I COMERCIAL");
            //Se valida con la función rError
            if (lError != 0)
            {
                rError(lError);
            }
            else
            {
                sMensaje = "Se abrió el SDK correctamente.";
            }

            return sMensaje;
        }

        [DllImport("MGWServicios.dll", EntryPoint = "fInicioSesionSDKCONTPAQi")]
        public static extern void fInicioSesionSDKCONTPAQi(string aUsuario, string aContrasenia);

        [DllImport("MGWServicios.dll", EntryPoint = "fObtieneLicencia")]
        public static extern int fObtieneLicencia(StringBuilder aCodAcvtiva,
                                                  StringBuilder aCodSitio,
                                                  StringBuilder aSerie,
                                                  StringBuilder aTagVersion);

        public static string fNoConexion(EventArgs e)
        {
            string mensajeNo = "No has iniciado SDK";

            return mensajeNo;
        }

        //public static List<string> lista_empresas()//Método para listar las empresas
        //{
        //    int lError;
        //    List<string> lempresas = new List<string>();
        //    StringBuilder aNombreEmpresa = new StringBuilder(255);
        //    StringBuilder aDirectorioEmpresa = new StringBuilder(255);

        //    int aldEmpresa = 0;
        //    lError = fPosPrimerEmpresa(ref aldEmpresa, aNombreEmpresa, aDirectorioEmpresa);
        //    lempresas.Add(aDirectorioEmpresa.ToString());

        //    do
        //    {
        //        lError = fPosSiguienteEmpresa(ref aldEmpresa, aNombreEmpresa, aDirectorioEmpresa);
        //        if (lError == 2)
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            lempresas.Add(aDirectorioEmpresa.ToString());
        //        }
        //    } while (lError == 0);

        //    return lempresas;
        //}

        #region METODOS DE ERRORES
        [DllImport("MGWServicios.dll")]
        public static extern void fError(int NumeroError, StringBuilder Mensaje, int Longitud);

        // Función para el manejo de errores en SDK
        public static string rError(int iError)
        {
            StringBuilder sMensaje = new StringBuilder(512);

            if (iError != 0)
            {
                fError(iError, sMensaje, 512);

            }
            return sMensaje.ToString();
        }
        #endregion
    }
}

