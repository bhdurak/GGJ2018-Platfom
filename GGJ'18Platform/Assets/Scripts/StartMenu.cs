using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	public void StartLevel1()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene("AudioTestScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
