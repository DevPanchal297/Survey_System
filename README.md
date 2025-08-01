# 🧠 Survey_System Console App

**Survey_System** is a modular, .NET 8 Console Application designed to manage and conduct smart surveys efficiently. It captures user demographics, segments them dynamically, and delivers age-appropriate survey questions, all from a command-line interface.

---

## 🚀 Features

- 📋 Interactive survey intake form with validation  
- 🧠 Dynamic segmentation based on age and income  
- ❓ Tailored survey questions per user group (Student, Professional, Retired)  
- 💾 In-memory response storage  
- 📊 Summary report with survey insights  
- 🛡️ Robust input validation and exception handling  

---

## 📦 Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

---

## 🛠️ Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/DevPanchal297/Survey_System.git
   cd Survey_System/Survey_System/Survey_System
   ```

2. **Build the project:**
   ```bash
   dotnet build
   ```

3. **Run the application:**
   ```bash
   dotnet run
   ```

---

## 💡 Usage

Follow the on-screen prompts to:
- Enter user details  
- Answer personalized survey questions  
- View survey results at the end of the session  

The app handles incorrect inputs gracefully and guides users to enter valid data.

---

## 🧪 Sample Input & Output

**Input Example:**
```
Enter your name: Dev
Enter your age: 24
Enter gender (Male/Female/Other): Male
Enter your location (optional): Mumbai
Enter your monthly income: 45000
```

**System Output:**
```
User Segmented As: Professional | Mid Income

Survey:
1. Are you satisfied with your job? → Yes
2. Do you work remotely? → Sometimes

Thank you! Your responses have been recorded.
```

**Final Report Summary:**
```
Total Users Surveyed: 3

Segment Breakdown:
- Students: 1
- Professionals: 2
- Retired: 0

Survey Responses:
Dev (Professional):
- Are you satisfied with your job? → Yes
- Do you work remotely? → Sometimes
```

---

## 🧠 Concepts Practiced

- **Enums** for Gender and Age Group  
- **Control Flow** using `if`, `switch`, `while`, `foreach`  
- **Exception Handling** using `try-catch`, `TryParse`, `Enum.TryParse`  
- **Collections**: `List<T>`, `Dictionary<K,V>` for response mapping  
- **Object-Oriented Design** using modular classes  
- **Separation of Concerns** for profile intake, segmentation, survey, and storage  

---

## 🧰 Tech Used

- **.NET 8 Console Application**  
- **C#** (Object-Oriented Programming)  
- **In-Memory Storage** (`List`, `Dictionary`)  
- (Optional) **System.Text.Json** for file export  
- **Exception Handling** & **User Input Validation**

---

## 🤝 Contributing

Contributions are welcome! Feel free to:
- Fork the repository  
- Submit a pull request with improvements or bug fixes

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

## 👤 Author

**Dev Panchal**  
📧 [devpanchal1452@gmail.com](mailto:devpanchal1452@gmail.com)  
🌐 [GitHub](https://github.com/DevPanchal297)

---
