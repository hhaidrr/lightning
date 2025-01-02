# Transaction states
Transaction states have multiple layers of abstraction associated with the various layers of transaction processing.

The top layer must be relevant and generic enough to apply to any processing method (cc, EFT, ACH, etc.)

For this, we have decided that a 3-state approach is the ideal representation of any process. It consists of the basic idea of precondition -> process -> postcondition.

The literal semantic enumeration we have chosen are:
- pending
- processing
- completed

This allows these states to cover more detailed lifecycles pertaining to specific payment method phases
e.g. 
credit card:
- authorized -> settled
EFT:
-> initiated -> pulled -> settled -> pushed 
RTP (no settlement period):
-> processing -> completed

This allows individual payment methods to encapsulate their specific lifecycle states without spilling into an outer scope.

