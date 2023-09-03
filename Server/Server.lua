ESX = nil

TriggerEvent('esx:getSharedObject', function(obj)
    ESX = obj
end)

RegisterServerEvent('esxGuide:AddMoney')
AddEventHandler('esxGuide:AddMoney', function(amount)

    local xPlayer = ESX.GetPlayerFromId(source)

    xPlayer.addMoney(amount) 
end)
