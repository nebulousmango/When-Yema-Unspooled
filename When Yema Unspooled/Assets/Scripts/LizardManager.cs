using UnityEngine;

public class LizardManager : MonoBehaviour
{
    private PendantManager pendantManager;

    private void Start()
    {
        pendantManager = FindObjectOfType<PendantManager>();
        if (pendantManager != null)
        {
            pendantManager.B_hasLizard = true;
        }
    }

}
