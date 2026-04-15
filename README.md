<div align="center">

<!-- HERO BANNER -->
<img src="Assets/Sprites/ArMainMenu/Ar Main Menu 1.png" alt="AR Dragon Quest Banner" width="100%"/>

<br/>

```
░█████╗░██████╗░  ██████╗░██████╗░ █████╗ ██████╗░ ██████╗░ ███╗  ████╗    ██████╗ ███████╗███████╗████████╗
██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗██╔══██╗██╔════╝ ██╔═══██╗████╗ ██╔═╝   ██║   ██║██╔════╝██╔════╝╚══██╔══╝
███████║██████╔╝  ██║  ██║██████╔╝███████║██║  ███╗██║   ██║██╔██╗██║     ██║   ██║█████╗  ███████╗   ██║   
██╔══██║██╔══██╗  ██║  ██║██╔══██╗██╔══██║██║   ██║██║   ██║██║╚████║     ██║ ████║██╔══╝  ╚════██║   ██║   
██║  ██║██║  ██║  ██████╔╝██║  ██║██║  ██║╚██████╔╝╚██████╔╝██║ ╚███║     ╚██████╔╝███████╗███████║   ██║   
╚═╝  ╚═╝╚═╝  ╚═╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚══╝      ╚═══██╝ ╚══════╝╚══════╝   ╚═╝   
```

# 🐉 AR Dragon Quest

### *Summon the Dragon. Command the Skies. Experience the Legend — In Your World.*

<br/>

