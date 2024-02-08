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
        string name = "EXPhone";
        string BuyDate = "D.M.Y";
        double Price = 00.00;
        int WarrantyPeriodMonths = 000;

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
        }
    }
}
