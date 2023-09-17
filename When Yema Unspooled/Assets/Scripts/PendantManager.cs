using UnityEngine;

public class PendantManager : MonoBehaviour
{
    public bool B_hasFrog = false;
    public bool B_hasLizard = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
