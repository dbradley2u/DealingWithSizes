﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace DealingWithSizes
{

    public class WhatSizePage : ContentPage
    {
        Label label;

        public WhatSizePage()
        {
            label = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Content = label;

            SizeChanged += OnPageSizeChanged;
        }

        void OnPageSizeChanged(object sender, EventArgs args)
        {
            label.Text = String.Format("{0} \u00D7 {1}", Width, Height);
        }
    }
}
