﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBoxData
{
    public class Box
    {

        public Box(double length,double width,double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        private double length;
        private double width;
        private double height;

        public double Length 
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public string Calculate()
        {
            StringBuilder sb = new StringBuilder();
            double volume = this.Length * this.Width * this.Height;
            //2lh + 2wh
            double lateralSurfaceArea = 
                2 * this.Length * this.Height + 
                2 * this.Width * this.Height;
            // 2lw + 2lh + 2wh
            double surfaceArea = 
                2 * this.Length * this.Width + 
                2 * this.Length * this.Height + 
                2 * this.Width * this.Height;
            sb.AppendLine($"Surface Area - {surfaceArea:F2}");
            sb.AppendLine($"Lateral Surface Area - {lateralSurfaceArea:F2}");
            sb.AppendLine($"Volume - {volume:F2}");
            return sb.ToString();
        }
    }
}
