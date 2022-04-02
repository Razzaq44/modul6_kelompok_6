using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_6
{
    public class GlossaryItem1302200039
    {
        public static Glossary ReadJSON()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string pathAndFile = path + "/jurnal6_3_1302200039.json";
            string json = File.ReadAllText(pathAndFile);
            detail objGlossDeserialisasi = JsonSerializer.Deserialize<detail>(json);
            return objGlossDeserialisasi;
        }
    }
}
