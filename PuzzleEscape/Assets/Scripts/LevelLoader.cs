using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Controles()
    {
        SceneManager.LoadScene("Controles");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoseGame()
    {
        SceneManager.LoadScene("Lose");
    }

    public void WinGame()
    {
        SceneManager.LoadScene("Win");
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CutScene1()
    {
        SceneManager.LoadScene("CutScene1");
    }

    public void CutScene2()
    {
        SceneManager.LoadScene("CutScene2");
    }



}
