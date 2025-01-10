using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame_DoNotClickIgnoreAndContinue_15_September_2024
{
    internal class Settings
    {
        /*
         * SETTING UP THE SETTINGS.CS CLASS
         * Timestamp in the tutorial video: 11:58 to 13:15
         * 
         * Apparently, static variables do not need to be replicated and, when
         * called from the main class, can also be accessed from different
         * applications? Whoops, programs.
         * 
         * As I understand them, static variables just stay put.
         * 
         * Type:
         * public static int Width {  get; set; } 
         * public static int Height { get; set; }
         */

        public static int Width { get; set; }
        public static int Height { get; set; }




        /* 
         * Next, create a string variable which, as I understand them, contain
         * words and letters instead of numbers.
         * 
         * Type: 
         * public static string directions
         * 
         * Please leave this string variable empty for now. Apparently, you might
         * come back to this variable.
         */

        public static string directions;




        /* 
         * Finally, create a constructor called Settings(). A constructor must have the
         * same name as the class which in this case is Settings.
         * 
         * In this constructor, you will provide default or starting values for both the
         * width and height of the circle sprite... I assume this circle sprite is the
         * starting circle sprite?
         * 
         * Oh, the values for the width and height are the values for every circle
         * that is created by the game.
         * 
         * Regarding the default direction, the tutorial video specified the left direction,
         * but I guess in the future and if I feel curious about finding out if the direction
         * can change between left and right at the start of the game, I could always
         * change 'left' to 'right'.
         * 
         * public Settings()
        {
            Width = 16;
            Height = 16;
            directions = "left";
        }
         */

        public Settings()
        {
            Width = 16; // 25 (add to version 2);
            Height = 16; // 25;
            directions = "left";
        }
    }
}