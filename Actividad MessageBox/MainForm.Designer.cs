/*
 * Created by SharpDevelop.
 * User: Nahue
 * Date: 8/10/2021
 * Time: 19:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Actividad_MessageBox
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_usuario;
		private System.Windows.Forms.TextBox txt_contraseña;
		private System.Windows.Forms.Button btn_entrar;
		private System.Windows.Forms.Label lbl_message;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.txt_contraseña = new System.Windows.Forms.TextBox();
			this.btn_entrar = new System.Windows.Forms.Button();
			this.lbl_message = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(82, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inicio de Sesion";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "Usuario:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 35);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contraseña:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_usuario
			// 
			this.txt_usuario.Location = new System.Drawing.Point(118, 87);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(172, 20);
			this.txt_usuario.TabIndex = 3;
			// 
			// txt_contraseña
			// 
			this.txt_contraseña.Location = new System.Drawing.Point(118, 155);
			this.txt_contraseña.Name = "txt_contraseña";
			this.txt_contraseña.Size = new System.Drawing.Size(172, 20);
			this.txt_contraseña.TabIndex = 4;
			// 
			// btn_entrar
			// 
			this.btn_entrar.Location = new System.Drawing.Point(128, 218);
			this.btn_entrar.Name = "btn_entrar";
			this.btn_entrar.Size = new System.Drawing.Size(131, 39);
			this.btn_entrar.TabIndex = 5;
			this.btn_entrar.Text = "Entrar";
			this.btn_entrar.UseVisualStyleBackColor = true;
			this.btn_entrar.Click += new System.EventHandler(this.Btn_entrarClick);
			// 
			// lbl_message
			// 
			this.lbl_message.Location = new System.Drawing.Point(82, 279);
			this.lbl_message.Name = "lbl_message";
			this.lbl_message.Size = new System.Drawing.Size(212, 34);
			this.lbl_message.TabIndex = 6;
			this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 336);
			this.Controls.Add(this.lbl_message);
			this.Controls.Add(this.btn_entrar);
			this.Controls.Add(this.txt_contraseña);
			this.Controls.Add(this.txt_usuario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Actividad MessageBox";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
