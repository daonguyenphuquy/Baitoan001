using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập bán kính của hình tròn: ");
        double banKinh = Convert.ToDouble(Console.ReadLine());

        double dienTich = TinhDienTichHinhTron(banKinh);

        Console.WriteLine($"Diện tích của hình tròn có bán kính {banKinh} là: {dienTich:F2}");
    }
    static double TinhDienTichHinhTron(double banKinh)
    {
        return Math.PI * Math.Pow(banKinh, 2);
    }
}
