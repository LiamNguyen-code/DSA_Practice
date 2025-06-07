var maxProfit = function (prices) {
    let minPrice = prices[0];
    let maximumProfit = 0;
    prices.forEach((price, index) => {
        if (price < minPrice)
            minPrice = price;
        else {
            let profit = price - minPrice;
            if (profit > maximumProfit)
                maximumProfit = profit;
        }
    });

    return maximumProfit;
};