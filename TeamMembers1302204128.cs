using System;
using System.Text.Json;
using System.IO;

namespace mod6
{
	public class TeamMembers
	{
		public static Mahasiswa ReadJSON()
		{
			string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
			string pathAndFile = path + "/jurnal6_2_1302204128.json";
			string json = File.ReadAllText(pathAndFile);

			Mahasiswa objHasilDeserialisasi = JsonSerializer.Deserialize<Mahasiswa>(json);

			return objHasilDeserialisasi;
		}
	}
}
