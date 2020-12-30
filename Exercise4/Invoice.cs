using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;

        private string article;
        private int quantity;
        private double price;
        public Invoice(int account, string customer, string provider, string article, int quantity, double price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
            this.price = price;
        }

        public double GetSumm()
        {
            return price * quantity;
        }

        public string GetInvoiceDetails()
        {
            return new StringBuilder().Append($"Счет: {this.account}").Append(Environment.NewLine)
                .Append($"Отправитель: {this.provider}").Append(Environment.NewLine)
                .Append($"Получатель: {this.customer}").Append(Environment.NewLine)
                .Append($"Позиция: {this.article} ")
                .Append($"в кол-ве: {this.quantity} ")
                .Append($"по цене: {this.price:0.00}").Append(Environment.NewLine)
                .Append($"Итого: {this.GetSumm():0.00}")
                .Append($" в том числе НДС: {(this.GetSumm() * 0.2):0.00}").Append(Environment.NewLine)
                .ToString();
        }
    }
}
