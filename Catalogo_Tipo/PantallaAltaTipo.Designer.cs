
namespace Catalogo_Tipo
{
	partial class PantallaAltaTipo
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
			this.Clave = new System.Windows.Forms.Label();
			this.ClaveAlfanumerica = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ClaveAlta = new System.Windows.Forms.TextBox();
			this.ClaveAlfanumericaAlta = new System.Windows.Forms.TextBox();
			this.TipoProductoAlta = new System.Windows.Forms.TextBox();
			this.DescripcionProductoAlta = new System.Windows.Forms.TextBox();
			this.GuardarAlta = new System.Windows.Forms.Button();
			this.CancelarAlta = new System.Windows.Forms.Button();
			this.NombreEncargado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Clave
			// 
			this.Clave.AutoSize = true;
			this.Clave.Location = new System.Drawing.Point(38, 44);
			this.Clave.Name = "Clave";
			this.Clave.Size = new System.Drawing.Size(34, 13);
			this.Clave.TabIndex = 0;
			this.Clave.Text = "Clave";
			this.Clave.Click += new System.EventHandler(this.label1_Click);
			// 
			// ClaveAlfanumerica
			// 
			this.ClaveAlfanumerica.AutoSize = true;
			this.ClaveAlfanumerica.Location = new System.Drawing.Point(38, 127);
			this.ClaveAlfanumerica.Name = "ClaveAlfanumerica";
			this.ClaveAlfanumerica.Size = new System.Drawing.Size(97, 13);
			this.ClaveAlfanumerica.TabIndex = 1;
			this.ClaveAlfanumerica.Text = "Clave alfanumerica";
			this.ClaveAlfanumerica.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(233, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tipo de producto";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(38, 215);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Descripcion del tipo de producto";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// ClaveAlta
			// 
			this.ClaveAlta.Enabled = false;
			this.ClaveAlta.Location = new System.Drawing.Point(41, 60);
			this.ClaveAlta.Multiline = true;
			this.ClaveAlta.Name = "ClaveAlta";
			this.ClaveAlta.ReadOnly = true;
			this.ClaveAlta.Size = new System.Drawing.Size(121, 39);
			this.ClaveAlta.TabIndex = 4;
			this.ClaveAlta.TextChanged += new System.EventHandler(this.ClaveAlta_TextChanged);
			// 
			// ClaveAlfanumericaAlta
			// 
			this.ClaveAlfanumericaAlta.Location = new System.Drawing.Point(41, 143);
			this.ClaveAlfanumericaAlta.Multiline = true;
			this.ClaveAlfanumericaAlta.Name = "ClaveAlfanumericaAlta";
			this.ClaveAlfanumericaAlta.Size = new System.Drawing.Size(159, 41);
			this.ClaveAlfanumericaAlta.TabIndex = 5;
			this.ClaveAlfanumericaAlta.TextChanged += new System.EventHandler(this.ClaveAlfanumericaAlta_TextChanged);
			// 
			// TipoProductoAlta
			// 
			this.TipoProductoAlta.Location = new System.Drawing.Point(236, 143);
			this.TipoProductoAlta.Multiline = true;
			this.TipoProductoAlta.Name = "TipoProductoAlta";
			this.TipoProductoAlta.Size = new System.Drawing.Size(303, 41);
			this.TipoProductoAlta.TabIndex = 6;
			this.TipoProductoAlta.TextChanged += new System.EventHandler(this.TipoProductoAlta_TextChanged);
			// 
			// DescripcionProductoAlta
			// 
			this.DescripcionProductoAlta.Location = new System.Drawing.Point(41, 231);
			this.DescripcionProductoAlta.Multiline = true;
			this.DescripcionProductoAlta.Name = "DescripcionProductoAlta";
			this.DescripcionProductoAlta.Size = new System.Drawing.Size(498, 135);
			this.DescripcionProductoAlta.TabIndex = 7;
			this.DescripcionProductoAlta.TextChanged += new System.EventHandler(this.DescripcionProductoAlta_TextChanged);
			// 
			// GuardarAlta
			// 
			this.GuardarAlta.Location = new System.Drawing.Point(147, 382);
			this.GuardarAlta.Name = "GuardarAlta";
			this.GuardarAlta.Size = new System.Drawing.Size(75, 23);
			this.GuardarAlta.TabIndex = 8;
			this.GuardarAlta.Text = "Guardar";
			this.GuardarAlta.UseVisualStyleBackColor = true;
			this.GuardarAlta.Click += new System.EventHandler(this.GuardarAlta_Click);
			// 
			// CancelarAlta
			// 
			this.CancelarAlta.Location = new System.Drawing.Point(348, 382);
			this.CancelarAlta.Name = "CancelarAlta";
			this.CancelarAlta.Size = new System.Drawing.Size(75, 23);
			this.CancelarAlta.TabIndex = 9;
			this.CancelarAlta.Text = "Cancelar";
			this.CancelarAlta.UseVisualStyleBackColor = true;
			this.CancelarAlta.Click += new System.EventHandler(this.CancelarAlta_Click);
			// 
			// NombreEncargado
			// 
			this.NombreEncargado.AutoSize = true;
			this.NombreEncargado.Location = new System.Drawing.Point(233, 9);
			this.NombreEncargado.Name = "NombreEncargado";
			this.NombreEncargado.Size = new System.Drawing.Size(115, 13);
			this.NombreEncargado.TabIndex = 10;
			this.NombreEncargado.Text = "Nombre del encargado";
			this.NombreEncargado.Click += new System.EventHandler(this.NombreEncargado_Click_1);
			// 
			// PantallaAltaTipo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 450);
			this.Controls.Add(this.NombreEncargado);
			this.Controls.Add(this.CancelarAlta);
			this.Controls.Add(this.GuardarAlta);
			this.Controls.Add(this.DescripcionProductoAlta);
			this.Controls.Add(this.TipoProductoAlta);
			this.Controls.Add(this.ClaveAlfanumericaAlta);
			this.Controls.Add(this.ClaveAlta);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ClaveAlfanumerica);
			this.Controls.Add(this.Clave);
			this.Name = "PantallaAltaTipo";
			this.Text = "PantallaAltaProducto";
			this.Load += new System.EventHandler(this.PantallaAltaTipo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Clave;
		private System.Windows.Forms.Label ClaveAlfanumerica;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ClaveAlta;
		private System.Windows.Forms.TextBox ClaveAlfanumericaAlta;
		private System.Windows.Forms.TextBox TipoProductoAlta;
		private System.Windows.Forms.TextBox DescripcionProductoAlta;
		private System.Windows.Forms.Button GuardarAlta;
		private System.Windows.Forms.Button CancelarAlta;
		private System.Windows.Forms.Label NombreEncargado;
	}
}