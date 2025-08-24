using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagmentButtons : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject authorMenu;
    [SerializeField] GameObject pauseMenu;

    public void ButtonInMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ButtonPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonAuthor()
    {
        mainMenu.SetActive(false);
        authorMenu.SetActive(true);
    }

    public void ButtonNextLevel()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        int countLevels = SceneManager.sceneCountInBuildSettings - 1;

        if (index != countLevels)
        {
            SceneManager.LoadScene(index + 1);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    public void ButtonReplay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ButtonPause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void ButtonContinue()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
