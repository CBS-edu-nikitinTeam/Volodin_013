using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class ConvertFromCurrencyAction : IAction
    {
        public int GetActionId()
        {
            return 2;
        }

        void IAction.Execute()
        {
            Converter converter = new Converter(usd: 0.035, eur: 0.09, rub: 2.60);

            Console.WriteLine("Введите сумму в валюте:");
            if (!double.TryParse(Console.ReadLine(), out double summ))
            {
                Console.WriteLine("Сумма введена не корректно");
                return;
            }

            Console.WriteLine("Введите валюту (EUR, USD, RUB):");
            string currencyCode = Console.ReadLine().ToUpper();

            if (!(currencyCode switch
            {
                Currences.usd => true,
                Currences.eur => true,
                Currences.rub => true,
                _ => false,
            }))
            {
                Console.WriteLine("Валюта введена не корректно");
                return;
            }

            Console.WriteLine($"{summ} в валюте {currencyCode} это {converter.ConvertFromCurrence(summ, currencyCode):0.00} в гривнах");
        }

        void IAction.ShowName()
        {
            Console.WriteLine($"{GetActionId()}. Конвертации из валюты в гривну:");
        }
    }
}
