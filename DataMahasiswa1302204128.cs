using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa
{
	public static Mahasiswa ReadJSON()
	{
		string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
		string pathAndFile = path + "/jurnal6_1_1302204128.json";
		string json = File.ReadAllText(pathAndFile);

		Mahasiswa objHasilDeserialisasi = JsonSerializer.Deserialize<Mahasiswa>(json);

		return objHasilDeserialisasi;
	}
}
