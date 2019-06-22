# Source Link Test App

Library for testing out a source link enabled nuget package.

<b>Note:</b> For this to work correctly you'll need to host the nuget package found in the source link test lib repository on some flavor of nuget server (e.g. locally you could use BaGet) and update the nuget.config file to point at that server. You'll also need to make sure Visual Studio is setup to correctly consume it (add custom symbol server, enable source link, and disable just my code).