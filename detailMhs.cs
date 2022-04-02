using System;
using System.Collections.Generic;

namespace modul6_kelompok_6
{
    public class detailMhs
    {
        public Anggota members { get; set; }
        public detailMhs() { }
    }
    public class Anggota
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public String nim { get; set; }
        public Anggota() { }

    }
}
