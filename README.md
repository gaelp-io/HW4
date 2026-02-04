# HW4
## Devlog
This game uses a model-view-controller style structure to keep the Player code decoupled from other systems. The control side of the pattern is handled by the GameController class which acts as the singleton, which manages global game logic such as the player’s score and game state. For example, the AddScore(int amount) method updates the score and raises the OnScoreChanged event, while the isGameOver variable prevents further gameplay after the player hits a pipe. The view side is handled by the ScoreUI class, which is responsible only for displaying the score to the player using a TextMeshProUGUI component with a custom pixel font I added. ScoreUI subscribes to the OnScoreChanged event and updates the text inside the UpdateScore(int newScore) method, without directly accessing or modifying gameplay logic. These events are used to keep the view and control systems decoupled, since the GameController does not directly reference the UI. Additionally, the Singleton pattern is used in GameController through the static Instance property, allowing UI and audio systems to safely subscribe to score events from a single, centralized controller (which is why I made the gamecontroller the singleton/locator).

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
- [Simple grass&soil sprite pack](https://whrmysl.itch.io/simple-grasssoil-sprite-pack) - grass sprite
- [Pixel Fonts](https://www.1001fonts.com/pixel-fonts.html) - pixel text font
- [Free Point Sound Effect](https://pixabay.com/sound-effects/search/point/) - point audio source
- [1 royalty-free flappybird sound effects](https://pixabay.com/sound-effects/search/flappybird/) - flapping audio source
- [Game Over Sound Effects: Download Free & Royalty-Free Game Sounds](https://pixabay.com/sound-effects/search/game-over/) - game over audio source