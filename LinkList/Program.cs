namespace LinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UC4 list = new UC4();
            list.AddEnd(56);
            list.AddEnd(70);
            list.InserInBetween(30, 2);
            list.display();
        }
    }
}