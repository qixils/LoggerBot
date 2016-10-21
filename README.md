# LoggerBot
Simple bot for discord that logs messages to a txt file.

#Setting up the bot

## Windows
1. [Download the repository](https://github.com/Noahkiq/LoggerBot/archive/master.zip) and extract the zip into a folder.

2. Create a bot [here](https://discordapp.com/developers/applications/me/create) and add it to your server. (Use this link - https://discordapp.com/oauth2/authorize?client_id=CLIENT-ID&scope=bot - but relace "CLIENT-ID" with the client ID found on your bot's application page.)

3. Create a token.txt file in the same place as Program.cs (which is in [root]/LoggerBot/) and put your bot's token in it.

4. Install [Visual Studio](https://go.microsoft.com/fwlink/?LinkId=691978&clcid=0x409) if you don't already have it installed. (could take a while)

5. Open the LoggerBot.sln file in the root of the bot's directory. This should open up Visual Studio.

6. Click the start button at the top of the screen. (or look at this screenshot if you can't find it)
![start-button.png](http://i.imgur.com/grmqm0n.png)

The bot should now open and start logging messages to console and `[root]/LoggerBot/bin/Debug/`, with the filename being `(server id)-chatlog.txt`

To run the bot again if it closes, you can run the bot's executable at `[root]/LoggerBot/bin/Debug/LoggerBot.exe`

## Mac OS X / Linux / Alt. Windows

The Mac OS X/Linux steps haven't been proven to work, so if someone can confirm they don't work, please open an issue saying what part doesn't work.

1. For Mac OS X, [download Wine](https://dl.winehq.org/wine-builds/macosx/i686/winehq-devel-1.9.21.pkg).
For Linux, you'll have to find the appropriate version of Wine for your distro [here](https://www.winehq.org/download).
For Windows, don't worry about this step.

2. Download the latest version of LoggerBot from [here](https://github.com/Noahkiq/LoggerBot/releases/latest) and place it in a special folder.

3. Create a bot [here](https://discordapp.com/developers/applications/me/create) and add it to your server. (Use this link - https://discordapp.com/oauth2/authorize?client_id=CLIENT-ID&scope=bot - but relace "CLIENT-ID" with the client ID found on your bot's application page.)

4. Create a `token.txt` file, put your bot's token in it, and put the file in the same folder as the `LoggerBot.exe` file from earlier.

5. For Mac OS X and Linux, open the `LoggerBot.exe` file in Wine.
For Windows, just run the file normally.

The bot should now open and start logging messages to console and the same folder you put `LoggerBot.exe`, with the filename being `(server id)-chatlog.txt`

If you need to re-open the bot and you somehow don't know what to do, just do step 5 again.
