using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Örnek_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciadi=string.Empty,girilenKullaniciadi,mesaj,secilenBölüm,secilenDoktor;
            int sifre=default(int),girilenSifre,counter=default(int),counter1=default(int),secilenbölümKod,secilendoktorKod;
            bool kontrol = default(bool);

            try
            {
                #region KAYIT OLUSTUR

                Console.WriteLine("                          *******KAYIT OLUŞTUR*********                 ");
                Console.Write("Kullanıcı Adı : ");
                kullaniciadi = Console.ReadLine();
                Console.Write("Parola : ");
                sifre = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Başarı İle Kayıt Yaptırdınız.Giriş Sayfasına Yönlendiriliyorsunuz..");
                Thread.Sleep(2000);
                #endregion

                #region Giris Yap,Bölüm ve Doktor Seçimi

                Console.WriteLine("                         **********GİRİŞ YAP***********                   ");

                do
                {
                    Console.Write("Lütfen Kullanıcı Adınızı Giriniz : ");
                    girilenKullaniciadi = Console.ReadLine();
                    counter++;
                    if (counter > 3)
                    {
                        Console.WriteLine("Kullanıcı Adınızı Giremediniz.!");
                        break;
                    }
                    if (kullaniciadi == girilenKullaniciadi)
                    {
                        do
                        {
                            Console.Write("Lütfen Şifrenizi Giriniz : ");
                            girilenSifre = Convert.ToInt32(Console.ReadLine());
                            counter1++;
                            if (counter1 > 3)
                            {
                                Console.WriteLine("Şifrenizi Giremediniz.!");
                                mesaj = kontrol ? "Başarılı Giriş Yaptınız.Randevu Ekranına Yönlendiriliyorsunuz." : "Başarısız Giriş Yaptınız Lütfen Tekrar Deneyin.";
                                Console.WriteLine(mesaj);
                                Console.WriteLine(Environment.NewLine);
                                Thread.Sleep(2000);
                                break;
                            }
                            if (kullaniciadi == girilenKullaniciadi && sifre == girilenSifre)
                            {
                                kontrol = true;
                                mesaj = kontrol ? "Başarılı Giriş Yaptınız.Randevu Ekranına Yönlendiriliyorsunuz." : "Başarısız Giriş Yaptınız Lütfen Tekrar Deneyin.";
                                Console.WriteLine(mesaj);
                                Console.WriteLine(Environment.NewLine);
                                Thread.Sleep(2000);

                                Console.WriteLine("****************** RANDEVU EKRANI ***************");

                                List<string> Bölümler = new List<string>();
                                Bölümler.Add("Dahiliye");
                                Bölümler.Add("Çoçuk Hastalıkları");
                                Bölümler.Add("Üroloji");

                                List<string> Doktorlar = new List<string>();
                                Doktorlar.Add("Mert Ömgen");
                                Doktorlar.Add("Mehmet Ömgen");
                                Doktorlar.Add("Ayser Ömgen");
                                Doktorlar.Add("Maruf Ömgen");
                                Doktorlar.Add("Ali Veli");
                                Doktorlar.Add("Veli Ali");


                                for (int i = 0; i < Bölümler.Count; i++)
                                {
                                    Console.WriteLine("{0}-->{1}", i, Bölümler[i]);
                                }
                                Console.Write("Lütfen Bölümü Seçiniz : ");
                                secilenBölüm = Console.ReadLine();
                                //secilenbölümKod = Convert.ToInt32(Console.ReadLine());

                                if (secilenBölüm == Bölümler[0] /*|| secilenbölümKod == 0*/)
                                {
                                    Console.WriteLine("Dahiliye Bölümünü Seçtiniz..Doktor Ekranına Yönlendiriliyorsunuz..");
                                    Thread.Sleep(1500);

                                    Console.WriteLine("********** DOKTOR EKRANI ***********");

                                    for (int i = 0; i < 2; i++)
                                    {
                                        Console.WriteLine("Doktor --> {0}", Doktorlar[i]);
                                    }
                                    Console.Write("Lütfen Doktorunuzu Seçiniz : ");
                                    secilenDoktor = Console.ReadLine();
                                    //secilendoktorKod = Convert.ToInt32(Console.ReadLine());

                                    if (secilenDoktor == Doktorlar[0] /*|| secilendoktorKod == 0*/)
                                    {
                                        Console.WriteLine("{0} Seçtiniz.", Doktorlar[0]);
                                    }

                                    else if (secilenDoktor == Doktorlar[1] /*|| secilendoktorKod == 1*/)
                                    {
                                        Console.WriteLine("{0} Seçtiniz.", Doktorlar[1]);
                                    }

                                    else
                                    {
                                        Console.WriteLine("Yanlış Giriş Yaptınız..!");
                                    }
                                }

                                else if (secilenBölüm == Bölümler[1] /*|| secilenbölümKod == 1*/)
                                {
                                    Console.WriteLine("Çoçuk Hastalıkları Bölümünü Seçtiniz..Doktor Ekranına Yönlendiriliyorsunuz..");
                                    Thread.Sleep(1500);

                                    Console.WriteLine("********** DOKTOR EKRANI ***********");

                                    for (int i = 2; i < 4; i++)
                                    {
                                        Console.WriteLine("Doktor --> {0}", Doktorlar[i]);
                                    }
                                    Console.Write("Lütfen Doktorunuzu Seçiniz : ");
                                    secilenDoktor = Console.ReadLine();
                                    //secilendoktorKod = Convert.ToInt32(Console.ReadLine());

                                    if (secilenDoktor == Doktorlar[2] /*|| secilendoktorKod == 2*/)
                                    {
                                        Console.WriteLine("{0} Seçtiniz.", Doktorlar[2]);
                                    }

                                    else if (secilenDoktor == Doktorlar[3] /*|| secilendoktorKod == 3*/)
                                    {
                                        Console.WriteLine("{0} Seçtiniz.", Doktorlar[3]);
                                    }

                                    else
                                    {
                                        Console.WriteLine("Yanlış Giriş Yaptınız..!");
                                    }
                                }

                                else if (secilenBölüm == Bölümler[2] /*|| secilenbölümKod == 2*/)
                                {
                                    Console.WriteLine("Üroloji Bölümünü Seçtiniz..Doktor Ekranına Yönlendiriliyorsunuz..");
                                    Thread.Sleep(1500);

                                    Console.WriteLine("********** DOKTOR EKRANI ***********");

                                    for (int i = 4; i < 6; i++)
                                    {
                                        Console.WriteLine("Doktor --> {0}", Doktorlar[i]);
                                    }
                                    Console.Write("Lütfen Doktorunuzu Seçiniz : ");
                                    secilenDoktor = Console.ReadLine();
                                    //secilendoktorKod = Convert.ToInt32(Console.ReadLine());

                                    if (secilenDoktor == Doktorlar[4] /*|| secilendoktorKod == 4*/)
                                    {
                                        Console.WriteLine("{0} Seçtiniz.", Doktorlar[4]);
                                    }

                                    else if (secilenDoktor == Doktorlar[5] /*|| secilendoktorKod == 5*/)
                                    {
                                        Console.WriteLine("{0} Seçtiniz.", Doktorlar[5]);
                                    }

                                    else
                                    {
                                        Console.WriteLine("Yanlış Giriş Yaptınız..!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Yanlış Giriş Yaptınız.!");
                                }
                            }
                        } while (sifre != girilenSifre);
                    }

                } while (kullaniciadi != girilenKullaniciadi);
                Thread.Sleep(1000);
                Console.WriteLine("BAŞARIYLA SEÇİM YAPTINIZ.!");
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hatalı Giriş Yaptınız.! --> " + ex.Message);
                
            }
            Console.ReadKey();
        }
      
    }
}
