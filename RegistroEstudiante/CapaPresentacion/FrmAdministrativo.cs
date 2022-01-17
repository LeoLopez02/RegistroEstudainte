using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmAdministrativo : Form
    {
        private bool EsNuevo = false;
        private bool EsEditar = false;


        public FrmAdministrativo()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.txtApellido, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.comboGenero, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.dtFechaNacimiento, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.dtFechaIngreso, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.txtNacionalidad, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.comboEstatus, "**Campo obligatorio.**");
            this.ttMensaje.SetToolTip(this.txtFuncion, "**Campo obligatorio.**");
        }

        //Mostrar mensaje de confirmacion
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo Limpiar
        private void Limpiar()
        {
            this.txtId.Text = string.Empty; //Agregar 
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.maskedTelefono.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.maskedCedula.Text = string.Empty;
            this.comboGenero.Text = string.Empty;
            this.txtCondicionMedica.Text = string.Empty;
            this.dtFechaNacimiento.Text = string.Empty;
            this.dtFechaIngreso.Text = string.Empty;
            this.txtCorreoElectronico.Text = string.Empty;
            this.txtNacionalidad.Text = string.Empty;
            this.txtTitulo.Text = string.Empty;
            this.comboEstatus.Text = string.Empty;
            this.txtFuncion.Text = string.Empty;
            this.txtNombre.Focus();
        }

        //Habilitar Textboxs
        private void Habilitar(bool Valor)
        {
            this.txtNombre.ReadOnly = !Valor;
            this.txtApellido.ReadOnly = !Valor;
            this.maskedTelefono.ReadOnly = !Valor;
            this.txtDireccion.ReadOnly = !Valor;
            this.maskedCedula.ReadOnly = !Valor;
            this.txtCondicionMedica.ReadOnly = !Valor;
            this.txtCorreoElectronico.ReadOnly = !Valor;
            this.txtNacionalidad.ReadOnly = !Valor;
            this.txtTitulo.ReadOnly = !Valor;
            this.txtFuncion.ReadOnly = !Valor;
        }

        //Habilitar Botones
        private void Botones()
        {
            if (this.EsNuevo || this.EsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnInsertar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnLimpiar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnInsertar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnLimpiar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
        }

        //Ocultar Columnas
        private void Ocultar()
        {
            //this.dtListado.Columns[0].Visible = false;
            //this.dtListado.Columns[1].Visible = false;
        }

        //Mostrar
        private void Mostrar()
        {
            this.dtListado.DataSource = NegocioAdministrativo.Mostrar();
            this.Ocultar();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        //Buscar Nombre
        private void BuscarNombre()
        {
            this.dtListado.DataSource = NegocioAdministrativo.BuscarNombre(this.comboBuscar.Text);
            this.Ocultar();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        //Buscar Cedula
        private void BuscarCedula()
        {
            this.dtListado.DataSource = NegocioAdministrativo.BuscarCedula(this.txtBuscar.Text);
            this.Ocultar();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtListado.Rows.Count);
        }

        private void FrmAdministrativo_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = true;
            this.EsEditar = false;
            this.Botones();
            this.Habilitar(true);
            this.Limpiar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtNombre.Text == string.Empty || this.txtApellido.Text == string.Empty)
                {
                    MessageBox.Show("No se pudo guardar de forma correcta el registro. Completar campos obligatorios!");
                    errorIcono.SetError(txtNombre, "**Campo obligatorio");
                    errorIcono.SetError(txtApellido, "**Campo obligatorio");
                }
                else
                {
                    if (this.EsNuevo)
                    {
                        respuesta = NegocioAdministrativo.Insertar(this.txtNombre.Text.Trim(), this.txtApellido.Text.Trim(), this.maskedTelefono.Text.Trim(), this.txtDireccion.Text.Trim(), this.maskedCedula.Text.Trim(), this.comboGenero.Text.Trim(), this.txtCondicionMedica.Text.Trim(), this.dtFechaNacimiento.Value, this.dtFechaIngreso.Value, this.txtCorreoElectronico.Text.Trim(), this.txtNacionalidad.Text.Trim(), this.txtTitulo.Text.Trim(), this.comboEstatus.Text.Trim(), this.txtFuncion.Text.Trim());
                    }
                    else
                    {
                        respuesta = NegocioAdministrativo.Editar(Convert.ToInt32(this.txtId.Text.Trim()), this.txtNombre.Text.Trim(), this.txtApellido.Text.Trim(), this.maskedTelefono.Text.Trim(), this.txtDireccion.Text.Trim(), this.maskedCedula.Text.Trim(), this.comboGenero.Text.Trim(), this.txtCondicionMedica.Text.Trim(), this.dtFechaNacimiento.Value, this.dtFechaIngreso.Value, this.txtCorreoElectronico.Text.Trim(), this.txtNacionalidad.Text.Trim(), this.txtTitulo.Text.Trim(), this.comboEstatus.Text.Trim(), this.txtFuncion.Text.Trim());
                    }
                    if (respuesta.Equals("OK"))
                    {
                        if (this.EsNuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el registro.");
                        }
                        else
                        {
                            this.MensajeOK("Se actualizó de forma correcta el registro.");
                        }
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                    this.EsNuevo = false;
                    this.EsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + " Botón Insertar.");
            }
        }
    }
}
