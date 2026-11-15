using Shop_Shihova.Data.Models;

namespace Shop_Shihova.Data.Interfaces
{
    public interface ICategorys
    {
        IEnumerable<Categorys> AllCategorys { get; }
    }
}
