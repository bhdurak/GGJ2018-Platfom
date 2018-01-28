using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	public void StartLevel1()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene("Level_2");
    }
    public void StartLevel3()
    {
        SceneManager.LoadScene("Level_3");
    }
    public void StartLevel4()
    {
        SceneManager.LoadScene("Level_4");
    }
    public void StartLevel5()
    {
        SceneManager.LoadScene("Level_5");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
