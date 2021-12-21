
namespace Catalogo_Tipo
{
	partial class PantallaModificaTipo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.GuardarModifica = new System.Windows.Forms.Button();
			this.Clave = new System.Windows.Forms.Label();
			this.ClaveModifica = new System.Windows.Forms.TextBox();
			this.clavelabel = new System.Windows.Forms.Label();
			this.Tipolabel = new System.Windows.Forms.Label();
			this.DescripcionProductolabel = new System.Windows.Forms.Label();
			this.CancelarModifica = new System.Windows.Forms.Button();
			this.ClaveAlfanumericaModifica = new System.Windows.Forms.TextBox();
			this.TipoProductoModifica = new System.Windows.Forms.TextBox();
			this.DescripcionProductoModifica = new System.Windows.Forms.TextBox();
			this.NombreEncargado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// GuardarModifica
			// 
			this.GuardarModifica.Location = new System.Drawing.Point(168, 389);
			this.GuardarModifica.Name = "GuardarModifica";
			this.GuardarModifica.Size = new System.Drawing.Size(75, 23);
			this.GuardarModifica.TabIndex = 0;
			this.GuardarModifica.Text = "Guardar";
			this.GuardarModifica.UseVisualStyleBackColor = true;
			this.GuardarModifica.Click += new System.EventHandler(this.GuardarModifica_Click);
			// 
			// Clave
			// 
			this.Clave.AutoSize = true;
			this.Clave.Location = new System.Drawing.Point(77, 52);
			this.Clave.Name = "Clave";
			this.Clave.Size = new System.Drawing.Size(34, 13);
			this.Clave.TabIndex = 1;
			this.Clave.Text = "Clave";
			this.Clave.Click += new System.EventHandler(this.Clave_Click);
			// 
			// ClaveModifica
			// 
			this.ClaveModifica.Location = new System.Drawing.Point(80, 68);
			this.ClaveModifica.Multiline = true;
			this.ClaveModifica.Name = "ClaveModifica";
			this.ClaveModifica.ReadOnly = true;
			this.ClaveModifica.Size = new System.Drawing.Size(100, 33);
			this.ClaveModifica.TabIndex = 2;
			this.ClaveModifica.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// clavelabel
			// 
			this.clavelabel.AutoSize = true;
			this.clavelabel.Location = new System.Drawing.Point(18, 128);
			this.clavelabel.Name = "clavelabel";
			this.clavelabel.Size = new System.Drawing.Size(97, 13);
			this.clavelabel.TabIndex = 3;
			this.clavelabel.Text = "Clave alfanumerica";
			this.clavelabel.Click += new System.EventHandler(this.ClaveAlfanumericaModifica_Click);
			// 
			// Tipolabel
			// 
			this.Tipolabel.AutoSize = true;
			this.Tipolabel.Location = new System.Drawing.Point(249, 128);
			this.Tipolabel.Name = "Tipolabel";
			this.Tipolabel.Size = new System.Drawing.Size(88, 13);
			this.Tipolabel.TabIndex = 4;
			this.Tipolabel.Text = "Tipo de producto";
			this.Tipolabel.Click += new System.EventHandler(this.TipoProductoModifica_Click);
			// 
			// DescripcionProductolabel
			// 
			this.DescripcionProductolabel.AutoSize = true;
			this.DescripcionProductolabel.Location = new System.Drawing.Point(77, 204);
			this.DescripcionProductolabel.Name = "DescripcionProductolabel";
			this.DescripcionProductolabel.Size = new System.Drawing.Size(123, 13);
			this.DescripcionProductolabel.TabIndex = 5;
			this.DescripcionProductolabel.Text = "Descripcion de producto";
			this.DescripcionProductolabel.Click += new System.EventHandler(this.DescripcionProductoModifica_Click);
			// 
			// CancelarModifica
			// 
			this.CancelarModifica.Location = new System.Drawing.Point(384, 389);
			this.CancelarModifica.Name = "CancelarModifica";
			this.CancelarModifica.Size = new System.Drawing.Size(75, 23);
			this.CancelarModifica.TabIndex = 6;
			this.CancelarModifica.Text = "Cancelar";
			this.CancelarModifica.UseVisualStyleBackColor = true;
			this.CancelarModifica.Click += new System.EventHandler(this.CancelarModifica_Click);
			// 
			// ClaveAlfanumericaModifica
			// 
			this.ClaveAlfanumericaModifica.Location = new System.Drawing.Point(21, 144);
			this.ClaveAlfanumericaModifica.Multiline = true;
			this.ClaveAlfanumericaModifica.Name = "ClaveAlfanumericaModifica";
			this.ClaveAlfanumericaModifica.Size = new System.Drawing.Size(222, 33);
			this.ClaveAlfanumericaModifica.TabIndex = 7;
			this.ClaveAlfanumericaModifica.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// TipoProductoModifica
			// 
			this.TipoProductoModifica.Location = new System.Drawing.Point(249, 144);
			this.TipoProductoModifica.Multiline = true;
			this.TipoProductoModifica.Name = "TipoProductoModifica";
			this.TipoProductoModifica.Size = new System.Drawing.Size(364, 33);
			this.TipoProductoModifica.TabIndex = 8;
			this.TipoProductoModifica.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// DescripcionProductoModifica
			// 
			this.DescripcionProductoModifica.Location = new System.Drawing.Point(21, 220);
			this.DescripcionProductoModifica.Multiline = true;
			this.DescripcionProductoModifica.Name = "DescripcionProductoModifica";
			this.DescripcionProductoModifica.Size = new System.Drawing.Size(592, 119);
			this.DescripcionProductoModifica.TabIndex = 9;
			this.DescripcionProductoModifica.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// NombreEncargado
			// 
			this.NombreEncargado.AutoSize = true;
			this.NombreEncargado.Location = new System.Drawing.Point(305, 9);
			this.NombreEncargado.Name = "NombreEncargado";
			this.NombreEncargado.Size = new System.Drawing.Size(115, 13);
			this.NombreEncargado.TabIndex = 10;
			this.NombreEncargado.Text = "Nombre del encargado";
			this.NombreEncargado.Click += new System.EventHandler(this.NombreEncargado_Click);
			// 
			// PantallaModificaTipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 450);
			this.Controls.Add(this.NombreEncargado);
			this.Controls.Add(this.DescripcionProductoModifica);
			this.Controls.Add(this.TipoProductoModifica);
			this.Controls.Add(this.ClaveAlfanumericaModifica);
			this.Controls.Add(this.CancelarModifica);
			this.Controls.Add(this.DescripcionProductolabel);
			this.Controls.Add(this.Tipolabel);
			this.Controls.Add(this.clavelabel);
			this.Controls.Add(this.ClaveModifica);
			this.Controls.Add(this.Clave);
			this.Controls.Add(this.GuardarModifica);
			this.Name = "PantallaModificaTipo";
			this.Text = "PantallaModificaProducto";
			this.Load += new System.EventHandler(this.PantallaModificaTipo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button GuardarModifica;
		private System.Windows.Forms.Label Clave;
		private System.Windows.Forms.TextBox ClaveModifica;
		private System.Windows.Forms.Label clavelabel;
		private System.Windows.Forms.Label Tipolabel;
		private System.Windows.Forms.Label DescripcionProductolabel;
		private System.Windows.Forms.Button CancelarModifica;
		private System.Windows.Forms.TextBox ClaveAlfanumericaModifica;
		private System.Windows.Forms.TextBox TipoProductoModifica;
		private System.Windows.Forms.TextBox DescripcionProductoModifica;
		private System.Windows.Forms.Label NombreEncargado;
	}
}