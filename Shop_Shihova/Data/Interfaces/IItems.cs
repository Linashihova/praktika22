using Shop_Shihova.Data.Models;

namespace Shop_Shihova.Data.Interfaces
{
    public interface IItems
    {
        public IEnumerable<Items> AllItems { get; }
    }
}
