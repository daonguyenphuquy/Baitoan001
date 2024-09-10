using System;
using lib_toan; 

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập bán kính của hình tròn: ");
        double banKinh = Convert.ToDouble(Console.ReadLine());

        TinhToan calculator = new TinhToan();
        double dienTich = calculator.TinhDienTichHinhTron(banKinh);

        Console.WriteLine($"Diện tích của hình tròn có bán kính {banKinh} là: {dienTich:F2}");
    }
}
