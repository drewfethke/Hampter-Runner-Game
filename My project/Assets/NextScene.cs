using UnityEngine;
using UnityEngine.SceneManagement;

public class SetLevelScript : MonoBehaviour
{

    public int levelIndex;

    void Start()
    {
        // Load the specified level instantly when the script starts
        SceneManager.LoadScene(levelIndex);
    }
}