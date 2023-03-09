using ConsoleAppAirportDesk;

DeskManager manager = new DeskManager();

manager.AddRow(new DeskRow(new TimeOnly(9, 2), "ERYT23", "Moscow", TerminalList.B, StatusList.Arrival));
manager.AddRow(new DeskRow(new TimeOnly(10, 2), "ERYT23", "Moscow", TerminalList.A, StatusList.CheckIn));
manager.AddRow(new DeskRow(new TimeOnly(11, 2), "ERYT23", "Moscow", TerminalList.C, StatusList.Boarding));
manager.AddRow(new DeskRow(new TimeOnly(23, 2), "ERYT23", "Moscow", TerminalList.A, StatusList.CheckIn));

manager.PrintAllRows();
Console.WriteLine(new string('#', 10));
manager.PrintRowsByTerminal(TerminalList.A);