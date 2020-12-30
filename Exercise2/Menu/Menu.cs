using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Menu
    {
        public static void Open()
        {
            List<IAction> actions = new List<IAction>() { new ConvertToCurrencyAction(),
                                                          new ConvertFromCurrencyAction()};
            Console.WriteLine("Программа конвертации гривны в валюту");
            Console.WriteLine("Выберите пункт меню:");
            foreach (var action in actions)
            {
                action.ShowName();
            }

            if (!int.TryParse(Console.ReadLine(), out int key))
            {
                Console.WriteLine("Не удалось определить действие");
                return;
            }

            bool actionFind = false;

            foreach (var action in actions)
            {
                if (action.GetActionId() == key)
                {
                    actionFind = true;
                    action.Execute();
                }
            }

            if (actionFind == false)
            {
                Console.WriteLine("Не удалось определить действие");
            }
        }
    }
}
