namespace LinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UC6 list = new UC6();
            list.AddEnd(56);
            list.AddEnd(30);
            list.AddEnd(70);
            list.DeleteLastNode();
            list.display();

        }
    }
}