﻿using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace HeroesExplorerLib.IO.X
{
    [DebuggerDisplay("{ID}")]
    public class XFlag
    {
        public string ID { get; private set; }
        public UInt32 Unknown1 { get; private set; }
        public UInt32 Unknown2 { get; private set; }
        public XFlag(BinaryReader br)
        {
            this.ID = Encoding.ASCII.GetString(br.ReadBytes(4));
            this.Unknown1 = br.ReadUInt32();
            this.Unknown2 = br.ReadUInt32();
        }
    }
}
