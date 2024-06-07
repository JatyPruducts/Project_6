namespace Project_6;

public class VisitChecker : Visiter
{
    public void Visit(Visibility element)
    {
        try
        {
            if (element.GetState() == 0)
                Console.WriteLine("тревога!");
        }
        catch (Exception)
        {
            Console.WriteLine("тревога!");
        }
    }
}

public class SystemChecker
{
    private readonly List<Visibility> _elements;
    public SystemChecker()
    {
        _elements = new List<Visibility>
        {
            new Element_check_1(),
            new Element_check_2()
        };

    }

    public void Checkstate()
    {
        var visiter = new VisitChecker();

        foreach (var element in _elements)
        {
            visiter.Visit(element);
        }
    }
}