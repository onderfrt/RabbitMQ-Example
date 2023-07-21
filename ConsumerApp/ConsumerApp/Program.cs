using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace ConsumerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bağlantı Oluşturma

            ConnectionFactory factory = new();
            factory.Uri = new("amqps://alchltry:s4vsK9XkMABWTy_UOQuEOaFn3zgtR1xa@sparrow.rmq.cloudamqp.com/alchltry");

            //Bağlantı Aktifleştirme ve Kanal Açma
            using IConnection connection = factory.CreateConnection();
            using IModel channel = connection.CreateModel();


            //Queue Oluşturma
            channel.QueueDeclare(queue: "example-queue", exclusive: false);  //Consumer'da da kuyruk publisher'daki ile birebir aynı yapılandırmada tanımlanmalıdır!

            //Queue'dan Mesaj Okuma
            EventingBasicConsumer consumer = new(channel);

            channel.BasicConsume(queue: "example-queue", false, consumer);

            consumer.Received += (sender, e) =>
            {
                //Kuyruğa gelen mesajın işlendiği yerdir!
                //e.Body: Kuyruktaki mesajın verisini bütünsel olarak getirecektir.
                //e.Body.Span veya e.Body.ToArray()  : Kuyruktaki mesajın byte veirisini getirecektir.

                Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));
            };

            Console.Read();
        }
    }
}
