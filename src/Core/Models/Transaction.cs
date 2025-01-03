// docs/implementation_design/transaction_states.md
public enum TransactionState{
    Pending,
    Initiated,
    Completed
}

private class Amount{
    private int value;
    private Currency currency;
}

class Transaction{
    private Amount amount;
    private BankAccount senderAccount;
    private BankAccount recipientAccount;
}

