using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAirportDesk
{
    public class DeskRow
    {
        private int _id;
        private TimeOnly _arrivalTime;
        private string _flight;
        private string _destination;
        private string _terminal;
        private string _status;

        public DeskRow(int id, TimeOnly arrivalTime, string flight, string destination, string terminal, string status)
        {
            _id = id;
            _arrivalTime = arrivalTime;
            _flight = flight;
            _destination = destination;
            _terminal = terminal;
            _status = status;
        }

        public override string ToString()
        {
            return string.Format("{0,-3}{1,-10}{2,-8}{3, -15}{4, -3}{5, -16}", _id, _arrivalTime, _flight, _destination, _terminal, _status);
        }

        public void ChangeStatus(string status)
        {
            _status = status;
        }

        public void ChangeTerminal(string terminal)
        { 
            _terminal = terminal;
        }
    }

}
