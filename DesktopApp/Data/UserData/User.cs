
using System.Collections.Generic;

public class User
{
    public List<Stock> Favorites { get; set; }

    public User()
    {
        Favorites = DBService.UploadStocksFromDB();
    }

  
}