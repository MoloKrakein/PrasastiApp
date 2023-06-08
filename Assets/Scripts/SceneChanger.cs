using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    

    //print "game is Starting" on debug
    void Start()
    {
        Debug.Log("Game is Starting");
    }

    // change scene to next scene
    public void ChangeScene(string sceneName)
    {
        // Application.LoadLevel(sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
