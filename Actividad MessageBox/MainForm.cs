/*
 * Created by SharpDevelop.
 * User: Nahue
 * Date: 8/10/2021
 * Time: 19:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Actividad_MessageBox
{
	
	
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Usuario user;
		bool auxc;
		bool auxu;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			user = new Usuario();
			auxu = false;
			auxc = false;
		}
		void Btn_entrarClick(object sender, EventArgs e)
		{
			if (txt_usuario.Text == user.usuario){
				auxu = true;
			}else{
				auxu = false;
			}
			if(txt_contraseña.Text == user.constraseña){
				auxc = true;
			}else{
				auxc = false;
			}
			
			if(auxc == true && auxu == true){
				lbl_message.ForeColor = Color.Green;
				lbl_message.Text = "Bienvenido";
				MessageBox.Show("Bienvenido","Bienvenido");
			}else if (auxc == false && auxu == true){
				lbl_message.ForeColor = Color.Red;
				lbl_message.Text = "Constraseña Incorrecta";
				MessageBox.Show("Constraseña Incorrecta","Error");
			}else if (auxc == true && auxu == false){
				lbl_message.ForeColor = Color.Red;
				lbl_message.Text = "Usuario Incorrecto";
				MessageBox.Show("Usuario Incorrecto","Error");
			}else{
				lbl_message.ForeColor = Color.Red;
				lbl_message.Text = "Usuario y Contraseña Incorrectos";
				MessageBox.Show("Usuario y Contraseña Incorrectos","Error");
			}
		}
	}
	
	public class Usuario{
		public string usuario = "Nahuel";
		public string constraseña = "hola123";
	}
}
