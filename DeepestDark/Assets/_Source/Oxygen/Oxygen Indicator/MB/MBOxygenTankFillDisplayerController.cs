using FillDisplayerSystem.Implementations.MB;
using OxygenTankSystem.Implementations.MB;
using UnityEngine;

namespace OxygenTankFillDisplayerControllerSystem.Implementations.MB.Implementations
{
    public class MBOxygenTankFillDisplayerController : MonoBehaviour
    {
        [SerializeField] private AMBOxygenTank oxygenTank;
        [SerializeField] private AMBFillDisplayer oxygenTankFillDisplayer;

        private OxygenTankFillDisplayerController _oxygenTankFillDisplayerController;

        private void Start()
        {
            _oxygenTankFillDisplayerController = new(oxygenTankFillDisplayer);

            _oxygenTankFillDisplayerController.DisplayOxygenTank(oxygenTank);
        }
    }
}
