# 📱 Love Letter AR – Augmented Reality Game Prototype  
**Course Project – Unity + Vuforia**

## 🧩 Project Overview  
This prototype is an augmented reality adaptation of the card game *Love Letter*, developed in **Unity 2021** using the **Vuforia Engine 11.2.4**. It presents a simplified version of the original gameplay, utilizing **three image targets** to represent key cards:

- 🛡️ **Maid** – Grants the player immunity for one turn  
- 🕵️ **Priest** – Reveals the NPC's card  
- 🗡️ **Guard** – Allows guessing the NPC’s card; correct guesses eliminate the NPC  

The game is optimized for mobile AR, serving as a practical exercise in AR development and basic turn-based mechanics.

## ⚙️ Technologies Used  
- Unity 2021.3 LTS  
- Vuforia Engine 11.2.4  
- C# scripting  
- Android platform (tested on Samsung S8)  
- Image-based marker tracking  

## 🎮 Gameplay Flow & Features  

### AR Marker Detection  
Three printed image targets are used. Each corresponds to a 3D model of one of the cards.

### 3D Model Interaction  
Tapping a card model in AR triggers its effect.

### Turn-Based Logic  
The game alternates turns between the player and a simple AI opponent. The AI selects random valid actions.

### Game Feedback  
Text-based UI informs the player of the current turn and card outcomes.

### Marker-Dependent Interaction  
Cards can only be used when their respective image target is actively tracked.

### Card Usage  
Each card is removed after use to simulate single-use behavior.

---

**Note**: This project was built using beginner-friendly tools and logic, with the primary focus on learning Unity workflows, AR interaction via Vuforia, and state-based game logic.
