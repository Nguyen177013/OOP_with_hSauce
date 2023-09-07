using SauceStorage.Sauces;

namespace SauceStorage.SauceStorage
{
    internal abstract class Storage
    {
        protected List<Sauce> listSauce = new List<Sauce>();

        public Storage()
        {

        }

        public abstract void AddSauce(Sauce sauce);

        public List<Sauce> getAllSauce()
        {
            return listSauce;
        }

        public Sauce getSauceById(int id)
        {
            Sauce result = null;
            listSauce.ForEach(sauce =>
            {
                if (sauce.ID == id)
                {
                    result = sauce;
                    return;
                }
            });
            return result;
        }
    }
}
