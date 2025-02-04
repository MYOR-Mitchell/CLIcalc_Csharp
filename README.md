# CLI Calculator (C#)

## Overview
This is my CLI Calculator is a Command-Line Interface (CLI) application built in C#. It allows users to perform basic  operations while following clean build principles and dependency injection.

## Features
- Perform basic calculations (`+`, `-`, `*`, `/`)
- Input handling
- Uses Dependency Injection (DI) for better maintainability
- Loops for continuous use (exit with 'e' keypress)
- Separation of Concerns (Calculator logic, Display, Input Handling)

## Skills Used
- **C#**
- **.NET Core**
- **Dependency Injection** 
- **SOLID Principles**

## Usage
1. Enter two numbers and an operator (`+`, `-`, `*`, `/`).
2. Example Calculation:
   ```
   Enter first number: 10
   Enter operator (+, -, *, /): +
   Enter second number: 5
   Result: 15
   ```
3. To exit, type 'e' when prompted.

## Future Enhancements
- Chained operations(e.g., `5 + 3 - 2`)
- Unit tests
- Support for additional operations (`%`, `^`, `sqrt`)
