using System;
using Caliburn.Micro;
using MahApps.Metro.IconPacks;
using MetroLightTemplate.Models;

namespace MetroLightTemplate.ViewModels
{
    public class ChatPage
    {
        public BindableCollection<MenuGlyphItem> RecentChatSource { get; set; } = new BindableCollection<MenuGlyphItem>();

        public ChatPage()
        {
            InitializeChatPage();
        }

        private void InitializeChatPage()
        {
            this.RecentChatSource.Add(new MenuGlyphItem()
            {
                Glyph = @"Assets\Images\Home.jpg",
                Label = @"文件传输助手"
            });
        }
    }
}