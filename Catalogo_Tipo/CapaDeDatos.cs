using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo_Tipo
{
	public class CapaDeDatos
	{
		
		private SqlConnection conn = new SqlConnection("Data Source=NANDEATBITPC;User ID=sa;Password=123456;Persist Security Info=True;Initial Catalog=InventariosSPF;");
		//mi cadena de conexion esta aquí
		#region INSERTAR ALTA 
		public void InsertarAlta(CapaDeModelo Modelo)//modelotipoproducto es mi modelo de la bd, modelo es un objeto de el
		{
			try
			{
				conn.Open();//abrimos la base de datos
				string query = @"INSERT INTO tca_tipodeproducto (clave_alfanumerica, tipo_de_producto, descripcion_de_producto)
								VALUES (@clave_alfanumerica, @tipo_de_producto, @descripcion_de_producto) ";
				//aqui va mi query
				//aqui van los parametros
				SqlParameter clave_alfanumerica = new SqlParameter("@clave_alfanumerica", Modelo.clave_alfanumerica);
				SqlParameter tipo_de_producto = new SqlParameter("@tipo_de_producto", Modelo.tipo_de_producto);
				SqlParameter descripcion_de_producto = new SqlParameter("@descripcion_de_producto", Modelo.descripcion_de_producto);
				

				SqlCommand comando = new SqlCommand(query, conn);
				comando.Parameters.Add(clave_alfanumerica);
				comando.Parameters.Add(tipo_de_producto);
				comando.Parameters.Add(descripcion_de_producto);
				comando.ExecuteNonQuery();

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		#endregion

		#region LISTATIPOS
		public List<CapaDeModelo> ListaTipos(string buscarclave = null, string buscartipo = null, string buscardescripcion = null)//aqui estan los datos que se utilizan para el controlador
		{
			List<CapaDeModelo> Modelo = new List<CapaDeModelo>();//crear nueva lista objeto de nuestro modelo de datos para usarlo para las consultas sql
			try//try y catch sirven para darnos una notificacion de que esta mal en nuestras querys
			{
				conn.Open();


				string query = @"SELECT * FROM tca_tipodeproducto ";//el query de sql
				SqlCommand comando = new SqlCommand(query, conn);//comando de sql para ejecutar la query

				 if(!string.IsNullOrEmpty(buscarclave) || !string.IsNullOrEmpty(buscartipo) || !string.IsNullOrEmpty(buscardescripcion))//PARA BUSCAR
				{
					query += "WHERE clave_alfanumerica LIKE @buscarclave AND tipo_de_producto LIKE @buscartipo AND descripcion_de_producto LIKE @buscardescripcion";
					comando.Parameters.Add(new SqlParameter("@buscarclave", $"%{buscarclave}%"));//parte de sql, no me importa que haya adelante o atras, mientras al menos contenga lo que dice esa variable, en cualquier lugar de esa variable					
					comando.Parameters.Add(new SqlParameter("@buscartipo", $"%{buscartipo}%"));
					comando.Parameters.Add(new SqlParameter("@buscardescripcion", $"%{buscardescripcion}%"));
				}
				comando.CommandText = query;//para filtrarse en la GRID
				comando.Connection = conn;


				SqlDataReader lector = comando.ExecuteReader();//el lector que se utiliza para los select
				while (lector.Read())//utilizamos un while para que el lector los lea y los vaya añadiendo 
				{
					Modelo.Add(new CapaDeModelo
					{
						clave = int.Parse(lector["clave"].ToString()),//aquí hacemos un casteo de int a string para que lo pueda leer y mostrarlo en la lista
						clave_alfanumerica = lector["clave_alfanumerica"].ToString(),//aqui pasamos a string lo que lee para mostrarlo
						tipo_de_producto = lector["tipo_de_producto"].ToString(),
						descripcion_de_producto = lector["descripcion_de_producto"].ToString(),
					});
				}
			}
			catch (Exception)
			{
			throw;//aqui nos notifica que estuvo mal
			}

			finally //para finalizar la consulta cierra la conexion
			{
				conn.Close();//cerrar conexion
			}
			return Modelo;//tenemos que regresar algo a fuerza para la funcion
		}

		//public static explicit operator CapaDeDatos(Form v)
		//{
		//	throw new NotImplementedException();
		//}
		#endregion

		#region MODIFICAR PRODUCTO
		public void ModificarProducto(CapaDeModelo Modelo)
		{
			try
			{
				
				conn.Open();
				string query = @"UPDATE tca_tipodeproducto
									SET clave_alfanumerica = @clave_alfanumerica, 
										tipo_de_producto = @tipo_de_producto,
										descripcion_de_producto = @descripcion_de_producto 
									WHERE clave = @clave";
				SqlParameter clave_alfanumerica = new SqlParameter("@clave_alfanumerica", Modelo.clave_alfanumerica);
				SqlParameter tipo_de_producto = new SqlParameter("@tipo_de_producto", Modelo.tipo_de_producto);
				SqlParameter descripcion_de_producto = new SqlParameter("@descripcion_de_producto", Modelo.descripcion_de_producto);
				SqlParameter clave = new SqlParameter("@clave", Modelo.clave);
				SqlCommand comando = new SqlCommand(query, conn);
				comando.Parameters.Add(clave_alfanumerica);
				comando.Parameters.Add(tipo_de_producto);
				comando.Parameters.Add(descripcion_de_producto);
				comando.Parameters.Add(clave);
				comando.ExecuteNonQuery();
			}
			catch (Exception)
			{
			throw;
			}
			finally
			{
				conn.Close();
			}
		}
		#endregion

		#region BORRAR PRODUCTO

		public void BorrarTipo(int clave)
		{
			try
			{
				conn.Open();
				string query = @"DELETE FROM tca_tipodeproducto WHERE clave = @clave";		
				SqlCommand comando = new SqlCommand(query, conn);
				comando.Parameters.Add(new SqlParameter("@clave", clave));
				comando.ExecuteNonQuery();

			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				conn.Close();
			}
		}

		#endregion

		
		public string ExisteTipo(string clavealfanumerica = null, string tipodeproducto = null, string salida = "")
		{
			try
			{
				conn.Open();
				string query = @" SELECT COUNT(clave_alfanumerica) FROM tca_tipodeproducto
                                  WHERE clave_alfanumerica = @clave_alfanumerica 
                                  OR  tipo_de_producto= @tipo_de_producto";

				SqlCommand command = new SqlCommand(query, conn);
				command.Parameters.AddWithValue("@clave_alfanumerica", clavealfanumerica);
				command.Parameters.AddWithValue("@tipo_de_producto", tipodeproducto);
			
				int emp = Convert.ToInt32(command.ExecuteScalar());

			
				if (emp <= 0)
				{
					salida = "si";
				
				}
				else
				{
					salida = "no";
				
				}
				

			}
			catch (Exception)
			{
				throw;
			}
			finally { conn.Close(); }
			
			return salida;

		}
	}
}