using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class IntArrayHelper
    {

        public int[] SortAscending(int[] intArray) {

          
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++) {
                for (int j = i + 1; j < intArray.Length; j++) {
                    if (intArray[i] > intArray[j]) {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
       
           
            return intArray;
            //Kopi fra hjemmeside
          

        }

        public int[] SortAscendingAndReverse(int[] intArray) {
            
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++) {
                for (int j = i + 1; j < intArray.Length; j++) {
                    if (intArray[i] < intArray[j]) {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            

            return intArray;
            //Kopi fra hjemmeside
        }

    }
}
