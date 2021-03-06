﻿using System;
using System.Reflection;
using TaleWorlds.Core;

namespace Coop.Mod.Serializers
{
    [Serializable]
    internal class DeterministicRandomSerializer : CustomSerializer
    {
        int capacity;
        public DeterministicRandomSerializer(DeterministicRandom value)
        {
            capacity = (int)typeof(DeterministicRandom)
                .GetField("_capacity", BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(value);
            if(NonSerializableObjects.Count > 0)
            {
                throw new Exception("Unhandled non serialized object");
            }
        }

        public override object Deserialize()
        {
            DeterministicRandom newDeterministicRandom = new DeterministicRandom(capacity);
            
            return base.Deserialize(newDeterministicRandom);
        }
    }
}