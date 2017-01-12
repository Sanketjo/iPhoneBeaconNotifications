using Alpenhorn.Infrastructure.Enums;
using System.Collections.Generic;

namespace Alpenhorn.Screens
{
    public class ChatItemModel
    {
        public string Message { get; set; }

        public string ImagePreview { get; set; }

        public bool ImageIsVisible { get; set; }

        public bool ButtonsAreVisible { get; set; }

        public IEnumerable<string> Images { get; set; }

        public NotificationTypes NotificationType { get; set; }

        public int QuestionID { get; set; }

        public bool IsBot { get; set; }
    }
}
