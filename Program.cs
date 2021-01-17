using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Kazım Karahan Güzel.
            //Müşterileri bilgilerimizi girelim..
            Consumer consumer1 = new Consumer();
            consumer1.Id = 13579;
            consumer1.ConsName = "Ayşe Güzel";
            consumer1.ConsBalance = 1000;
            consumer1.ConsCity = "İzmir";

            Consumer consumer2 = new Consumer();
            consumer2.Id = 02468;
            consumer2.ConsName = "Fatma Güzel";
            consumer2.ConsBalance = 2000;
            consumer2.ConsCity = "İstanbul";

            Consumer consumer3 = new Consumer();
            consumer3.Id = 12345;
            consumer3.ConsName = "Hayriye Güzel";
            consumer3.ConsBalance = 3000;
            consumer3.ConsCity = "Ankara";

            //Consumer Classını kullanarak bilgilerimizi düzenli şekilde girdik.
            //Şimdi sıra ConsumerManagement'ta oluşturduğumuz "Delete"/"Add"/"ShowBalance"/"ShowCity"/"ShowId" metotlarımızı örneklemede.

            ConsumerManager consumerManager = new ConsumerManager();
            consumerManager.Add(consumer1);
            consumerManager.Delete(consumer2);
            consumerManager.ShowBalance(consumer3);
            consumerManager.ShowCity(consumer1);
            consumerManager.ShowId(consumer2);
            consumerManager.ConsInformations(consumer1);
            consumerManager.ConsInformations(consumer2);
            consumerManager.ConsInformations(consumer3);



        }
    }
}
