using RabbitMQ.Client;
using System;
using System.Text;
using System.Threading.Tasks;

namespace PublisherApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bağlantı oluşturma
            ConnectionFactory factory = new();

            factory.Uri = new("amqps://alchltry:s4vsK9XkMABWTy_UOQuEOaFn3zgtR1xa@sparrow.rmq.cloudamqp.com/alchltry");

            //Bağlantıyı aktifleştirme ve kanal açma

            using IConnection connection = factory.CreateConnection();

            using IModel channel = connection.CreateModel();

            //Quee Oluşturma
            channel.QueueDeclare(queue: "example-queue", exclusive:false);

            //Queue'ye Mesaj Gönderme

            //RabbirMQ kuyruğa atacağı mesajları byte türünden kabul etmektedir.

            //byte[] message = Encoding.UTF8.GetBytes("Merhaba");

            //channel.BasicPublish(exchange: "",routingKey:"example-queue",body:message);

            for (int i = 0; i < 100; i++)
            {
                Task.Delay(200);
                byte[] message = Encoding.UTF8.GetBytes("RabbitMQ Test" + " " + i);

                channel.BasicPublish(exchange: "", routingKey: "example-queue", body: message);
            }

            Console.Read();

        }

        
    }
}
