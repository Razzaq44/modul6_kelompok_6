using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json;

namespace modul6_kelompok_6
{
    public class TeamMembers1302200039
    {
        public static detailMhs ReadJSON()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string pathAndFile = path + "/jurnal6_2_1302200039.json";
            string json = File.ReadAllText(pathAndFile);
            detailMhs objDeserialisasi = JsonSerializer.Deserialize<detailMhs>(json);
            return objDeserialisasi;
        }
    }
}
