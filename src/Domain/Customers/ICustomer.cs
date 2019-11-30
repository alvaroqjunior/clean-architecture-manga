namespace Domain.Customers
{
    using Domain.Accounts;

    public interface ICustomer
    {
        CustomerId Id { get; }

        AccountCollection Accounts { get; }

        void Register(IAccount account);
    }
}