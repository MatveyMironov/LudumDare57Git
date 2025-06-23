using SceneLoaderSystem.Implementations.MB;
using UnityEngine;

namespace SceneLoaderUISystem
{
    public class MBSceneLoaderUIController : MonoBehaviour
    {
        [SerializeField] private AMBSceneLoader sceneLoader;
        [SerializeField] private LoadingScreen loadingScreen;

        private void Start()
        {
            SceneLoaderUIController sceneLoaderUIController = new(loadingScreen);
            sceneLoaderUIController.DisplaySceneLoader(sceneLoader);
        }
    }
}
