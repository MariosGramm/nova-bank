namespace NovaBank.Domain.Enums
{
    public enum CardStatus
    {
        ACTIVE,     //default
        INACTIVE,   //if account of user is deactivated by employee
        FROZEN,     //if user freezes their card
        EXPIRED     //if expiry date is due
    }
}
