using InputActionsManagerSystem.Implementations.MB;
using SceneLoaderSystem.Implementations.MB;
using UnityEngine;

namespace SceneTransitionSystem.Implementations.MB.Implementations
{
    public class MBSceneTransition : MonoBehaviour, ISceneTransition
    {
        [SerializeField] private AMBSceneLoader sceneLoader;
        [SerializeField] private string sceneName;
        [SerializeField] private AMBInputActionsManager inputActionsManager;

        private SceneTransition _sceneTransition;

        private SceneTransition SceneTransition
        {
            get
            {
                _sceneTransition ??= new(sceneLoader, sceneName, inputActionsManager);

                return _sceneTransition;
            }
        }

        public void ExecuteTransition()
        {
            SceneTransition.ExecuteTransition();
        }
    }
}
