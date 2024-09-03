using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_reload
{
    public class CreditCard
    {
        private string cardNumber;
        private string cvc;
        private int balance;

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public string Cvc
        {
            get { return cvc; }
            set { cvc = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public CreditCard(string cardNumber, string cvc, int balance)
        {
            CardNumber = cardNumber;
            Cvc = cvc;
            Balance = balance;
        }

        public static CreditCard operator +(CreditCard card, int amount)
        {
            card.Balance += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, int amount)
        {
            card.Balance -= amount;
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.Cvc == card2.Cvc;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return card1.Cvc != card2.Cvc;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        public override bool Equals(object obj)
        {
            if (obj is CreditCard)
            {
                CreditCard other = (CreditCard)obj;
                return this.Cvc == other.Cvc;
            }
            else            
                return false;
            
        }

        public override int GetHashCode()
        {
            return this.Cvc.GetHashCode();
        }
    }
}
