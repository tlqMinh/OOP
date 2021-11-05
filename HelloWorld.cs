using System;

namespace TinhTienDien
{
    class Program
    {
        // Khai báo các hằng 
        const int Muc1=100, Muc2=150, Muc3=300;
        const int Gia1=2000, Gia2=2500, Gia3=3000;

        static void Main()
        {
            int sokWh=0;
            double soTien=0;

            // Input
            // Viết code của bạn để xử lý nhập số kWh tiêu thụ 
            Console.WriteLine("Nhap so kWh tieu thu:");
            sokWh = int.Parse(Console.ReadLine());
            
            // Process
            // Viết code của bạn để tính số tiền vào biến sotien
            // Chỉ tính số tiền, không in ra kết quả ở phần này
            if(sokWh <= Muc1) soTien = sokWh * Gia1;
            else if(sokWh <= Muc2) soTien = Muc1 * Gia1 + (sokWh - Muc1)*Gia2;
            else if(sokWh <= Muc3) soTien = Muc1 * Gia1 + (Muc2 - Muc1)*Gia2 + (sokWh - Muc2)*Gia3;
            else soTien = (Muc1 * Gia1 + (Muc2 - Muc1)*Gia2 + (sokWh - Muc3)*Gia3)*1.1;

            // Output
            Console.WriteLine("So tien: {0}",soTien);
        }
    }
}