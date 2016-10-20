# LoggerBot
Simple bot for discord that logs messages to a txt file.

#Setting up the bot
0. Download the files from this repository and extract them into a folder.

1. Create a bot [here](https://discordapp.com/developers/applications/me/create) and add it to your server. (Use this link - https://discordapp.com/oauth2/authorize?client_id=CLIENT-ID&scope=bot - but relace "CLIENT-ID" with the client ID found on your bot's application page.)

2. Create a token.txt file in the same place as Program.cs (which is in [root]/LoggerBot/) and put your bot's token in it.

3. Install [Visual Studio](https://go.microsoft.com/fwlink/?LinkId=691978&clcid=0x409) if you don't already have it installed. (could take a while)

4. Open the LoggerBot.sln file in the root of the bot's directory. This should open up Visual Studio.

5. Click the start button at the top of the screen. (or look at this screenshot if you can't find it)
![start-button.png](http://i.imgur.com/grmqm0n.png)

The bot should now open and start logging messages to the `LoggerBot-Logs` folder in your `My Documents` folder.

To run the bot again if it closes, you can run the bot's executable at `[root]/LoggerBot/bin/Debug/LoggerBot.exe`
