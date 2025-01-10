using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame_DoNotClickIgnoreAndContinue_15_September_2024
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
             * Hello, Nathan in the future!
             * 
             * After a false restart and messing up on where to
             * add a new Windows Form application, you will
             * be learning how to set up a 'splash screen' screen
             * to appear while Nathan's Snake Game starts up
             * in the background.
             * 
             * My brain already feels like it imploded but I will
             * continue and try my best to do this.
             * 
             * I followed the steps provided in this video on YouTube:
             * 
             * How to create a Splash Screen in C# 2020
             * 
             * First things first, comment out 'Application.Enable...();'
             * as, apparently, you do not need this on.
             */
            // Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen_24_Sep_2024());

            // Form1()); (original run thing)
            // SplashScreen_24_Sep_2024()); (add to version 2);


            // See if this works and does not duplicate the game on repeat.
            // 10:33pm update: Nope. Nothing opened.

            /*
             * Leave the rest of the code alone.
             * 
             * Next, move your mouse to the SnakeGame solution on the
             * right-hand-side. Right-click on SnakeGame_DoNotClick...
             * at the very top then click on Add and then click on
             * Form (Windows Forms)...
             * 
             * For the rest of these comments, click on the SplashScreen
             * Windows Form.
             */
        }
    }
}
