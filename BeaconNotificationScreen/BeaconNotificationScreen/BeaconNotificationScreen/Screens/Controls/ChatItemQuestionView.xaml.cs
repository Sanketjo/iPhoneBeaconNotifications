using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Alpenhorn.Screens.Controls
{
    public partial class ChatItemQuestionView : ContentView
    {
        public ChatItemQuestionView()
        {
            InitializeComponent();
        }

        public void UpdateContext(ChatItemModel context)
        {
            question.Text = context.Message;
            preview.Source = context.ImagePreview;
            preview.IsVisible = context.ImageIsVisible;
        }
    }
}
