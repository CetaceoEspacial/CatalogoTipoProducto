
namespace Catalogo_Tipo
{
	partial class Main
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.Clave = new System.Windows.Forms.Label();
			this.TipoProducto = new System.Windows.Forms.Label();
			this.DescripcionTipoProducto = new System.Windows.Forms.Label();
			this.ClaveConsulta = new System.Windows.Forms.TextBox();
			this.TipoProductoConsulta = new System.Windows.Forms.TextBox();
			this.DescripcionProductoConsulta = new System.Windows.Forms.TextBox();
			this.BuscarTipo = new System.Windows.Forms.Button();
			this.AgregarTipo = new System.Windows.Forms.Button();
			this.NombreEncargado = new System.Windows.Forms.Label();
			this.GridViewTipo = new System.Windows.Forms.DataGridView();
			this.modificar = new System.Windows.Forms.DataGridViewLinkColumn();
			this.borrar = new System.Windows.Forms.DataGridViewLinkColumn();
			this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clavealfanumericaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipodeproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripciondeproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.capaDeModeloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.capaDeModeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.GridViewTipo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.capaDeModeloBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.capaDeModeloBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// Clave
			// 
			resources.ApplyResources(this.Clave, "Clave");
			this.Clave.Name = "Clave";
			this.Clave.Click += new System.EventHandler(this.Clave_Click);
			// 
			// TipoProducto
			// 
			resources.ApplyResources(this.TipoProducto, "TipoProducto");
			this.TipoProducto.Name = "TipoProducto";
			this.TipoProducto.Click += new System.EventHandler(this.TipoProducto_Click);
			// 
			// DescripcionTipoProducto
			// 
			resources.ApplyResources(this.DescripcionTipoProducto, "DescripcionTipoProducto");
			this.DescripcionTipoProducto.Name = "DescripcionTipoProducto";
			this.DescripcionTipoProducto.Click += new System.EventHandler(this.DescripcionTipoProducto_Click);
			// 
			// ClaveConsulta
			// 
			resources.ApplyResources(this.ClaveConsulta, "ClaveConsulta");
			this.ClaveConsulta.Name = "ClaveConsulta";
			this.ClaveConsulta.TextChanged += new System.EventHandler(this.ClaveConsulta_TextChanged);
			// 
			// TipoProductoConsulta
			// 
			resources.ApplyResources(this.TipoProductoConsulta, "TipoProductoConsulta");
			this.TipoProductoConsulta.Name = "TipoProductoConsulta";
			this.TipoProductoConsulta.TextChanged += new System.EventHandler(this.TipoProductoConsulta_TextChanged);
			// 
			// DescripcionProductoConsulta
			// 
			resources.ApplyResources(this.DescripcionProductoConsulta, "DescripcionProductoConsulta");
			this.DescripcionProductoConsulta.Name = "DescripcionProductoConsulta";
			this.DescripcionProductoConsulta.TextChanged += new System.EventHandler(this.DescripcionProductoConsulta_TextChanged);
			// 
			// BuscarTipo
			// 
			resources.ApplyResources(this.BuscarTipo, "BuscarTipo");
			this.BuscarTipo.Name = "BuscarTipo";
			this.BuscarTipo.UseVisualStyleBackColor = true;
			this.BuscarTipo.Click += new System.EventHandler(this.BuscarTipo_Click);
			// 
			// AgregarTipo
			// 
			resources.ApplyResources(this.AgregarTipo, "AgregarTipo");
			this.AgregarTipo.Name = "AgregarTipo";
			this.AgregarTipo.UseVisualStyleBackColor = true;
			this.AgregarTipo.Click += new System.EventHandler(this.AgregarTipo_Click);
			// 
			// NombreEncargado
			// 
			resources.ApplyResources(this.NombreEncargado, "NombreEncargado");
			this.NombreEncargado.Name = "NombreEncargado";
			this.NombreEncargado.Click += new System.EventHandler(this.NombreEncargado_Click);
			// 
			// GridViewTipo
			// 
			this.GridViewTipo.AutoGenerateColumns = false;
			this.GridViewTipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridViewTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridViewTipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveDataGridViewTextBoxColumn,
            this.clavealfanumericaDataGridViewTextBoxColumn,
            this.tipodeproductoDataGridViewTextBoxColumn,
            this.descripciondeproductoDataGridViewTextBoxColumn,
            this.modificar,
            this.borrar});
			this.GridViewTipo.DataSource = this.capaDeModeloBindingSource1;
			resources.ApplyResources(this.GridViewTipo, "GridViewTipo");
			this.GridViewTipo.Name = "GridViewTipo";
			this.GridViewTipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewTipo_CellContentClick_1);
			// 
			// modificar
			// 
			resources.ApplyResources(this.modificar, "modificar");
			this.modificar.Name = "modificar";
			this.modificar.ReadOnly = true;
			this.modificar.Text = "Modificar";
			this.modificar.UseColumnTextForLinkValue = true;
			// 
			// borrar
			// 
			resources.ApplyResources(this.borrar, "borrar");
			this.borrar.Name = "borrar";
			this.borrar.ReadOnly = true;
			this.borrar.Text = "Borrar";
			this.borrar.UseColumnTextForLinkValue = true;
			// 
			// claveDataGridViewTextBoxColumn
			// 
			this.claveDataGridViewTextBoxColumn.DataPropertyName = "clave";
			resources.ApplyResources(this.claveDataGridViewTextBoxColumn, "claveDataGridViewTextBoxColumn");
			this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
			// 
			// clavealfanumericaDataGridViewTextBoxColumn
			// 
			this.clavealfanumericaDataGridViewTextBoxColumn.DataPropertyName = "clave_alfanumerica";
			resources.ApplyResources(this.clavealfanumericaDataGridViewTextBoxColumn, "clavealfanumericaDataGridViewTextBoxColumn");
			this.clavealfanumericaDataGridViewTextBoxColumn.Name = "clavealfanumericaDataGridViewTextBoxColumn";
			// 
			// tipodeproductoDataGridViewTextBoxColumn
			// 
			this.tipodeproductoDataGridViewTextBoxColumn.DataPropertyName = "tipo_de_producto";
			resources.ApplyResources(this.tipodeproductoDataGridViewTextBoxColumn, "tipodeproductoDataGridViewTextBoxColumn");
			this.tipodeproductoDataGridViewTextBoxColumn.Name = "tipodeproductoDataGridViewTextBoxColumn";
			// 
			// descripciondeproductoDataGridViewTextBoxColumn
			// 
			this.descripciondeproductoDataGridViewTextBoxColumn.DataPropertyName = "descripcion_de_producto";
			resources.ApplyResources(this.descripciondeproductoDataGridViewTextBoxColumn, "descripciondeproductoDataGridViewTextBoxColumn");
			this.descripciondeproductoDataGridViewTextBoxColumn.Name = "descripciondeproductoDataGridViewTextBoxColumn";
			// 
			// capaDeModeloBindingSource1
			// 
			this.capaDeModeloBindingSource1.DataSource = typeof(Catalogo_Tipo.CapaDeModelo);
			// 
			// capaDeModeloBindingSource
			// 
			this.capaDeModeloBindingSource.DataSource = typeof(Catalogo_Tipo.CapaDeModelo);
			// 
			// Main
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.GridViewTipo);
			this.Controls.Add(this.NombreEncargado);
			this.Controls.Add(this.AgregarTipo);
			this.Controls.Add(this.BuscarTipo);
			this.Controls.Add(this.DescripcionProductoConsulta);
			this.Controls.Add(this.TipoProductoConsulta);
			this.Controls.Add(this.ClaveConsulta);
			this.Controls.Add(this.DescripcionTipoProducto);
			this.Controls.Add(this.TipoProducto);
			this.Controls.Add(this.Clave);
			this.Name = "Main";
			this.Load += new System.EventHandler(this.PantallaConsultaTipo_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridViewTipo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.capaDeModeloBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.capaDeModeloBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Clave;
		private System.Windows.Forms.Label TipoProducto;
		private System.Windows.Forms.Label DescripcionTipoProducto;
		private System.Windows.Forms.TextBox ClaveConsulta;
		private System.Windows.Forms.TextBox TipoProductoConsulta;
		private System.Windows.Forms.TextBox DescripcionProductoConsulta;
		private System.Windows.Forms.Button BuscarTipo;
		private System.Windows.Forms.Button AgregarTipo;
		private System.Windows.Forms.Label NombreEncargado;
		private System.Windows.Forms.BindingSource capaDeModeloBindingSource;
		private System.Windows.Forms.DataGridView GridViewTipo;
		private System.Windows.Forms.BindingSource capaDeModeloBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clavealfanumericaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipodeproductoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descripciondeproductoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewLinkColumn modificar;
		private System.Windows.Forms.DataGridViewLinkColumn borrar;
	}
}

