using System;
using UnityEngine;

namespace UnityModule
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
    public sealed class EnumFlagsAttribute : PropertyAttribute
    {
    }
}