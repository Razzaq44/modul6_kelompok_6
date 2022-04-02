using System;
using System.Collections.Generic;

namespace mod6
{
    public class program
    {
        public static void Main(string[] args)
        {
            Mahasiswa objHasilBaca = DataMahasiswa.ReadJSON();  
            Mahasiswa objHasilBaca2 = TeamMembers.ReadJSON();
            Mahasiswa objHasilBaca3 = GlossaryItem.ReadJSON();

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
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

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------- Team Members List -----------------------------------------------");
            Console.WriteLine();

            for (int i = 0; i < objHasilBaca2.members.Count; i++)
            {
                Team team = objHasilBaca2.members[i];
                Console.WriteLine(team.nim + " " + team.firstName + " " + team.lastName + " ( " + team.age + " " + team.gender + " )");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------- GlossEntry ---------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("ID           : " + objHasilBaca3.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine("SortAs       : " + objHasilBaca3.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine("GlossTerm    : " + objHasilBaca3.glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine("Acronym      : " + objHasilBaca3.glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine("Abbrev       : " + objHasilBaca3.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine("GlossDef     : ");
            Console.WriteLine("     para                    : " + objHasilBaca3.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            List<string> glossSee = objHasilBaca3.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso;
            Console.WriteLine("     GlossSeeAlso            : " + String.Join(", ", glossSee));      
            Console.WriteLine("GlossSee     : " + objHasilBaca3.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}