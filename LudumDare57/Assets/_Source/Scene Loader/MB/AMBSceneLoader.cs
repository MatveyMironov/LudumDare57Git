using System;
using UnityEngine;

namespace SceneLoaderSystem.Implementations.MB
{
    public abstract class AMBSceneLoader : MonoBehaviour, ISceneLoader
    {
        public abstract bool IsLoadingScene { get; }
        public abstract float LoadingProgress { get; }

        public abstract event Action OnLoadingStarted;
        public abstract event Action OnLoadingFinished;
        public abstract event Action<float> OnLoadingProgressChanged;

        public abstract void LoadScene(string sceneName);
    }
}
