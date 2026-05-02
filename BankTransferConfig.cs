using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul9_103022400068
{
    internal class BankTransferConfig
    {
        public Config config { get; set; }
        private String filepath = "bank_transfer_config.json";
        public BankTransferConfig()
        {
            config = new Config();
        }
        public void ReadConfigFile()
        {
            String file = File.ReadAllText(filepath);
            config = JsonSerializer.Deserialize<Config>(file);
        }
        public void WriteConfigFile()
        {
            String jsonString = JsonSerializer.Serialize(config);
        }
        public void SetDefaultConfig()
        {
            config = new Config();
        }
    }
}