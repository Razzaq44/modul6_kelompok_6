// See https://aka.ms/new-console-template for more information
using System;
using System.Text.Json;
using System.IO;

namespace modul6_kelompok_6
{
    public class program
    {
        public static void Main(string[] args)
        {
            detail objHasilBaca = DataMahasiswa1302200039.ReadJSON();
            
            Console.WriteLine("Nama " + objHasilBaca.firstName + " " + objHasilBaca.lastName + " dengan gender " + objHasilBaca.gender + " umur " + objHasilBaca.age);
            Console.WriteLine();

            
        }
    }
}