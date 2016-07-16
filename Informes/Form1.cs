using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace Informes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<ReportParameter> crearLiquidacion()
        {
            string r = txtSueldoBase.Text;
            List<ReportParameter> parametros = new List<ReportParameter>();

            /* Header */

            ReportParameter nombreTrabajador    = new ReportParameter("txtNombreTrabajador", "Nombre Trabajador");
            ReportParameter rutTrabajador       = new ReportParameter("txtRut", "RUT Trabajador");
            ReportParameter fechaContratacion   = new ReportParameter("txtFechaContratacion", "Fecha Contratacion");
            ReportParameter cargo               = new ReportParameter("txtCargo", "Cargo Trabajador");
            ReportParameter tipoContrato        = new ReportParameter("txtTipoContrato", "Tipo Contrato");
            ReportParameter valorUF             = new ReportParameter("txtValorUF", "22,58");
            ReportParameter TopeImponible       = new ReportParameter("txtTopeImponible", "4654623");
            parametros.Add(nombreTrabajador);
            parametros.Add(rutTrabajador);
            parametros.Add(fechaContratacion);
            parametros.Add(cargo);
            parametros.Add(tipoContrato);
            parametros.Add(valorUF);
            parametros.Add(TopeImponible);
            /** Haberes **/
            /* Imponible */
            ReportParameter sueldoBase          = new ReportParameter("txtSueldoBase", txtSueldoBase.Text);
            ReportParameter descuento           = new ReportParameter("txtDescuentos", txtDescuento.Text);
            ReportParameter gratificacion       = new ReportParameter("txtValorGratificacion", txtGratificacion.Text);
            ReportParameter totalImponible      = new ReportParameter("txtTotalImponible", txtTotalImponible.Text);
            parametros.Add(sueldoBase);
            parametros.Add(descuento);
            parametros.Add(gratificacion);
            parametros.Add(totalImponible);
            /* No Imponible */
            ReportParameter movilizacion        = new ReportParameter("txtValorMovilizacion", txtMovilizacion.Text);
            ReportParameter colacion            = new ReportParameter("txtValorColacion", txtColacion.Text);
            ReportParameter totalNoImponible    = new ReportParameter("txtValorTotalNoImponible", txtTotalNoImponible.Text);
            parametros.Add(movilizacion);
            parametros.Add(colacion);
            parametros.Add(totalNoImponible);
            /* Total Haberes */
            ReportParameter totalHaberes        = new ReportParameter("txtTotalHaberes", txtTotalHaberes.Text);
            parametros.Add(totalHaberes);

            /** Descuentos **/
            ReportParameter valorAFP            = new ReportParameter("txtValorAFP", txtAFP.Text);
            ReportParameter valorSalud          = new ReportParameter("txtValorSalud", txtSalud.Text);
            ReportParameter valorAFC            = new ReportParameter("txtValorAFC", txtAFC.Text);
            ReportParameter valorSeguro         = new ReportParameter("txtValorSeguros", txtSeguros.Text);
            ReportParameter valorOtrosDescuentos = new ReportParameter("txtOtrosDescuentos", txtOtrosDescuentos.Text);
            ReportParameter valorImpuesto       = new ReportParameter("txtValorImpuesto", txtImpuesto2.Text);
            ReportParameter totalDescuentos     = new ReportParameter("txtTotalDescuentos", txtTotalDescuentos.Text);
            parametros.Add(valorAFP);
            parametros.Add(valorSalud);
            parametros.Add(valorAFC);
            parametros.Add(valorSeguro);
            parametros.Add(valorOtrosDescuentos);
            parametros.Add(valorImpuesto);
            parametros.Add(totalDescuentos);

            /** Pago **/

            ReportParameter alcanceLiquido      = new ReportParameter("txtAlcanceLiquido", txtAlcanceLiquido.Text);
            ReportParameter anticipos           = new ReportParameter("txtAnticipos", txtAnticipos.Text);
            ReportParameter totalAPagar         = new ReportParameter("txtTotalAPagar", txtTotalAPagar.Text);
            parametros.Add(alcanceLiquido);
            parametros.Add(anticipos);
            parametros.Add(totalAPagar);

            /** Footer **/
            NumeroAPalabras n                   = new NumeroAPalabras();
            ReportParameter fechaEmision        = new ReportParameter("txtFechaEmision", DateTime.Now.ToShortDateString());
            ReportParameter son                 = new ReportParameter("txtSon", "Son: " + n.Convertir(txtTotalAPagar.Text, false));
            parametros.Add(fechaEmision);
            parametros.Add(son);



            return parametros;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

       


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            Liquidacion l = new Liquidacion();
            l.reportViewer1.LocalReport.SetParameters(crearLiquidacion());
            l.reportViewer1.RefreshReport();
            l.Show();
        }

        private void txtSueldoBase_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sueldoBase          = int.Parse(txtSueldoBase.Text);
                int descuentos          = int.Parse(txtDescuento.Text);
                int gratificacion       = int.Parse(txtGratificacion.Text);
                int totalImponible      = sueldoBase - descuentos + gratificacion;
                txtTotalImponible.Text  = totalImponible.ToString();
            }
            catch(Exception)
            {

            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sueldoBase          = int.Parse(txtSueldoBase.Text);
                int descuentos          = int.Parse(txtDescuento.Text);
                int gratificacion       = int.Parse(txtGratificacion.Text);
                int totalImponible      = sueldoBase - descuentos + gratificacion;
                txtTotalImponible.Text  = totalImponible.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtGratificacion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sueldoBase          = int.Parse(txtSueldoBase.Text);
                int descuentos          = int.Parse(txtDescuento.Text);
                int gratificacion       = int.Parse(txtGratificacion.Text);
                int totalImponible      = sueldoBase - descuentos + gratificacion;
                txtTotalImponible.Text  = totalImponible.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtMovilizacion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int movilizacion            = int.Parse(txtMovilizacion.Text);
                int colacion                = int.Parse(txtColacion.Text);
                int totalNoImponible        = movilizacion + colacion;
                txtTotalNoImponible.Text    = totalNoImponible.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtColacion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int movilizacion            = int.Parse(txtMovilizacion.Text);
                int colacion                = int.Parse(txtColacion.Text);
                int totalNoImponible        = movilizacion + colacion;
                txtTotalNoImponible.Text    = totalNoImponible.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtTotalImponible_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int totalImponible          = int.Parse(txtTotalImponible.Text);
                int totalNoImponible        = int.Parse(txtTotalNoImponible.Text);
                int totalHaberes            = totalImponible + totalNoImponible;
                txtTotalHaberes.Text        = totalHaberes.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtTotalNoImponible_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int totalImponible = int.Parse(txtTotalImponible.Text);
                int totalNoImponible = int.Parse(txtTotalNoImponible.Text);
                int totalHaberes = totalImponible + totalNoImponible;
                txtTotalHaberes.Text = totalHaberes.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtAFP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int afp = int.Parse(txtAFP.Text);
                int salud = int.Parse(txtSalud.Text);
                int afc = int.Parse(txtAFC.Text);
                int seguros = int.Parse(txtSeguros.Text);
                int otrosDescuentos = int.Parse(txtOtrosDescuentos.Text);
                int impuesto = int.Parse(txtImpuesto2.Text);
                int totalDescuentos = afp + salud + afc + seguros + otrosDescuentos + impuesto;
                txtTotalDescuentos.Text = totalDescuentos.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void txtSalud_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int afp = int.Parse(txtAFP.Text);
                int salud = int.Parse(txtSalud.Text);
                int afc = int.Parse(txtAFC.Text);
                int seguros = int.Parse(txtSeguros.Text);
                int otrosDescuentos = int.Parse(txtOtrosDescuentos.Text);
                int impuesto = int.Parse(txtImpuesto2.Text);
                int totalDescuentos = afp + salud + afc + seguros + otrosDescuentos + impuesto;
                txtTotalDescuentos.Text = totalDescuentos.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtAFC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int afp = int.Parse(txtAFP.Text);
                int salud = int.Parse(txtSalud.Text);
                int afc = int.Parse(txtAFC.Text);
                int seguros = int.Parse(txtSeguros.Text);
                int otrosDescuentos = int.Parse(txtOtrosDescuentos.Text);
                int impuesto = int.Parse(txtImpuesto2.Text);
                int totalDescuentos = afp + salud + afc + seguros + otrosDescuentos + impuesto;
                txtTotalDescuentos.Text = totalDescuentos.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtSeguros_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int afp = int.Parse(txtAFP.Text);
                int salud = int.Parse(txtSalud.Text);
                int afc = int.Parse(txtAFC.Text);
                int seguros = int.Parse(txtSeguros.Text);
                int otrosDescuentos = int.Parse(txtOtrosDescuentos.Text);
                int impuesto = int.Parse(txtImpuesto2.Text);
                int totalDescuentos = afp + salud + afc + seguros + otrosDescuentos + impuesto;
                txtTotalDescuentos.Text = totalDescuentos.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtOtrosDescuentos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int afp = int.Parse(txtAFP.Text);
                int salud = int.Parse(txtSalud.Text);
                int afc = int.Parse(txtAFC.Text);
                int seguros = int.Parse(txtSeguros.Text);
                int otrosDescuentos = int.Parse(txtOtrosDescuentos.Text);
                int impuesto = int.Parse(txtImpuesto2.Text);
                int totalDescuentos = afp + salud + afc + seguros + otrosDescuentos + impuesto;
                txtTotalDescuentos.Text = totalDescuentos.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtImpuesto2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int afp = int.Parse(txtAFP.Text);
                int salud = int.Parse(txtSalud.Text);
                int afc = int.Parse(txtAFC.Text);
                int seguros = int.Parse(txtSeguros.Text);
                int otrosDescuentos = int.Parse(txtOtrosDescuentos.Text);
                int impuesto = int.Parse(txtImpuesto2.Text);
                int totalDescuentos = afp + salud + afc + seguros + otrosDescuentos + impuesto;
                txtTotalDescuentos.Text = totalDescuentos.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtTotalHaberes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int totalHaberes        = int.Parse(txtTotalHaberes.Text);
                int totalDescuentos     = int.Parse(txtTotalDescuentos.Text);         
                int alcanceLiquido      = totalHaberes - totalDescuentos;
                txtAlcanceLiquido.Text  = alcanceLiquido.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtTotalDescuentos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int totalHaberes = int.Parse(txtTotalHaberes.Text);
                int totalDescuentos = int.Parse(txtTotalDescuentos.Text);
                int alcanceLiquido = totalHaberes - totalDescuentos;
                txtAlcanceLiquido.Text = alcanceLiquido.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtAlcanceLiquido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int alcanceLiquido = int.Parse(txtAlcanceLiquido.Text);
                int anticipos = int.Parse(txtAnticipos.Text);
                int totalAPagar = alcanceLiquido - anticipos;
                txtTotalAPagar.Text = totalAPagar.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtAnticipos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int alcanceLiquido = int.Parse(txtAlcanceLiquido.Text);
                int anticipos = int.Parse(txtAnticipos.Text);
                int totalAPagar = alcanceLiquido - anticipos;
                txtTotalAPagar.Text = totalAPagar.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
