# Spider Unity - VR Phobia Treatment Prototype

[![Unity](https://img.shields.io/badge/Unity-2021.3+-black.svg?style=flat&logo=unity)](https://unity3d.com/)
[![C#](https://img.shields.io/badge/C%23-Unity_Scripts-239120.svg?style=flat&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Meta Quest](https://img.shields.io/badge/Meta_Quest-3-1C1E20.svg?style=flat&logo=oculus)](https://www.meta.com/quest/quest-3/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

A Virtual Reality prototype exploring interactive fear-inducing immersive media for potential therapeutic applications, specifically focusing on arachnophobia treatment.

## Overview

This Unity-based VR application creates an immersive environment where virtual spiders crawl toward the user, who can interact with them using Meta Quest 3 hand tracking capabilities. The project was developed as an exploration of Virtual Reality Exposure Therapy (VRET) applications for phobia treatment.

**Note**: This repository contains the initial prototype. For the latest implementation, please refer to the [Spider_Main repository](https://github.com/rk4500/Spider_Main).

## Key Features

- **Hand Tracking Integration**: Utilizes Meta Quest 3's hand tracking for natural interaction
- **Interactive Fear Response**: Users can throw or push spiders away using hand gestures
- **Controlled Environment**: Safe, virtual space for confronting arachnophobia
- **Immersive Experience**: Realistic spider behaviors and movements
- **Gradual Exposure**: Designed to support systematic desensitization

## Technical Implementation

### Platform & Technologies
- Unity Game Engine (2021.3+)
- Meta Quest 3 VR Headset
- Oculus Integration SDK
- Hand tracking SDK integration
- C# scripting for game logic

### Core Mechanics
- Spider AI with approach behaviors
- Physics-based interactions for pushing/throwing
- Hand gesture recognition
- Spatial tracking and room-scale VR support
- Audio feedback system for immersion

## Potential Applications

### Primary Use Case: Virtual Reality Exposure Therapy (VRET)
- Gradual exposure to fear-inducing stimuli
- Controlled environment for therapeutic intervention
- Safe space for patients to confront phobias

### Additional Applications
- **Anxiety Management**: Developing resilience through controlled exposure
- **Cognitive Behavioral Therapy (CBT)**: Integration with therapeutic frameworks
- **Stress Inoculation Training**: Preparation for high-stress situations
- **Research Tool**: Studying psychological responses to fear stimuli
- **Empowerment Through Control**: Allowing users to physically interact with their fears

## Project Context

This prototype was developed as part of research exploring the intersection of VR technology and mental health treatment at FLAME University's School of Computing and Data Sciences. While the accompanying research paper was not completed, the prototype demonstrates the technical feasibility and potential of VR-based phobia treatment systems.

## Research Background

The project investigates how VR can address limitations in traditional exposure therapy:
- Difficulty replicating certain fear scenarios
- Patient reluctance for real-world exposure
- Need for controlled, measurable therapeutic environments
- Accessibility of treatment options

## Future Development Possibilities

- Integration of physiological feedback (heart rate monitoring)
- Dynamic difficulty adjustment based on user response
- Expanded creature library for different phobias
- Therapist dashboard for session monitoring
- Progress tracking and analytics
- Multiplayer support for group therapy sessions

## Technical Requirements

- Unity 2021.3 or later
- Meta Quest 3 or compatible VR headset with hand tracking
- Oculus Integration package
- Sufficient play space for room-scale VR

## Installation & Setup

1. Clone the repository
2. Open the project in Unity 2021.3 or later
3. Import Oculus Integration from the Unity Asset Store
4. Configure XR settings for Meta Quest 3
5. Build and deploy to your VR headset

## Project Structure

```
Spider_Main/
├── Assets/
│   ├── Oculus/              # Oculus SDK integration files
│   ├── Scenes/              # Unity scene files
│   ├── Spider Green/        # Spider models and textures
│   ├── Suyash/
│   │   ├── Animations/      # Spider animation controllers
│   │   ├── Materials/       # Visual materials
│   │   ├── Prefabs/         # Reusable game objects
│   │   ├── Scripts/         # C# game scripts
│   │   └── Sounds/          # Audio files
│   └── XR/                  # VR configuration
├── Packages/                # Unity package dependencies
└── ProjectSettings/         # Unity project configuration

```

## Contributors

- **Suyash Lal** - Development and Implementation
- **Dr. Rahul Kumar Ray** - Research and Conceptualization

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- FLAME University School of Computing and Data Sciences
- Virtual Reality research community
- Open-source VR development tools and libraries

## References

- Albakri, G., et al. (2022). "Phobia exposure therapy using virtual and augmented reality: a systematic review." Applied Sciences, vol. 12, no. 3, p. 1672.

---

**Project Status**: Prototype/Research Exploration    
**Field**: VR Therapy, Human-Computer Interaction, Mental Health Technology