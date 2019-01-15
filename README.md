# WangNet
A basic keylogger virus.

Semi-Automatic Installation Instructions<br>
-Download the file 'Startup Manager'<br>
-Inset the file 'Startup Manager' into your startup folder.<r>
-Restart your computer to begin execution of startup manager<br><br>
What Does 'StartupManager' Do?<br>
-Afteter you restart, Startup manager checks whether the directory 'C:\Keylogs exist. If not it will create that directory and make following files exist; 'C:\Keylogs\KLService.exe' and 'C:\Keylogs\KLGUI.exe'.<br>
-It uses a system.net.webclient to fetch the content for these files (in the file branch of this repository). So you can delete 'C:\Keylogs' to reset WangNet. *NOTE: You must have an internet connection on the first restart. THe point is to start up 'Startup Manager' with internet only for the first run<br>
-It starts 'C:\Keylogs\KLService.exe' right afterwards. This is the kelogger application<br>
-To open the general user interface to control WangNet, press ENTER+O simuntaniusley. For help, just type 'help'<br><br>
Manual Installation<br>
-Go to the file branch of this respitory<br>
-Download all the files there.<br>
-Create a directory at 'C:\Keylogs'<br>
-Put 'KLService.exe' and 'KLGUI.exe' in that directory.
-Put 'StartupManager.exe' inside your startup folder. *NOTE: Internet isn't required this time because all the files are pre-placed and fetched.<br>
-Restart to bootup WangNet.<br><br>
Avoiding Restarting<br>
Simply just run 'StartupManager.exe' in your startup folder. If you are using semi-automatic installation, make sure you have an internet connection.
