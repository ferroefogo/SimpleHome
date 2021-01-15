using UnityEngine;

namespace Oxide.Plugins
{
    [Info("Home Command","Marco F.", 0.1)]
    [Description("A home command")]
    class Home : RustPlugin{

        Vector3 HomePos = Vector3.zero;

        [ChatCommand("sethome")]
        void SetHome(BasePlayer player){
            HomePos = player.ServerPosition;
            Broadcast(player, "Home has been set.");
        }
        [ChatCommand("home")]
        void GoHome(BasePlayer player){
            player.Teleport(HomePos);
            Broadcast(player, "Teleporting home");
        }
        void Broadcast(BasePlayer player, string message, params object[] args){
            PrintToChat(player, message, args);
        }

    }
}
