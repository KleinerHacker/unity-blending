using System;
using UnityEngine;

namespace UnityBlending.Runtime.scene_system.blending.Scripts.Runtime.Components
{
    public abstract class BlendingSystem : MonoBehaviour
    {
        public abstract float LoadingProgress { get; set; }
        
        public abstract void ShowBlend(Action onFinished = null);
        public abstract void ShowBlendImmediately();
        public abstract void HideBlend(Action onFinished = null);
        public abstract void HideBlendImmediately();
    }
}