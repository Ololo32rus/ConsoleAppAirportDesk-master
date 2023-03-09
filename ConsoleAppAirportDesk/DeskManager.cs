namespace ConsoleAppAirportDesk;

public class DeskManager
{
    private List<DeskRow> _rows;
    private int _globalId;

    public DeskManager()
    {
        _rows = new List<DeskRow>();
        _globalId = 0;
    }

    public void AddRow(DeskRow row)
    {
        _globalId++;
        row.SetId(_globalId);
        
        _rows.Add(row);
    }

    private void PrintRows(List<DeskRow> rows)
    {
        Console.WriteLine("{0,-3}{1,-14}{2,-8}{3, -17}{4, -9}{5, -16}", "ИД", "Время вылета", "Рейс", "Пункт назначения", "Терминал", "Статус");

        foreach (DeskRow row in rows)
        {
            Console.WriteLine(row);
        }
    }

    public void PrintAllRows()
    {
        PrintRows(_rows);
    }

    public void PrintRowsByTerminal(string terminal)
    {
        List<DeskRow> foundRows = _rows.Where(row => row.GetTerminal() == terminal).ToList();

        PrintRows(foundRows);
    }
}