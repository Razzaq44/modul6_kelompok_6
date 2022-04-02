using System;

namespace mod6
{
	public class Mahasiswa
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string gender { get; set; }
		public int age { get; set; }
		public Address address { get; set; }
		public List<Matkul> courses { get; set; }
		public Mahasiswa() { }

	}

	public class Address
	{
		public string streetAddress { get; set; }
		public string city { get; set; }
		public string state { get; set; }
		public Address() { }
	}

	public class Matkul
	{
		public string code { get; set; }
		public string name { get; set; }
		public Matkul() { }
	}
}
