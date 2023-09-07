using SauceStorage.Sauces;

namespace SauceStorage.SauceStorage
{
    internal class StorageImage : Storage
    {
        public override void AddSauce(Sauce sauce)
        {
            listSauce.Add(sauce);
            Console.WriteLine("Sauce Image has been added");
        }
    }
}
