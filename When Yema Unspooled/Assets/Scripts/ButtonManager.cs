using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private string S_LevelOne;
    [SerializeField] private string S_LevelTwo;
    [SerializeField] private string S_LevelThree;

    public void LoadLevelOne()
    {
        StartCoroutine(ChangeToScene(S_LevelOne));
    }

    public void LoadLevelTwo()
    {
        StartCoroutine(ChangeToScene(S_LevelTwo));
    }

    public void LoadLevelThree()
    {
        StartCoroutine(ChangeToScene(S_LevelThree));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public IEnumerator ChangeToScene(string sceneToChangeTo)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneToChangeTo);
    }
}