using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevel0()
    {
        SceneManager.LoadScene("Level 0");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
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

    public void CutScene1()
    {
        SceneManager.LoadScene("CutScene1");
    }

    public void CutScene2()
    {
        SceneManager.LoadScene("CutScene2");
    }



}
