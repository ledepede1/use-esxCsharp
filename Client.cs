using CitizenFX.Core;
using CitizenFX.Core.Native;
using System;
using System.Collections.Generic;

namespace Main {
    public class Main : BaseScript {
        public static void Command() {
            API.RegisterCommand("getmoney", new Action<int, List<object>, string>((source, args, rawCommand) =>
            {
                int amount = 1000;
                TriggerServerEvent("('esxGuide:AddMoney", amount);
            }), false);
        }
    }
}
