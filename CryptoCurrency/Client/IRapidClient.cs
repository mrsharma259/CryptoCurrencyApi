using CryptoCurrency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoCurrency.Client
{
    public interface IRapidClient
    {
       Task<List<Coins.Coin>> GetAsync();
    }
}
