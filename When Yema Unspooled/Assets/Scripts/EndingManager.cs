using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndingManager : MonoBehaviour
{
    [SerializeField] private string S_LevelOne;
    [SerializeField] private string S_LevelTwo;
    [SerializeField] private string S_LevelThree;

    private PendantManager pendantManager;

    public void LoadNextLevel()
    {
        pendantManager = FindObjectOfType<PendantManager>();
        if (pendantManager != null)
        {
            if (pendantManager.B_hasFrog == true || pendantManager.B_hasLizard == true)
                {
                    StartCoroutine(ChangeToScene(S_LevelTwo));
                }
            else
                {
                    StartCoroutine(ChangeToScene(S_LevelOne));

                }
        }
    }
    public void LoadLevelThree()
    {
        StartCoroutine(ChangeToScene(S_LevelThree));
    }


    public IEnumerator ChangeToScene(string sceneToChangeTo)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneToChangeTo);
    }
}