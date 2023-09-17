using UnityEngine;

public class FrogManager : MonoBehaviour
{
    private PendantManager pendantManager;

    private void Start()
    {
        pendantManager = FindObjectOfType<PendantManager>();
        if (pendantManager != null)
        {
            pendantManager.B_hasFrog = true;
        }
    }

}
