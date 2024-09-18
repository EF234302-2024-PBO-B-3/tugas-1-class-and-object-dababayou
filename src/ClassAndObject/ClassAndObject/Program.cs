using ClassAndObject.Perpustakaan;
using ClassAndObject.Kendaraan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
using ClassAndObject.OperasiMatematika;
namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buku buku1 = new Buku("Pemrograman C#", "John Doe", 2021);
            buku1.TampilkanInfo();
            
            
            Mobil mobil1 = new Mobil("Toyota", "Avanza", 2020);
            mobil1.TampilkanSpesifikasi();

            
            Laptop laptop1 = new Laptop("Dell", "Intel Core i7", 16, 512);
            laptop1.TampilkanSpesifikasi();

            
            Sepeda sepeda1 = new Sepeda("Polygon", "Mountain Bike", 14.5);
            sepeda1.TampilkanInformasi();

            
            Kalkulator kalkulator = new Kalkulator();
            double hasilTambah = kalkulator.Tambah(10, 5);
            double hasilKurang = kalkulator.Kurang(10, 5);
            double hasilKali = kalkulator.Kali(10, 5);
            double hasilBagi = kalkulator.Bagi(10, 5);
        
            Console.WriteLine($"Hasil Penjumlahan: {hasilTambah}");
            Console.WriteLine($"Hasil Pengurangan: {hasilKurang}");
            Console.WriteLine($"Hasil Perkalian: {hasilKali}");
            Console.WriteLine($"Hasil Pembagian: {hasilBagi}");
        }
    }
}
