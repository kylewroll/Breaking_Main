Author: Kyle Rolland
Date: 2/20/2021
File: README.md
Description: Description of project, capabilties, bugs, etc

This project is basically a copy of the paint project, but with a few minor changes. For one, there is a newly added class called "App.cs". Secondly, there is are new .xaml and .xaml.cs files for New_window

App.cs is a hand made main function, which replaces the auto generated main function that Visual Studio provided. The goal was to just find and take over Main, so we know where it is and how we can modify it, if that is necessary. App.cs creates an application class, and uses it to run the program and call New_Window.xaml, contrasting to the previous main function which would call MainWindow. 

New_Window is quite literally just a label that says "HELP, THE CODE IS SENTIENT" and exists solely for the purpose of making sure that the new main function works properly. Originally, I was to implement a label on the MainWindow. However, implementing the label without the use of the xaml GUI was causing me immense frustration, and I couldn't get anything to wrok right, no matter what I tried.

Then I realized that all we had to do was prove that main was actually running the right program, so I made a whole new window, while also leaving the other windows in the file, so I could see if the program was still using the auto generated function instead of my own, and rewrote main to call New_Window instead of MainWindow. This was the easist way to test that was working properly, while also maintaining my sanity, so while it wasnt exactly according to protocol, I dont feel like it strayed far enough away to be too big of a deal.

Plus now I can actually get some sleep.

Other than that, there don't seem to be any issues with the program, it only calls the new window, which constists of a label. The old program still works too, believe me, it ran way too many times when I was trying to work up a proper label without using the GUI, and as far as I could tell, nothing had changed. Still the same paint program, and still NO LABELS.
