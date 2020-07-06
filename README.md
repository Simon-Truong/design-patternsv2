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

## Abstract Factory Design Pattern
Identical to the Factory Method design pattern, except that the factory returns more than one _product_