# LeetCode 45-Minute Timer

A simple, modern Windows application to help you follow the 45-minute rule when solving LeetCode problems. This timer helps you manage your problem-solving sessions effectively by breaking them down into three phases:

1. **Problem Solving (25 minutes)**
   - Attempt to solve the problem on your own
   - Focus on understanding and implementing a solution

2. **Hint Review (5 minutes)**
   - If stuck, review available hints
   - Consider different approaches

3. **Solution Study (15 minutes)**
   - If still unable to solve, study the solution
   - Understand the optimal approach and implementation

## Features

- 🕒 Automatic phase transitions with audio alerts
- 📌 Always-on-top window for easy visibility
- ⏯️ Start/Pause functionality
- 🔄 Reset timer option
- ⏭️ Skip phase button for flexibility
- 🎨 Modern, clean interface
- 🖥️ High DPI support

## Installation

Two versions are available for download:

1. **Standalone Version (LeetCodeTimer-standalone.exe)**
   - Self-contained executable with no dependencies
   - Larger file size but works on any Windows machine
   - Recommended for most users

2. **Framework-Dependent Version (LeetCodeTimer-requires-dotnet.exe)**
   - Requires .NET 7.0 runtime
   - Smaller file size
   - Suitable if you already have .NET installed

Download your preferred version from the [Releases](../../releases) page.

## Usage

1. **Starting a Session**
   - Launch the application
   - Click "Start" to begin the 25-minute problem-solving phase
   - Timer will automatically progress through all phases

2. **Controls**
   - **Start/Pause**: Toggle timer running state
   - **Reset**: Return to the beginning of the current phase
   - **Skip Phase**: Move to the next phase immediately

3. **Phase Transitions**
   - Audio alerts will play when phases change
   - Current phase is always displayed below the timer
   - Timer automatically moves to the next phase

## Why Use the 45-Minute Rule?

The 45-minute rule helps:
- Prevent getting stuck on problems for too long
- Maintain a structured learning approach
- Balance between independent problem-solving and learning from solutions
- Make efficient use of your practice time

## Building from Source

1. Clone the repository
2. Open in Visual Studio 2022
3. Build and run the solution

Requirements:
- .NET 7.0 SDK
- Windows Forms support

## Contributing

Contributions are welcome! Feel free to:
- Report bugs
- Suggest features
- Submit pull requests

## License

This project is licensed under the MIT License - see the LICENSE file for details. 