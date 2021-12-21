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
	public partial class Main : Form
	{
		public CapaDeNegocio capaDeNegocio;//inicializamos la clase de la capa de negocios(controlador)

		public Main()
		{
			InitializeComponent();
			capaDeNegocio = new CapaDeNegocio();
		}


		#region AL MOMENTO DE CARGAR LA PANTALLA(MOSTRAR TIPOS es dueña de listatipos)
		public void PantallaConsultaTipo_Load(object sender, EventArgs e)//al momento de cargar la pantalla cargar tipos muestra los tipos de contactos
		{
			MostrarTipos();
		}
		public void MostrarTipos(string buscarclave = null, string buscartipo = null, string buscardescripcion = null)//cuando el parametro es nulo es opcional, si no lo envio no se utiliza
		{
			 List<CapaDeModelo> Modelo = capaDeNegocio.ListaTipos(buscarclave,buscartipo,buscardescripcion);//para mostrar los tipos actualizados, tambien se usa con el boton guardar.
			GridViewTipo.DataSource = Modelo;
		}
		

		#endregion

		#region LABELS
		private void NombreEncargado_Click(object sender, EventArgs e)
		{

		}
		private void Clave_Click(object sender, EventArgs e)
		{

		}

		private void TipoProducto_Click(object sender, EventArgs e)
		{

		}

		private void DescripcionTipoProducto_Click(object sender, EventArgs e)
		{

		}

		#endregion

		#region BOTONES
		private void BuscarTipo_Click(object sender, EventArgs e)
		{
			MostrarTipos(ClaveConsulta.Text,TipoProductoConsulta.Text,DescripcionProductoConsulta.Text);
			ClaveConsulta.Text = string.Empty;
			TipoProductoConsulta.Text = string.Empty;
			DescripcionProductoConsulta.Text = string.Empty;
		}

		private void AgregarTipo_Click(object sender, EventArgs e)
		{
			PantallaAltaTipo pantallaaltatipo = new PantallaAltaTipo();//Crear objeto de una clase para el boton Agregar
			pantallaaltatipo.ShowDialog(this);//Al apretar agregar muestra el formulario de alta de tipo de producto
		//el this hace que jale el owner para volver a mostrar contactos despues de dar al boton guardar en PantallaAltaProducto

		}
		#endregion

		#region CUADROS DE TEXTO
		private void ClaveConsulta_TextChanged(object sender, EventArgs e)
		{

		}

		private void TipoProductoConsulta_TextChanged(object sender, EventArgs e)
		{

		}

		private void DescripcionProductoConsulta_TextChanged(object sender, EventArgs e)
		{

		}




		#endregion

		#region EL DATA GRID QUE DEVUELVE LA LISTA DE TIPOS DE LA BD(MODIFICAR Y BORRAR)
		private void GridViewTipo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

			DataGridViewLinkCell cell = (DataGridViewLinkCell)GridViewTipo.Rows[e.RowIndex].Cells[e.ColumnIndex];//funcion para verificar que celda se clickeó
			if (cell.Value.ToString() == "Modificar")//si fue la celda modificar has esto(o sea si se clickeo el texto modificar, que anteriormente lo demoninaste como datalink
			{

				PantallaModificaTipo pantallamodificatipo = new PantallaModificaTipo();
				pantallamodificatipo.CargarTipo(new CapaDeModelo
				{
					clave = int.Parse((GridViewTipo.Rows[e.RowIndex].Cells[0]).Value.ToString()),//hay que parsear porque es INT
					clave_alfanumerica = (GridViewTipo.Rows[e.RowIndex].Cells[1]).Value.ToString(),
					tipo_de_producto = (GridViewTipo.Rows[e.RowIndex].Cells[2]).Value.ToString(),
					descripcion_de_producto = (GridViewTipo.Rows[e.RowIndex].Cells[3]).Value.ToString()

				});
				pantallamodificatipo.ShowDialog(this);//muestra la pantalla modificar
			}

			else if (cell.Value.ToString() == "Borrar")
			{
				DialogResult result = MessageBox.Show("¿Estás seguro que quieres ELIMINAR este tipo de producto?", "Eliminar tipo de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (result == DialogResult.Yes)
				{
					BorrarTipo(int.Parse((GridViewTipo.Rows[e.RowIndex].Cells[0]).Value.ToString()));//hay que parsear porque es INT)
					MostrarTipos();
					_ = MessageBox.Show("Tipo de producto borrado con exito", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
					
		}
		
		private void BorrarTipo(int clave)
		{
			capaDeNegocio.BorrarTipo(clave);
		}
	}

		#endregion
	}

