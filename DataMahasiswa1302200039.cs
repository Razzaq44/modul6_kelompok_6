using System;
using System.Text.Json;
using System.IO;

namespace modul6_kelompok_6
{
    public class DataMahasiswa1302200039
    {
        public static detail ReadJSON()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string pathAndFile = path + "/jurnal6_1_1302200039.json";
            string json = File.ReadAllText(pathAndFile);
            detail objDetailDeserialisasi = JsonSerializer.Deserialize<detail>(json);
            return objDetailDeserialisasi;
        }
    }
}
