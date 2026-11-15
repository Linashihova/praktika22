using Shop_Shihova.Data.Models;

namespace Shop_Shihova.Data.ViewModell
{
    public class VMItems
    {
        public IEnumerable<Items> Items { get; set; }
        public IEnumerable<Categorys> Categorys { get; set; }
        public int SelectCategory = 0;
    }
}
