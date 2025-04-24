using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalOrderSystem.SingletonYeYe;

namespace SingletonYeYe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lấy instance của OrderConfigurationManager
            var config = OrderConfigurationManager.Instance;

            // Thay đổi giá trị cấu hình
            config.Currency = "VND";

            // In ra giá trị
            Console.WriteLine($"Current currency: {OrderConfigurationManager.Instance.Currency}");
            Console.ReadKey();
        }
    }
}