namespace Project_6
{
    public interface Visiter
    {
        void Visit(Visibility element);
    }

    public interface Visibility
    {
        int GetState();
    }

    public class Element_check_1 : Visibility
    {
        public int GetState() => 1;
    }
    
    public class Element_check_2 : Visibility
    {
        public int GetState() => 0;
    }
}

