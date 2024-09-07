using System.Text;

namespace Design_Pattern.Behavioral_Patterns
{
    public class VoiceBasedNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(Notification notification)
        {
            StringBuilder sb = new StringBuilder($"Sending voice-based Notification to : {notification.Recipient}\n");
            sb.Append($"Message: {notification.Message}");

            Console.WriteLine(sb.ToString());
        }
    }
}