using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _7._0.Клас_команд_RoutedCommand
{
    public class CustomCommands
    {
        public static readonly RoutedUICommand Exit = new RoutedUICommand
            (
                "Exit",//імя команди
                "Exit",//назва команди
                typeof(CustomCommands),//елемент-власник
                new InputGestureCollection()
                {
                    new KeyGesture(Key.F4, ModifierKeys.Alt)
                }
            );

        //Define more commands here, just like the one above
    }
}
