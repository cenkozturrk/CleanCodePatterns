# Factory Method Pattern

## Overview
The Factory Pattern is a creational design pattern used to create objects without specifying the exact class of object that will be created. It allows a class to delegate the responsibility of creating objects to subclasses or a factory class, making the system more flexible and decoupled.

## Key Features
- The program prompts them to choose a shipping method: standard, expedited, or international.
- Based on the input, the program uses the ShippingFactory to create the correct shipping method object.
- The chosen shipping method's ShipPackage method is called, and a message is displayed with the estimated delivery time.

