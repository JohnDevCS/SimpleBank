using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class BankAccount {
        private string name;

        //Kan godt lave auto implement get set. Men fjern felterne.

        //explicit 
        public string Name {
            get { return name; }
            set { name = value; }
        }

        private double balance = 0;
        public double Balance {
            get { return balance; }
        }


        private bool locked = false;



        public BankAccount(string name, double balance, bool locked) {
            Name = name;
            this.balance = balance;
            this.locked = locked;
        }


        public BankAccount(double balance) : this(" ", balance) {
            //  this.balance = balance;
        }

        public BankAccount(string name, double balance) {
            Name = name;
            this.balance = balance;
        }



        public void Deposit(double amount) {
            //Deposit(amount : double): indsætter det angivne beløb
            //må ikke være i stand til at indsætte til en låst bankkonto
            if (locked) {
                Console.WriteLine("Der kan ikke indsættes penge på en låst konto");

            }
            else {
                Console.WriteLine("Du har indsat " + amount + " på kontoen");
                balance += amount;
            }
        }


        //Withdraw(amount : double): trækker det angivne beløb (en: amount)

        //må ikke trække penge fra bankkontoen, hvis der efterspørges mere, end der er på bankkontoen
        //må ikke trække penge fra en låst bankkonto (en: locked)
        public void Withdraw(double amount) {
            // Tjekker om kontoen er låst
            if (locked) {
                Console.WriteLine("Kontoen er låst. Der kan ikke trækkes penge");

            } //Tjekker om der er penge nok på kontoen
            else if (balance < amount) {
                Console.WriteLine("Der er ikke nok penge på kontoen");

            } //Hvis ikke låst eller der er flere penge på kontoen. Så hæver vi
            else {
                balance -= amount;
                Console.WriteLine("Du har hævet " + amount + " på kontoen");
            }
        }


        public void ChangeLockState() {

            locked = !locked;

            /*
            if (locked) {
                balance = 5042;
            }*/

            //ChangeLockState(): ændrer den nuværende status (locked) til det modsatte af, hvad den er

        }



        public override string ToString() {
            //ToString() : string: returnerer en tekst-streng med navn og balance, således:
            //Name: Bob, Balance: 250

            if (name == " ") {
                return $"Name: , Balance: {Balance}"; //Hvis intet navn
            }
            else {
                return $"Name: {Name}, Balance: {Balance}"; //Hvis der findes et navn Bob
            }


        }


   

    }
}
