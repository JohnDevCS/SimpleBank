
namespace SimpleBank
{
    public class Program
    {
        static void Main(string[] args) {

            BankAccount MyAccount = new BankAccount("Bob", 250);
            MyAccount.Deposit(500);
            MyAccount.Withdraw(300);
            
            Console.WriteLine(MyAccount.ToString());

            //PR14 bankaccount and sorting

            //Øvelse 3.1 inspicere for løkken
            // for (int i = 0; i = length; i++ ) {
            /*
            
            I parenteserne har vi
            
            En starts værdi
            Kør x antal gange
            Tælle op eller ned
            }
             */

            //Lav et while loop med samme logik
            /*
            int i = 0;
            while(i = length){
            
            i++;
            }
             */



            //Øvelse 3.2int

          /*  int[] intArray = {55,3,255,4,1 };
            foreach (int i in intArray) {
                int h = intArray[0];
                h = 60;
               
                Console.WriteLine(i);
                                                   

            }
          */
            //Ja det gik som forventet. Man kan ikke ændre det i scope.
            //Loopet udskriver alle tal. Ellers udskriver den 60, 5 gange da det er loopets størrelse.

            //Øvelse 3.3.1


        }
    }
}
