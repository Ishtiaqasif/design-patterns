using System.Text;

namespace Design_Pattern.Behavioral_Patterns
{
    public class PushBasedNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(Notification notification)
        {
            StringBuilder sb = new StringBuilder($"Sending Push based Notification to : {notification.Recipient}\n");
            sb.Append($"Message: {notification.Message}");

            Console.WriteLine(sb.ToString());
        }
    }
}