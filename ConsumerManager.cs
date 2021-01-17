using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ConsumerManager
    {
        public void Delete(Consumer consumer)
        {
            Console.WriteLine("Selected Consumer has Deleted" + ":" + consumer.ConsName);

        }
        public void Add(Consumer consumer)
        {
            Console.WriteLine("The Consumer Has Added" + ":" + consumer.ConsName);

        }

        public void ShowBalance(Consumer consumer)
        {
            Console.WriteLine("Consumer's Balance İs" + ":" + consumer.ConsBalance);

        }
        public void ShowCity(Consumer consumer)
        {
            Console.WriteLine("Consumer's City İs" + ":" + consumer.ConsCity);

        }
        public void ShowId(Consumer consumer)
        {
            Console.WriteLine("Consumer's ID İs" + ":" + consumer.Id);

        }
        public void ConsInformations(Consumer consumer)
        {
            Console.WriteLine("Consumer's Informations are the following" + ":");
            Console.WriteLine("ID :" + consumer.Id);
            Console.WriteLine("NAME :" + consumer.ConsName);
            Console.WriteLine("BALANCE:" + consumer.ConsBalance);
            Console.WriteLine("CİTY:" + consumer.ConsCity);
        }
}   }
