# Sign Language Interpreter for Mute People

This project is titled **Sign Language Interpreter for Mute People** and was developed by **Nooruddin Noonari** as a Final Year project at **Sukkur IBA University** under the Bachelor of Science in Computer Science program.

## Project Overview

The Sign Language Interpreter is a system designed to bridge the communication gap between mute/deaf individuals and those who can speak and hear. The system takes input in the form of Pakistan Sign Language (PSL) gestures and converts them into both audible and readable text formats. This allows a mute/deaf person to communicate more effectively with others.

## Features

- **Gesture Detection:** The system uses motion detection to identify gestures made by a user. This feature simulates the role of a Kinect sensor for detecting hand movements.
- **Sign Language to Text Conversion:** Detected gestures are converted into textual form, making it easier for others to understand the intended message.
- **Text to Speech Conversion:** The textual interpretation is further converted into speech, allowing a mute/deaf person to "speak" through the system.
- **Voice to Sign Language Conversion:** The system also supports converting spoken language back into text and corresponding sign language, enabling two-way communication.

## Project Scope

Due to time constraints and project scope, the system focuses on emergency and need-based communication scenarios. The core functionality is geared towards enabling basic communication, with additional features to be implemented in future work.

## Technical Approach

1. **Motion Detection System:** Simulates the detection of hand gestures.
2. **Sign Language Synthesis Database:** Holds the mappings of gestures to their corresponding text meanings.
3. **Sign Language to Text Converter:** Converts detected gestures into text.
4. **Text to Speech Converter:** Uses the System.Speech library in C# to convert the interpreted text into audible speech.

### Simplified Workflow

- The user performs a gesture in front of the system.
- The system detects the gesture using the motion detection module.
- The detected gesture is then converted into text using a predefined database of sign language mappings.
- The text is finally converted into speech and outputted through the system's speakers.

## System Flow
(![image](https://github.com/user-attachments/assets/db0541ef-7e1a-49f7-a716-7ccc02f97f91)
![Gesture Detection](./path-to-your-image2.png)
![Sign Language Interpreter Interface](./path-to-your-image3.png)

## How to Run the Project

1. **Prerequisites:**
   - Visual Studio (2019 or later recommended)
   - .NET Framework 4.7.2 or later
   - Reference to `System.Speech` for text-to-speech functionality

2. **Steps:**
   - Clone the repository to your local machine.
   - Open the solution file in Visual Studio.
   - Build the project to restore any necessary NuGet packages.
   - Run the project using `F5` or by selecting "Start" in Visual Studio.

## Future Work

- **Gesture Library Expansion:** Integrating a broader set of gestures to cover more comprehensive communication.
- **Real-Time Interaction:** Enhancing the system to support real-time conversation between a mute/deaf person and a hearing person.
- **Voice to Sign Language Conversion:** Improving the system's ability to interpret spoken language back into sign language for two-way communication.

## Author

**Nooruddin Noonari**

- LinkedIn: [Your LinkedIn Profile URL]
- Email: [Your Email Address]

This project was developed as a part of my undergraduate studies in Computer Science at Sukkur IBA University.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
