using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            
            Console.Title = "Responsi UAS Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
        
            Console.WriteLine("1. Menambah Mahasiswa");
            Console.WriteLine("2. Menghapus Mahasiswa");
            Console.WriteLine("3. Menampilkan Mahasiswa");
            Console.WriteLine("4. Keluar");
           
        }

        static void TambahMahasiswa()
        {

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Console.Clear();
            Console.WriteLine ("Tambah Data Mahasiswa");
            Console.WriteLine("");

            Mahasiswa mhs = new Mahasiswa();
            Console.Write("NIM  : ");
            mhs.nim = Console.ReadLine();
            Console.Write("Nama : ");
            mhs.nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [P/W] : ");
            mhs.kelamin = Console.ReadLine();
            if (mhs.kelamin == "P")
            {
                mhs.kelamin = "Pria";
            }
            else if (mhs.kelamin == "W")
            {
                mhs.kelamin = "Wanita";
            }
            Console.Write("IPK Mahasiswa : ");
            mhs.IPK = double.Parse(Console.ReadLine());

            daftarMahasiswa.Add(mhs);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadLine();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();


            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            Console.WriteLine("Hapus Data Mahasiswa\n");
            Console.Write("NIM : ");
            string nim = Console.ReadLine();

            Mahasiswa delete = daftarMahasiswa.SingleOrDefault(x => x.nim == nim);
            if (daftarMahasiswa.Contains(delete) == true)
            {
                daftarMahasiswa.Remove(delete);
                Console.WriteLine("Data Mahasiswa Berhasil Dihapus");
            }
            else
            {
                Console.WriteLine("NIM Tidak Ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;

            Console.WriteLine("No\tNIM\tNama \tJenis Kelamin\tIPK");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {

                Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}", no, mahasiswa.nim, mahasiswa.nama, mahasiswa.kelamin, mahasiswa.IPK);
                no++;
            }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}