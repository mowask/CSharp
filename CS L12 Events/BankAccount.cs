using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L12_Events
{
    internal class BankAccount
    {
                                                                // делегат для отправки сообщений
        public delegate void Notification(string text);
        public event Notification Notify;                         //определение события

        private decimal _balance;

        public BankAccount(decimal balance) { _balance= balance; }

        public void Deposit ( decimal amount )
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance += amount;
                if (Notify != null)
                    Notify($"{amount:N} был добавлен на ваш счет, текущий баланс: {_balance:N}");
            }
            else
            {
                if (Notify != null)
                    Notify("Ошибка: Сумма пополнения должна быть положительнойю");
            }
        }

        public void Withdraw ( decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                if (Notify != null)
                    Notify($"{amount:N} был снят с вашего счета, текущий баланс: {_balance}");
            }
            else {
                if (Notify != null)
                    Notify("Ошибка: Недостаточный баланс или сумма снятия не может быть отрицательной.");
            }
        }

    }
}
