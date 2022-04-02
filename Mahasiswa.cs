using System;
using System.Collections.Generic;

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
		public List<Team> members { get; set; }
		public Glossary glossary { get; set; }
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

	public class Team
    {
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string gender { get; set; }
		public int age { get; set; }
		public string nim { get; set; }
    }

	public class Glossary
    {
		public string title { get; set; }
		public GlossDivision GlossDiv { get; set; }
	}

	public class GlossDivision
    {
		public string title { get; set; }
		public DaftarGloss GlossList { get; set; }
	}

	public class DaftarGloss
    {
		public InputGloss GlossEntry { get; set; }
	}

	public class InputGloss
    {
		public string ID { get; set; }
		public string SortAs { get; set; }
		public string GlossTerm { get; set; }
		public string Acronym { get; set; }
		public string Abbrev { get; set; }
		public GlossDefi GlossDef { get; set; }
		public string GlossSee { get; set; }
	}

	public class GlossDefi
    {
		public string para { get; set; }
		public List<string> GlossSeeAlso { get; set; }
	}
}
