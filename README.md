# StaticVsSingelton
Static vs Singleton Design Pattern

This is one of the common question which will be asked in interview, apart from following difference - 

-> Singleton objects are stored in Heap, but static objects are stored in stack.
-> We can clone (if the designer did not disallow it) the singleton object, but we can not clone the static class object .
-> Singleton classes follow the OOP (object oriented principles), static classes do not.
-> We can implement an interface with a Singleton class, but a class's static methods (or e.g. a C# static class) cannot.

The main difference is - 
If a method inside the singelton class which does some I/O Operation or Database operation and if particular method needs to be unit tested then we can do it in singelton class but not in static class. 

In this code you will find above implemention. 

