using System;

namespace SceneLoaderSystem.Implementations.MB.Implementations
{
    public class MBSceneLoader : AMBSceneLoader
    {
        private SceneLoader _sceneLoader;

        private SceneLoader SceneLoader
        {
            get
            {
                _sceneLoader ??= new(this);

                return _sceneLoader;
            }
        }

        public override bool IsLoadingScene { get { return SceneLoader.IsLoadingScene; } }
        public override float LoadingProgress { get { return SceneLoader.LoadingProgress; } }

        public override event Action OnLoadingStarted { add { SceneLoader.OnLoadingStarted += value; } remove { SceneLoader.OnLoadingStarted -= value; } }
        public override event Action OnLoadingFinished { add { SceneLoader.OnLoadingFinished += value; } remove { SceneLoader.OnLoadingFinished -= value; } }
        public override event Action<float> OnLoadingProgressChanged { add { SceneLoader.OnLoadingProgressChanged += value; } remove { SceneLoader.OnLoadingProgressChanged -= value; } }

        public override void LoadScene(string sceneName)
        {
            SceneLoader.LoadScene(sceneName);
        }
    }
}
