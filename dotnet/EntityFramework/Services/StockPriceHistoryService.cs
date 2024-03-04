using System;
using EntityFramework.Models;
using EntityFramework.Interfaces;
using EntityFramework.Providers;
namespace EntityFramework.Services
{
    public class StockPriceHistoryService : IStockPriceHistoryService
	{
		IStockPriceHistoryProvider stockPriceHistoryProvider;
	    public StockPriceHistoryService(IStockPriceHistoryProvider stocksPriceHistoryProvider)
		{
            stockPriceHistoryProvider = stocksPriceHistoryProvider;
		}

        public List<StocksPriceHistory> GetStockPriceHistory(string tickersymbol)
        {
            return stockPriceHistoryProvider.GetStockPriceHistory(tickersymbol);
        }

	}
}

