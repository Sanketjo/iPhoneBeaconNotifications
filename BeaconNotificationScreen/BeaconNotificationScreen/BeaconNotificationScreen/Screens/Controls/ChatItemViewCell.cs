using System;
using Xamarin.Forms;

namespace Alpenhorn.Screens.Controls
{
    public class ChatItemViewCell : ViewCell
    {
        private readonly ChatItemQuestionView questionView = null;

        private readonly ChatItemAnswerView answerView = null;

        private ChatItemModel context = null;

        public static event Action<ChatItemModel, bool> ButtonPressed;

        public ChatItemViewCell()
        {
            questionView = new ChatItemQuestionView();
            answerView = new ChatItemAnswerView(OnQuestionAnswered);
        }

        protected override void OnBindingContextChanged()
        {
                base.OnBindingContextChanged();
                context = BindingContext as ChatItemModel;

                if (context != null)
                {
                    if (context.IsBot)
                    {
                        questionView.UpdateContext(context);
                        View = questionView;
                    }
                    else
                    {
                        answerView.UpdateContext(context);
                        View = answerView;
                    }
                }
        }

        private void OnQuestionAnswered(bool answer)
        {
            ButtonPressed?.Invoke(context, answer);
        }
    }
}
