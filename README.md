# Basic C# Programs for Pitman Training

This repository contains C# practice projects created during my personal study at Pitman Training. Each project demonstrates fundamental C# programming concepts and progressively builds programming skills.

## 🎯 Purpose
Personal learning repository for mastering C# fundamentals through hands-on projects.

## 🛠️ Technologies
- **Language:** C# (.NET 10)
- **IDE:** Visual Studio Community 2026 (18.7.1)

## 📂 Projects

### 1. Hello World
**Location:** `Hello_World/`  
**Description:** The classic first program — outputs "Hello World!" to the console.  
**Concepts Covered:**
- Basic console output
- Program entry point structure
- `Console.WriteLine()` method

---

### 2. myConsoleProject
**Location:** `myConsoleProject/`  
**Description:** Interactive console application that prompts the user for their name and displays a personalised welcome message. Defaults to "Guest" if no name is provided.  
**Concepts Covered:**
- User input with `Console.ReadLine()`
- String variables
- String interpolation (`$"{variable}"`)
- Null coalescing operator (`??`)

---

### 3. Writing and Running Code in C# Assignment
**Location:** `Writing and Running Code in C# Assignment/`  
**Description:** Professional greeting application for Acme Accounting Systems demonstrating string formatting and namespace organisation.  
**Concepts Covered:**
- Namespace organisation
- Escape sequences (`\n` for newlines, `\"` for quotation marks)
- Multi-line console output

---

### 4. Math Challenge
**Location:** `Math Challenge/`  
**Description:** Demonstrates all four basic arithmetic operations using integer variables, printing each calculation and its result to the console.  
**Concepts Covered:**
- Integer variables (`int`)
- Arithmetic operators (`+`, `-`, `*`, `/`)
- String interpolation for formatted output

---

### 5. String Assignment
**Location:** `String assignment/`  
**Description:** Explores string manipulation by concatenating multiple words into a sentence, converting the result to uppercase, and building a multi-sentence paragraph using `StringBuilder`.  
**Concepts Covered:**
- String concatenation (`+`)
- `string.ToUpper()` method
- `StringBuilder` class (`System.Text`)
- `StringBuilder.Append()` and `ToString()`

---

### 6. Daily Report Assignment
**Location:** `Daily Report Assignment/`  
**Description:** A student daily report form for the Academy of Learning Career College. Collects the student's name, course, page number, help requirements, experiences, feedback, and study hours, then displays a formatted summary. Includes input validation loops for numeric and boolean fields.  
**Concepts Covered:**
- Multiple data types (`string`, `int`, `bool`)
- `int.TryParse()` and `bool.TryParse()` for safe input validation
- `while` loops for re-prompting on invalid input
- String interpolation for summary output

---

### 7. Branching Assignment Submission
**Location:** `Branching Assignment Submission/`  
**Description:** A shipping cost calculator for "Package Express". Accepts package weight and dimensions, rejects packages that exceed weight or size limits, and calculates a shipping quote based on volume and weight.  
**Concepts Covered:**
- `if` statements and branching logic
- Early `return` to exit on invalid input
- `decimal` data type for precise calculations
- Arithmetic expressions and formatted output (`"F2"`)

---

### 8. Boolean Logic Assignment
**Location:** `Boolean Logic Assignment/`  
**Description:** A car insurance eligibility checker. Collects the applicant's age, DUI history, and number of speeding tickets, then evaluates all three conditions together to determine if they qualify.  
**Concepts Covered:**
- `bool` variables and boolean expressions
- Logical AND operator (`&&`)
- Compound conditions
- `if`/`else` branching based on boolean results

---

## 🚀 How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/Thomas-B04/Basic_C_Sharp_Programs_For_Pitman_Training.git
   ```

2. Open the desired project folder's `.sln` or `.slnx` file in Visual Studio 2026 or later

3. Press `F5` to build and run, or use the terminal:
   ```bash
   dotnet run
   ```

## 📚 Learning Progress
These projects represent the foundational stages of C# learning, covering:
- ✅ Console I/O operations
- ✅ Variables and data types (`string`, `int`, `bool`, `decimal`)
- ✅ String manipulation and `StringBuilder`
- ✅ Arithmetic operators
- ✅ Input validation (`TryParse`, `while` loops)
- ✅ Branching (`if`/`else`, early `return`)
- ✅ Boolean logic and compound conditions
- ✅ Basic program and namespace structure

## 👤 Author
**Thomas** 
Personal study repository for Pitman Training coursework

## 📝 License
This is a personal learning repository. All code is for educational purposes.

---
