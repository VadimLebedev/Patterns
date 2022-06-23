namespace Bridge.Abstractions
{
    abstract class WidgetBase
    {
        protected virtual void ViewData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
