﻿using UIKit;

namespace Event.iOS
{
    public class Application
    {
        #region Методы

        // This is the main entry point of the application.
        private static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }

        #endregion
    }
}