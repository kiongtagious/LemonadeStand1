namespace ConsoleApplication1
{
    public class Inventory
    {
        Lemons lemons;
        Ice ice;
        Sugar sugar;
        Cups cups;
        Pitcher pitcher;

        public Inventory()
        {
            lemons = new Lemons();
            ice = new Ice();
            sugar = new Sugar();
            pitcher = new Pitcher();
            cups = new Cups();
        }
    }
}