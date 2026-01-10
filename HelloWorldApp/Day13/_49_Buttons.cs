class Button
{
    // Step 1: Declare a delegate
    public delegate void ClickHandler();

    // Step 2: Declare an event using the delegate
    // Clicked is the event name
    public event ClickHandler Clicked;

    // Step 3: Method that raises the event
    public void Click()
    {
        Clicked?.Invoke();
    }
}


class _49_Program
{
    public void Main()
    {
        Button btn = new Button();

        btn.Clicked += () => Console.WriteLine("Button was Clicked");

        btn.Click();
    }
}