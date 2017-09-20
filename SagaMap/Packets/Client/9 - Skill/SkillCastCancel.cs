using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;

namespace SagaMap.Packets.Client
{
    public class SkillCastCancel : Packet
    {
        public SkillCastCancel()
        {
            this.size = 9;
            this.offset = 4;
        }

        public byte GetSkillType()
        {
            return this.GetByte(4);
        }

        public uint GetSkillID()
        {
            return this.GetUInt(5);
        }

        public override SagaLib.Packet New()
        {
            return (SagaLib.Packet)new SagaMap.Packets.Client.SkillCastCancel();
        }

        public override void Parse(SagaLib.Client client)
        {
            ((MapClient)(client)).OnSkillCastCancel(this);
        }
    }
}


