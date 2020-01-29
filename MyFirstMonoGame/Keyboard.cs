using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Xna.Framework.Input;

namespace MyFirstMonoGame
{
    class Keyboard
    {
        static KeyboardState currentKeyState;
        static KeyboardState previousKeyState;
        static string stringValue = string.Empty;

        public static KeyboardState GetState()
        {
            previousKeyState = currentKeyState;
            currentKeyState = Microsoft.Xna.Framework.Input.Keyboard.GetState();
            Keys[] keys = currentKeyState.GetPressedKeys();

            if (keys.Length > 0)
            {
                Debug.WriteLine(keys[0].ToString());
                //var keyValue = keys[0].ToString();
                //stringValue += keyValue;
            }
            //Debug.WriteLine(stringValue);
            return currentKeyState;
        }

        public static bool IsPressed(Keys key)
        {
            return currentKeyState.IsKeyDown(key);
        }

        public static bool HasBeenPressed(Keys key)
        {
            if (currentKeyState.IsKeyDown(key))
            { 
                Debug.WriteLine("Now!");
                if (!previousKeyState.IsKeyDown(key))
                    Debug.WriteLine("Later!");
            }
            return (currentKeyState.IsKeyDown(key) && !(previousKeyState.IsKeyDown(key)));
        }
    }
}
