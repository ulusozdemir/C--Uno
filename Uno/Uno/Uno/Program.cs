using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme3
{
    class Program
    {

        static void Main(string[] args)
        {
            int paskontrol = 0;
            int[] passayac = new int[2];
            int oyuncupas = 0;
            int hamlekimde = 0;
            int boskontrol = 0;
            int kazanmasart = 0;
            string yerdeki = "bos";
            string[] deste = new string[18] { "k1", "k2", "k3", "k4", "k5", "m1", "m2", "m3", "m4", "m5", "s1", "s2", "s3", "s4", "s5", "rd", "rd", "rd" };
            for (int i = 0; i < 18; i++)
            {
                Random b = new Random();
                int a = b.Next(0, 18);
                string de;
                de = deste[i];
                deste[i] = deste[a];
                deste[a] = de;


            }
            string[] oyuncu1 = new string[6];
            string[] oyuncu2 = new string[6];
            string[] oyuncu3 = new string[6];
            for (int i = 0; i < 6; i++)
            {
                oyuncu1[i] = deste[i];
            }
            for (int i = 6; i < 12; i++)
            {
                oyuncu2[i - 6] = deste[i];
            }
            for (int i = 12; i < 18; i++)
            {
                oyuncu3[i - 12] = deste[i];
            }

            Random baslayacaq = new Random();
            int baslayacak = baslayacaq.Next(1, 4);
            if (baslayacak == 1)
            {
                Console.WriteLine("1. oyuncu baslayacak");
            }
            else if (baslayacak == 2)
            {
                Console.WriteLine("2.oyuncu baslayacak");
            }
            else if (baslayacak == 3)
            {
                Console.WriteLine("3. oyuncu baslayacak");
            }
            Console.WriteLine("1. oyuncunun eli");

            Console.WriteLine();
            foreach (var item in oyuncu1)
            {
                Console.WriteLine(item + "");
            }
            Console.WriteLine();
            Console.WriteLine();
            if (baslayacak == 2)

            {
                int kontrol1 = 0;
                for (int i = 0; i < 6 && kazanmasart == 0; i++)
                {
                    if (kontrol1 == 0)
                    {
                        if (oyuncu2[i] != "rd")
                        {
                            Console.WriteLine("2. oyuncu {0} kartını oynadı", oyuncu2[i]);
                            kontrol1 = kontrol1 + 1;
                            yerdeki = oyuncu2[i];
                            oyuncu2[i] = "bos";
                            boskontrol = 0;
                            hamlekimde = 2;
                            for (int j = 0; j < 6; j++)
                            {
                                if (oyuncu2[j] == "bos")
                                    boskontrol++;
                                if (boskontrol == 6)
                                {
                                    kazanmasart = 1;
                                }

                            }
                        }
                        else
                        {
                            kontrol1 = 0;
                            continue;
                        }





                    }

                }
            }
            if (baslayacak == 3)

            {
                int kontrol2 = 0;
                for (int i = 0; i < 6 && kazanmasart == 0; i++)
                {
                    if (kontrol2 == 0)
                    {
                        if (oyuncu3[i] != "rd")
                        {
                            Console.WriteLine("3. oyuncu {0} kartını oynadı", oyuncu3[i]);
                            kontrol2 = kontrol2 + 1;
                            yerdeki = oyuncu3[i];
                            oyuncu3[i] = "bos";
                            boskontrol = 0;
                            hamlekimde = 3;
                            for (int j = 0; j < 6; j++)
                            {
                                if (oyuncu3[j] == "bos")
                                    boskontrol++;
                                if (boskontrol == 6)
                                {
                                    kazanmasart = 1;
                                }

                            }
                        }
                        else
                        {
                            kontrol2 = 0;
                            continue;
                        }





                    }

                }

            }
            while (kazanmasart == 0 && paskontrol != 9)
            {
                if (oyuncupas == 1 && passayac[0] == 1 && passayac[1] == 1)
                {

                }
                else
                    paskontrol = 0;

                Console.WriteLine("Sıra sizde \n");
                Console.WriteLine();
                foreach (var item in oyuncu1)
                {
                    Console.WriteLine(item + "");
                }

                bool cevap1 = false;
                while (cevap1 == false && kazanmasart == 0)
                {




                    Console.WriteLine("Oynayacagınız kartı secin\n");
                    Console.WriteLine("Pas gecmek icin pas yazın\n");
                    string oynanan = Console.ReadLine();

                    string degisken = "bos";
                    cevap1 = false;
                    if (oynanan == "rd")
                    {


                        for (int i = 0; i < 6 && kazanmasart == 0 && paskontrol != 9 && cevap1 == false; i++)
                        {
                            if (oynanan != oyuncu1[i])
                            {
                                cevap1 = false;

                            }
                            else
                                cevap1 = true;

                        }
                        if (cevap1 == false)
                        {
                            Console.WriteLine("Elinizde bu kart bulunmuyor tekrar oynayın \n");
                        }
                        else
                        {


                            for (int i = 0, c = 0; i < 6 && kazanmasart == 0 && c == 0; i++)
                            {
                                if (oynanan == oyuncu1[i])
                                {
                                    oyuncu1[i] = "bos";
                                    c = 1;
                                }
                            }
                            Console.WriteLine("Oynamak istediginiz rengi secin k ,s,m\n ");
                            degisken = Console.ReadLine();
                            if (degisken == "k")
                            {
                                Console.WriteLine("1.Oyuncu rengi kırmızıya degistirdi\n");
                                yerdeki = "k0";
                                cevap1 = true;
                                hamlekimde = 1;
                                boskontrol = 0;
                                for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                {
                                    if (oyuncu1[j] == "bos")
                                        boskontrol++;
                                    if (boskontrol == 6)
                                    {
                                        kazanmasart = 1;
                                    }

                                }

                            }
                            if (degisken == "m")
                            {
                                Console.WriteLine("1.Oyuncu rengi maviye degistirdi\n");
                                yerdeki = "m0";
                                cevap1 = true;
                                boskontrol = 0;
                                hamlekimde = 1;
                                for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                {
                                    if (oyuncu1[j] == "bos")
                                        boskontrol++;
                                    if (boskontrol == 6)
                                    {
                                        kazanmasart = 1;
                                    }

                                }
                            }

                            if (degisken == "s")
                            {
                                Console.WriteLine("1.Oyuncu rengi sarıya degistirdi\n");
                                yerdeki = "s0";
                                cevap1 = true;
                                boskontrol = 0;
                                hamlekimde = 1;
                                for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                {
                                    if (oyuncu1[j] == "bos")
                                        boskontrol++;
                                    if (boskontrol == 6)
                                    {
                                        kazanmasart = 1;
                                    }

                                }
                            }
                        }
                    }
                    else if (yerdeki.Substring(0, 1) != oynanan.Substring(0, 1) && yerdeki.Substring(1, 1) != oynanan.Substring(1, 1) && oynanan != "pas" && yerdeki != "bos")
                    {

                        Console.WriteLine("Gecersiz hamle !!!!!\n");
                        cevap1 = false;

                    }

                    else
                    if ((yerdeki.Substring(0, 1) == oynanan.Substring(0, 1) || yerdeki.Substring(1, 1) == oynanan.Substring(1, 1)) && yerdeki != "bos")
                    {
                        for (int i = 0, l = 0; i < 6 && l == 0; i++)
                            if (oynanan == oyuncu1[i])
                            {
                                Console.WriteLine("Oyuncu 1 {0} kartını oynadı\n", oynanan);
                                l = 1;
                            }
                            else if (oynanan != oyuncu1[i])
                            {

                                l = 1;
                            }


                        for (int i = 0; i < 6 && kazanmasart == 0; i++)
                        {
                            if (oynanan == oyuncu1[i])
                            {
                                yerdeki = oynanan;
                                oyuncu1[i] = "bos";
                                cevap1 = true;
                                boskontrol = 0;
                                hamlekimde = 1;
                                for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                {
                                    if (oyuncu1[j] == "bos")
                                        boskontrol++;
                                    if (boskontrol == 6)
                                    {
                                        kazanmasart = 1;
                                    }

                                }

                            }
                        }

                    }
                    else if (yerdeki == "bos")
                    {

                        if (oynanan == "rd")
                        {
                            Console.WriteLine("İlk hamlede renk degistir oynanmaz");
                            continue;
                        }
                        else
                        {
                            for (int i = 0, k = 0, c = 0; i < 6 && k == 0; i++)
                                if (oynanan == oyuncu1[i])
                                {
                                    Console.WriteLine("Oyuncu 1 {0} kartını oynadı\n", oynanan);
                                    k = 1;
                                    c = 1;
                                }
                                else if (!(oynanan == oyuncu1[i]) && oynanan != "pas" && c == 0)
                                {

                                    k = 1;


                                }
                            for (int i = 0; i < 6 && kazanmasart == 0; i++)
                            {
                                if (oynanan == oyuncu1[i])
                                {
                                    yerdeki = oynanan;
                                    oyuncu1[i] = "bos";
                                    cevap1 = true;
                                    boskontrol = 0;
                                    hamlekimde = 1;
                                    for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                    {
                                        if (oyuncu1[j] == "bos")
                                            boskontrol++;
                                        if (boskontrol == 6)
                                        {
                                            kazanmasart = 1;
                                        }

                                    }

                                }
                            }
                        }



                    }

                    if (oynanan == "pas")
                    {
                        Console.WriteLine("Pas gectiniz\n");
                        cevap1 = true;
                        oyuncupas = 1;
                        paskontrol++;
                    }

                }
                bool cevap3 = false;
                for (int k = 0; k < 6 && kazanmasart == 0 && cevap3 == false && paskontrol != 9; k++)
                {
                    for (int i = 0; i < 6 && cevap3 == false; i++)
                    {
                        if (cevap3 == false)
                        {
                            if (yerdeki.Substring(0, 1) == oyuncu2[i].Substring(0, 1) || yerdeki.Substring(1, 1) == oyuncu2[i].Substring(1, 1))
                            {


                                Console.WriteLine("2. oyuncu {0} oynadı", oyuncu2[i]);
                                yerdeki = oyuncu2[i];
                                oyuncu2[i] = "bos";
                                boskontrol = 0;
                                hamlekimde = 2;
                                for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                {
                                    if (oyuncu2[j] == "bos")
                                        boskontrol++;
                                    if (boskontrol == 6)
                                    {
                                        kazanmasart = 1;
                                    }

                                }
                                cevap3 = true;

                            }
                            else
                                cevap3 = false;
                            bool rb = false;
                            for (int j = 0, c = 0; j < 6 && kazanmasart == 0 && c == 0; j++)
                            {
                                if (oyuncu2[j] == "rd")
                                {
                                    rb = true;
                                    oyuncu2[j] = "bos";
                                    c = 1;
                                }


                                else
                                    rb = false;
                            }
                            if ((cevap3 == false) && (rb == true))
                            {
                                Random gen1 = new Random();
                                int uret = gen1.Next(1, 4);
                                if (uret == 1)
                                {
                                    yerdeki = "k" + oyuncu2[i].Substring(1, 1);
                                    Console.WriteLine("2.oyuncu yerdeki karti kirmizi cevirdi\n");
                                    yerdeki = "k0";
                                    cevap3 = true;
                                    boskontrol = 0;
                                    hamlekimde = 2;
                                    for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                    {
                                        if (oyuncu2[j] == "bos")
                                            boskontrol++;
                                        if (boskontrol == 6)
                                        {
                                            kazanmasart = 1;
                                        }

                                    }
                                }
                                else if (uret == 2)
                                {
                                    yerdeki = "m" + oyuncu2[i].Substring(1, 1);
                                    Console.WriteLine("2. oyuncu yerdeki karti mavi cevirdi\n");
                                    yerdeki = "m0";
                                    cevap3 = true;
                                    boskontrol = 0;
                                    hamlekimde = 2;
                                    for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                    {
                                        if (oyuncu2[j] == "bos")
                                            boskontrol++;
                                        if (boskontrol == 6)
                                        {
                                            kazanmasart = 1;
                                        }

                                    }

                                }

                                else if (uret == 3)
                                {
                                    yerdeki = "s" + oyuncu2[i].Substring(1, 1);
                                    Console.WriteLine("2. oyuncu yerdeki karti sariya cevirdi\n");
                                    yerdeki = "s0";
                                    cevap3 = true;
                                    boskontrol = 0;
                                    hamlekimde = 2;
                                    for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                    {
                                        if (oyuncu2[j] == "bos")
                                            boskontrol++;
                                        if (boskontrol == 6)
                                        {
                                            kazanmasart = 1;
                                        }

                                    }
                                }
                            }



                        }

                    }

                    if (cevap3 == false && kazanmasart == 0)

                    {
                        Console.WriteLine(" 2 oyuncu pas gecti\n");
                        boskontrol--;
                        passayac[0] = 1;
                        paskontrol++;
                        cevap3 = true;
                    }
                }
                bool cevap = false;
                for (int k = 0; k < 6 && kazanmasart == 0 && cevap == false && paskontrol != 9; k++)
                {
                    for (int i = 0; i < 6 && cevap == false; i++)
                    {
                        if (cevap == false)
                        {
                            if (yerdeki.Substring(0, 1) == oyuncu3[i].Substring(0, 1) || yerdeki.Substring(1, 1) == oyuncu3[i].Substring(1, 1))
                            {


                                Console.WriteLine("3. oyuncu {0} oynadı", oyuncu3[i]);
                                yerdeki = oyuncu3[i];
                                oyuncu3[i] = "bos";
                                boskontrol = 0;
                                hamlekimde = 3;
                                for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                {
                                    if (oyuncu3[j] == "bos")
                                        boskontrol++;
                                    if (boskontrol == 6)
                                    {
                                        kazanmasart = 1;
                                    }

                                }
                                cevap = true;

                            }
                            else
                                cevap = false;
                            bool rb = false;
                            for (int j = 0, c = 0; j < 6 && kazanmasart == 0 && c == 0; j++)
                            {
                                if (oyuncu3[j] == "rd")
                                {
                                    rb = true;
                                    oyuncu3[j] = "bos";
                                    c = 1;
                                }


                                else
                                    rb = false;
                            }
                            if ((cevap == false) && (rb == true))
                            {
                                Random gen1 = new Random();
                                int uret = gen1.Next(1, 4);
                                if (uret == 1)
                                {
                                    yerdeki = "k" + oyuncu3[i].Substring(1, 1);
                                    Console.WriteLine("3.oyuncu yerdeki karti kirmizi cevirdi\n");
                                    yerdeki = "k0";
                                    cevap = true;
                                    boskontrol = 0;
                                    hamlekimde = 3;
                                    for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                    {
                                        if (oyuncu3[j] == "bos")
                                            boskontrol++;
                                        if (boskontrol == 6)
                                        {
                                            kazanmasart = 1;
                                        }

                                    }
                                }
                                else if (uret == 2)
                                {
                                    yerdeki = "m" + oyuncu3[i].Substring(1, 1);
                                    Console.WriteLine("3. oyuncu yerdeki karti mavi cevirdi\n");
                                    yerdeki = "m0";
                                    cevap = true;
                                    boskontrol = 0;
                                    hamlekimde = 3;
                                    for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                    {
                                        if (oyuncu3[j] == "bos")
                                            boskontrol++;
                                        if (boskontrol == 6)
                                        {
                                            kazanmasart = 1;
                                        }

                                    }

                                }

                                else if (uret == 3)
                                {
                                    yerdeki = "s" + oyuncu3[i].Substring(1, 1);
                                    Console.WriteLine("3. oyuncu yerdeki karti sariya cevirdi\n");
                                    yerdeki = "s0";
                                    cevap = true;
                                    boskontrol = 0;
                                    hamlekimde = 3;
                                    for (int j = 0; j < 6 && kazanmasart == 0; j++)
                                    {
                                        if (oyuncu3[j] == "bos")
                                            boskontrol++;
                                        if (boskontrol == 6)
                                        {
                                            kazanmasart = 1;
                                        }

                                    }
                                }
                            }



                        }

                    }

                    if (cevap == false && kazanmasart == 0)

                    {
                        Console.WriteLine(" 3 oyuncu pas gecti\n");
                        boskontrol--;
                        passayac[1] = 1;
                        paskontrol++;
                        cevap = true;
                    }
                }
            }
            if (hamlekimde == 2 && kazanmasart == 1)
                Console.WriteLine("2. Oyuncu kazandı");
            else if (hamlekimde == 3 && kazanmasart == 1)
                Console.WriteLine("3. Oyuncu kazandı");
            else if (hamlekimde == 1 && kazanmasart == 1)
                Console.WriteLine("1. Oyuncu kazandı");
            else if (paskontrol == 9)
                Console.WriteLine("Oyun berabere bitti");

            Console.ReadKey();
        }

    }

}


