namespace Core.UnitTests;

public class PaymentMethodTests
{
    [Fact]
    public void Process_NewTransaction_SetToInitiated()
    {
        //Arrange
        mocks
        //Act
        paymentMethod.process(transaction)
        //Assert
        //assert that funds are confirmed to have been debited from the senders bank account
        senderBankAccount.ledger
        //assert that funds are confirmed to be credited to the recipient bank account 
        

    }
}
