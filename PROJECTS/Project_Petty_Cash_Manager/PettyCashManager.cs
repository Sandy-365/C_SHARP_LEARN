namespace PettyCashManager
{
    public enum TransactionStatus
    {
        PendingApproval,
        Approved,
        Rejected
    }

    public enum UserRole
    {
        Admin,
        Requester,
        Approver,
        Accountant,
        Auditor
    }

    public enum CategoryType
    {
        Stationery = 1,
        Travel = 2,
        Refreshments = 3,
        Courier = 4,
        Other = 5
    }

    public abstract class Transaction
    {
        public int id;
        public float Amount;
        public DateTime Date;
        
    }

}