[![Unity](https://img.shields.io/badge/Unity-6.3%20LTS-000000?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com/)
[![Android](https://img.shields.io/badge/Android-ARCore-3DDC84?style=for-the-badge&logo=android&logoColor=white)](https://developers.google.com/ar)
[![XR](https://img.shields.io/badge/XR-OpenXR%20%2B%20ARFoundation-5C2D91?style=for-the-badge&logo=microsoft&logoColor=white)](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@latest)
[![Platform](https://img.shields.io/badge/Platform-Android-green?style=for-the-badge&logo=android)](https://play.google.com/)
[![License](https://img.shields.io/badge/License-MIT-blue?style=for-the-badge)](LICENSE)
[![Stars](https://img.shields.io/github/stars/iamyasirqureshi/AR-Dragon-Game?style=for-the-badge&color=gold)](https://github.com/iamyasirqureshi/AR-Dragon-Game/stargazers)

<br/>

> **"Point your camera. Scan the image. Watch the dragon rise."**  
> A fully immersive AR experience powered by Unity 6 — featuring a living, breathing, fire-breathing dragon that inhabits *your* real world.

<br/>

---

</div>

<br/>

## 🌌 Table of Contents

| # | Section |
|---|---------|
| 1 | [✨ Overview](#-overview) |
| 2 | [🎮 Gameplay Features](#-gameplay-features) |
| 3 | [📱 Screenshots & Demo](#-screenshots--demo) |
| 4 | [🛠 Tech Stack](#-tech-stack) |
| 5 | [📁 Project Structure](#-project-structure) |
| 6 | [⚙️ Setup & Installation](#️-setup--installation) |
| 7 | [🎯 How to Play](#-how-to-play) |
| 8 | [🔊 Audio System](#-audio-system) |
| 9 | [🐉 Dragon System](#-dragon-system) |
| 10 | [🤝 Contributing](#-contributing) |
| 11 | [👤 Author](#-author) |

---

<br/>

## ✨ Overview

**AR Dragon Quest** is a next-generation **Augmented Reality mobile game** built with **Unity 6.3 LTS** and **ARCore/ARFoundation**. The game brings a legendary blue dragon to life in your real-world environment — respond to your commands, breathe fire on demand, and fill the air with its thunderous roar.

Scan a custom **reference image** to anchor the dragon in physical space. Use an on-screen joystick to control movement and rotation, trigger fire attacks with a dedicated button, and experience spatial 3D audio that fades realistically over **up to 10 metres**.

This project merges **game design**, **AR development**, and **cinematic audio** into a single polished Android experience — complete with a **Game of Thrones-inspired theme** for the main menu.

<br/>

---

## 🎮 Gameplay Features

<div align="center">

| 🔥 Feature | 📋 Description |
|:---:|---|
| 🐉 **Image-Based AR Tracking** | Scan a reference image to spawn the dragon in your real-world environment using ARCore |
| 🕹️ **Dynamic Joystick Control** | Dual-mode joystick (dynamic + fixed) for smooth dragon movement & rotation in AR space |
| 🔥 **Fire Breathing Attack** | Tap the fire button to unleash real-time particle fire effects from the dragon's mouth |
| 🔊 **Immersive 3D Spatial Audio** | Dragon roar with 3D sound falloff — full volume up close, fading to silence at ~10 metres |
| 📐 **Min/Max Dragon Scaling** | Scale the dragon from miniature desktop companion to room-filling beast |
| 🎵 **Game of Thrones Theme** | Epic GOT-inspired background music on the main menu — sets the legendary atmosphere |
| 🖼️ **Cinematic Main Menu** | Full-screen illustrated main menu with animated splash and glowing PLAY button |
| 🚪 **Quick Exit Control** | Always-visible EXIT button for fast session termination |
| 🎬 **Animated Dragon Model** | Rigged & animated dragon using the Terrorbring animator controller with full skeletal rig |
| 📡 **XR Interaction Manager** | Full Unity XR Foundation setup for cross-device AR compatibility |

</div>

<br/>

---

## 📱 Screenshots & Demo

<div align="center">

### 🏠 Main Menu
> *Epic splash screen with GOT music and animated dragon artwork*

<table>
<tr>
<td align="center"><b>Splash Screen</b></td>
<td align="center"><b>Unity Editor — Main Menu Scene</b></td>
</tr>
<tr>
<td><img src="Assets/Sprites/ArMainMenu/Ar Main Menu 1.png" width="250" alt="Main Menu Splash"/></td>
<td><em>[ See images 6 & 7 in editor screenshots ]</em></td>
</tr>
</table>

---

### 🐉 In-Game AR Dragon

> *Dragon spawned in the real world via image tracking*

| Gameplay View | Editor Preview |
|:---:|:---:|
| Dragon attacking in real room | Dragon model in Unity Scene view |

---

### 📲 On-Device Experience
> *Tested live on Android — dragon rendered over real surfaces*

</div>

<br/>

---

## 🛠 Tech Stack

```
┌─────────────────────────────────────────────────────────────────┐
│                     AR DRAGON QUEST — STACK                     │
├──────────────────────┬──────────────────────────────────────────┤
│  Engine              │  Unity 6.3 LTS (6000.3.7f1) + DX12      │
│  AR Framework        │  Unity ARFoundation + Google ARCore      │
│  XR SDK              │  OpenXR + XRI (XR Interaction Toolkit)   │
│  Language            │  C# (.NET / Mono)                        │
│  Target Platform     │  Android (ARM64)                         │
│  Audio               │  Unity Audio Source (3D Spatial)         │
│  Animation           │  Mechanim Animator + Terrorbring Rig     │
│  UI Framework        │  Unity UGUI + Canvas / Rect Transform    │
│  Physics             │  Unity Rigidbody + Colliders             │
│  Build System        │  IL2CPP + Gradle (Android)               │
│  VCS                 │  Git + Unity VCS                         │
└──────────────────────┴──────────────────────────────────────────┘
```

**Language Breakdown:**
```
C++     ████████████████████████████████████████  87.1%
C#      ████████                                  12.9%
ShaderLab / CMake / HLSL / C#  <1% each
```

<br/>

---

## 📁 Project Structure

```
AR-Dragon-Game/
│
├── 📁 Assets/
│   ├── 📁 Scenes/
│   │   ├── 🎬 Main Menu          # Splash screen + GOT music
│   │   └── 🎮 Level1             # AR gameplay scene
│   │
│   ├── 📁 Scripts/
│   │   ├── 🐉 DragonController.cs      # Movement, speed, rotation
│   │   ├── 🔥 DragonFireController.cs  # Fire particle trigger logic
│   │   ├── ⚔️  DragonAttack.cs         # Attack animation handler
│   │   ├── 🔊 DragonAudioStart.cs      # Spatial audio init on AR start
│   │   ├── 🎮 MainMenu.cs             # Scene loader + UI logic
│   │   └── 🚪 ExitButton.cs           # App exit handler
│   │
│   ├── 📁 Sprites/
│   │   ├── 📁 ArMainMenu/         # Main menu background artwork
│   │   ├── 📁 Joysticks/          # All joystick axis/handle sprites
│   │   └── 📁 DragonIcon/         # UI dragon icons
│   │
│   ├── 📁 Audio/
│   │   ├── 🔊 Dragon Roar         # 3D spatial dragon roar audio
│   │   ├── 🎵 GOT                 # Game of Thrones theme
│   │   └── 🔥 DragonAttack        # Fire breath SFX
│   │
│   ├── 📁 Prefabs/
│   │   ├── 🐉 Blue (Dragon)       # Main dragon prefab with all components
│   │   ├── 🔥 FireEffect          # Particle fire prefab
│   │   └── 🕹️  Joysticks          # Dynamic/Fixed/Floating joystick prefabs
│   │
│   ├── 📁 XR/                     # ARFoundation + XRI config
│   ├── 📁 XRI/                    # Input action maps
│   ├── 📁 LiteFireEffect/         # Lightweight fire shader
│   ├── 📁 TextMesh Pro/           # TMP font assets
│   └── 📁 ReferenceImageLibrary   # AR tracking image(s)
│
├── 📁 ProjectSettings/            # Unity project settings
├── 📁 Packages/                   # Package manifest
├── 📁 UserSettings/               # Local editor preferences
├── 📄 .gitignore
├── 📄 AR Dragon Quest.apk         # Release APK
└── 📄 README.md
```

<br/>

---

## ⚙️ Setup & Installation

### 📋 Prerequisites

Before cloning, make sure you have the following installed:

| Tool | Version | Link |
|------|---------|------|
| **Unity Hub** | Latest | [Download](https://unity.com/download) |
| **Unity Editor** | 6.3 LTS (6000.3.7f1) | Via Unity Hub |
| **Android Build Support** | Included in Unity | Module in Unity Hub |
| **Android SDK / NDK** | API Level 24+ | Via Unity or Android Studio |
| **Git** | Any | [Download](https://git-scm.com/) |
| **ARCore Compatible Device** | Android 7.0+ | [Device List](https://developers.google.com/ar/devices) |

---

### 🚀 Clone & Open

```bash
# 1. Clone the repository
git clone https://github.com/iamyasirqureshi/AR-Dragon-Game.git

# 2. Open Unity Hub → Add → Browse to cloned folder
# 3. Open with Unity 6.3 LTS
# 4. Allow Unity to import all packages (may take a few minutes)
```

---

### 🔧 Build for Android

```
1. File → Build Settings
2. Select Platform: Android
3. Click "Switch Platform"
4. Player Settings:
   ├── Minimum API Level: Android 7.0 (API 24)
   ├── Target API Level: Android 14 (API 34)
   ├── Graphics API: OpenGL ES 3.0 / Vulkan
   └── IL2CPP Scripting Backend (recommended)
5. Enable:
   ├── XR Plug-in Management → ARCore
   └── Custom Main Manifest (for ARCore meta-data)
6. Click "Build & Run" with device connected via USB
```

---

### 📲 Install Pre-built APK

If you just want to try the game without building:

```bash
# Enable USB Debugging on your Android device
# Connect via USB, then:
adb install AR\ Dragon\ Quest.apk
```

> ⚠️ **Note:** Your device must support **Google ARCore**. Check the [supported devices list](https://developers.google.com/ar/devices).

<br/>

---

## 🎯 How to Play

```
┌──────────────────────────────────────────────────────────┐
│                    GAME FLOW                             │
│                                                          │
│   [Launch App]                                           │
│        │                                                 │
│        ▼                                                 │
│   [Main Menu]  ──── 🎵 GOT Theme plays automatically     │
│        │                                                 │
│        ▼  (tap PLAY)                                     │
│   [AR Session Starts]  ──── Camera opens                 │
│        │                                                 │
│        ▼                                                 │
│   [Scan Reference Image]  ──── Point camera at image     │
│        │                                                 │
│        ▼                                                 │
│   [Dragon Spawns in AR]  ──── 🐉 Dragon appears!         │
│        │                                                 │
│        ├──── 🕹️  Left Joystick: Move dragon               │
│        ├──── 🔥  Fire Button (top-right): Breathe fire    │
│        ├──── 📐  Pinch gesture: Scale dragon up/down      │
│        ├──── 🔊  Move closer: Hear louder roar            │
│        └──── 🚪  EXIT button: Return to menu              │
└──────────────────────────────────────────────────────────┘
```

### 🕹️ Controls Reference

| Control | Action |
|---------|--------|
| **🟢 Green Joystick** | Move dragon forward/backward/strafe |
| **🔴 Fire Button** | Trigger fire breath particle attack |
| **Pinch In/Out** | Scale dragon (miniature ↔ giant) |
| **Walk toward dragon** | Hear louder spatial roar (3D audio) |
| **🔴 EXIT Button** | Exit AR session |

<br/>

---

## 🔊 Audio System

The audio design is one of the most immersive aspects of AR Dragon Quest:

```
Dragon Roar — 3D Spatial Audio
──────────────────────────────
📍 Source: Dragon's mesh position
🔊 Volume: 0.7 (looped, plays on awake)
📡 Spatial Blend: 1.0 (fully 3D)
📏 Min Distance: 0 m (full volume)
📏 Max Distance: 10 m (silent at 10m+)
🎚️ Priority: 128
🔄 Loop: ✅ Enabled

GOT Theme — Main Menu
──────────────────────
🎵 Audio Clip: GOT (Game of Thrones theme)
📍 Source: DragonSound GameObject
🔊 Volume: 0.8 (ambient, stereo)
📡 Spatial Blend: 0 (2D — fills screen)
🔄 Loop: ✅ Enabled
▶️  Play On Awake: ✅

Dragon Attack SFX
──────────────────
🔥 Triggered: On fire button press
⚡ One-shot: Non-looping burst
```

<br/>

---

## 🐉 Dragon System

The **Blue Dragon** prefab is the heart of the game. It combines multiple Unity components into a cohesive living creature:

```
Blue (Dragon Prefab)
├── 🎨 Animator Component
│   ├── Controller: Terrorbring (full skeletal animation)
│   ├── Avatar: DragonTer
│   ├── Clip Count: 4
│   ├── Curves: 148 Quat / 328 Euler / 0 Scale
│   └── Update Mode: Normal
│
├── 🎮 DragonController (Script)
│   ├── Speed: 0.5
│   └── Rotation Speed: 10
│
├── 🔊 AudioSource (Dragon Roar)
│   ├── Clip: Dragon Roar
│   ├── 3D Spatial Blend: 1.0
│   └── Max Distance: 10m
│
├── 🔊 DragonAudioStart (Script)
│   └── Initializes audio on AR tracking begin
│
├── ⚔️  DragonAttack (Script)
│   └── Triggers attack animation + SFX
│
├── 🔥 DragonFireController (Script)
│   ├── Fire Effect: FireEffect (Particle Prefab)
│   └── Spawns fire from dragon mouth on command
│
└── ⚙️  Rigidbody
    ├── Mass: 1
    ├── Linear Damping: 0
    └── Angular Damping: 0.05
```

<br/>

---

## 🤝 Contributing

Contributions, ideas, and bug reports are welcome! Here's how to get involved:

```bash
# 1. Fork the repository
# 2. Create your feature branch
git checkout -b feature/AmazingFeature

# 3. Commit your changes
git commit -m "Add: AmazingFeature — short description"

# 4. Push to branch
git push origin feature/AmazingFeature

# 5. Open a Pull Request on GitHub
```

### 🐛 Bug Reports

Please open a [GitHub Issue](https://github.com/iamyasirqureshi/AR-Dragon-Game/issues) with:
- Device model & Android version
- Steps to reproduce
- Screenshot or screen recording (if applicable)

### 💡 Planned Features

- [ ] 🌍 Multiple dragon skins (Red, Gold, Shadow)
- [ ] 👊 Combat system with enemy targets
- [ ] 🏰 Multiple AR levels / environments  
- [ ] 🎤 Voice commands ("FIRE!", "FLY!")
- [ ] 🏆 Score + achievement system
- [ ] 🌐 Multiplayer AR — two dragons, one battle

<br/>

---

## 👤 Author

<div align="center">

<br/>

```
  ██╗   ██╗ █████╗ ███████╗██╗██████╗      ██████╗ ██╗   ██╗██████╗ ███████╗███████╗██╗  ██╗██╗
  ╚██╗ ██╔╝██╔══██╗██╔════╝██║██╔══██╗    ██╔═══██╗██║   ██║██╔══██╗██╔════╝██╔════╝██║  ██║██║
   ╚████╔╝ ███████║███████╗██║██████╔╝    ██║   ██║██║   ██║██████╔╝█████╗  ███████╗███████║██║
    ╚██╔╝  ██╔══██║╚════██║██║██╔══██╗    ██║▄▄ ██║██║   ██║██╔══██╗██╔══╝  ╚════██║██╔══██║██║
     ██║   ██║  ██║███████║██║██║  ██║    ╚██████╔╝╚██████╔╝██║  ██║███████╗███████║██║  ██║██║
     ╚═╝   ╚═╝  ╚═╝╚══════╝╚═╝╚═╝  ╚═╝     ╚══▀▀═╝  ╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝╚═╝  ╚═╝╚═╝
```

### **Yasir Qureshi**
*Unity Developer · AR/XR Engineer · Game Designer*

<br/>

[![GitHub](https://img.shields.io/badge/GitHub-iamyasirqureshi-181717?style=for-the-badge&logo=github)](https://github.com/iamyasirqureshi)
[![Unity](https://img.shields.io/badge/Built%20With-Unity%206-000000?style=for-the-badge&logo=unity)](https://unity.com)


<br/>

> *"AR isn't about escaping reality — it's about making reality legendary."*  
> — Yasir Qureshi

<br/>

---

<br/>

### ⭐ If this project impressed you, drop a star. The dragon demands it. 🐉🔥

<br/>

```
                                    /|    |\
                                   / |    | \
                                  /  |    |  \
                    🔥🔥🔥🔥🔥🔥🔥🔥  🐉   🔥🔥🔥🔥🔥🔥🔥🔥
                                  \  |    |  /
                                   \ |    | /
                                    \|    |/
```

**© 2025 Yasir Qureshi — AR Dragon Quest. All Rights Reserved.**  
*Built with Unity 6 | Powered by ARCore | Forged by a Dragon*

</div>
