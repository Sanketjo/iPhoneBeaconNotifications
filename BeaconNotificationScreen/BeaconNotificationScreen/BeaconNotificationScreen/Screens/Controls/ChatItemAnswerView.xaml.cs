using System;
using Xamarin.Forms;

namespace Alpenhorn.Screens.Controls
{
    public partial class ChatItemAnswerView : ContentView
    {
        private readonly Action<bool> onQuestionAnswered = null;

        public Command<bool> AcceptCommand { get; private set; }

        public Command<bool> DeclineCommand { get; private set; }

        public ChatItemAnswerView(Action<bool> handler)
        {
            InitializeComponent();
            onQuestionAnswered = handler;

            AcceptCommand = new Command<bool>(OnChatButtonClick);
            DeclineCommand = new Command<bool>(OnChatButtonClick);

            buttonContainer.BindingContext = this;
        }

        public void UpdateContext(ChatItemModel context)
        {
            buttonContainer.IsVisible = context.ButtonsAreVisible;
            buttonContainer.IsVisible = context.ButtonsAreVisible;      
            answer.IsVisible = !context.ButtonsAreVisible;
            answer.Text = context.Message;
        }

        public static string GetUserAnswerString(bool answer)
        {
            if (answer)
                return "Yes, sure";

            return "No, thanks";
        }

        private void OnChatButtonClick(bool value)
        {
            answer.Text = GetUserAnswerString(value);
            buttonContainer.IsVisible = false;
            answer.IsVisible = true;
            onQuestionAnswered(value);
        }
    }
}
