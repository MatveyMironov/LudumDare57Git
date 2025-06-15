using UnityEngine;

namespace SceneTransitionSystem.Implementations.MB
{
    public abstract class AMBSceneTransition : MonoBehaviour, ISceneTransition
    {
        public abstract void ExecuteTransition();
    }
}
