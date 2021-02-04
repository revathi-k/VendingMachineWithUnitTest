using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachineNew
{
    public class ValidateCoinsBL
    {
        public string ValidateCoins(string inputCurrency,string inputTextCoins,double prdPrice)
        {
            double rcvdAmt; string result = string.Empty;
            int inputCoins = 0;
            if (!string.IsNullOrEmpty(inputTextCoins) && inputTextCoins!="0")
            {
                inputCoins = Convert.ToInt32(inputTextCoins);
            }
            else
            {
                return "please insert coins.";
            }

            if (Constants.exchangeValue.ContainsKey(inputCurrency))
            {
                rcvdAmt = inputCoins * Constants.exchangeValue[inputCurrency];

                if (prdPrice >0 && prdPrice== rcvdAmt)//Correct Amount
                {
                    result = "Thank You!";
                }
                else if (prdPrice>0 && Convert.ToDouble(prdPrice) > rcvdAmt)//less amount
                {
                    result = "Amount not sufficient. Need more :" + ((Convert.ToDouble(prdPrice) - rcvdAmt) / Constants.exchangeValue[inputCurrency]).ToString();
                }
                else if (prdPrice>0 && prdPrice < rcvdAmt)//more amount
                {
                    result = "Inserted More Coins. please less :" + ((rcvdAmt - Convert.ToDouble(prdPrice)) / Constants.exchangeValue[inputCurrency]).ToString();
                }
                else
                {
                    result = "Invalid Error.";
                }
            }
            else
            {
                result = "Invalid Cuurency.";
            }
            return result;
        }

    }
}