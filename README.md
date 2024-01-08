# Guided Assignment - Introduction to Console.ReadLine in C#

## Introduction
In this assignment, we delve into one of the essential methods in C# programming: `Console.ReadLine()`. This method is used for reading input from the user. Think of it as a way of having a conversation with your program.

`string userInput = Console.ReadLine();`

- Here, `Console.ReadLine()` waits for the user to type something in the console window and press Enter.
- The input is then stored as a string in the variable `userInput`.

---

## Requirements

1. Create a new console application named `GA_ConsoleReadLine_YourName`.
2. Follow the step-by-step instructions.
3. Upload the project to GitHub and submit the repository link in Canvas.

---

### Starting Code
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
    }
}
```

We will work within the `Main` method for this assignment.

---

### **Step 1: Using Console.ReadLine to Capture Input**

After the `Console.WriteLine("What is your name?");` line, use `Console.ReadLine()` to read the user's input.

```csharp
static void Main(string[] args)
{
    Console.WriteLine("What is your name?");

    // Reading user input
    string userName = Console.ReadLine();
} 
```

**Run your code**  
Type your name in the console and press Enter. Notice that the program doesn't do anything with the input yet.

---

### **Step 2: Responding to User Input**

Now, let's make the program respond using the input.

1. After capturing the input, use `Console.WriteLine()` to respond.
2. Concatenate a greeting with the user's name.

```csharp
    // Responding to user input
    Console.WriteLine("Hello, " + userName + "!");
```

**Run your code again**  
This time, after entering your name, you should see a greeting that includes the name you entered.

---

### **Step 3: Adding More Interaction**

Let's add more interaction. Ask the user for their favorite color.

1. Add another `Console.WriteLine()` to ask for the user's favorite color.
2. Use `Console.ReadLine()` to capture the color.

```csharp
    Console.WriteLine("What is your favorite color?");
    string favoriteColor = Console.ReadLine();

    // Responding with the favorite color
    Console.WriteLine("Ah, " + favoriteColor + " is a great color!");
```

**Run your code**  
You should now be able to interact more with your program.

---

### **Step 4: Combining Information**

Finally, let’s combine the information we have from the user.

```csharp
    Console.WriteLine(userName + ", who likes " + favoriteColor + ", welcome to the program!");
```

**Run your code**  
The program now uses both pieces of information in a sentence.

---

### **Step 5: Experiment and Modify**

Encourage students to experiment:
- Ask for different types of information.
- Use different responses.
- Try combining more pieces of information.

---

## Rubric

| Criteria | Description | Points |
|----------|-------------|--------|
| **Project Setup** | Proper creation of a new console application named GA_ConsoleReadLine_YourName. | 20 |
| **Implementation of ReadLine** | Correct usage of `Console.ReadLine()` to capture user input. | 20 |
| **Responding to Input** | Accurate modification of the program to respond to user input. | 20 |
| **Additional Interaction** | Successfully adding more user interaction and capturing additional input. | 20 |
| **Combining Information** | Correctly combining and displaying multiple pieces of user input. | 10 |
| **Code Readability and Comments** | Clear and readable code with comments explaining each step. | 5 |
| **Running Code** | Code compiles and runs without errors. | 5 |
| **Submission** | Successful upload to GitHub and correct submission link provided on Canvas. | 10 |
| **Total** |  | 100 |

Citation:

"Guided Assignment - Introduction to Console.ReadLine in C#," created by ChatGPT for educational purposes, OpenAI, accessed January 7, 2024.