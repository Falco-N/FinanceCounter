using System;

namespace ElectronicsDataBase._1
{
    // Main Class and Descriptions
    class Electronics
    {
        // Fields
        string name = "Device";
        string date = "D.M.Y";
        double price = 0.00d;
        int warranty = 000;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Warranty
        {
            get { return warranty; }
            set { warranty = value; }
        }
        // Constructors
        // w/o
        public Electronics()
        {

        }
        // 1
        public Electronics(string name)
        {
            this.name = name;
        }
        // 2
        public Electronics(string name, string date)
        {
            this.name = name;
            this.date = date;
        }
        // 3
        public Electronics(string name, string date, double price)
        {
            this.name = name;
            this.date = date;
            this.price = price;
        }
        // 4
        public Electronics(string name, string date, double price, int warranty)
        {
            this.name = name;
            this.date = date;
            this.price = price;
            this.warranty = warranty;
        }

        // Other methods


        // Need to add how the data will be input
    }

    // Sub Classes
    class Phone : Electronics
    {
        // Add type (android/ios/win), maker, memory 
    }

    class Tablet : Electronics
    {
        // Add type (android/ios/win), maker, memory
    }

    class Computer : Electronics
    {
        // Add type (stationary/laptop/touchpad), maker, parameters (windows/linux/mac), memory, extras (paid programs)
    }

    // All additives (headset/mouse/keyboard/webcam/screen)
    class Peripherals : Electronics
    {
        // Add type (function), belonging, maker
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Electronics electronics1 = new Electronics();
            Console.WriteLine(electronics1.Name);
            Console.ReadLine();
        }
    }
}
