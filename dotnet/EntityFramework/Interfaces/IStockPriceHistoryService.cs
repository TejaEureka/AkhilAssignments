using System;
using EntityFramework.Models;
using EntityFramework.Services;

namespace EntityFramework.Interfaces
{
	public interface IStockPriceHistoryService
	{
        public List<StocksPriceHistory> GetStockPriceHistory(string tickersymbol);
    }
}

