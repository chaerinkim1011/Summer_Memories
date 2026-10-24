# Summer Memories

A Unity story-driven jigsaw puzzle game.

## Getting started

1. Open this folder in Unity Hub using a Unity 6 editor.
2. Open `Assets/Scenes/Bootstrap.unity` after creating the initial scene in the editor, or create a scene and save it there.
3. Add the puzzle and story prefabs to the scene as they are implemented.

The project uses TextMeshPro for UI text. Import TMP Essentials from **Window > TextMeshPro > Import TMP Essential Resources** when prompted.

## Project layout

- `Assets/Scenes` — bootstrap, menu, and gameplay scenes
- `Assets/Scripts/Core` — game state and scene flow
- `Assets/Scripts/Puzzle` — board, pieces, placement, and completion logic
- `Assets/Scripts/Story` — chapter and dialogue data/runtime
- `Assets/Scripts/UI` — screen controllers and presentation
- `Assets/Data` — authored chapter and puzzle assets
- `Assets/Prefabs` — reusable game objects
- `Assets/Art` — imported artwork, sprites, and audio
- `Assets/Settings` — project-specific settings and render pipeline assets
