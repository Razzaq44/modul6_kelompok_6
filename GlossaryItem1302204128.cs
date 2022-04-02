using System;
using System.IO;
using System.Text.Json;

namespace mod6
{
	public class GlossaryItem
	{
		public static Mahasiswa ReadJSON()
		{
			string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
			string pathAndFile = path + "/jurnal6_3_1302204128.json";
			string json = File.ReadAllText(pathAndFile);

			Mahasiswa objHasilDeserialisasi = JsonSerializer.Deserialize<Mahasiswa>(json);

			return objHasilDeserialisasi;
		}
	}
}
