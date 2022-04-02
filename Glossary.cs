using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_6
{
    public class Glossary
    {
        public gloss glossary { get; set; }
        public glossdiv GlossDiv { get; set; }
        public glosslist GlossList { get; set; }
        public Glossary() { }
    }

    public class gloss
    {
        public String title { get; set; }
        public gloss() { }
    }
    public class glossdiv
    {
        public String title { get; set; }
        public glossdiv() { }
    }
    public class glosslist
    {
        public listBaru GlossEntry { get; set; }
        public glosslist() { }
    }
    public class listBaru
    {
        public String ID { get; set; }
        public String SortAs { get; set; }
        public String GlossTerm { get; set; }
        public String Acronym { get; set; }
        public String Abbrev { get; set; }
        public String GlossDef { get; set; }
        public String GlossSeeAlso { get; set; }

        public String GlossSee { get; set; }
        public listBaru() { }
    }

    
}
