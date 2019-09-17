using Microsoft.Mixer;
using UnityEngine;
using UnityEngine.UI;

namespace MixerInteractiveExamples
{
    public class MouseLight : MonoBehaviour
    {

        RaycastHit hit;
        Vector2 target;

        void Update()
        {
            if (MixerInteractive.GetMouseButton())
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(MixerInteractive.MousePosition), out hit, 100))
                {
                    target = hit.point;
                    print("hit.point");
                }
            }
        }
    }
}
