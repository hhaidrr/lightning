private class Currency{
    private string code;
    private string region;
}

// We don't want to capture a balance for an account even thought is its primary data field, since 
// the source of truth for the balance for a real account is always external. We can only derive a 
// net delta on the balance by event sourcing all affecting transactions.
class BankAccount{
    


}

class AccountHolder{

}




