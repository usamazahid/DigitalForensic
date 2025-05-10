# 🛡️ Ransomware Simulation & Kaspersky Anti-Ransomware Protection Demo

This project demonstrates a **simulated ransomware attack** created in **C# .NET**, and how **Kaspersky Anti-Ransomware Tool for Business** effectively detects, blocks, and rolls back changes to infected files in real time.
The entire process is showcased in a **Windows 10 virtual machine**.

🎥 **Watch the full video demonstration here:**
[![Kaspersky Anti-Ransomware Demo](https://img.youtube.com/vi/hB4o-M3IXJU/0.jpg)](https://youtu.be/hB4o-M3IXJU)

---

## 📚 Table of Contents

* [Software & Tools Used](#-software--tools-used)
* [Project Structure](#-project-structure)
* [How to Use](#-how-to-use)
* [Video Demo Highlights](#-video-demo-highlights)
* [Deep Freeze Demonstration (2-Part Series)](#-deep-freeze-demonstration-2-part-series)
* [Disclaimer](#-disclaimer)
* [Contributions](#-contributions)
* [License](#-license)

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
| Deep Freeze                    | Latest (Standard)              |

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
   git clone https://github.com/usamazahid/DigitalForensic.git
   cd DigitalForensic
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

🎥 [Watch it here](https://youtu.be/hB4o-M3IXJU)

---

## 🧊 Deep Freeze Demonstration (2-Part Series)

This section demonstrates the behavior of **Deep Freeze** in protecting system drives against unwanted changes.

### 🔹 Part 1: Installation & Setup

📺 [Watch on YouTube](https://youtu.be/KnLWQDQDQmA)

* Installing Deep Freeze on Windows 10
* Understanding Frozen vs Thawed drives

### 🔹 Part 2: File Persistence Test

📺 [Watch on YouTube](https://youtu.be/rmlSk37btHA)

* File created in Thawed drive persists after reboot ✅
* File copied to Frozen drive is erased on reboot ❌
* Demonstrates how Deep Freeze maintains system integrity

> Deep Freeze is especially useful for maintaining public or lab computers in a consistent, clean state.

---

## 📚 Disclaimer

> This project is for **educational and research purposes only**. Do not use or distribute the ransomware simulator outside of isolated test environments.

---

## 🙌 Contributions

Pull requests are welcome for improvements, documentation, or extended simulation functionality.

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

![GitHub Repo stars](https://img.shields.io/github/stars/usamazahid/DigitalForensic?style=social)
![GitHub forks](https://img.shields.io/github/forks/usamazahid/DigitalForensic?style=social)
![GitHub license](https://img.shields.io/github/license/usamazahid/DigitalForensic)
