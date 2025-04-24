// See https://aka.ms/new-console-template for more information

using My_First_Class_Create;

class Program
{
    static void Main()
    {
        var kotak = new Rectangle(width: 100, height: 29);
        var bangunRuang = new BangunRuang(kotak);
        
        // print dari first initiate
        bangunRuang.PrintData();
        
        // coba ganti value dalamnya
        kotak.ChangeSpec(width: 1999, height: 1);
        
        // print setelah ganti isi datanya
        bangunRuang.PrintData();
    }
}