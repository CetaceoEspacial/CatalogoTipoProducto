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
	public partial class PantallaModificaTipo : Form
	{
		private CapaDeNegocio capaDeNegocio;

		private CapaDeModelo _Modelo;//incializamos este objeto _Modelo para el metodo CargaTipo

		public PantallaModificaTipo()
		{
			InitializeComponent();
			capaDeNegocio = new CapaDeNegocio();
		}
		#region AL MOMENTO DE CARGAR LA PANTALLA
		public void PantallaModificaTipo_Load(object sender, EventArgs e)
		{
			CargarTipo(_Modelo);//lee el objeto modelo el cual contiene la clave
		}


		#endregion

		#region BOTONES
		private void GuardarModifica_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("¿Estás seguro que quieres MODIFICAR este tipo de producto?", "Modificar tipo de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (result == DialogResult.Yes)
			{
				GuardarTipoModifica();
				Close();
				((Main)Owner).MostrarTipos();
				_ = MessageBox.Show("Tipo de producto modificado con exito", "Hecho",MessageBoxButtons.OK , MessageBoxIcon.Information);
				//aqui se jala el metodo cargatipos lo aplica para mostrarnos el cambio al actualizar la ventana
			}
		
              
                    
                
		}

		private void CancelarModifica_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion

		#region LABELS
		private void NombreEncargado_Click(object sender, EventArgs e)
		{

		}
		private void Clave_Click(object sender, EventArgs e)
		{

		}

		private void ClaveAlfanumericaModifica_Click(object sender, EventArgs e)
		{

		}

		private void TipoProductoModifica_Click(object sender, EventArgs e)
		{

		}

		private void DescripcionProductoModifica_Click(object sender, EventArgs e)
		{

		}
		#endregion

		#region CUADROS DE TEXTO
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}
		#endregion

		#region FUNCION CARGARTIPO
		public void CargarTipo(CapaDeModelo Modelo)
		{
			_Modelo = Modelo;
			if (Modelo != null)//si encuentra algo en el objeto modelo carga lo siguiente
			{
				LimpiarFormulario();

				ClaveAlfanumericaModifica.Text = Modelo.clave_alfanumerica;
				TipoProductoModifica.Text = Modelo.tipo_de_producto;
				DescripcionProductoModifica.Text = Modelo.descripcion_de_producto;
			}
		}
		private void LimpiarFormulario()//Asegurarnos que las cajas de texto estén vacías
		{
			ClaveAlfanumericaModifica.Text = string.Empty;
			TipoProductoModifica.Text = string.Empty;
			DescripcionProductoModifica.Text = string.Empty;
		}

		#endregion

		#region FUNCION GUARDARTIPO MODIFICA
		private void GuardarTipoModifica()
		{
					
			CapaDeModelo Modelo = new CapaDeModelo();
			Modelo.clave = _Modelo != null ? _Modelo.clave : 0;
			//Modelo.clave = int.Parse(ClaveModifica.Text);
			Modelo.clave_alfanumerica = ClaveAlfanumericaModifica.Text;
			Modelo.tipo_de_producto = TipoProductoModifica.Text;
			Modelo.descripcion_de_producto = DescripcionProductoModifica.Text;
			capaDeNegocio.InsertarTipo(Modelo);//usamos el controlador para el metodo de insertar alta y usamos un objeto como parametro
			


		}
		#endregion
	}
}
