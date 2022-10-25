using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MessageBox
    {
        public event Action<State>? WindowClose = null;
        public async void Open()
        {
            Console.WriteLine("Вiкно вiдкрито");
            await Task.Delay(3000);
            Console.WriteLine("Вiкно закрито");
            WindowClose?.Invoke((State)new Random().Next(2));
        }
    }
}