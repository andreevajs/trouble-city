﻿using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace trouble_city
{
    class Explosion : IVisualised
    {
        public Image Img { get; }
        public Vector Position { get { return new Vector(Canvas.GetLeft(Img), Canvas.GetTop(Img)); } }
        public int Radius { get; }
        public int Health { get; set; }

        public Explosion(Meteorite meteor)
        {
            Img = new Image();
            Img.Source = new BitmapImage(new Uri("pack://application:,,,/Images/explosion.png"));
            Img.Width = meteor.Radius * 4;
            Health = 1;
        }

        public void Act()
        {
            Img.Opacity -= 0.04;
            if (Img.Opacity == 0) Health = 0;
        }
    }
}
