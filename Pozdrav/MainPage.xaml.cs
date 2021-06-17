using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pozdrav
{
    public partial class MainPage : ContentPage
    {
        Random rnd;
        public MainPage()
        {
            InitializeComponent();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            picker.Title = "Вы выбрали:" + picker.SelectedIndex;
            if (picker.SelectedIndex == 0)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 1)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 2)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 3)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 4)
            {
                EntrySubject.Text = $"{picker}";
            }
        }


        private void ButtonSend_Clicked_1(object sender, EventArgs e)
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail($"{picker.SelectedItem}", $"{EntrySubject}", $"{EntryRecipients}");
            }
            ButtonSend.Text = "Отправлено!";
        }
        private void randombutton_Clicked_1(object sender, EventArgs e)
        {
            picker.Title = "Вы выбрали:" + picker.SelectedIndex;
            if (picker.SelectedIndex == 0)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 1)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 2)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 3)
            {
                EntrySubject.Text = $"{picker}";
            }
            if (picker.SelectedIndex == 4)
            {
                EntrySubject.Text = $"{picker}";
            }
        }
    }
}
