using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo_Tipo
{
	public partial class PantallaAltaTipo : Form
	{
		private CapaDeNegocio capaDeNegocio;
		private CapaDeDatos capaDeDatos;
		private CapaDeModelo Modelo;
		string nombrecolumna;		
		private CapaDeModelo _Modelo;//incializamos este objeto _Modelo para el metodo GuardaTipo
		public PantallaAltaTipo()
		{
			InitializeComponent();
			capaDeNegocio = new CapaDeNegocio();
			capaDeDatos = new CapaDeDatos();

		}
		#region AL MOMENTO DE CARGAR ESTA PANTALLA 
		private void PantallaAltaTipo_Load(object sender, EventArgs e)
		{

		}

		
		#endregion

		#region LABELS QUE DICEN TEXTO
		private void NombreEncargado_Click_1(object sender, EventArgs e)
		{

		}
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
		#endregion

		#region CAMPOS DE TEXTO
		private void ClaveAlfanumericaAlta_TextChanged(object sender, EventArgs e)
		{

		}

		private void TipoProductoAlta_TextChanged(object sender, EventArgs e)
		{

		}

		private void DescripcionProductoAlta_TextChanged(object sender, EventArgs e)
		{

		}

		private void ClaveAlta_TextChanged(object sender, EventArgs e)
		{

		}


		#endregion

		#region BOTONES CANCELAR Y GUARDAR

		public void GuardarAlta_Click(object sender, EventArgs e)
		{
			
			if (string.IsNullOrEmpty(ClaveAlfanumericaAlta.Text))
			{
				nombrecolumna = "Clave Alfanumérica";
			}
			else if (string.IsNullOrEmpty(TipoProductoAlta.Text))
			{
				nombrecolumna = "Tipo de producto";
			}
			else if (string.IsNullOrEmpty(DescripcionProductoAlta.Text))
			{
				nombrecolumna = "Descripción de producto";
			}			
			else
			{
				if (capaDeDatos.ExisteTipo(ClaveAlfanumericaAlta.Text, TipoProductoAlta.Text) != "si") 
				{
					DialogResult result = MessageBox.Show("Error, ya existe un usuario con esa clave o ese nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					if (result == DialogResult.Yes)
					{
						this.Close();
					}
					else
					{
						LimpiarFormularioAlta();
					}
				}
				else
				{
					GuardarTipo();
					Close();
					((Main)this.Owner).MostrarTipos();//aqui se jala el metodo liy lo aplica para mostrarnos el cambio al actualizar la ventana
					DialogResult result = MessageBox.Show("¿Estás seguro que quieres dar de ALTA este tipo de producto?", "Alta tipo de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
					if (result == DialogResult.Yes)
					{
						nombrecolumna = "";
						GuardarTipo();
						Close();
						((Main)Owner).MostrarTipos();
						_ = MessageBox.Show("Hecho", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
						//aqui se jala el metodo cargatipos lo aplica para mostrarnos el cambio al actualizar la ventana
					}
				}
			}

			if (!string.IsNullOrEmpty(nombrecolumna))
			{
				MessageBox.Show("Error, es necesario capturar el campo requerido " + nombrecolumna, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}		
		}
		private void GuardarTipo()
		{

			CapaDeModelo Modelo = new CapaDeModelo();
			Modelo.clave_alfanumerica = ClaveAlfanumericaAlta.Text;
			Modelo.tipo_de_producto = TipoProductoAlta.Text;
			Modelo.descripcion_de_producto = DescripcionProductoAlta.Text;
			capaDeNegocio.InsertarTipo(Modelo);//usamos el controlador para el metodo de insertar alta y usamos un objeto como parametro
			Modelo = _Modelo;
			
		}

		private void CancelarAlta_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion
		private void LimpiarFormularioAlta()//Asegurarnos que las cajas de texto estén vacías
		{
			ClaveAlfanumericaAlta.Text = string.Empty;
			TipoProductoAlta.Text = string.Empty;
			DescripcionProductoAlta.Text = string.Empty;
		}

	}
}
