
using System.Collections.Generic;


public class Favorit
{
    public List<Stock> favoritList { get; set; }

    public Favorit(List<Stock> favoritList)
    {
        this.favoritList = favoritList;
    }
}