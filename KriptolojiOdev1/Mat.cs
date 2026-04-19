using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KriptolojiOdev1
{
    public class Mat
    {
        Form1 form;
        public static char[,] MatrisiKaristir(char[,] matris, int seed)
        {
            Random rnd = new Random(seed);
            int satirSayisi = matris.GetLength(0);
            int sutunSayisi = matris.GetLength(1);
            int toplamEleman = satirSayisi * sutunSayisi;

            // Fisher-Yates algoritmasının 2D uyarlaması
            for (int i = toplamEleman - 1; i > 0; i--)
            {
                // Rastgele bir indeks seç (0 ile i arasında)
                int j = rnd.Next(i + 1);

                // i. elemanın koordinatlarını hesapla
                int satirI = i / sutunSayisi;
                int sutunI = i % sutunSayisi;

                // j. elemanın koordinatlarını hesapla
                int satirJ = j / sutunSayisi;
                int sutunJ = j % sutunSayisi;

                // Yer değiştirme (Swap) işlemi
                char gecici = matris[satirI, sutunI];
                matris[satirI, sutunI] = matris[satirJ, sutunJ];
                matris[satirJ, sutunJ] = gecici;
            }
            return matris;
        }

        public static int[] KonumBul(char[,] matris, char c)
        {
            for(int i=0; i<matris.GetLength(0); i++)
            {
                for(int j=0; j<matris.GetLength(1); j++)
                {
                    if (matris[i, j] == c)
                    {
                        return new int[]{i, j};
                    }
                }
            }
            return new int[]{-1, -1};
        }

        public static int[] MatrisCarpimi(int[] matris1, int[,] matris2)
        {
            int[] yeniMatris = new int[matris1.Length]; 
            for(int i=0; i<matris1.GetLength(0); i++)
            {
                int sonuc = 0;
                for(int j=0; j< matris1.GetLength(0); j++)
                {
                    sonuc += matris1[j] * matris2[j, i];
                }
                yeniMatris[i] = sonuc;
            }
            return yeniMatris;
        }

        public static int[,] MatrisModAl(int[,] matris, int mod)
        {
            for(int i=0; i<matris.GetLength(0); i++)
            {
                for(int j=0; j<matris.GetLength(0); j++)
                {
                    matris[i,j] %= mod;
                }
            }
            return matris;
        }
        public static int[] MatrisModAl(int[] matris, int mod)
        {
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                matris[i] %= mod;
            }
            return matris;
        }

        public static int[,] RastgeleMatrisUret(int boyut, int max, int seed)
        {
            Random r = new Random(seed);
            int[,] matris = new int[boyut, boyut];

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    matris[i, j] = r.Next(1, max);
                }
            }
            return matris;
        }

        public static int[,] MinorMatrisiniAl(int[,] matris, int satir, int sutun)
        {
            int boyut = matris.GetLength(0);
            int[,] sonuc = new int[boyut - 1, boyut - 1];
            int yeniSatir = 0;

            for (int i = 0; i < boyut; i++)
            {
                if (i == satir) continue;
                int yeniSutun = 0;
                for (int j = 0; j < boyut; j++)
                {
                    if (j == sutun) continue;
                    sonuc[yeniSatir, yeniSutun] = matris[i, j];
                    yeniSutun++;
                }
                yeniSatir++;
            }
            return sonuc;
        }

        public static int DeterminantHesapla(int[,] matris)
        {
            int boyut = matris.GetLength(0);

            if (boyut == 1) return matris[0, 0];
            if (boyut == 2) return (matris[0, 0] * matris[1, 1]) - (matris[0, 1] * matris[1, 0]);

            int det = 0;
            for (int j = 0; j < boyut; j++)
            {
                int isaret = (j % 2 == 0) ? 1 : -1;
                det += isaret * matris[0, j] * DeterminantHesapla(MinorMatrisiniAl(matris, 0, j));
            }
            return det;
        }

        public int[,] KofaktorMatrisi(int[,] matris, int mod)
        {
            int boyut = matris.GetLength(0);
            int[,] kofMatris = new int[boyut, boyut];

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    int[,] minor = MinorMatrisiniAl(matris, i, j);
                    int isaret = ((i + j) % 2 == 0) ? 1 : -1;
                    int kofDeger = isaret * DeterminantHesapla(minor);
                    kofMatris[i, j] = kofDeger;
                }
            }
            return kofMatris;
        }

        public static int[,] MatrisTranspoz(int[,] matris)
        {
            int satir = matris.GetLength(0);
            int sutun = matris.GetLength(1);
            int[,] sonuc = new int[sutun, satir];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    sonuc[j, i] = matris[i, j];
                }
            }
            return sonuc;
        }

        public double[,] MatrisTersiniAl(int[,] matris)
        {
            int boyut = matris.GetLength(0);
            int det = DeterminantHesapla(matris);

            if (det == 0)
            {
                throw new Exception("Determinant 0 olduğu için bu matrisin tersi yoktur.");
            }

            int[,] kof = KofaktorMatrisi(matris, 29);
            int[,] adj = MatrisTranspoz(kof);

            double[,] tersMatris = new double[boyut, boyut];
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    tersMatris[i, j] = adj[i, j] / det;
                }
            }
            return tersMatris;
        }
    }
}
