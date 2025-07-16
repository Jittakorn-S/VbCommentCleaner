# 🧹 VB Comment Cleaner WinApp

**VB Comment Cleaner WinApp** is a lightweight Windows Forms application built with C# that removes comments from VB.NET source code. It uses the Roslyn compiler platform to parse and clean the code, making it easier to analyze or reuse without documentation or inline comments.

---

## 🚀 Features

- 🧼 **Comment Removal**: Automatically strips both regular and documentation comments from VB.NET code.
- 📋 **Clipboard Support**: Copy cleaned code directly to your clipboard.
- ⚡ **Instant Feedback**: Displays cleaned code in real-time after processing.
- 🖥️ **Simple UI**: Easy-to-use Windows Forms interface.

---

## 🛠️ How It Works

1. Paste your VB.NET code into the input textbox.
2. Click the **Clean** button.
3. The app uses Roslyn to parse the code and remove all comment trivia.
4. Cleaned code is displayed in the output textbox.
5. Optionally, click **Copy** to copy the result to your clipboard.

---

## 📦 Dependencies

- .NET Framework / .NET Core
- Microsoft.CodeAnalysis
- Microsoft.CodeAnalysis.VisualBasic

---

## 🧪 Example

**Input:**
```vbnet
' This is a comment
Public Class HelloWorld
    ''' <summary>This is a doc comment</summary>
    Public Sub SayHello()
        Console.WriteLine("Hello, world!") ' Inline comment
    End Sub
End Class
```

**Output:**
```vbnet
Public Class HelloWorld
    Public Sub SayHello()
        Console.WriteLine("Hello, world!")
    End Sub
End Class
```

---

## 📁 Project Structure

```
VBCommentCleanerWinApp/
├── Program 1.cs       # Entry point for the application
├── Form1.cs           # Main form logic and UI event handlers
```

---

## 📄 License

This project is licensed under the MIT License. See the LICENSE file for details.

---
