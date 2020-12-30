using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Converter
    {
        private double usd;
        private double eur;
        private double rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        /// <summary>
        /// Конвертация иностранной валюты в локальную
        /// </summary>
        /// <param name="summ">Сумма в иностранной валюте</param>
        /// <param name="currence">Ид. иностранной валюты</param>
        /// <returns></returns>
        public double ConvertToCurrence(double summ, string currence)
        {
            return summ * currence switch
            {
                Currences.usd => this.usd,
                Currences.eur => this.eur,
                Currences.rub => this.rub,
                _ => 0,
            };
        }

        /// <summary>
        /// Конвертация суммы в локальной валюте в иностранную
        /// </summary>
        /// <param name="summ">Сумма в локальной валюте</param>
        /// <param name="currence">Ид. иностранной валюты для конвертации</param>
        /// <returns></returns>
        public double ConvertFromCurrence(double summ, string currence)
        {
            double currenceRate = currence switch
            {
                Currences.usd => this.usd,
                Currences.eur => this.eur,
                Currences.rub => this.rub,
                _ => 0,
            };

            if (currenceRate == 0)
            {
                return 0;
            }

            return summ / currenceRate;
        }
    }
}
