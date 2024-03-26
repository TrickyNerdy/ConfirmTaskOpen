![image](https://github.com/TrickyNerdy/ConfirmTaskOpen/assets/116591550/963e0f3c-6609-4990-88cc-d3f01d474377)

Allows you to paste an aplication path and set a shortcut name. The application creates a shortcut on the desktop to itself, and uses a commandline argument to specify the desired application. When opening the link you can confrim if you really want to open the application. The open button is selected at lauch so ENTER will lauch the app, ESC will dismiss the confirmation.
The use case is for making taskbar shortcuts, that ask you if you really want to open the program.

I made this app becuase I always accedentally open Blender or Photoshop when I have other things like a game running, and I wanted away to confrim my misclicks on my taskbar.

One known issue is that Win11's right click "Copy as path" includes quotes, I have no idea what happens if you don't delete those, I never tested it. The text boxes also don't have any file path syntax validation.

The release build was made with Costura
https://github.com/Fody/Costura
https://opencollective.com/fody
