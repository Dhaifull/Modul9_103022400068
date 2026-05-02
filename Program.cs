using System.Text.Json;

namespace Modul9_103022400068
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankTransferConfig bankTransferConfig = new BankTransferConfig();
            bankTransferConfig.ReadConfigFile();
            bankTransferConfig.WriteConfigFile();
            bankTransferConfig.SetDefaultConfig();

            if (bankTransferConfig == "en")
            {
                Console.WriteLine("“Please insert the amount of money to \r\ntransfer:");
            } else if (bankTransferConfig == "id")
            {
                Console.WriteLine("“Masukkan jumlah uang yang akan \r\nditransfer:");
            }   
    }
}