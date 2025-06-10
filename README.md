# ![Build Status](https://img.shields.io/badge/build-passing-brightgreen) ![License](https://img.shields.io/badge/license-none-lightgray) ![Language](https://img.shields.io/badge/language-C%23-blue) ![Framework](https://img.shields.io/badge/.NET-9.0-blue)

# .NetArcCourse

A comprehensive collection of C# tutorials, exercises, and sample projects demonstrating core programming concepts, object-oriented programming, data structures, algorithms, and application development using the .NET 9.0 framework.

This repository serves as an educational resource for learning C# and .NET, showcasing various programming paradigms such as inheritance, polymorphism, interfaces, exception handling, multithreading, and more through practical examples.

---

## Key Features

- **Educational exercises** covering fundamental programming concepts
- **Object-Oriented Programming**: inheritance, polymorphism, interfaces, constructors, and abstract classes
- **Data Structures**: arrays, lists, multidimensional arrays
- **Control Structures**: loops (`for`, `while`, `foreach`), conditionals (`if-else`, `switch`)
- **Advanced Concepts**: generics, method overloading/overriding, type casting, exception handling
- **Application Samples**: simple calculators, file I/O, logging, game logic, and more
- **Modular structure**: organized into directories per topic with dedicated sample files

---

## Tech Stack

| Technology | Description | Logo |
|--------------|----------------|--------|
| ![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white) | Programming language used for all projects | ![C# Logo](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white) |
| ![.NET 9.0](https://img.shields.io/badge/.NET-9.0-blue?style=flat&logo=.NET) | Framework for building and running C# applications | ![.NET Logo](https://img.shields.io/badge/.NET-9.0-blue?style=flat&logo=.NET) |
| ![Visual Studio Code](https://img.shields.io/badge/VS_Code-007ACC?style=flat&logo=visual-studio-code&logoColor=white) | Recommended IDE for development | N/A |

---

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) installed on your machine
- A code editor such as [Visual Studio Code](https://code.visualstudio.com/) or Visual Studio

---

## Installation

1. **Clone the repository**

```bash
git clone https://github.com/69killian/.NetArcCourse.git
cd .NetArcCourse
```

2. **Navigate to a specific project folder**

Each folder contains a C# console application. For example:

```bash
cd array-of-objects
```

3. **Restore dependencies**

Most projects are simple console apps that rely on the .NET SDK. Run:

```bash
dotnet restore
```

4. **Build the project**

```bash
dotnet build
```

---

## Usage

### Running individual projects

Navigate to the desired project directory and execute:

```bash
dotnet run
```

### Examples

- To run the **Facture** example:

```bash
cd Facture
dotnet run
```

- To run the **Calculator**:

```bash
cd calculator
dotnet run
```

### Environment setup

No special environment variables are required. Some projects involve file I/O or logging, so ensure the directories (like `logs/`) exist or are created by the code.

---

## Project Structure Overview

```plaintext
. NetArcCourse/
├── 1h-exercice/                 # Basic C# exercises and simple programs
├── 2h-exercice/                 # Logic and control flow exercises
├── 3h-exercice/                 # Advanced control flow exercises
├── abstract-classes/             # Demonstrations of abstract classes
├── arithmetic/                   # Basic arithmetic operations
├── array-of-objects/             # Arrays of objects and iteration
├── arrays/                       # Simple array manipulation
├── calculator/                   # Basic calculator console app
├── calculator-program/           # Calculator with user input
├── classes/                      # Classes and object instantiation
├── conditional-operators/        # Ternary conditional examples
├── constructor/                  # Constructor usage examples
├── constructor-car/              # Car class with constructor
├── enums/                        # Enum types and usage
├── exception-handling/           # Try-catch exception handling
├── Facture/                      # Invoice classes with polymorphism
├── for-loop/                     # For loop exercises
├── foreach/                      # Foreach loop examples
├── generics/                     # Generics and type-safe collections
├── getters-setters/              # Auto-implemented properties
├── if-else/                      # Conditional statements
├── inheritance/                  # Basic inheritance
├── inheritance-polymorphism/     # Polymorphism with base and derived classes
├── integers-sum/                 # Summation of integers
├── interfaces/                   # Interface implementation examples
├── jeu-de-plateau/               # Simple board game logic
├── Lecture-ecriture/              # File reading and writing
├── list-of-objects/              # List collection usage
├── logical-operators/            # Logical operators in conditions
├── math-class/                   # Math functions and calculations
├── method-overloading/           # Multiple methods with same name
├── method-overriding/            # Override base class methods
├── methods/                      # Static methods examples
├── multidimentional-arrays/       # 2D arrays and nested loops
├── multiplication-table/         # Multiplication table generator
├── multithreading/               # Basic multithreading with threads
├── nested-loops/                 # Nested loops exercises
├── number-game/                  # Guess the number game
├── object-as-argument/           # Passing objects to methods
├── output/                       # Program output examples
├── overloaded-constructors/      # Constructor overloading
├── pair-numbers-addition/        # Summation of pairs
├── params-keyword/               # Params keyword usage
├── password-generator/           # Password generator app
├── polymorphism/                 # Polymorphism with base and derived classes
├── random-numbers/               # Random number generation
├── return-keyword/               # Return statement examples
├── rock-paper/                   # Rock-Paper-Scissors game
├── static/                       # Static class and members
├── string-interpolation/         # String interpolation examples
├── string-methods/               # String manipulation methods
├── switches/                     # Switch statement examples
├── to-string-method/             # Override ToString()
├── type-casting/                 # Type conversions
├── user-input/                   # User input handling
├── variables/                    # Variable declarations
├── while-loop/                   # While loop exercises
```

---

## Contributing

Contributions are welcome! Feel free to fork the repository, submit issues, or create pull requests with improvements, new exercises, or additional examples. Please ensure your contributions follow the existing code style and are well-documented.

---

## Notes

- Many projects are simple console applications designed for educational purposes.
- To run a specific project, navigate to its folder and execute `dotnet run`.
- The codebase is primarily focused on demonstrating C# language features and programming concepts within the .NET 9.0 environment.

---

*Happy coding! 🚀*
