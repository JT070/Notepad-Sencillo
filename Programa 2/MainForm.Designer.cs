/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 25/09/2020
 * Time: 07:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Programa_2
{
	partial class MainFormNP
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eliminarTodoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tipoDeLetraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.RichTextBox CajaTexto;
		private System.Windows.Forms.ToolStripMenuItem colorDeLetraToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog GuardarArchivo;
		private System.Windows.Forms.ToolStripMenuItem colorDeFondoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cambiarPaddingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorDelMargenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vistaPorDefectoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modoOscuroToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormNP));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tipoDeLetraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorDeLetraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cambiarPaddingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorDelMargenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vistaPorDefectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.CajaTexto = new System.Windows.Forms.RichTextBox();
			this.GuardarArchivo = new System.Windows.Forms.SaveFileDialog();
			this.modoOscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.archivoToolStripMenuItem,
			this.editarToolStripMenuItem,
			this.formatoToolStripMenuItem,
			this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(628, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.nuevoToolStripMenuItem,
			this.guardarToolStripMenuItem,
			this.guardarComoToolStripMenuItem,
			this.abrirToolStripMenuItem,
			this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// nuevoToolStripMenuItem
			// 
			this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.nuevoToolStripMenuItem.Text = "Nuevo";
			this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.NuevoToolStripMenuItemClick);
			// 
			// guardarToolStripMenuItem
			// 
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.guardarToolStripMenuItem.Text = "Guardar";
			this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItemClick);
			// 
			// guardarComoToolStripMenuItem
			// 
			this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
			this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.guardarComoToolStripMenuItem.Text = "Guardar como";
			this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.GuardarComoToolStripMenuItemClick);
			// 
			// abrirToolStripMenuItem
			// 
			this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
			this.abrirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.abrirToolStripMenuItem.Text = "Abrir";
			this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// editarToolStripMenuItem
			// 
			this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.deshacerToolStripMenuItem,
			this.cortarToolStripMenuItem,
			this.copiarToolStripMenuItem,
			this.pegarToolStripMenuItem,
			this.eliminarToolStripMenuItem,
			this.rehacerToolStripMenuItem,
			this.eliminarTodoToolStripMenuItem});
			this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
			this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.editarToolStripMenuItem.Text = "Editar";
			// 
			// deshacerToolStripMenuItem
			// 
			this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
			this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.deshacerToolStripMenuItem.Text = "Deshacer";
			this.deshacerToolStripMenuItem.Click += new System.EventHandler(this.DeshacerToolStripMenuItemClick);
			// 
			// cortarToolStripMenuItem
			// 
			this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
			this.cortarToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.cortarToolStripMenuItem.Text = "Cortar";
			this.cortarToolStripMenuItem.Click += new System.EventHandler(this.CortarToolStripMenuItemClick);
			// 
			// copiarToolStripMenuItem
			// 
			this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
			this.copiarToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.copiarToolStripMenuItem.Text = "Copiar";
			this.copiarToolStripMenuItem.Click += new System.EventHandler(this.CopiarToolStripMenuItemClick);
			// 
			// pegarToolStripMenuItem
			// 
			this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
			this.pegarToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.pegarToolStripMenuItem.Text = "Pegar";
			this.pegarToolStripMenuItem.Click += new System.EventHandler(this.PegarToolStripMenuItemClick);
			// 
			// eliminarToolStripMenuItem
			// 
			this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
			this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.eliminarToolStripMenuItem.Text = "Eliminar";
			this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.EliminarToolStripMenuItemClick);
			// 
			// rehacerToolStripMenuItem
			// 
			this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
			this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.rehacerToolStripMenuItem.Text = "Rehacer";
			this.rehacerToolStripMenuItem.Click += new System.EventHandler(this.RehacerToolStripMenuItemClick);
			// 
			// eliminarTodoToolStripMenuItem
			// 
			this.eliminarTodoToolStripMenuItem.Name = "eliminarTodoToolStripMenuItem";
			this.eliminarTodoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.eliminarTodoToolStripMenuItem.Text = "Eliminar todo";
			this.eliminarTodoToolStripMenuItem.Click += new System.EventHandler(this.EliminarTodoToolStripMenuItemClick);
			// 
			// formatoToolStripMenuItem
			// 
			this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tipoDeLetraToolStripMenuItem,
			this.colorDeLetraToolStripMenuItem,
			this.colorDeFondoToolStripMenuItem,
			this.cambiarPaddingToolStripMenuItem,
			this.colorDelMargenToolStripMenuItem,
			this.vistaPorDefectoToolStripMenuItem,
			this.modoOscuroToolStripMenuItem});
			this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
			this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.formatoToolStripMenuItem.Text = "Formato";
			// 
			// tipoDeLetraToolStripMenuItem
			// 
			this.tipoDeLetraToolStripMenuItem.Name = "tipoDeLetraToolStripMenuItem";
			this.tipoDeLetraToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.tipoDeLetraToolStripMenuItem.Text = "Tipo de letra";
			this.tipoDeLetraToolStripMenuItem.Click += new System.EventHandler(this.TipoDeLetraToolStripMenuItemClick);
			// 
			// colorDeLetraToolStripMenuItem
			// 
			this.colorDeLetraToolStripMenuItem.Name = "colorDeLetraToolStripMenuItem";
			this.colorDeLetraToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.colorDeLetraToolStripMenuItem.Text = "Color de letra";
			this.colorDeLetraToolStripMenuItem.Click += new System.EventHandler(this.ColorDeLetraToolStripMenuItemClick);
			// 
			// colorDeFondoToolStripMenuItem
			// 
			this.colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
			this.colorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.colorDeFondoToolStripMenuItem.Text = "Color de fondo";
			this.colorDeFondoToolStripMenuItem.Click += new System.EventHandler(this.ColorDeFondoToolStripMenuItemClick);
			// 
			// cambiarPaddingToolStripMenuItem
			// 
			this.cambiarPaddingToolStripMenuItem.Name = "cambiarPaddingToolStripMenuItem";
			this.cambiarPaddingToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.cambiarPaddingToolStripMenuItem.Text = "Margen (padding)";
			this.cambiarPaddingToolStripMenuItem.Click += new System.EventHandler(this.CambiarPaddingToolStripMenuItemClick);
			// 
			// colorDelMargenToolStripMenuItem
			// 
			this.colorDelMargenToolStripMenuItem.Name = "colorDelMargenToolStripMenuItem";
			this.colorDelMargenToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.colorDelMargenToolStripMenuItem.Text = "Color del margen";
			this.colorDelMargenToolStripMenuItem.Click += new System.EventHandler(this.ColorDelMargenToolStripMenuItemClick);
			// 
			// vistaPorDefectoToolStripMenuItem
			// 
			this.vistaPorDefectoToolStripMenuItem.Name = "vistaPorDefectoToolStripMenuItem";
			this.vistaPorDefectoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.vistaPorDefectoToolStripMenuItem.Text = "Vista por defecto";
			this.vistaPorDefectoToolStripMenuItem.Click += new System.EventHandler(this.VistaPorDefectoToolStripMenuItemClick);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.acercaDeToolStripMenuItem});
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.acercaDeToolStripMenuItem.Text = "Acerca de";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItemClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripButton1,
			this.toolStripButton2,
			this.toolStripButton3,
			this.toolStripButton4,
			this.toolStripButton5});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(628, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "toolStripButton3";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Text = "toolStripButton4";
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton5.Text = "toolStripButton5";
			// 
			// CajaTexto
			// 
			this.CajaTexto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CajaTexto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CajaTexto.Location = new System.Drawing.Point(0, 49);
			this.CajaTexto.Name = "CajaTexto";
			this.CajaTexto.Size = new System.Drawing.Size(628, 442);
			this.CajaTexto.TabIndex = 2;
			this.CajaTexto.Text = "";
			// 
			// modoOscuroToolStripMenuItem
			// 
			this.modoOscuroToolStripMenuItem.Name = "modoOscuroToolStripMenuItem";
			this.modoOscuroToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.modoOscuroToolStripMenuItem.Text = "Modo Oscuro";
			this.modoOscuroToolStripMenuItem.Click += new System.EventHandler(this.ModoOscuroToolStripMenuItemClick);
			// 
			// MainFormNP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(628, 491);
			this.Controls.Add(this.CajaTexto);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.Desktop;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainFormNP";
			this.Text = "Bloc de Notas";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}//this.toolStrip1.ResumeLayout(false);
			//this.toolStrip1.PerformLayout();
			//this.ResumeLayout(false);
			//this.PerformLayout();

		
	}
}
