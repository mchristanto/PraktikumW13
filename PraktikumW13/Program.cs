using System;
using System.Linq;
using System.Collections.Generic;
namespace PraktikumW13
{
    class Program //bingung ce
    { 
        static void ulang()
    {
            bool ulang = true;
            while (ulang = true)
            {
                Main();
            }
    }
        static void Main()
        {
            var counter = 0;
            var statusSama = 0;
            var sama = 0;
            
            string[,] dataBaru = new string[6, 2];
            while (counter < 6)
            {
                Console.Write("Berapa Data: ");
                var data = Convert.ToInt32(Console.ReadLine());
                if (counter == 0)
                {
                    for (int i = 0; i < data; i++)
                    {
                        Console.WriteLine("Data ke - " + (i + 1));
                        Console.Write("NIM : ");
                        string nim = Console.ReadLine();
                        Console.Write("NAMA : ");
                        string nama = Console.ReadLine();
                        Console.Write("JENIS KELAMIN :");
                        string jenisKelamin = Console.ReadLine();
                        Console.Write("TAHUN MASUK : ");
                        string tahun = Console.ReadLine();
                        Console.Write("PROGRAM STUDI : ");
                        string prodi = Console.ReadLine();
                        Console.Write("KELAS : ");
                        string kelas = Console.ReadLine();
                        Console.WriteLine();
                    }
                    counter++;
                }
                else
                {
                    Console.Write("NIM : ");
                    int nim = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < counter; i++)
                    {
                        if (dataBaru[0, i] == dataBaru[0, counter])
                        {
                            statusSama = 1;
                        }
                        else if (statusSama != 1)
                        {
                            statusSama = 0;
                        }
                        if (statusSama == 0)
                        {
                            Console.WriteLine("Data ke - " + (i + 1));
                            Console.Write("NIM : ");
                            string Nim = Console.ReadLine();
                            Console.Write("NAMA : ");
                            string nama = Console.ReadLine();
                            Console.Write("JENIS KELAMIN :");
                            string jenisKelamin = Console.ReadLine();
                            Console.Write("TAHUN MASUK : ");
                            string tahun = Console.ReadLine();
                            Console.Write("PROGRAM STUDI : ");
                            string prodi = Console.ReadLine();
                            Console.Write("KELAS : ");
                            string kelas = Console.ReadLine();
                            Console.WriteLine();
                            counter++;
                        }
                        else if (statusSama == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN !!!");
                            statusSama = 0;
                        }
                    }
                }
            }
            Console.Write("PRINT HASIL ? (y/n)");
            string hasil = Console.ReadLine();
            if (hasil == "y")
            {/*bingung ceee
                var header = String.Format("{1,4}{1,8}{2,12}{3,8}{4,12}{5,14}{6,16}{7,20}\n",
                "NO", "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI"); //ini nya gabisa ce, gatau yang salah apa
                Console.WriteLine(header);
                foreach (var datas in dataBaru) 
                {
                    var output = String.Format("{0,-12}{1,8}{2,12}{3,8}{4,12}{5,14}{6,16}{7,20}");                       
                }
            }
            else if (hasil == "n")
            {             
            }*/
            }  
       }
    }
}
