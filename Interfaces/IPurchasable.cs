namespace movietheaterzach
{
    public interface IPurchasable
    {
        //Float was for an integer with a decimal
        float Cost { get; set; }
        int Inventory { get; set; }

        //Cant write the entire method just have to reference it here
        //If anything inherites the IPurchasable interface it will have to have a purchase method on it
        //was originally void but changed to a bool
        bool Purchase(int quantity);

    }
}