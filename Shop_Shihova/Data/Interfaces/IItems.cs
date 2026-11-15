using Shop_Shihova.Data.Models;

namespace Shop_Shihova.Data.Interfaces
{
    public interface IItems
    {
        public IEnumerable<Items> AllItems { get; }
        public int Add(Items Item);
        public void Update(Items Item);
        public void Delete(int Id);
    }
}
