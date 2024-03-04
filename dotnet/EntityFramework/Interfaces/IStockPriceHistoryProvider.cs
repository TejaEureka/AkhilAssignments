using System;
using EntityFramework.Models;
using EntityFramework.Providers;
namespace EntityFramework.Interfaces
{
    public interface IStockPriceHistoryProvider
	{
        public List<StocksPriceHistory> GetStockPriceHistory(string tickersymbol);
	}
}

