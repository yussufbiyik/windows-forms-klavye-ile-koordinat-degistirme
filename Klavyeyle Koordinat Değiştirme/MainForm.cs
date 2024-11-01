using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Klavyeyle_Koordinat_Değiştirme
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			// Her tuş basımında fonksiyonumuzu tetikliyoruz
            this.KeyDown += new KeyEventHandler(MainFormKeyDown);
            // Formun klavye hareketlerini kullabailmesine izin tanıyoruz
            this.KeyPreview = true;
		}
		void koordinatDegistir(string degisimYonu) {
			// Tek harekette ne kadar yukarı aşağı sağ sol gideceğini tanımlıyoruz.
			int degisimMiktari = 10;
			// Üstten ve soldan uzaklıklarını alıp X ve Y eksen değerleri olarak tanımlıyoruz.
			int labelXKonum = label1.Left;
			int labelYKonum = label1.Top;
			// Konumu değiştirmek için switch kullanıyoruz hem hızlı hem okunaklı
			switch (degisimYonu) {
				// Girdinin Yukarı ya da W tuşu olması durumunda yapılacak işlem
				// Diğer case blokları da aynı mantıkla aşağıya, sağa, sola gibi hareketlerin girilince çalışıyor
				case "Yukarı":
					// Buradaki mantık new Point(X Konumu, Y Konumu)
					// biz de X ve Y konumunu manipüle edip label'ın Location (Konum) özelliğine yeni bir değer/konum atıyoruz
					label1.Location = new Point(labelXKonum, labelYKonum-degisimMiktari);
					break;
				case "Aşağı":
					label1.Location = new Point(labelXKonum, labelYKonum+degisimMiktari);
					break;
				case "Sol":
					label1.Location = new Point(labelXKonum-degisimMiktari, labelYKonum);
					break;
				case "Sağ":
					label1.Location = new Point(labelXKonum+degisimMiktari, labelYKonum);
					break;
			}
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			string hareketYonu;
			switch (e.KeyCode){
				// Basılan W, A, S, D tuşlarına göre hareket yönü değişkenimize değer ataması yapıyoruz
				case Keys.W:
					hareketYonu = "Yukarı";
					break;
				case Keys.S:
					hareketYonu = "Aşağı";
					break;
				case Keys.A:
					hareketYonu = "Sol";
					break;
				case Keys.D:
					hareketYonu = "Sağ";
					break;
				// Hiçbir tuşa basılmazsa hata çıkmaması için fonksiyonu return diyip iptal ediyoruz
				default:
					return;
			}
			// Koordinat değişme fonksiyonumuza hareket yönünü gönderiyoruz
			koordinatDegistir(hareketYonu);
		}
		void YukariClick(object sender, EventArgs e)
		{
			koordinatDegistir("Yukarı");
		}
		void AsagiClick(object sender, EventArgs e)
		{
			koordinatDegistir("Aşağı");
		}
		void SolClick(object sender, EventArgs e)
		{
			koordinatDegistir("Sol");
		}
		void SagClick(object sender, EventArgs e)
		{
			koordinatDegistir("Sağ");
		}
	}
}
