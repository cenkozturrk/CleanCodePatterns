# OOP - Abstraction in C#

## Overview

This project demonstrates the concept of **Abstraction** in Object-Oriented Programming (OOP). Abstraction allows you to hide complex implementation details and expose only essential features of an object. In this project, we abstract the concept of a **Vehicle** and create two types of vehicles: `Car` and `Truck`. The program uses abstract methods to define common behaviors (`Start` and `Stop`), while each derived class provides specific implementations for those behaviors.

## Key Features

- An **abstract class** `Vehicle` with properties like `Brand` and `Model`.
- Two **derived classes**:
  - `Car`: Adds a `FuelType` property and overrides the `Start` and `Stop` methods.
  - `Truck`: Adds a `LoadCapacity` property and overrides the `Start` and `Stop` methods.
- Abstract methods `Start()` and `Stop()` that are implemented by each derived class.
- **User input**: The program prompts users to enter details about the vehicles they want to create.
- **Polymorphism**: The `Start()` and `Stop()` methods exhibit polymorphic behavior depending on the type of the vehicle.

## Usage

**Run the program**: Start the program and provide details for a `Car` and a `Truck` by entering the vehicle's brand, model, and other specific details such as `FuelType` for cars and `LoadCapacity` for trucks.
   

