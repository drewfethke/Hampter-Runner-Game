using UnityEngine;

public class PrefabBlocker : MonoBehaviour
{
    private Vector3 initialPosition;
    private bool isDuplicate = false;

    void Awake()
    {
        initialPosition = transform.position;
    }

    void Start()
    {
        // Set the isDuplicate flag to true if the prefab is a duplicate
        if (transform.parent != null)
        {
            isDuplicate = true;
        }
    }

    void Update()
    {
        // Prevents the prefab from being moved
        if (transform.position != initialPosition)
        {
            transform.position = initialPosition;
        }

        // Deletes the prefab if its Z position is less than 20
        if (transform.position.z < 20f)
        {
            Destroy(gameObject);
        }

        // Prevents duplication of the prefab
        if (isDuplicate)
        {
            Destroy(gameObject);
        }
    }

    void OnValidate()
    {
        if (Application.isPlaying)
        {
            Debug.LogWarning("You cannot duplicate or modify prefabs at runtime. Please remove this script before building your game.");
            Destroy(this);
        }
    }
}