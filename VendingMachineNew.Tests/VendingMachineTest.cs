using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachineNew.Tests
{
    [TestClass]
    public class VendingMachineTest
    {
        [TestMethod]
        public void validateCoins_ifZeroCoinsInserted()
        {
            //Arrange
            string inputCoins = "0";
            string inputCurrency = "Nickels";
            double prdPrice = 1;
            string expectResult = "please insert coins.";
           
            //act
            ValidateCoinsBL objBL = new ValidateCoinsBL();
            string actualResult = objBL.ValidateCoins(inputCurrency, inputCoins, prdPrice);

            //Assert
            Assert.AreEqual(expectResult, actualResult, true);
        }

        [TestMethod]
        public void validateCoins_ifLessCoinsInserted()
        {
            //Arrange
            string inputCoins = "2";
            string inputCurrency = "Nickels";
            double prdPrice = 1;
            string expectResult = "Amount not sufficient. Need more :3";

            //act
            ValidateCoinsBL objBL = new ValidateCoinsBL();
            string actualResult = objBL.ValidateCoins(inputCurrency, inputCoins, prdPrice);

            //Assert
            Assert.AreEqual(expectResult, actualResult, true);
        }
        [TestMethod]
        public void validateCoins_Correct_Coins_Inserted()
        {
            //Arrange
            string inputCoins = "5";
            string inputCurrency = "Nickels";
            double prdPrice = 1;
            string expectResult = "Thank You!";

            //act
            ValidateCoinsBL objBL = new ValidateCoinsBL();
            string actualResult = objBL.ValidateCoins(inputCurrency, inputCoins, prdPrice);

            //Assert
            Assert.AreEqual(expectResult, actualResult, true);
        }

        [TestMethod]
        public void validateCoins_InvalidCurrency_Coins_Inserted()
        {
            //Arrange
            string inputCoins = "5";
            string inputCurrency = "pennies";
            double prdPrice = 1;
            string expectResult = "Invalid Cuurency.";

            //act
            ValidateCoinsBL objBL = new ValidateCoinsBL();
            string actualResult = objBL.ValidateCoins(inputCurrency, inputCoins, prdPrice);

            //Assert
            Assert.AreEqual(expectResult, actualResult, true);
        }
    }
}
