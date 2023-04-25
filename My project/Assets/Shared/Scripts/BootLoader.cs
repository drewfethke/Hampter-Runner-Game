using UnityEngine;
using HyperCasual.Gameplay;

public class BootLoader : MonoBehaviour
{
    [SerializeField]
    SequenceManager m_SequenceManagerPrefab;

    void Start()
    {
        // Instantiate and initialize a SequenceManager
        //SequenceManager sequenceManager = Instantiate(m_SequenceManagerPrefab);
        //sequenceManager.Initialize();

       // // Load the "LEVEL" level definition
        //sequenceManager.LoadSceneDefinition("LEVEL");
    }
}