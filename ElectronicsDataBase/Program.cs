using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsDataBase._1
{
    // Main Class and Descriptions
    class Electronics
    {
        // Fields
        string name = "EXPhone";
        string date = "D.M.Y";
        double price = 00.00;
        int warranty = 000;

        // Properties

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
        string name;
        string buyDate;
        double price;
        int warranty;

        public Phone(string name) 
        { 
            this.name = name;
        }  
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
        }
    }
}
