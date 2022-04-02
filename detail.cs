using System;
using System.Collections.Generic;

namespace modul6_kelompok_6
{
    public class detail
    {
        public Matkul courses{get; set;}
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public alamat address { get; set; }
        public detail() { }
    }
    public class Matkul
    {
        public String code { get; set; }
        public String name { get; set; }

        public Matkul() { }
    }
    public class alamat
    {
        public String streetAddress { get; set; }
        public String city { get; set; }
        public String state { get; set; }

        public alamat() { }
    }

}
