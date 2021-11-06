﻿using System.Collections;
using UnityEngine;

namespace MyLibrary.Utility
{
    [System.Serializable]
    public abstract class CameraEffect
    {
        protected string _name = "Camera Effect";
        public string ClassName => _name;
        public bool isInspectorShown;
        public Coroutine CamCoroutine;
        public bool isPlaying => CamCoroutine != null ? true : false;
        public float duration;

        protected CameraEffect(string name)
        {
            _name = name;
        }

#if UNITY_EDITOR
        public abstract void DrawInspectorGUI();
#endif
        public abstract IEnumerator Action(Transform cam);
        public abstract void Stop(Transform cam);
    }
}
