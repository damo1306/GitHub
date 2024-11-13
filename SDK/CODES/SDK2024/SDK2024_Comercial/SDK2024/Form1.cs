using SDK_PRODUCTOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDK2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            btnCierraEmpresa.Enabled = false;
            btnAbreEmpresa.Enabled = false;
            btnTermina.Enabled = false;
        }

        private bool btnIniciaPress = false;
        private void btnInicia_Click(object sender, EventArgs e)
        {
            btnIniciaPress = true;
            SDK.fconexion(e);//e evento para la llamar a la función que se encuentra dentro de mi clase SDK para iniciar la conexión         
            //cmbEmpresas.DataSource = SDK.lista_empresas();//en mi combobox me lista las empresas que tengo existentes despues de iniciar SDK
            btnAbreEmpresa.Enabled = true;
            btnTermina.Enabled = true;
            MessageBox.Show("Sesion iniciada");
        }

        private void btnAbreEmpresa_Click(object sender, EventArgs e)
        {
            int nError = 0;

            if (btnIniciaPress)
            {

                //Object selItem = cmbEmpresas.SelectedItem;

                //C:\Compac\Empresas\adORGANICOS_NAVEZ_OSOR
                //SDK.fAbreEmpresa(selItem.ToString());
                nError = SDK.fAbreEmpresa("C:\\Compac\\Empresas\\adORAGNICOS_NAVEZ_OSOR");

                if (nError != 0)
                {
                    MessageBox.Show("Error: " + SDK.rError(nError));
                }
                else
                {
                    MessageBox.Show("Empresa abierta correctamente");

                    btnCierraEmpresa.Enabled = true;                
                }

                //MessageBox.Show("Se ha abierto la empresa " + selItem.ToString());
            }
            else
            {
                MessageBox.Show("No has iniciado SDK");
            }
        }

        private void btnCierraEmpresa_Click(object sender, EventArgs e)
        {
            SDK.fCierraEmpresa();
            btnCierraEmpresa.Enabled = false;
            MessageBox.Show("Cerraste la empresa..");
        }

        private void btnTermina_Click(object sender, EventArgs e)
        {
            if (btnIniciaPress == true)
            {
                SDK.fCierraEmpresa();
                SDK.fTerminaSDK();
                MessageBox.Show("Cerraste la empresa, se cerrará la sesión");
                //MessageBox.Show("Sesion terminada");
                Close();
            }
            else
            {
                MessageBox.Show("No iniciaste sesión anteriormente");
                Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnIniciaPress)
            {
                SDK.fCierraEmpresa();
                SDK.fTerminaSDK();
            }
        }
    }
}
