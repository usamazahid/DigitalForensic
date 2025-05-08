# 🛡️ Ransomware Simulation & Kaspersky Anti-Ransomware Protection Demo

This project demonstrates a **simulated ransomware attack** created in **C# .NET**, and how **Kaspersky Anti-Ransomware Tool for Business** effectively detects, blocks, and rolls back changes to infected files in real time.
The entire process is showcased in a **Windows 10 virtual machine**.

🎥 **Watch the full video demonstration here:**
[![Kaspersky Anti-Ransomware Demo](https://img.youtube.com/vi/hB4o-M3IXJU/0.jpg)](https://youtu.be/hB4o-M3IXJU)

---

## 📆 Software & Tools Used

| Tool                           | Version                        |
| ------------------------------ | ------------------------------ |
| Windows 10 VM                  | 21H2                           |
| Visual Studio                  | 2022                           |
| .NET Framework                 | 4.x                            |
| Kaspersky Anti-Ransomware Tool | Latest (Free Version)          |
| C# Language                    | .NET Console App               |
| Hypervisor                     | VMware / VirtualBox (optional) |

---

## 🧪 Project Structure

```
RansomwareDemo/
├── RansomwareSimulator/       # C# .NET project simulating ransomware behavior
│   ├── Program.cs
│   └── ...
├── TestFiles/                 # Sample files used for encryption and rollback
├── README.md
└── LICENSE
```

---

## 🚀 How to Use

> ⚠️ **Warning:** This code is for **educational purposes only** and should only be executed in a secure, isolated virtual environment.

### 🔧 Prerequisites

* A Windows 10 virtual machine
* Visual Studio (with .NET Desktop Development workload)
* Kaspersky Anti-Ransomware Tool for Business installed ([Download Here](https://www.kaspersky.com/anti-ransomware-tool))

### 📅 Installation Steps

1. **Clone the Repository**

   ```bash
   git clone https://github.com/your-username/your-repo.git
   cd your-repo
   ```

2. **Open the Project in Visual Studio**

   * Open `RansomwareSimulator.sln`
   * Build the solution

3. **Prepare the Test Files**

   * Create or copy some dummy files into the `TestFiles` folder.
   * These will be targeted by the ransomware simulation.

4. **Run the Simulation**

   * Run the compiled console app.
   * Kaspersky should detect the encryption behavior and block the attack.
   * File rollback will automatically restore affected files.

---

## 📺 Video Demo Highlights

* ✅ Installation of Kaspersky Anti-Ransomware
* 💣 Launching simulated ransomware
* 🔐 Detection & block by Kaspersky
* 🔄 File rollback and recovery

Watch it here: [https://youtu.be/hB4o-M3IXJU](https://youtu.be/hB4o-M3IXJU)

---

## 📚 Disclaimer

> This project is for **educational and research purposes only**. Do not use or distribute the ransomware simulator outside of isolated test environments.

---

## 🙌 Contributions

Pull requests are welcome for improvements, documentation, or extended simulation functionality.

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).
