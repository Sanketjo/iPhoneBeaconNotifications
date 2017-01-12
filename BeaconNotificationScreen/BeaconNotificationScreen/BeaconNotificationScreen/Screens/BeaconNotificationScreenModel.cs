using Alpenhorn.Infrastructure.Support;
using Alpenhorn.Screens.Controls;
using System.Collections.Generic;

namespace Alpenhorn.Screens
{
    class BeaconNotificationScreenModel : ViewModelBase
    {
        private IList<ChatItemModel> chatItems;

        public IList<ChatItemModel> ChatItems
        {
            get { return chatItems; }
            set
            {
                chatItems = value;
                NotifyPropertyChanged("ChatItems");
            }
        }

        public BeaconNotificationScreenModel()
        {
            var items_ = new List<ChatItemModel>();

            for (int i = 0; i < 100; i++)
            {
                var isBot = i % 2 == 0;

                items_.Add(new ChatItemModel
                {
                    QuestionID = i,
                    IsBot = isBot,
                    Message = isBot ? "Do you want to buy something?" : "Yes, sure",
                    ImagePreview = "http://santiagochile.com/wp-content/uploads/Santiago-Marriott-Hotel-500x300.png",
                    ButtonsAreVisible = !isBot && i % 3 == 0,
                    ImageIsVisible = i % 3 == 0
                });
            }

            ChatItems = new List<ChatItemModel>(items_);
            ChatItemViewCell.ButtonPressed += OnQuestionAnswered;
        }

        public void OnQuestionAnswered(ChatItemModel chatItem, bool answer)
        {
            System.Diagnostics.Debug.WriteLine("{0} - {1}", chatItem.QuestionID, answer);
        }
    }
}
