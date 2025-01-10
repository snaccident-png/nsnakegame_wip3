using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame_DoNotClickIgnoreAndContinue_15_September_2024
{
    internal class Circle
    {
        /*
         * SETTING UP THE CIRCLE.CS CLASS
         * Timestamp in the tutorial video: 10:20 to 11:54
         * 
         * I forgot and then sort of remembered int variables. They are used to
         * provide reference points that you can repeat later on and assign numbers
         * to. I think once an int variable is created, I can just type the name
         * of the variable such as X or Y every time I want to refer to the variable later.
         * 
         * In this case, the int variable is named and has something else called
         * 'properties' such as 'get' and 'set'.
         * 
         * Properties apparently provide better control over how to use variables or
         * the properties themselves and how they get called from the class.
         * 
         * Type:
         * public int X {  get; set; }
         * public int Y { get; set; }
         */

        public int X { get; set; }
        public int Y { get; set; }




        /* Next, create a 'constructor'. What on planet Earth is a constructor?
         * 
         * A constructor sounds kind of helpful if I understand it correctly.
         * 
         * A constructor helps each instance or repetition of a class to know what
         * to do with the X and Y positions or coordinates.
         * 
         * For example, if I created a copy of this Circle.cs class for whatever reason,
         * having provided a constructor would allow the copy of the Circle.cs class
         * to quickly understand what to do with the X and Y coordinates if they move
         * constantly.
         * 
         * I hope my understanding and example is right!
         * 
         * Also, a constructor must have the same name as the class. For example,
         * if the class is called 'Binary300', then the constructor must also be called
         * 'Binary300'.
         * 
         * Type:
         *public Circle()
        {
            X = 0;
            Y = 0;
        }
         */

        public Circle()
        {
            X = 0;
            Y = 0;
        }
    }
}