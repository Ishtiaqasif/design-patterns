using System.Text;

namespace Design_Pattern.Behavioral_Patterns
{
    public class DocumentBasedNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(Notification notification)
        {
            StringBuilder sb = new StringBuilder($"Sending Document-based Notification : {notification.Recipient}\n");
            sb.Append($"Message: {notification.Message}");

            Console.WriteLine(sb.ToString());
        }
    }
}