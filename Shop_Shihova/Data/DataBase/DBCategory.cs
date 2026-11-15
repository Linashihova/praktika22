using MySql.Data.MySqlClient;
using Shop_Shihova.Data.Common;
using Shop_Shihova.Data.Interfaces;
using Shop_Shihova.Data.Models;

namespace Shop_Shihova.Data.DataBase
{
    public class DBCategory : ICategorys
    {
        public IEnumerable<Categorys> AllCategorys
        {
            get
            {
                List<Categorys> categories = new List<Categorys>();
                MySqlConnection connection = Connection.OpenConnection();
                MySqlDataReader data = Connection.Query("SELECT * FROM `Categorys` ORDER BY `Name`;", connection);
                while (data.Read())
                {
                    categories.Add(new Categorys()
                    {
                        Id = data.IsDBNull(0) ? -1 : data.GetInt32(0),
                        Name = data.IsDBNull(1) ? "" : data.GetString(1),
                        Description = data.IsDBNull(2) ? "" : data.GetString(2)
                    });
                }
                Connection.CloseConnection(connection);
                return categories;
            }
        }
    }
}
