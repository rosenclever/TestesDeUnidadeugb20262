public class BankAccount
{
    private string m_customerName;
    private decimal m_balance;
    public string CustomerName
    {
        get { return m_customerName; }
        set { m_customerName = value; }
    }
    public decimal Balance
    {
        get { return m_balance; }
    }

    public BankAccount(string customerName, decimal balance)
    {
        m_customerName = customerName;
        m_balance = balance;
    }

    public BankAccount() { }

    public void Debit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException("valor ", amount, "O valor do saque deve ser positivo.");
        }
        if(amount > m_balance)
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
        m_balance -= amount;
    }

    public void Credit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException("valor ", amount, "O valor do depósito deve ser positivo.");
        }
        m_balance += amount;
    }
}


