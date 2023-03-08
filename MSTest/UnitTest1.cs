using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculation_Negativ_Count()
        {
            Class1 Calc_zero = new Class1();
            int Result = (int)Calc_zero.GetQuantityForProduct_NonExistentProductType(-1, 20, 45, 3, 2);
        }
        [TestMethod]
        public void Calculation_Negativ_weidh()
        {
            Class1 Calc_zero = new Class1();
            int Result = (int)Calc_zero.GetQuantityForProduct_NonExistentProductType(15, -1, 45, 3, 2);
        }
        [TestMethod]
        public void Calculation_Negativ_length()
        {
            Class1 Calc_zero = new Class1();
            int Result = (int)Calc_zero.GetQuantityForProduct_NonExistentProductType(15, 20, -1, 3, 2);
        }
        [TestMethod]
        public void Calculation_Negativ_Valid_ProductType()
        {
            Class1 Calc_zero = new Class1();
            int Result = (int)Calc_zero.GetQuantityForProduct_NonExistentProductType(15, 20, 45, S, 2);
        }
        [TestMethod]
        public void Calculation_Negativ_Valid_MaterialType()
        {
            Class1 Calc_zero = new Class1();
            int Result = (int)Calc_zero.GetQuantityForProduct_NonExistentProductType(15, 20, 45, 3, -1);
        }
        [TestMethod]
        public void Calculation_Zero_Count()
        {
            Class1 Calc_zero = new Class1();
            int Result = (int)Calc_zero.GetQuantityForProduct_NonExistentProductType(15, 20, 45, 3, 2);
        }
        [TestMethod]
        public void Calculation_Zero_weidh()
        {
            Class1 Calc_zero = new Class1();
            int Result = (int)Calc_zero.GetQuantityForProduct_NonExistentProductType(15, 20, 45, 3, 2);
        }
        [TestMethod]
        public void Calculation_Zero_length()
        {
            Class1 Calc_zero = new Class1();
            int Result = (int)Calc_zero.GetQuantityForProduct_NonExistentProductType(15, 20, 45, 3, 2);
        }
        [TestMethod]
        public void Calculation_Valid_ProductType()
        {
            Class1 Calc_zero = new Class1();
            int Result = (int)Calc_zero.GetQuantityForProduct_NonExistentProductType(15, 20, 45, 3, 2);
        }
        [TestMethod]
        public void Calculation_Valid_MaterialType()
        {
            Class1 Calc_zero = new Class1();
            int Result = (int)Calc_zero.GetQuantityForProduct_NonExistentProductType(15, 20, 45, 3, 2);
        }
    }
}
