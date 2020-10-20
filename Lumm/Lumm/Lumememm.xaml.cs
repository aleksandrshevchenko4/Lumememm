using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lumememm : ContentPage
    {
        BoxView box1, box2, box3, box4;
        Button btn, btn1, btn2;
        Label lbl;
        public Lumememm()
        {
            box1 = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 100,
                WidthRequest = 100,
                HeightRequest = 100,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            box2 = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 100,
                WidthRequest = 130,
                HeightRequest = 130,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            box3 = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 100,
                WidthRequest = 160,
                HeightRequest = 160,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,

            };
            box4 = new BoxView
            {
                Color = Color.Black,
                CornerRadius = 0,
                WidthRequest = 50,
                HeightRequest = 50,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            
            btn = new Button
            {
                Text = "OFF",
            };
            btn.Clicked += Btn_Clicked;

            btn1 = new Button
            {
                Text = "ON",
            };
            btn1.Clicked += Btn1_Clicked;

            btn2 = new Button
            {
                Text = "Random color",
            };
            btn2.Clicked += Btn2_Clicked;


            lbl = new Label()
            {

                Text = "",
                FontAttributes = FontAttributes.Bold,
                Margin = 10,
            };

            StackLayout stackLayout = new StackLayout()
            {
                Margin = 10,
                Spacing = -4,
                Children = { box4, box1, box2, box3}
            };
            Content = stackLayout;

            StackLayout stackLayout1 = new StackLayout()
            {
                Children = { btn, btn1, btn2 },
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            Content = stackLayout1;


            StackLayout stackLayout3 = new StackLayout()
            {
                Children = { lbl },
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                
            };
            Content = stackLayout3;

            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { stackLayout, stackLayout1, stackLayout3 }
            };
            Content = stackLayout2;


        }


        Random rnd = new Random();
        Random rnd1 = new Random();
        Random rnd2 = new Random();
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            int red = rnd.Next(256);
            int green = rnd.Next(256);
            int blue = rnd.Next(256);
            Color randomColor = Color.FromRgb(red, green, blue);

            lbl.FontSize = 30;
            lbl.Text = string.Format("#{0:X2}{1:X2}{2:X2}", red, green, blue);

            int red1 = rnd1.Next(256);
            int green1 = rnd1.Next(256);
            int blue1 = rnd1.Next(256);
            Color randomColor1 = Color.FromRgb(red1, green1, blue1);

            int red2 = rnd2.Next(256);
            int green2 = rnd2.Next(256);
            int blue2 = rnd2.Next(256);
            Color randomColor2 = Color.FromRgb(red2, green2, blue2);

            box1.Color = randomColor;
            box2.Color = randomColor1;
            box3.Color = randomColor2;
        }   

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            box4.Opacity = 1;
            box1.Opacity = 1;
            box2.Opacity = 1;
            box3.Opacity = 1;
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            box4.Opacity = 0;
            box1.Opacity = 0;
            box2.Opacity = 0;
            box3.Opacity = 0;
        }
    }
}