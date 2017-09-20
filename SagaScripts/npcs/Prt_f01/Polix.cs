using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Polix : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1163;
            Name = "Polix";
            StartX = 20032F;
            StartY = 81984F;
            StartZ = 5056;
            Startyaw = 60768;
            SetScript(3);
            AddButton(Functions.EverydayConversation, new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
        }

    }
}