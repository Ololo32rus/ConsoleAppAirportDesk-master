using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAirportDesk
{
    public static class StatusList
    {
        public static string CheckIn { get; } = "Регистрация";
        public static string Boarding { get; } = "Идет посадка";
        public static string Arrival { get; } = "Вылетел";
        public static string Delayed { get; } = "Задерживается";
        public static string Canceled { get; } = "Рейс отменен";
    }
}
