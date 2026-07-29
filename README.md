# Trash Flight

> A 2D vertical shooting game built with Unity.

**Trash Flight** is a Unity-based 2D vertical shooting game inspired by the classic mobile game *Dragon Flight*.

Players move through the sky, defeat incoming trash enemies, collect coins to upgrade their weapons, survive increasingly difficult waves, and defeat the final boss.

---


## Gameplay

### Player Movement
- Mouse-based player movement
- Screen boundary restriction
- Weapon follows the player's position

### Shooting System
- Automatic bullet firing
- Bullet and enemy collision detection
- Enemy destruction

### Coin & Upgrade System
- Collect coins by defeating enemies
- Weapon upgrades at 10, 20, and 30 coins
- Stronger weapons as the game progresses

### Enemy System
- Continuous enemy spawning
- Increasing enemy difficulty
- Final boss battle

### Background
- Infinite scrolling background

### Game System
- Score system
- Game Over when colliding with enemies
- Enemy spawning stops after Game Over
- Restart game functionality

---

## Tech Stack

| Category | Technology |
| --- | --- |
| Game Engine | Unity |
| Language | C# |
| Input | Unity Input System |
| IDE | Visual Studio Code |
| Version Control | Git, GitHub |

---

## Project Structure

```text
Assets
├── Prefabs
├── Scenes
├── Scripts
│   ├── Background.cs
│   ├── Coin.cs
│   ├── Enemy.cs
│   ├── EnemySpawner.cs
│   ├── GameManager.cs
│   ├── Player.cs
│   └── Weapon.cs
├── Settings
├── Sprites
├── TextMesh Pro
└── InputSystem_Actions.inputactions
```

---

## Script Responsibilities

| Script | Description |
| --- | --- |
| Background.cs | Infinite scrolling background |
| Coin.cs | Coin movement and collection |
| Enemy.cs | Enemy movement and collision |
| EnemySpawner.cs | Enemy spawning system |
| GameManager.cs | Score, Game Over, and game state management |
| Player.cs | Player movement and screen boundaries |
| Weapon.cs | Bullet firing and weapon upgrade system |

---

## Features

- Mouse movement
- Infinite scrolling background
- Enemy spawning
- Shooting system
- Collision detection
- Coin collection
- Weapon upgrade
- Enemy difficulty progression
- Boss stage
- Score system
- Game Over & Restart

---

## What I Learned

Through this project, I learned the fundamentals of Unity 2D game development, including:

- Unity Input System
- Mouse-based player movement
- Infinite scrolling backgrounds
- Prefab instantiation
- Coroutine-based enemy spawning
- Collision detection using Trigger
- Game state management
- Basic game architecture in Unity
- Object-oriented programming with C#
- Git & GitHub workflow

---


## Reference

This project was developed as a learning project by following the Unity Crash Course tutorial below.

**Tutorial**

- Unity Crash Course (5 Hours)  
  https://youtu.be/rJE6bhVUNhk

This repository is intended for educational purposes and personal learning.

---

## Developer

**오소원**

- Computer Science