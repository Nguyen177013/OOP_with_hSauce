using SauceStorage.Sauces;

namespace SauceStorage.SauceStorage
{
    internal class StorageCode : Storage
    {
        public override void AddSauce(Sauce sauce)
        {
            listSauce.Add(sauce);
            Console.WriteLine("Sauce code has been added");
        }
    }
}
