# ❌⭕ Tic-Tac-Toe: The Polyglot Project

> A "Hello World" to game logic.

## 📖 About
This repository documents my journey learning different programming languages by implementing the exact same application in each one: a terminal-based **Tic-Tac-Toe** game.

The logic remains consistent (3x3 grid, turn-based loop, win detection), but the implementation details highlight the unique syntax, memory management, and input handling of each language.

## ✨ Features
* **Terminal Only:** No GUIs, just raw logic and standard I/O.
* **Game Modes:**
  * 🆚 **PvP:** Hotseat multiplayer.
  * 🤖 **PvC:** Play against a Randomized Computer opponent.
* **Input Validation:** Prevents overwriting moves or crashing on non-numeric input.
* **Artificial Delay:** Computer "thinks" before moving to improve UX.
* **Win/Draw Detection:** Checks rows, columns, and diagonals.

## 🛠️ Implementation Status

| Language              | Status    | File Location         | Key Concepts Used                     |
| :---                  | :---:     | :---                  | :---                                  |
| **C**                 | ⬜ Todo   | `/c/main.c`           | Pointers, Headers, Memory Mgmt        |
| **C++**               | ⬜ Todo   | `/cpp/main.cpp`       | Pointers, Headers, Memory Mgmt        |
| **C# (.NET)**         | ⏳ In-Progress   | `/csharp/TikTacToe/Program.cs`  | Classes, Arrays, `Console.ReadLine`   |
| **Python**            | ⬜ Todo   | `/python/main.py`     | Lists, `input()`, `try/except`        |
| **JavaScript**        | ⬜ Todo   | `/js/index.js`        | Node.js, Async Input (`readline`)     |
| **Rust**              | ⬜ Todo   | `/rust/main.rs`       | Ownership, Borrowing, `Result`        |
| **Go**                | ⬜ Todo   | `/go/main.go`         | Slices, Structs, fmt                  |


## 🚀 How to Run

### C

```bash
cd c
gcc main.c -o tictactoe
./tictactoe
```

### C++

```bash
cd cpp
g++ main.cpp -o tictactoe
./tictactoe
```

### C#

```bash
cd csharp
dotnet run
```

### Python
```bash
cd python
python main.py
```

### JavaScript (Node.js)

```bash
cd js
node index.js
```

## 🧠 Learning Notes

*Differences I observed while porting the logic:*

## 🤝 Contributing

If you spot a bug or a more idiomatic way to write the code in a specific language, feel free to open a Pull Request!

## 📄 License

MIT
