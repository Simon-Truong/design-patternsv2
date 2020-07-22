# Head First Design Patterns

## Strategy Design Pattern
Provides the flexibility to interchange "strategies" or algorithms at runtime by using composition

## Observer Design Pattern
Consists of a "subject" or publisher and "observers" where the observers can subscribe to the subject and receive updates. To receive updates, the observers can either pull the state from the subject, or the subject pushes the updates to the observers. To do a pull, the observer needs a reference of the subject

## Decorator Design Pattern
An approach to adding extensibility to classes. By using "decorators" which IS-A _product_ and HAS-A _product_, we can wrap the initial product with a decorator, and then treat that decorator as a product itself

## Simple Factory Design Pattern
Encapsulation of object creation responsibility, the simple factory creates objects of a certain type i.e IAnimal. It has a create method which uses the static keyword

## Factory Method Design Pattern
Similar to the Simple Factory Design Pattern, it differs in that the factory itself has an interface. This allows flexibility with polymorphism which allows multiple factories. Each factory can have its own distinct behaviour in creating _products_

**Note**: When using this pattern, ensure we pass the factory to the object, we can then change this like the Strategy design pattern, in which we can exchange different factories as need be through composition

## Factory Method Design Pattern (revisited)
Another approach is to have an abstract class that contains an abstract method that is responsible for creating objects. Subclasses will inherit this abstract class, and will have their own implementation of creating objects. This explains the name of the pattern, as the method itself that is inherited will create the objects for the subclass to act upon

## Abstract Factory Design Pattern
Identical to the Factory Method design pattern, except that the factory returns more than one _product_

## Singleton Design Pattern
Singleton is a design pattern with the purpose to have one and only one object. This can be done with the SimpleSingleton implementation, however, this is **not** thread safe. We can make it thread safe with the following implementations:
- Active Singleton: this implementation is not lazy, it will always have an _instance when it is being referred
- Lock Singleton: this singleton uses a lock to keep it thread safe
- Mutex Singleton: this singleton uses a mutex to keep it thread safe

Also includes singleton implementation using C#'s Lazy<T> class

## Command Design Pattern
The Command design pattern focuses on encapsulating a request that will hold enough state to execute a behaviour from a receiver at a later time. What this means is each command will have a reference of their own receiver, which could be anything, and when they need to be executed, the command itself will know how to use the receiver. With the use of abstraction, we are able to decouple the invoker with the receivers, therefore, the invoke only needs to know that the command has an "execute" method, but it does not know how or what is being used. Only the command knows how to use the receiver. This design pattern is also capable of an undo mechanism, if we know how to use a receiver, we also know how to reverse the action. We can also create something called a macro command, this command will hold a reference of a collection of commands and when its execute method is called, it will loop through all commands and run its own execute method.

## Null Object Design Pattern
The Null Object design pattern is used to mitigate null object reference exceptions. This pattern works by being a placeholder of a desired object. Therefore it will have all the characteristics of a desired object, however, it will do nothing when using its methods/fields/properties.

## Adapter Design Pattern
The Adapter design pattern allows the client to treat a incompatible interface as a target interface e.g client wants to use interface A but only interface B is available therefore, we use the Adapter design pattern. We create an intermediatory adapter between the two interfaces, so when the client uses interface A, it is secretly delegating to interface B.

## Facade Design Pattern
A simple design pattern whose sole purpose is to simplify an exposed interface. The Facade design pattern focuses on providing a simple interface to the client, where it itself has references to the sub interfaces, so it will know how to run the business logic. Therefore, we achieve decoupling because the client doesn't know what is being called when calling the facade's methods, only the facade knows what to do with its references. This pattern practices the "Law of Demeter" or "Principle of Lease Knowledge" which states that within a function, the only objects that should be referred to are:
- Objects from the object itself(class's instance fields/properties)
- Objects provided as an argument
- Objects instantiated in the method
By following this principle, we remove further object dependencies, you must not call on object fields/methods after a method returns an object. This adds coupling, instead, we should create a method that deals with business logic associated with the returning object(wrapper class).  

## Template Design Pattern
The Template design pattern encourages code re-usability by providing a "template" for deriving classes. The template(base class) will contain the algorithm or sequence of methods to run, which it will provide some or no implementations. It is therefore up to the derived classes to determine what these implementations are. This pattern also utilizes "hooks" which are essentially optional methods to override, hence, the base class will have an implementation but the deriving class **can** change its behaviour if suitable. The base class will have 3 types of methods
- readonly, which is defined by and only by the base class
- abstract, deriving classes **must** override these methods and provide their own implementations
- hooks, optional methods that can be overridden
This pattern also practices the "Don't call me, I'll call you" principle in which focuses on the base class to call the method, and not the derived class. Essentially, this means that we should only use the method(algorithm) in the base class, which calls the methods in the derived classes

## Iterator Design Pattern
The Iterator design pattern creates a common interface that allows the clients to iterate over a collection regardless of the collection type. What this means is that each class will support its own iterator, which is returned to the client and is used to iterate over its items. Therefore, by providing a common interface, and say for example the requirement is to merge the two collections(differently typed), then we can use one loop to iterate through both collections, as we can just call the commen interface's methods(HasNext() & Next())