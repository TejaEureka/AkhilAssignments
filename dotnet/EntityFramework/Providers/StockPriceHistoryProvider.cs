using System;
using EntityFramework.Models;
using EntityFramework.Interfaces;
using Dapper;
using Npgsql;


namespace EntityFramework.Providers
{
    public class StockPriceHistoryProvider : IStockPriceHistoryProvider
	{
        public List<StocksPriceHistory> GetStockPriceHistory(string tickersymbol)
		{
			List<StocksPriceHistory> stocksPriceHistories = new List<StocksPriceHistory>();
            string connectionString = "Server=endeavourtech.ddns.net;Port=31240;User Id=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;Database=StocksDB;";
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                stocksPriceHistories = conn.Query<StocksPriceHistory>("select * from endeavour.stockpricehistory where ticker_symbol = @Tickersymbol", new { Tickersymbol = tickersymbol }).ToList();
                
            }
            return stocksPriceHistories;
        }

    }
}

