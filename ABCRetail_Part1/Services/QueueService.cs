using Azure.Storage.Queues;
using System.Threading.Tasks;

namespace ABCRetail_Part1.Services
{
    public class QueueService
    {
        private readonly QueueClient _queueClient;

        //constructor to initialize QueueClient with connection string and queue name
        public QueueService(string connectionString, string queueName)
        {
            _queueClient = new QueueClient(connectionString, queueName); 
        }

        //method to send message to specified queue
        public async Task SendMessageAsync(string message)
        {
            await _queueClient.SendMessageAsync(message); 
        }
    }
}
