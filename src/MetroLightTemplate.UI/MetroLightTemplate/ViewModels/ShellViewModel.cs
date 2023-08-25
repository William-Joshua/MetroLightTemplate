using System;
using Caliburn.Micro;
using MahApps.Metro.IconPacks;
using MetroLightTemplate.Models;

namespace MetroLightTemplate.ViewModels
{
    public class ShellViewModel : PropertyChangedBase
    {
        public BindableCollection<MenuItem> MenuItems { get; set; } = new BindableCollection<MenuItem>();

        public BindableCollection<MenuItem> OptionItems { get; set; } = new BindableCollection<MenuItem>();

        public ShellViewModel()
        {
            InitializeShellView();
        }

        private void InitializeShellView()
        {
            this.MenuItems.Add(new MenuItem()
            {
                Icon = new PackIconMaterial() { Kind = PackIconMaterialKind.ChatProcessingOutline },
                Label = "聊天",
                NavigationType = typeof(ChatPage),
                NavigationDestination = new Uri("Views/ChatPage.xaml", UriKind.RelativeOrAbsolute)

            });
            this.MenuItems.Add(new MenuItem()
            {
                Icon = new PackIconMaterial() { Kind = PackIconMaterialKind.ContactsOutline },
                Label = "通讯录",
                NavigationType = typeof(ContactsPage),
                NavigationDestination = new Uri("Views/ContactsPage.xaml", UriKind.RelativeOrAbsolute)

            });

            this.OptionItems.Add(new MenuItem()
            {
                Icon = new PackIconMaterial() { Kind = PackIconMaterialKind.CogOutline },
                Label = "设置",
                NavigationType = typeof(ContactsPage),
                NavigationDestination = new Uri("Views/ContactsPage.xaml", UriKind.RelativeOrAbsolute)

            });
        }

    }
}