using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array;
internal class BestTimetoBuyandSellStock
{
    public int MaxProfit(int[] prices)
    {
        var maximumProfit = 0;
        for (var i = 0; i < prices.Length; i++)
        {
            for (var j = i + 1; j < prices.Length; j++)
            {
                var profit = prices[j] - prices[i];
                if (profit > maximumProfit)
                    maximumProfit = profit;
            }
        }

        return maximumProfit;
    }

    public int MaxProfit_v2(int[] prices)
    {
        var maximumProfit = 0;
        var minPrice = prices[0];
        for (var i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];
            else
            {
                var profit = prices[i] - minPrice;
                if (profit > maximumProfit)
                    maximumProfit = profit;
            }
        }

        return maximumProfit;
    }
}

//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
