/*
 * Created by SharpDevelop.
 * User: Javier
 * Date: 25/09/2020
 * Time: 07:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using InputKey;
using System.IO;
using System.Linq;

namespace Programa_2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainFormNP : Form
	{
		public MainFormNP()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			txtAcercaDe objAcercaDe = new txtAcercaDe();
			objAcercaDe.Show();
		}
		
		//
		//   EDITAR
		//
		
		void CopiarToolStripMenuItemClick(object sender, EventArgs e){
			CajaTexto.Copy();
		}
		void PegarToolStripMenuItemClick(object sender, EventArgs e){
			CajaTexto.Paste();
		}
		void DeshacerToolStripMenuItemClick(object sender, EventArgs e){
			CajaTexto.Undo();
		}
		void RehacerToolStripMenuItemClick(object sender, EventArgs e){
			CajaTexto.Redo();
		}
		void CortarToolStripMenuItemClick(object sender, EventArgs e){
			CajaTexto.Cut();
		}
		void EliminarToolStripMenuItemClick(object sender, EventArgs e){
			CajaTexto.SelectedText = string.Empty;
		}
		void EliminarTodoToolStripMenuItemClick(object sender, EventArgs e){
			CajaTexto.Clear();
		}
		
		//
		//   FORMATO	
		//	
		
		void ColorDeLetraToolStripMenuItemClick(object sender, EventArgs e){
			CajaTexto.ForeColor = PideColor().Color;
		}
		void TipoDeLetraToolStripMenuItemClick(object sender, EventArgs e){
			FontDialog oFontDialog = new FontDialog();
			oFontDialog.ShowDialog();
			CajaTexto.Font = oFontDialog.Font;
		}
		void ColorDeFondoToolStripMenuItemClick(object sender, EventArgs e){
			CajaTexto.BackColor = PideColor().Color;
		}
		void CambiarPaddingToolStripMenuItemClick(object sender, EventArgs e){
			int vPadding = Int16.Parse(InputDialog.mostrar("Ingrese el tamaño de margen que desea:"));			
			while(vPadding < 0 || vPadding > 200 ){
				vPadding = Int16.Parse(InputDialog.mostrar("Ingrese un valor entre 0 y 200"));
			}
			this.Padding = new Padding(vPadding);			
		}		
		void ColorDelMargenToolStripMenuItemClick(object sender, EventArgs e){
			this.BackColor = Color.FromArgb(PideColor().Color.ToArgb());
		}	
		void VistaPorDefectoToolStripMenuItemClick(object sender, EventArgs e){
			this.BackColor = Color.White;
			this.Padding = Padding.Empty;
			CajaTexto.BackColor = Color.White;
			CajaTexto.Font = DefaultFont;
			CajaTexto.ForeColor = Color.Black;
		}
		
		//
		//   ARCHIVO
		//
		
		void NuevoToolStripMenuItemClick(object sender, EventArgs e){
			CerraryGuardar();
			CajaTexto.Clear();
			NombreArchivo = "Bloc de Notas";
			this.Text = NombreArchivo;
		}
		void SalirToolStripMenuItemClick(object sender, EventArgs e){
			CerraryGuardar();
			this.Dispose();
		}
		void AbrirToolStripMenuItemClick(object sender, EventArgs e){
			CerraryGuardar();
			AbrirArchivo();
		}
		void GuardarToolStripMenuItemClick(object sender, EventArgs e){			
			Guardar(0);
		}
		void GuardarComoToolStripMenuItemClick(object sender, EventArgs e){
			Guardar(1);
		}
		
		//
		//DECLARACIÓN DE FUNCIONES Y OTRAS VARIABLES	
		//
		
		public void AbrirArchivo(){
			OpenFileDialog oOpenFileDialog = new OpenFileDialog();
			oOpenFileDialog.Filter = "Texto | *.txt";
			oOpenFileDialog.Title = "Archivos de texto.";
			if(oOpenFileDialog.ShowDialog() == DialogResult.OK){
				NombreArchivo = oOpenFileDialog.FileName;
				var fileStream = new FileStream(NombreArchivo, FileMode.Open);
				var streamReader = new StreamReader(fileStream);
				CajaTexto.Text = streamReader.ReadToEnd();
				contenido = CajaTexto.Text;
				streamReader.Close();
				fileStream.Close();
				this.Text = NombreArchivo;
			}	
			
		}
		
		void Guardar(int bandera){			
			SaveFileDialog DialogoGuardar = new SaveFileDialog();
			DialogoGuardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			DialogoGuardar.Title = "Guardar archivo de texto";			
			if(File.Exists(NombreArchivo)){
				FileStream file = new FileStream(NombreArchivo, FileMode.Create);
				StreamWriter Reader = new StreamWriter(file);
				Reader.WriteLine(CajaTexto.Text);
				Reader.Close();
				file.Close();
				contenido = CajaTexto.Text;
				MessageBox.Show("Archivo guardado");
			}else{
				//Es un if/else corto [operador ternario]
				DialogoGuardar.Filter = (bandera == 0) ? "Archivo de texto *.txt|*.txt" : "Todos los archivos (*.*)|*.*";					
				if (DialogoGuardar.ShowDialog() == DialogResult.OK) {
					NombreArchivo = DialogoGuardar.FileName;
					FileStream file = new FileStream(NombreArchivo, FileMode.Create);
					StreamWriter Reader = new StreamWriter(file);
					Reader.WriteLine(CajaTexto.Text);
					Reader.Close();
					file.Close();
					contenido = CajaTexto.Text;
				}
			}			
		}	
		
		void CerraryGuardar(){
			if(this.Text != "Bloc de Notas"){    //Comprueba si tiene abierto un archivo existente
				if(contenido != CajaTexto.Text)  //Comprueba si se hicieron cambios
					PreguntaGuardar("Desea guardar los cambios?");				
			}else
				if(CajaTexto.Text != "")  	     //Pregunta si hay un texto sin guardar
					PreguntaGuardar("Desea guardar el documento?");						
		}
		
		void PreguntaGuardar(string leyenda){
			const string mensaje = "Deseas guardar el archivo?";
			var resultado = MessageBox.Show(mensaje, leyenda, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(resultado == DialogResult.Yes) Guardar(0);
		}
		
		ColorDialog PideColor(){
			ColorDialog oColorDialog = new ColorDialog();
			oColorDialog.ShowDialog();
			return oColorDialog;
		}
		
		string carpeta = Application.StartupPath + @"\Contenedor";
		string NombreArchivo;
		string contenido;
		
		void ModoOscuroToolStripMenuItemClick (object sender, EventArgs e) {
			this.BackColor = Color.FromArgb(35, 36, 37);
			this.Padding = Padding.Empty;
			CajaTexto.BackColor = Color.FromArgb(35, 36, 37);
			CajaTexto.ForeColor = Color.White;
		}
				
		
	}
}
