using modul4_103022300148;

public class Program() {
    public static void Main(string[] args) {
        //Produk produk = new Produk();
        //Console.Write("Masukkan Nama Produk : ");
        //String input = Console.ReadLine();
        //Console.WriteLine("Kode Produk : " + produk.getKodeProduk(input));

        FanLaptop fan = new FanLaptop();
        Console.Write("Masukkan Perintah : ");
        String input = Console.ReadLine();
        while (input != "Close") {
            if (fan.getState() == State.QUIET)
            {
                if (input == "Mode Up")
                {
                    fan.Balanced();
                    Console.WriteLine("Fan Quiet Berubah Menjadi Balanced");
                }else if(input == "Turbo Shortcut")
                {
                    fan.Turbo();
                    Console.WriteLine("Fan Quiet Berubah Menjadi Turbo");
                }
            }else if(fan.getState() == State.BALANCED)
            {
                if (input == "Mode Up")
                {
                    fan.Performance();
                    Console.WriteLine("Fan Balanced Berubah Menjadi Performance");
                }
                else if (input == "Mode Down")
                {
                    fan.Quiet();
                    Console.WriteLine("Fan Balanced Berubah Menjadi Quiet");
                }
            }else if(fan.getState() == State.PERFORMANCE)
            {
                if (input == "Mode Up")
                {
                    fan.Turbo();
                    Console.WriteLine("Fan Performance Berubah Menjadi Turbo");
                }
                else if (input == "Mode Down")
                {
                    fan.Balanced();
                    Console.WriteLine("Fan Performance Berubah Menjadi Balanced");
                }
            }else if(fan.getState() == State.TURBO)
            {
                if (input == "Mode Down")
                {
                    fan.Performance();
                    Console.WriteLine("Fan Turbo Berubah Menjadi Performance");
                }
                else if (input == "Turbo Shortcut")
                {
                    fan.Quiet();
                    Console.WriteLine("Fan Turbo Berubah Menjadi Quiet");
                }
            }
            Console.Write("Masukkan Perintah : ");
            input = Console.ReadLine();
        }
    }
}