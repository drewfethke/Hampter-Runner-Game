using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadOnClick(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex++);
    }
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("QuitGame");
    }
}
