using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsLumememm : ContentPage
    {
        BoxView box1, box2, box3, box4, silm, silm1, box, nina;
        Label lbl;
        public AbsLumememm()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();

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
            silm = new BoxView
            {
                Color = Color.Black,
                CornerRadius = 100,
                WidthRequest = 10,
                HeightRequest = 10,
            };

            silm1 = new BoxView
            {
                Color = Color.Black,
                CornerRadius = 100,
                WidthRequest = 10,
                HeightRequest = 10,

            };
            box = new BoxView
            {
                Color = Color.Black,
                CornerRadius = 0,
                WidthRequest = 50,
                HeightRequest = 5,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            nina = new BoxView
            {
                Color = Color.Orange,
                CornerRadius = 100,
                WidthRequest = 7,
                HeightRequest = 7,
            };

            Button btn = new Button
            {
                    Text = "OFF"
            };
            btn.Clicked += Btn_Clicked;

            Button btn1 = new Button
            {
                Text = "ON"
            };
            btn1.Clicked += Btn1_Clicked;

            Button btn2 = new Button
            {
                Text = "Random color"
            };
            btn2.Clicked += Btn2_Clicked;



            lbl = new Label()
            {

                Text = "",
                FontAttributes = FontAttributes.Bold,
            };

            AbsoluteLayout.SetLayoutBounds(box4, new Rectangle(110, 75, 50, 50));
            absoluteLayout.Children.Add(box4);

            AbsoluteLayout.SetLayoutBounds(box1, new Rectangle(85, 120, 100, 100));
            absoluteLayout.Children.Add(box1);

            AbsoluteLayout.SetLayoutBounds(box2, new Rectangle(70, 200, 130, 130));
            absoluteLayout.Children.Add(box2);

            AbsoluteLayout.SetLayoutBounds(box3, new Rectangle(60, 300, 160, 160));
            absoluteLayout.Children.Add(box3);

            absoluteLayout.Children.Add(silm1, new Point(140, 140));

            absoluteLayout.Children.Add(silm, new Point(120, 140));

            absoluteLayout.Children.Add(box, new Point(110, 170));

            absoluteLayout.Children.Add(nina, new Point(133, 150));

            absoluteLayout.Children.Add(
                btn,
                new Point(10, 500)
                );
            absoluteLayout.Children.Add(
                btn1,
                new Point(100, 500)
                );
            absoluteLayout.Children.Add(
                btn2,
                new Point(280, 500)
                );
            absoluteLayout.Children.Add(
                lbl,
                new Point(130, 550)
                );
            Content = absoluteLayout;     
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
            silm.Opacity = 1;
            silm1.Opacity = 1;
            nina.Opacity = 1;
            box.Opacity = 1;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            box4.Opacity = 0;
            box1.Opacity = 0;
            box2.Opacity = 0;
            box3.Opacity = 0;
            silm.Opacity = 0;
            silm1.Opacity = 0;
            nina.Opacity = 0;
            box.Opacity = 0;
        }
    }
}