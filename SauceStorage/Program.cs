using SauceStorage.Sauces;
using SauceStorage.SauceStorage;

Sauce sauceCode1 = new SauceCode(1, "metamorphosis", "unknow", 177013, new List<string> { "Drama, NTR, Pregnant, Mind Break" });
Sauce sauceCode2 = new SauceCode(2, "Rat Man", "ratata47", 471817, new List<string> { "Vanila, Romance" });
Sauce sauceCode3 = new SauceCode(3, "meh", "cringe", 464454, new List<string> { "NTR, Pregnant, Rape" });
Sauce sauceImage1 = new SauceImage(1, "Ahihih", "idk");
Sauce sauceImage2 = new SauceImage(2, "I guess so", "yike");
Sauce sauceImage3 = new SauceImage(3, "wuit", "yeehak");

Storage storageCode = new StorageCode();
Storage storageImage = new StorageImage();
storageCode.AddSauce(sauceCode1);
storageCode.AddSauce(sauceCode2);
storageCode.AddSauce(sauceCode3);
storageImage.AddSauce(sauceImage1);
storageImage.AddSauce(sauceImage2);
storageImage.AddSauce(sauceImage3);

storageCode.getAllSauce().ForEach(sauces =>
{
    Console.WriteLine(sauces.generateSauce());
});
storageImage.getAllSauce().ForEach(sauces =>
{
    Console.WriteLine(sauces.generateSauce());
});

Console.WriteLine(storageCode.getSauceById(1).generateSauce());
Console.WriteLine(storageImage.getSauceById(3).generateSauce());

