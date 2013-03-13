using System;
using System.Linq;

namespace HotelManager.Person
{
    interface IPay
    {
        void CollectMoney(decimal ammount); // increases money in persons wallet
        bool RequestMoney(decimal ammount); // checks if there are enough money in the wallet
        decimal PayMoney(decimal ammount); // decreases money in persons wallet
    }
}
