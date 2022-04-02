using System;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;

namespace modul6_kelompok_6
{
    public class DataMahasiswa1302204029
    {
        public void ReadJSON()
        {
            string jsonFile = File.ReadAllText(@"C:\Users\620879\Documents\kuliah\JURNAL_MOD6\modul6_kelompok_6\jurnal6_1_1302204029.json");
            dynamic data = JsonConvert.DeserializeObject(jsonFile);
            Console.WriteLine("Nama " + data.firstName + " " + data.lastName + " gender " + data.gender + " age " + data.age + " address : \n" + data.address.streetAddress + " " + data.address.city + " " + data.address.state);
        }
    }
}
