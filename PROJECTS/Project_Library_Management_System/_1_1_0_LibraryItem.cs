public abstract class LibraryItem
{
    public string Title;
    public string Author;
    public int ItemId;

    public abstract void DisplayItems();
    public abstract void CalculateLateFees(int Days);
}
