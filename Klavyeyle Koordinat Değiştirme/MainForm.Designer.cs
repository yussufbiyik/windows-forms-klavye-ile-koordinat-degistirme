/*
 * Created by SharpDevelop.
 * User: Yusuf Bıyık
 * Github: @yussufbiyik
 * yussufbiyik.github.io
 * Date: 30.10.2024
 * Time: 22:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Klavyeyle_Koordinat_Değiştirme
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button yukari;
		private System.Windows.Forms.Button asagi;
		private System.Windows.Forms.Button sol;
		private System.Windows.Forms.Button sag;
		private System.Windows.Forms.Label label1;
		
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
			this.yukari = new System.Windows.Forms.Button();
			this.asagi = new System.Windows.Forms.Button();
			this.sol = new System.Windows.Forms.Button();
			this.sag = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// yukari
			// 
			this.yukari.Location = new System.Drawing.Point(12, 197);
			this.yukari.Name = "yukari";
			this.yukari.Size = new System.Drawing.Size(75, 23);
			this.yukari.TabIndex = 0;
			this.yukari.Text = "Yukarı";
			this.yukari.UseVisualStyleBackColor = true;
			this.yukari.Click += new System.EventHandler(this.YukariClick);
			// 
			// asagi
			// 
			this.asagi.Location = new System.Drawing.Point(12, 226);
			this.asagi.Name = "asagi";
			this.asagi.Size = new System.Drawing.Size(75, 23);
			this.asagi.TabIndex = 1;
			this.asagi.Text = "Aşağı";
			this.asagi.UseVisualStyleBackColor = true;
			this.asagi.Click += new System.EventHandler(this.AsagiClick);
			// 
			// sol
			// 
			this.sol.Location = new System.Drawing.Point(93, 226);
			this.sol.Name = "sol";
			this.sol.Size = new System.Drawing.Size(75, 23);
			this.sol.TabIndex = 3;
			this.sol.Text = "Sol";
			this.sol.UseVisualStyleBackColor = true;
			this.sol.Click += new System.EventHandler(this.SolClick);
			// 
			// sag
			// 
			this.sag.Location = new System.Drawing.Point(93, 197);
			this.sag.Name = "sag";
			this.sag.Size = new System.Drawing.Size(75, 23);
			this.sag.TabIndex = 2;
			this.sag.Text = "Sağ";
			this.sag.UseVisualStyleBackColor = true;
			this.sag.Click += new System.EventHandler(this.SagClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(83, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 14);
			this.label1.TabIndex = 4;
			this.label1.Text = "X";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(181, 261);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sol);
			this.Controls.Add(this.sag);
			this.Controls.Add(this.asagi);
			this.Controls.Add(this.yukari);
			this.Name = "MainForm";
			this.Text = "Klavyeyle Koordinat Değiştirme";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.ResumeLayout(false);

		}
	}
}
