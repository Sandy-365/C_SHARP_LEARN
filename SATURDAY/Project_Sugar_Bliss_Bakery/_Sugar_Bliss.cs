class Chocolate
{
    public string Flavour { get; set; }
    public int Quantity { get; set; }
    public int PricePerUnit { get; set; }
    public double TotalPrice { get; set; }
    public double DiscountedPrice { get; set; }

    public bool ValidateChocolateFlavour()
    {
        if(Flavour=="Dark" || Flavour=="Milk" || Flavour == "White")
        {
            return true;
        }
        else
        {
            return true;
        }
    }

    public Chocolate CalculateDiscountedPrice(Chocolate chocolate)
    {
        Dictionary<string,int> disData = new Dictionary<string, int>();
        disData["Dark"] = 18;
        disData["Milk"] = 12;
        disData["White"] = 6;

        string name = chocolate.Flavour;
        chocolate.TotalPrice = chocolate.Quantity * chocolate.PricePerUnit;
        chocolate.DiscountedPrice = TotalPrice - (TotalPrice * disData[name]/100);
        return chocolate; 
    }



}