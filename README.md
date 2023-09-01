

# USE ESX IN C#
Hello welcome to this guide to use ESX in C#.

## # Creating FXManifest.lua 
So first we need to make our self a folder lets call it `"ESX-TestCommand"`
Inside the folder we first need to make a file called `'fxmanifest.lua'`
When you have created that you need to go inside the file.

When inside you will need to make a basic Fxmanifest.
```lua
fx_version 'adamant'

game 'gta5'

description 'Description'

version '1.0'

client_scripts {
  'Client/Client.net.dll',
}

server_scripts {
  'Server/Server.lua',
}
```
## # Creating folders and files
Right now you have made the fxmanifest.lua, you will ned to make two folders called `Client` and `Server`
And after that add a file inside the `Server` folder named `Server.lua`.

## # Server.lua 
Go inside the Server.lua that you just created.
And for this guide we will make a script that gives money to the player.
So we need to type in the following:
```lua
ESX = nil

TriggerEvent('esx:getSharedObject', function(obj)
    ESX = obj
end)

RegisterServerEvent('esxGuide:AddMoney')
AddEventHandler('esxGuide:AddMoney', function(amount)

    local xPlayer = ESX.GetPlayerFromId(source)

    xPlayer.addMoney(amount) 
end)

```
Right so what we are doing is calling esx inside the `Server.lua`
And creating a ServerEvent that gives money to the source called ```esxGuide:AddMoney```.

## # Use ESX in C#
Okay now we have done that you will need to make a basic script 
- If you dont know how to make one look up this: https://docs.fivem.net/docs/scripting-manual/runtimes/csharp/

Okay, inside your script you will need to add the following:
```c#
API.RegisterCommand("getmoney", new Action<int, List<object>, string>((source, args, rawCommand) =>
{
  int amount = 1000;
  TriggerServerEvent("('esxGuide:AddMoney", amount);
}), false );

```

Then build your solution and put it inside the `Client` folder. 
Then ensure the script and test.


##
Other Examples:
```lua
RegisterServerEvent('esxGuide:RemoveMoney')
AddEventHandler('esxGuide:RemoveMoney', function(amount)

    local xPlayer = ESX.GetPlayerFromId(source)

    xPlayer.removeMoney(amount)
end)
```

```lua
RegisterServerEvent('esxGuide:GetFirstName')
AddEventHandler('esxGuide:GetFirstName', function(amount)

    local xPlayer = ESX.GetPlayerFromId(source)

    xPlayer.PlayerData.firstName
end)
```
*and much much more!*
#
**@ledepede1**
#
[![Typing SVG](https://readme-typing-svg.demolab.com/?lines=Reach+me+on.;@ledepede1+on+discord)](https://git.io/typing-svg)
 <a href="#">
    <img src="https://github.com/MikeCodesDotNET/ColoredBadges/blob/master/svg/dev/languages/csharp.svg" alt="example badge" style="vertical-align:top margin:6px 4px">
  </a>  
  
