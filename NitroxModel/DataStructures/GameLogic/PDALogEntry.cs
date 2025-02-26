﻿using System;
using BinaryPack.Attributes;
using ProtoBufNet;

namespace NitroxModel.DataStructures.GameLogic
{
    [Serializable]
    [ProtoContract]
    public class PDALogEntry
    {
        [ProtoMember(1)]
        public string Key;

        [ProtoMember(2)]
        public float Timestamp;

        [IgnoreConstructor]
        protected PDALogEntry()
        {
            // Constructor for serialization. Has to be "protected" for json serialization.
        }

        public PDALogEntry(string key, float timestamp)
        {
            Key = key;
            Timestamp = timestamp;
        }

        public override string ToString()
        {
            return $"{nameof(Key)}: {Key}, {nameof(Timestamp)}: {Timestamp}";
        }
    }
}
