
RabbitMQ Publisher-Consumer Application
This repository contains a simple RabbitMQ publisher-consumer application. This application creates a queue via RabbitMQ, publishes messages, and then consumes these messages.

Requirements
You must have .NET Core 3.1 or a newer version installed.
Access to a RabbitMQ broker is required. In this example, CloudAMQP is used.
Installation
Clone this repository to your local machine:

bash
Copy code
git clone <repository_url>
Navigate to the PublisherApp and ConsumerApp folders respectively and follow these steps in each:

Open the appsettings.json file. Replace the ConnectionUri field with the appropriate URI for accessing the RabbitMQ broker.

Open a terminal and run the following command in the PublisherApp folder:

bash
Copy code
dotnet run
Open another terminal window and run the following command in the ConsumerApp folder:

bash
Copy code
dotnet run
Usage
The PublisherApp application will create a queue named example-queue and then publish messages containing numbers from 0 to 99. The ConsumerApp application will consume messages from the example-queue queue and write them to the console.

References
You can find the source that developed this project in the following video: Youtube Video https://www.youtube.com/watch?v=xMwmB4kMBro
