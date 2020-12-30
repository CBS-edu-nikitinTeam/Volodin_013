using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class ConvertToCurrencyAction : IAction
    {
        public int GetActionId()
        {
            return 1;
        }

        void IAction.Execute()
        {
            Converter converter = new Converter(usd: 0.035, eur: 0.029, rub: 2.60);

            Console.WriteLine("Введите сумму в гривнах:");
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

            Console.WriteLine($"{summ} в гривнах это {converter.ConvertToCurrence(summ, currencyCode):0.00} в валюте {currencyCode}");
        }

        void IAction.ShowName()
        {
            Console.WriteLine($"{GetActionId()}. Конвертация из гривны в валюту:");
        }
    }
}
