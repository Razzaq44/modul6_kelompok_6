using System;

public class program
{
    public static void Main(string[] args)
    {
        Mahasiswa objHasilBaca = DataMahasiswa.ReadJSON();
        Console.WriteLine("nim " + objHasilBaca.nim);
    }
}
