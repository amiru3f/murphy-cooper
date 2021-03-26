 # Murphy Cooper
 ## I'm going to show how to serve `Rest` and `Grpc` services with the same domain layer using `MediatR`.

 ### Note: [MediatR](https://github.com/jbogard/MediatR) is a tool that implements domain-interaction encapsulator using `Mediator` pattern (behavioral).

### There is a simple TestService that echos Hello [Name] and receives [Name] as parameter. 

#### Implementation notes:
* The grpc server runs on http 2.+
* The rest server runs on http 1.+
* MediatR acts as a single responsible player that routes the requests from different protocol gateways.

#### To be continued.