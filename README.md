# RabbitMQ-Example
Bu repo, basit bir RabbitMQ yayıncı-tüketici (publisher-consumer) uygulamasını içermektedir. Bu uygulama, RabbitMQ aracılığıyla bir kuyruk oluşturarak mesajları yayınlar ve ardından bu mesajları tüketir.

Gereksinimler
.NET Core 3.1 veya daha yeni bir sürümü yüklü olmalıdır.
RabbitMQ brokerına erişim sağlanmalıdır. Bu örnekte CloudAMQP kullanılmaktadır.
Kurulum
Bu depoyu yerel makinenize klonlayın:

bash
Copy code
git clone <repository_url>
PublisherApp ve ConsumerApp klasörlerine sırasıyla gidin ve her birinde aşağıdaki adımları izleyin:

appsettings.json dosyasını açın.
ConnectionUri alanını, RabbitMQ brokerına erişim için uygun olan URI ile değiştirin.
Terminali açın ve PublisherApp klasöründe aşağıdaki komutu çalıştırın:

bash
Copy code
dotnet run
Başka bir terminal penceresi açın ve ConsumerApp klasöründe aşağıdaki komutu çalıştırın:

bash
Copy code
dotnet run
Kullanım
PublisherApp uygulaması, example-queue adında bir kuyruk oluşturacak ve ardından 0'dan 99'a kadar olan sayıları içeren mesajları yayınlayacaktır.
ConsumerApp uygulaması, example-queue kuyruğundan mesajları tüketerek konsola yazdıracaktır.
Lisans
Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için LICENSE dosyasına başvurun.


Kaynakça:https://www.youtube.com/watch?v=xMwmB4kMBro
