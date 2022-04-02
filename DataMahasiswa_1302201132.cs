namespace modul6_kelompok_6
{
    public class DataMahasiswa_1302201132
    {
        public void ReadJSON()
        {
            string jsonFile = File.ReadAllText(@"C:\Users\LENOVO\Documents\KPL\JURNAL_MOD6\modul6_kelompok_6\jurnal6_1_1302201132.json");
            dynamic data = JsonConvert.DeserializeObject(jsonFile);
            Console.WriteLine("Nama " + data.firstName + " " + data.lastName + " gender " + data.gender + " age " + data.age + " address : \n" + data.address.streetAddress + " " + data.address.city + " " + data.address.state);
        }
    }
}