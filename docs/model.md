```mermaid
classDiagram
%% Models
class Currency{
    code
    region
}

class Amount{
    value
    currency
}

class Transaction{
    Amount
    senderAccount
    recipientAccount
}

%% Use-Cases
Interface PaymentMethod{
    process(Transaction)
}

%% Should we call these payment methods?
class CreditCardProcessor(PaymentMethod){
    process(Transaction)
        sender.card.charge
        ...
}

class AchProcessor(PaymentMethod){
    process(Transaction)
        sender.card.charge
        ...
}

```
