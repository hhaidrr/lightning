/payments
    POST /transaction
    {
        amount
        receivingAccount
        paymentMethod
        correlationReference
    }->
    {
        pspReference
        resultCode
        additionalData
    }

    GET /transactions

    POST /paymentMethod
    ...

    GET /paymentMethods

              

        
