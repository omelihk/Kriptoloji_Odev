using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;
using System.IO;

namespace KriptolojiOdev1
{
    public partial class Form1 : Form
    {
        public char[] alfabe = {'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ',
                         'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T',
                         'U', 'Ü', 'V', 'Y', 'Z'};

        string alfabe2 = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";

        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += Form1_DragEnter;
            this.DragDrop += Form1_DragDrop;
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            sifreBox.Text = "";
            sonucBox.Text = "";
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;  // Yeşil + işareti göster
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] dosyalar = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (dosyalar == null || dosyalar.Length == 0) return;

            string dosya = dosyalar[0]; // İlk dosyayı al

            if (!dosya.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Lütfen sadece .txt dosyası sürükleyiniz.",
                    "Hatalı Dosya Türü", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string icerik = File.ReadAllText(dosya, Encoding.UTF8);
                sifreBox.Text = icerik;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okunurken hata: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mail_yolla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sonucBox.Text))
            {
                MessageBox.Show("Lütfen şifrelenmiş metni giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mail bilgilerini almak için dialog aç
            using (MailForm mailForm = new MailForm())
            {
                if (mailForm.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    string dosyayolu = Path.Combine(Path.GetTempPath(), "sonuc.txt");
                    File.WriteAllText(dosyayolu, sonucBox.Text, Encoding.UTF8);

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential(mailForm.Gonderen, mailForm.AppSifre);
                        smtp.EnableSsl = true;

                        using (MailMessage mesaj = new MailMessage())
                        {
                            mesaj.From = new MailAddress(mailForm.Gonderen);
                            mesaj.To.Add(mailForm.Alici);
                            mesaj.Subject = "Kriptoloji Sonucu";
                            mesaj.Body = "Şifreleme sonucu ekteki metin dosyasında yer almaktadır.";

                            using (Attachment ek = new Attachment(dosyayolu))
                            {
                                mesaj.Attachments.Add(ek);
                                smtp.Send(mesaj);
                            }
                        }
                    }

                    MessageBox.Show("E-posta başarıyla gönderildi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "E-posta Hatası",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0: //Kaydırmalı Şifreleme
                    kaydirmaliSifrelemePanel.Visible = true;
                    affinePanel.Visible = false;
                    yerDegistirmePanel.Visible = false;
                    permutasyonPanel.Visible = false;
                    sayiAnahtarliPanel.Visible = false;
                    rotaPanel.Visible = false;
                    zikzakPanel.Visible = false;
                    vigenerePanel.Visible = false;
                    DortKarePanel.Visible = false;
                    hillPanel.Visible = false;
                    break;
                
                case 1: //Affine Şifreleme
                    affinePanel.Visible = true;
                    kaydirmaliSifrelemePanel.Visible=false;
                    yerDegistirmePanel.Visible = false;
                    sayiAnahtarliPanel.Visible = false;
                    permutasyonPanel.Visible = false;
                    rotaPanel.Visible = false;
                    zikzakPanel.Visible = false;
                    vigenerePanel.Visible = false;
                    DortKarePanel.Visible = false;
                    hillPanel.Visible = false;
                    break;
                case 2: //Yer Değiştirme Şifreleme
                    kaydirmaliSifrelemePanel.Visible=false;
                    affinePanel.Visible = false;
                    yerDegistirmePanel.Visible = true;
                    sayiAnahtarliPanel.Visible = false;
                    permutasyonPanel.Visible = false;
                    rotaPanel.Visible = false;
                    zikzakPanel.Visible = false;
                    vigenerePanel.Visible = false;
                    DortKarePanel.Visible = false;
                    hillPanel.Visible = false;
                    break;
                case 3: //Yer Değiştirme Şifreleme (Sayı Anahtarlı)
                    kaydirmaliSifrelemePanel.Visible = false;
                    affinePanel.Visible = false;
                    yerDegistirmePanel.Visible = false;
                    sayiAnahtarliPanel.Visible = true;
                    permutasyonPanel.Visible = false;
                    rotaPanel.Visible = false;
                    zikzakPanel.Visible = false;
                    vigenerePanel.Visible = false;
                    DortKarePanel.Visible = false;
                    hillPanel.Visible = false;
                    break;
                case 4: //Permütasyon Şifreleme
                    kaydirmaliSifrelemePanel.Visible = false;
                    affinePanel.Visible = false;
                    yerDegistirmePanel.Visible = false;
                    sayiAnahtarliPanel.Visible = false;
                    permutasyonPanel.Visible = true;
                    rotaPanel.Visible = false;
                    zikzakPanel.Visible = false;
                    vigenerePanel.Visible = false;
                    DortKarePanel.Visible = false;
                    hillPanel.Visible = false;
                    break;
                case 5: //Rota Şifreleme
                    kaydirmaliSifrelemePanel.Visible = false;
                    affinePanel.Visible = false;
                    yerDegistirmePanel.Visible = false;
                    sayiAnahtarliPanel.Visible = false;
                    permutasyonPanel.Visible = false;
                    zikzakPanel.Visible = false;
                    rotaPanel.Visible = true;
                    vigenerePanel.Visible = false;
                    DortKarePanel.Visible = false;
                    hillPanel.Visible = false;
                    break;
                case 6: //Zikzak Şifreleme
                    kaydirmaliSifrelemePanel.Visible = false;
                    affinePanel.Visible = false;
                    yerDegistirmePanel.Visible = false;
                    sayiAnahtarliPanel.Visible = false;
                    permutasyonPanel.Visible = false;
                    rotaPanel.Visible = false;
                    zikzakPanel.Visible = true;
                    vigenerePanel.Visible = false;
                    DortKarePanel.Visible = false;
                    hillPanel.Visible = false;
                    break;
                case 7: //Vigenere Şifreleme
                    kaydirmaliSifrelemePanel.Visible = false;
                    affinePanel.Visible = false;
                    yerDegistirmePanel.Visible = false;
                    sayiAnahtarliPanel.Visible = false;
                    permutasyonPanel.Visible = false;
                    rotaPanel.Visible = false;
                    zikzakPanel.Visible = false;
                    vigenerePanel.Visible = true;
                    DortKarePanel.Visible = false;
                    hillPanel.Visible = false;
                    break;
                case 8: //4 Kare Şifreleme
                    kaydirmaliSifrelemePanel.Visible = false;
                    affinePanel.Visible = false;
                    yerDegistirmePanel.Visible = false;
                    sayiAnahtarliPanel.Visible = false;
                    permutasyonPanel.Visible = false;
                    rotaPanel.Visible = false;
                    zikzakPanel.Visible = false;
                    vigenerePanel.Visible = false;
                    DortKarePanel.Visible = true;
                    hillPanel.Visible = false;
                    break;
                case 9: //Hill Şifreleme
                    kaydirmaliSifrelemePanel.Visible = false;
                    affinePanel.Visible = false;
                    yerDegistirmePanel.Visible = false;
                    sayiAnahtarliPanel.Visible = false;
                    permutasyonPanel.Visible = false;
                    rotaPanel.Visible = false;
                    zikzakPanel.Visible = false;
                    vigenerePanel.Visible = false;
                    DortKarePanel.Visible = false;
                    hillPanel.Visible = true;
                    break;
            }
        }

        public string metniSadelestir(string metin)
        {
            if (metin == "" || metin == null) return "";

            metin = metin.ToUpper(new System.Globalization.CultureInfo("tr-TR"));
            metin = metin.Trim();
            string emptyString = "";
            foreach(char c in metin)
            {
                if(alfabe.Contains(c)) emptyString += c;
            }
            return emptyString;
        }

        public string metniSadelestirDortKareOzel(string metin)
        {
            char[] alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZX".ToCharArray();
            if (metin == "" || metin == null) return "";

            metin = metin.ToUpper(new System.Globalization.CultureInfo("tr-TR"));
            metin = metin.Trim();
            string emptyString = "";
            foreach (char c in metin)
            {
                if (alfabe.Contains(c)) emptyString += c;
            }
            return emptyString;
        }

        public string kaydirmaliSifreleme(string sifre, int key)
        {
            string sifrelenmisMetin = "";
            for(int i=0; i<sifre.Length; i++)
            {
                int deger = (Array.IndexOf(alfabe, sifre[i]) + key) % alfabe.Length;
                sifrelenmisMetin += alfabe[deger];
            }
            return sifrelenmisMetin;
        }
        public string kaydirmaliSifrelemeCoz(string sifre, int key)
        {
            string cozulmusMetin = "";
            for (int i=0;i<sifre.Length;i++)
            {
                int deger = (Array.IndexOf(alfabe, sifre[i]) - key) % alfabe.Length;
                while (deger < 0) deger += alfabe.Length;
                cozulmusMetin += alfabe[deger];
            }
            return cozulmusMetin;
        }

        public string affineSifreleme(string sifre, int A, int B)
        {
            string sifrelenmisMetin = "";
            for (int i = 0; i < sifre.Length; i++)
            {
                int deger = ((Array.IndexOf(alfabe, sifre[i]) * A) + B) % alfabe.Length;
                sifrelenmisMetin += alfabe[deger];
            }
            return sifrelenmisMetin;
        }

        public string affineSifrelemeCoz(string sifre, int A, int B)
        {
            string sifrelenmisMetin = "";
            int bolunecekSayi=1;
            while ((A * bolunecekSayi) % alfabe.Length != 1)
            {
                bolunecekSayi++;
            }

            for (int i = 0; i < sifre.Length; i++)
            {
                int deger = Array.IndexOf(alfabe, sifre[i]) - B;
                while (deger < 0) deger += alfabe.Length;
                //deger%=alfabe.Length;
                deger = (deger * bolunecekSayi) % alfabe.Length;
                sifrelenmisMetin += alfabe[deger];
            }
            return sifrelenmisMetin;
        }

        public string yerDegistirmeSifreleme(string sifre, int seed)
        {
            List<char> listeAlfabe = new List<char>(alfabe);
            char[] yeniAlfabe=new char[alfabe.Length];
            Random r=new Random(seed);
            int elemanSayisi = 0;
            while(listeAlfabe.Count > 0)
            {
                int rastgeleSayi=r.Next(0, listeAlfabe.Count);
                char deger = listeAlfabe[rastgeleSayi];
                yeniAlfabe[elemanSayisi] = deger;
                listeAlfabe.RemoveAt(rastgeleSayi);
                elemanSayisi++;
            }

            string sifrelenmisMetin = "";
            foreach(char c in sifre)
            {
                sifrelenmisMetin += yeniAlfabe[Array.IndexOf(alfabe, c)];
            }
            return sifrelenmisMetin;
        }

        public string yerDegistirmeSifrelemeCoz(string sifre, int seed)
        {
            List<char> listeAlfabe = new List<char>(alfabe);
            char[] yeniAlfabe = new char[alfabe.Length];
            Random r = new Random(seed);
            int elemanSayisi = 0;
            while (listeAlfabe.Count > 0)
            {
                int rastgeleSayi = r.Next(0, listeAlfabe.Count);
                char deger = listeAlfabe[rastgeleSayi];
                yeniAlfabe[elemanSayisi] = deger;
                listeAlfabe.RemoveAt(rastgeleSayi);
                elemanSayisi++;
            }

            string cozulmusMetin = "";
            foreach (char c in sifre)
            {
                cozulmusMetin += alfabe[Array.IndexOf(yeniAlfabe, c)];
            }
            return cozulmusMetin;
        }

        public string sayiAnahtarliSifreleme(string sifre, int key) {
            int satirSayisi=(int)Math.Ceiling(1.0*sifre.Length/key);
            char[,] matris = new char[satirSayisi, key];
            int pointer = 0;
            for(int i=0; i<satirSayisi; i++)
            {
                for(int j=0; j < key; j++)
                {
                    if (pointer < sifre.Length)
                        matris[i, j] = sifre[pointer++];
                    else
                        matris[i, j] = 'A';

                }
            }

            string sifrelenmisMetin = "";
            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < satirSayisi; j++)
                {
                    sifrelenmisMetin += matris[j, i];
                }
            }
            return sifrelenmisMetin;
        }

        public string sayiAnahtarliSifrelemeCoz(string sifre, int key) {
            int satirSayisi = (int)Math.Ceiling(1.0 * sifre.Length / key);
            char[,] matris = new char[satirSayisi, key];
            int pointer = 0;
            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < satirSayisi; j++)
                {
                    if (pointer < sifre.Length)
                        matris[j, i] = sifre[pointer++];
                    else
                        matris[j, i] = alfabe[0];

                }
            }

            string cozulmusMetin = "";
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < key; j++)
                {
                    cozulmusMetin += matris[i, j];
                }
            }
            return cozulmusMetin;
        }

        public string permutasyonSifreleme(string sifre, int key, int seed)
        {
            while (sifre.Length % key != 0)
            {
                sifre += alfabe[0];
            }
            char[] arraySifre = sifre.ToCharArray();
            List<int> siraliListe= new List<int>();
            char[] yeniSifre = new char[sifre.Length];

            for (int i = 0; i < key; i++)
                siraliListe.Add(i);

            List<int> karisikSira = new List<int>();
            Random r=new Random(seed);
            while (siraliListe.Count > 0)
            {
                int index = r.Next(0, siraliListe.Count);
                karisikSira.Add(siraliListe[index]);
                siraliListe.RemoveAt(index);
            }

            for (int i = 0; i < sifre.Length; i += key)
            {
                for (int j = 0; j < key; j++)
                {
                    yeniSifre[i + j] = arraySifre[i + karisikSira[j]];
                }
            }

            return new string(yeniSifre);
        }

        public string permutasyonSifrelemeCoz(string sifre, int key, int seed)
        {
            while (sifre.Length % key != 0)
            {
                sifre += alfabe[0];
            }
            char[] arraySifre = sifre.ToCharArray();
            List<int> siraliListe = new List<int>();
            char[] cozulmusSifre = new char[sifre.Length];

            for (int i = 0; i < key; i++)
                siraliListe.Add(i);

            List<int> karisikSira = new List<int>();
            Random r = new Random(seed);
            while (siraliListe.Count > 0)
            {
                int index = r.Next(0, siraliListe.Count);
                karisikSira.Add(siraliListe[index]);
                siraliListe.RemoveAt(index);
            }

            for (int i = 0; i < sifre.Length; i += key)
            {
                for (int j = 0; j < key; j++)
                {
                    cozulmusSifre[i + karisikSira[j]] = arraySifre[i + j];
                }
            }

            return new string(cozulmusSifre);
        }

        public string rotaSifreleme(string sifre, int key)
        {
            int satirSayisi = (int)Math.Ceiling(1.0 * sifre.Length / key);
            char[,] matris = new char[satirSayisi, key];
            int pointer = 0;
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < key; j++)
                {
                    if (pointer < sifre.Length)
                        matris[i, j] = sifre[pointer++];
                    else
                        matris[i, j] = alfabe[0];

                }
            }

            string sifrelenmisMetin = "";
            int sutunSayisi = key;
            int ustSinir = 0;
            int altSinir = satirSayisi-1;
            int solSinir = 0;
            int sagSinir = sutunSayisi-1;
            while (sifrelenmisMetin.Length < matris.Length)
            {
                for (int i = altSinir; i >= ustSinir && sifrelenmisMetin.Length < matris.Length; i--) //asagidan yukari
                {
                    sifrelenmisMetin += matris[i, solSinir];
                }
                solSinir++;

                for (int j = solSinir; j <= sagSinir && sifrelenmisMetin.Length < matris.Length; j++) //soldan saga
                {
                    sifrelenmisMetin += matris[ustSinir,j];
                }
                ustSinir++;

                for (int k = ustSinir; k <= altSinir && sifrelenmisMetin.Length < matris.Length; k++) //yukaridan asagi
                {
                    sifrelenmisMetin += matris[k, sagSinir];
                }
                sagSinir--;

                for (int l = sagSinir; l >= solSinir && sifrelenmisMetin.Length < matris.Length; l--) //sagdan sola
                {
                    sifrelenmisMetin += matris[altSinir, l];
                }
                altSinir--;
                
            }
            return sifrelenmisMetin;
        }

        public string rotaSifrelemeCoz(string sifre, int key)
        {
            int satirSayisi = (int)Math.Ceiling(1.0 * sifre.Length / key);
            char[,] matris = new char[satirSayisi, key];
            
            int bakilanHarf = 0;
            int sutunSayisi = key;
            int ustSinir = 0;
            int altSinir = satirSayisi - 1;
            int solSinir = 0;
            int sagSinir = sutunSayisi - 1;
            while (bakilanHarf < matris.Length)
            {
                for (int i = altSinir; i >= ustSinir && sifre.Length > bakilanHarf; i--) //asagidan yukari
                {
                    matris[i, solSinir] = sifre[bakilanHarf++];
                }
                solSinir++;

                for (int j = solSinir; j <= sagSinir && sifre.Length > bakilanHarf; j++) //soldan saga
                {
                    matris[ustSinir, j] = sifre[bakilanHarf++];
                }
                ustSinir++;

                for (int k = ustSinir; k <= altSinir && sifre.Length > bakilanHarf; k++) //yukaridan asagi
                {
                    matris[k, sagSinir] = sifre[bakilanHarf++];
                }
                sagSinir--;

                for (int l = sagSinir; l >= solSinir && sifre.Length > bakilanHarf; l--) //sagdan sola
                {
                    matris[altSinir, l] = sifre[bakilanHarf++];
                }
                altSinir--;
            }

            string cozulmusMetin = "";
            for(int i=0; i<matris.GetLength(0); i++)
            {
                for(int j=0; j<matris.GetLength(1); j++){ 
                    cozulmusMetin += matris[i, j];
                }
            }
            return cozulmusMetin;
        }

        public string zikzakSifreleme(string sifre, int key)
        {
            if (key <= 1) return sifre;

            char[,] matris = new char[key, sifre.Length];

            for (int i = 0; i < key; i++)
                for (int j = 0; j < sifre.Length; j++)
                    matris[i, j] = '\0';

            bool asagiMi = false;
            int pointer = 0;
            for (int i = 0; i < sifre.Length; i++)
            {
                matris[pointer, i] = sifre[i];

                if (pointer == 0)
                    asagiMi = true;
                else if (pointer == key - 1)
                    asagiMi = false;

                pointer += asagiMi ? 1 : -1;
            }


            string sifrelenmisMetin = "";
            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < sifre.Length; j++)
                {
                    if (matris[i, j] != '\0')
                    {
                        sifrelenmisMetin+=matris[i, j];
                    }
                }
            }
            return sifrelenmisMetin;
        }

        public string zikzakSifrelemeCoz(string sifre, int key)
        {
            if (key <= 1) return sifre;

            char[,] matris = new char[key, sifre.Length];

            for (int i = 0; i < key; i++)
                for (int j = 0; j < sifre.Length; j++)
                    matris[i, j] = '\0';

            bool asagiMi = false;
            int pointer = 0;
            for (int i = 0; i < sifre.Length; i++)
            {
                matris[pointer, i] = '*';

                if (pointer == 0) asagiMi = true;
                else if (pointer == key - 1) asagiMi = false;

                pointer += asagiMi ? 1 : -1;
            }

            int harfIndex = 0;
            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < sifre.Length; j++)
                {
                    if (matris[i, j] == '*' && harfIndex < sifre.Length)
                    {
                        matris[i, j] = sifre[harfIndex++];
                    }
                }
            }

            string cozulmusMetin = "";
            pointer = 0;
            asagiMi = false;
            for (int i = 0; i < sifre.Length; i++)
            {
                cozulmusMetin += matris[pointer, i];

                if (pointer == 0) asagiMi = true;
                else if (pointer == key - 1) asagiMi = false;

                pointer += asagiMi ? 1 : -1;
            }

            return cozulmusMetin;
        }

        public string vigenereSifreleme(string sifre, string key)
        {
            key = metniSadelestir(key);
            string sifrelenmisMetin = "";
            for(int i = 0; i < sifre.Length; i++)
            {
                int metinIndeks = Array.IndexOf(alfabe, sifre[i]);
                int anahtarIndeks = Array.IndexOf(alfabe, key[i % key.Length]);
                sifrelenmisMetin += alfabe[(metinIndeks + anahtarIndeks) % alfabe.Length];
            }
            return sifrelenmisMetin;
        }

        public string vigenereSifrelemeCoz(string sifre, string key)
        {
            key = metniSadelestir(key);
            string sifrelenmisMetin = "";
            for (int i = 0; i < sifre.Length; i++)
            {
                int metinIndeks = Array.IndexOf(alfabe, sifre[i]);
                int anahtarIndeks = Array.IndexOf(alfabe, key[i % key.Length]);
                int deger = (metinIndeks - anahtarIndeks) % alfabe.Length;
                while (deger < 0) deger += alfabe.Length;
                sifrelenmisMetin += alfabe[deger];
            }
            return sifrelenmisMetin;
        }

        public string dortKareSifreleme(string sifre, int key, int seed)
        {
            //char[] alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();
            int satir = (key == 0) ? 6 : 5;
            int sutun = (key == 0) ? 5 : 6;

            char[,] anaMatris = new char[satir, sutun];
            for (int i = 0; i < alfabe.Length; i++)
            {
                anaMatris[i / sutun, i % sutun] = alfabe[i];
            }
            anaMatris[satir - 1, sutun - 1] = 'X';

            char[,] key1 = Mat.MatrisiKaristir((char[,])anaMatris.Clone(), seed);
            char[,] key2 = Mat.MatrisiKaristir((char[,])anaMatris.Clone(), seed + 1);

            if (sifre.Length % 2 == 1) sifre += 'X';

            string sifrelenmisMetin = "";
            for (int i = 0; i < sifre.Length; i += 2)
            {
                int[] p1 = Mat.KonumBul(anaMatris, sifre[i]);     // 1. harf konumu
                int[] p2 = Mat.KonumBul(anaMatris, sifre[i + 1]); // 2. harf konumu

                sifrelenmisMetin += key1[p1[0], p2[1]];
                sifrelenmisMetin += key2[p2[0], p1[1]];
            }
            return sifrelenmisMetin;
        }

        public string dortKareCoz(string sifreliMetin, int key, int seed)
        {
            //char[] alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();
            int satir = (key == 0) ? 6 : 5;
            int sutun = (key == 0) ? 5 : 6;

            char[,] anaMatris = new char[satir, sutun];
            for (int i = 0; i < alfabe.Length; i++)
            {
                anaMatris[i / sutun, i % sutun] = alfabe[i];
            }
            anaMatris[satir - 1, sutun - 1] = 'X';

            char[,] key1 = Mat.MatrisiKaristir((char[,])anaMatris.Clone(), seed);
            char[,] key2 = Mat.MatrisiKaristir((char[,])anaMatris.Clone(), seed + 1);

            string cozulmusMetin = "";
            for (int i = 0; i < sifreliMetin.Length-1; i += 2)
            {
                int[] c1 = Mat.KonumBul(key1, sifreliMetin[i]);
                int[] c2 = Mat.KonumBul(key2, sifreliMetin[i + 1]);

                cozulmusMetin += anaMatris[c1[0], c2[1]];
                cozulmusMetin += anaMatris[c2[0], c1[1]];
            }

            return cozulmusMetin;
        }

        public string hillSifreleme(string sifre, int key, int seed)
        {
            while (sifre.Length % key != 0) sifre += alfabe[0];
            int[,] rastgeleMatris = Mat.RastgeleMatrisUret(key, alfabe.Length, seed);

            string sifrelenmisMetin = "";
            for (int i = 0; i < sifre.Length; i += key)
            {
                int[] blokVektoru = new int[key];
                for (int j = 0; j < key; j++)
                {
                    blokVektoru[j] = Array.IndexOf(alfabe, sifre[i + j]);
                }

                int[] sonucVektoru = Mat.MatrisCarpimi(blokVektoru, rastgeleMatris);
                sonucVektoru = Mat.MatrisModAl(sonucVektoru, alfabe.Length);

                for (int k = 0; k < key; k++)
                {
                    sifrelenmisMetin += alfabe[sonucVektoru[k]];
                }
            }
            return sifrelenmisMetin;
        }

        public string hillSifrelemeCoz(string sifre, int key, int seed)
        {
            int mod = alfabe.Length;
            int[,] anahtarMatrisi = Mat.RastgeleMatrisUret(key, alfabe.Length, seed);
            int det = Mat.DeterminantHesapla(anahtarMatrisi);

            int bolunecekSayi = 1;
            while ((det * bolunecekSayi) % alfabe.Length != 1)
            {
                bolunecekSayi++;
            }

            int detTersi = bolunecekSayi;

            int[,] kof = new Mat().KofaktorMatrisi(anahtarMatrisi, mod);
            int[,] adj = Mat.MatrisTranspoz(kof);

            int[,] tersMatris = new int[key, key];
            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < key; j++)
                {
                    int deger = (adj[i, j] * detTersi) % mod;
                    tersMatris[i, j] = (deger + mod) % mod;
                }
            }

            string cozulmusMetin = "";
            for (int i = 0; i < sifre.Length; i += key)
            {
                int[] blok = new int[key];
                for (int j = 0; j < key; j++)
                    blok[j] = Array.IndexOf(alfabe, sifre[i + j]);

                int[] sonucVektoru = Mat.MatrisCarpimi(blok, tersMatris);
                sonucVektoru = Mat.MatrisModAl(sonucVektoru, mod);

                for (int k = 0; k < key; k++)
                    cozulmusMetin += alfabe[sonucVektoru[k]];
            }

            return cozulmusMetin;
        }

        private void sifreleButton_Click(object sender, EventArgs e)
        {
            if (sifreBox.Text == "" || sifreBox.Text==null) return;
            string metin=metniSadelestir(sifreBox.Text);
            //string dortKareOzelMetin = metniSadelestirDortKareOzel(sifreBox.Text);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    sonucBox.Text = kaydirmaliSifreleme(metin, (int)kaydirmaliKey.Value);
                    break;
                case 1:
                    sonucBox.Text = affineSifreleme(metin, (int)affineKeyA.Value, (int)affineKeyB.Value);
                    break;
                case 2:
                    sonucBox.Text = yerDegistirmeSifreleme(metin, (int)seed.Value);
                    break;
                case 3:
                    sonucBox.Text = sayiAnahtarliSifreleme(metin, (int)sayiAnahtarlamaKey.Value);
                    break;
                case 4:
                    sonucBox.Text = permutasyonSifreleme(metin, (int)permutasyonKey.Value, (int)permutasyonSeed.Value);
                    break;
                case 5:
                    sonucBox.Text = rotaSifreleme(metin, (int)rotaKey.Value);
                    break;
                case 6:
                    sonucBox.Text = zikzakSifreleme(metin, (int)zikzakKey.Value);
                    break;
                case 7:
                    sonucBox.Text = vigenereSifreleme(metin, vigenereKey.Text);
                    break;
                case 8:
                    sonucBox.Text = dortKareSifreleme(metin, dortKareKey.SelectedIndex, (int)dortKareSeed.Value);
                    break;
                case 9:
                    sonucBox.Text = hillSifreleme(metin, (int)hillKey.Value, (int)hillSeed.Value); ;
                    break;
            }
        }

        private void cozButton_Click(object sender, EventArgs e)
        {
            if (sifreBox.Text == "" || sifreBox.Text == null) return;
            string metin = metniSadelestir(sifreBox.Text);
            string dortKareOzelMetin=metniSadelestirDortKareOzel(sifreBox.Text);

            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    sonucBox.Text = kaydirmaliSifrelemeCoz(metin, (int)kaydirmaliKey.Value);
                    break;
                case 1:
                    sonucBox.Text = affineSifrelemeCoz(metin, (int)affineKeyA.Value, (int)affineKeyB.Value);
                    break;
                case 2:
                    sonucBox.Text = yerDegistirmeSifrelemeCoz(metin, (int)seed.Value);
                    break;
                case 3:
                    sonucBox.Text = sayiAnahtarliSifrelemeCoz(metin, (int)sayiAnahtarlamaKey.Value);
                    break;
                case 4:
                    sonucBox.Text = permutasyonSifrelemeCoz(metin, (int)permutasyonKey.Value, (int)permutasyonSeed.Value);
                    break;
                case 5:
                    sonucBox.Text = rotaSifrelemeCoz(metin, (int)rotaKey.Value);
                    break;
                case 6:
                    sonucBox.Text = zikzakSifrelemeCoz(metin, (int)zikzakKey.Value);
                    break;
                case 7:
                    sonucBox.Text = vigenereSifrelemeCoz(metin, vigenereKey.Text);
                    break;
                case 8:
                    sonucBox.Text = dortKareCoz(dortKareOzelMetin, dortKareKey.SelectedIndex, (int)dortKareSeed.Value);
                    break;
                case 9:
                    sonucBox.Text = hillSifrelemeCoz(metin, (int)hillKey.Value, (int)hillSeed.Value);
                    break;
            }
        }
    }
}

//7 8
//6 8
//3 3
//3 6
//4 3