﻿using System;

namespace mod6
{
    public class program
    {
        public static void Main(string[] args)
        {
            Mahasiswa objHasilBaca = DataMahasiswa.ReadJSON();          
            Console.WriteLine("Name     : " + objHasilBaca.firstName + " " + objHasilBaca.lastName);
            Console.WriteLine("Gender   : " + objHasilBaca.gender);
            Console.WriteLine("Age      : " + objHasilBaca.age);
            Console.WriteLine("Address  : " + objHasilBaca.address.streetAddress + " " + objHasilBaca.address.city + " " + objHasilBaca.address.state);
            Console.WriteLine();

            for (int i = 0; i < objHasilBaca.courses.Count; i++)
            {
                Matkul matkul = objHasilBaca.courses[i];
                Console.WriteLine("MK " + (i + 1) + " " + matkul.code + " - " + matkul.name);
            }
        }
    }
}

