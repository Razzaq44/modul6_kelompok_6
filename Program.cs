﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_6
{
    public class DataMahasiswa_1302201132
    {
        public void ReadJSON()
        {
            //read json file
            string jsonFile = File.ReadAllText(@"C:\Users\LENOVO\Documents\KPL\JURNAL_MOD6\modul6_kelompok_6\jurnal6_1_1302201132.json");
            //convert json to array
            dynamic data = JsonConvert.DeserializeObject(jsonFile);
            //print data
            Console.WriteLine("Nama " + data.firstName + " " + data.lastName + " gender " + data.gender + " age " + data.age + " address : \n" + data.address.streetAddress + " " + data.address.city + " " + data.address.state);
        }
    }
