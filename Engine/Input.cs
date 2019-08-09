using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using MonoGame.Framework.WpfInterop.Input;

namespace Engine
{
    public static class Input
    {
        public static KeyboardState keys;
        public static KeyboardState lastKeys;

        public static MouseState mouse;
        public static MouseState lastMouse;

        private static WpfKeyboard wpfKey;
        private static WpfMouse wpfMouse;



        public static void Init(MainGame game)
        {
            wpfKey = new WpfKeyboard(game);
            wpfMouse = new WpfMouse(game)
            {
                CaptureMouseWithin = false
            };

        }

        public static void Update()
        {
            lastKeys = keys;
            lastMouse = mouse;

            keys = wpfKey.GetState();
            mouse = wpfMouse.GetState();
        }



    }
}
