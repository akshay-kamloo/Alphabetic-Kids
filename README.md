# Alphabetic Kids 📚✨ — Interactive Alphabet Learning App (WPF)

**Alphabetic Kids** is a desktop learning application that helps kindergarten students recognise letters and associate them with colourful icons and spoken pronunciations.  
Built with **C# & WPF/XAML**, the UI focuses on large buttons, bright imagery, and single‑click interactions so young learners (and parents!) can explore the alphabet without assistance. The project was one of my early attempts at icon‑based ed‑tech software.citeturn2view0

---

## Key Features
- **Tap‑to‑Explore UI** – each letter is represented by a tile featuring a friendly icon (A → 🍎 *apple*, B → 🐝 *bee*, …).
- **Built‑in Audio Pronunciations** – click any tile to hear the correct letter sound and word, reinforcing phonics.
- **Single‑Window Navigation** – no hidden menus; designed so children can’t “get lost”.
- **Lightweight** – runs locally, no internet required; perfect for school labs or offline homes.
- **Extensible** – new letters, words, or localisation audio can be added by dropping files into the *Assets* folder and updating the resource dictionary.

---

## Project Structure (excerpt)

```
Alphabetic-Kids/
│
├── Alphabetic Kids.sln                 # Visual Studio solution
├── Alphabetic-Kids-solution/           # Main WPF project
│   ├── App.xaml
│   ├── MainWindow.xaml                 # Alphabet grid & event logic
│   ├── ViewModels/
│   ├── Assets/                         # *.png icons & *.wav audio clips
│   └── Resources/
├── Project Report.docx                 # Development overview & screenshots
└── README.md                           # ← you are here
```

*(Folder names are truncated for brevity — see the repo for full details.)*

---

## Getting Started

### 1. Prerequisites
- Windows 10/11
- **Visual Studio 2019 or 2022** with “.NET desktop development” workload
- .NET Framework 4.7+ (installed automatically by VS)

### 2. Clone & Open

```bash
git clone https://github.com/akshay-kamloo/Alphabetic-Kids.git
cd Alphabetic-Kids
```

Open **Alphabetic Kids.sln** in Visual Studio.

### 3. Build & Run

1. Select **Debug → Any CPU** (or x86/x64 as preferred).  
2. Press <kbd>F5</kbd> or click **▶ Start**.  
3. The main window should launch displaying all 26 letters.

> **Tip:** If audio does not play, ensure your default playback device is active and that the `*.wav` files inside **Assets/Audio/** are marked as *Copy to Output Directory* **Always** in their *Properties*.

---

## Adding / Updating Content

1. **Icon** – drop a `letter.png` into **Assets/Icons/**. Recommended size: 256 × 256 px transparent PNG.  
2. **Audio** – record `letter_word.wav` (44.1 kHz mono) and place it in **Assets/Audio/**.  
3. Update `AlphabetResources.xaml` with the new *ImageSource* and *SoundPath* entries.  
4. Re‑build; no code changes required.

---

## Roadmap 🚧
- 🗣 **Multi‑language mode** (Hindi, Spanish): dynamic resource dictionaries.  
- 🎮 **Mini‑games**: drag‑and‑drop letter matching, pronunciation quiz.  
- 🌗 **High‑contrast & dark themes** for visually impaired learners.  
- 📦 **MSIX installer** for one‑click deployment in schools.

---

## Contributing

Bug reports, feature ideas, or pull requests are welcome!  
For larger changes please open an issue first to discuss the scope and design.

---

## License

Alphabetic Kids is released under the **MIT License** — see [`LICENSE`](./LICENSE) for details.

---

## Acknowledgements

- Icons sourced from [Twemoji](https://twemoji.twitter.com/) and [OpenMoji](https://openmoji.org/) (CC BY 4.0).  
- Thanks to early testers at *Little Stars KG School* for usability feedback.

Happy learning! 🎉
