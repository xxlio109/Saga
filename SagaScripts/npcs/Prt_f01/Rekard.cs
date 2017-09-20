using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Prt_f01
{
    public class Rekard : Npc
    {
        public override void OnInit()
        {
            MapName = "Prt_f01";
            Type = 1161;
            Name = "Rekard";
            StartX = 21984F;
            StartY = 85439F;
            StartZ = 5056;
            Startyaw = 32768;
            SetScript(3);
            AddButton(Functions.EverydayConversation, new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
        }

    }
}