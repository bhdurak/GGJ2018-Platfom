using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panels : MonoBehaviour {

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    

    public void Exit()
    {
        SceneManager.LoadScene("StartMenu");
    }


}
