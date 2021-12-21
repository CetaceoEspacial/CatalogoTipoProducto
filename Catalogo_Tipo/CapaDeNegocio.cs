using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_Tipo
{
	public class CapaDeNegocio
	{
		private CapaDeDatos capaDeDatos;//declaramos la capa de negocio
		
		
		public CapaDeNegocio()//constructor de la capa de negocio
		{
			capaDeDatos = new CapaDeDatos();//nuevo objeto de capa de datos
		}
		#region INSERTAR O MODIFICAR TIPO
		public CapaDeModelo InsertarTipo(CapaDeModelo Modelo)
		{
			
			if (Modelo.clave == 0)//si la clave es 0 entonces se inserta un nuevo tipo de producto
			{
				capaDeDatos.InsertarAlta(Modelo);
				return Modelo;
			}
			else
			{
				capaDeDatos.ModificarProducto(Modelo);
			}
			return Modelo;
		}
		#endregion


		#region LISTATIPOS(FUNCION QUE MUESTRA LA LISTA)
		public List<CapaDeModelo> ListaTipos(string buscarclave = null, string buscartipo = null, string buscardescripcion = null)//metodo que devuelve los contactos
		{
			return capaDeDatos.ListaTipos(buscarclave, buscartipo, buscardescripcion);//el controlador consigue de la capa de datos los elementos de la bd
		}
		#endregion


		#region BORRAR TIPO

		public void BorrarTipo(int clave)
		{
			capaDeDatos.BorrarTipo(clave);
			
		}
		#endregion

	}
}

