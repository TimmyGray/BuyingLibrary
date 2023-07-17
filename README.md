# Buying Library

First, a few words about full project. It provides construction of various cables and their purchase. It consists of two large parts:  

1) Part for seller - https://github.com/TimmyGray/Lovely_Wires; https://github.com/TimmyGray/Lovely_wires_server;  
2) Part for customer - https://github.com/TimmyGray/Buying_Client; https://github.com/TimmyGray/Dotnet_Server; https://github.com/TimmyGray/BuyingLibrary;  
Each part contains front and backend with joint mongo database. Most of features implemented, but not all. If something does't work correctly or doesn't work at all -  
please, write me!In additional,i is writing(Not yet finished) this pet-project for show to potential employer my hard skills. So, it is not real app you should use in your business,ofc=)  

This is library for server app that you can find by this link: https://github.com/TimmyGray/Dotnet_Server  
Includes various models, contexts and methods for the interaction with mongo database. Using GridFs allow storing the images.  

ATTENTION!!For now, I is implementing authenticaton in corresponding branch, so, if wou want working code(without authentication) - take master branch!  

How to use:  
1) Clone this repo  
2) Build this project  
3) Add builded lib to the server app  

Stack: .NET Core, Entity Framework(mongo db)  