using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private string S_LevelOne;
    [SerializeField] private string S_LevelTwo;
    [SerializeField] private string S_LevelThree;
    [SerializeField] private string S_LevelFour;
    private int PrevScene;

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

    public void LoadLevelFour()
    {
        StartCoroutine(ChangeToScene(S_LevelFour));
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void Start()
    {
        PrevScene = SceneManager.GetActiveScene().buildIndex - 1;
    }

    public IEnumerator ChangeToScene(string sceneToChangeTo)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneToChangeTo);
    }
}