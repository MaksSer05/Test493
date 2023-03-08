using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Class1
    {
        public double GetQuantityForProduct_NonExistentProductType(int Count, int weidht, int length, double product_type, double material_type)
        { 
            if (weidht <= 0 || length <= 0 || Count <= 0)
            {
                throw new DivideByZeroException();
            }
            switch (product_type)
            {
                case 1:
                  product_type = 1.1;
                 break;

                case 2:
                  product_type = 2.5;
                 break;

                case 3:
                  product_type = 8.43;
                 break;
                default:
                    throw new DivideByZeroException();
            }
            switch (material_type)
            {  
               case 1:
                 material_type = 0.003;
                 break;

               case 2:
                 material_type = 0.012;
                break;
                default:
                    throw new DivideByZeroException();                  
            }
            double Result = (weidht * length * Count) * product_type;
            Result = Result + (material_type * Result);
            return  Math.Ceiling(Result);
        } 
    }
}
