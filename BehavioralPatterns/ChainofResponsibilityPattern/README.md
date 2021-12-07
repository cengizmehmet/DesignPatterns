# Chain of Responsibility

Chain of Responsibility is a behavioral design pattern that lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.
By doing this, it is possible to create a hierarchal authorization for each asset, so that, no asset wastes time on matters that do not concern them.

In this application, I designed a withdrawal process. As you can see, there is a hierarchy between classes. The first asset is "Cashier". "Manager", "Director", "AreaManager" come after "Cashier" from the lowest to highest. All of them are derived from the abstract class of "Employee". Each class allows a specific amount of withdrawal. If the amount is higher than the amount that it can handle, the asset passes the process to one higher authority.

