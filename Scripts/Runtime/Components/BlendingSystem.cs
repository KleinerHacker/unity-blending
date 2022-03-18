using System;
using UnityEngine;
using UnityExtension.Runtime.extension.Scripts.Runtime.Components.Singleton;
using UnityExtension.Runtime.extension.Scripts.Runtime.Components.Singleton.Attributes;

namespace UnityBlending.Runtime.scene_system.blending.Scripts.Runtime.Components
{
    [Singleton(Scope = SingletonScope.Application, Instance = SingletonInstance.HasExistingInstance)]
    public abstract class BlendingSystem : SingletonBehavior<BlendingSystem>
    {
        public abstract float LoadingProgress { get; set; }
        
        public abstract void ShowBlend(Action onFinished = null);
        public abstract void ShowBlendImmediately();
        public abstract void HideBlend(Action onFinished = null);
        public abstract void HideBlendImmediately();
    }
}