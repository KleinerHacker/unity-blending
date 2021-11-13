using System;
using UnityAnimation.Runtime.animation.Scripts.Runtime.Types;
using UnityAnimation.Runtime.animation.Scripts.Runtime.Utils;
using UnityEngine;

namespace UnityBlending.Runtime.blending.Scripts.Runtime.Components
{
    public abstract class SplashSystem : MonoBehaviour
    {
        #region Inspector Data

        [SerializeField]
        private float showTime = 3f;

        #endregion

        #region Builtin Methods

        private void Start()
        {
            OnShow(() =>
                AnimationBuilder.Create(this, AnimationType.Unscaled)
                    .Wait(showTime, OnClose)
                    .Start()
            );
        }

        #endregion

        protected abstract void OnShow(Action onFinished);
        protected abstract void OnClose();
    }
}