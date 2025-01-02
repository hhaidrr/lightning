private class Currency{
    private string code;
    private string region;
}

private class Amount{
    private int value;
    private Currency currency;
}

class Transaction{
    private int amount;
    private BankAccount senderAccount;
    private BankAccount recipientAccount;
}

