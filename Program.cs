using modul4_103022300148;

public class Program() {
    public static void Main(string[] args) { 
        Produk produk = new Produk();
        Console.Write("Masukkan Nama Produk : ");
        String input = Console.ReadLine();
        Console.WriteLine("Kode Produk : " + produk.getKodeProduk(input));
    }
}