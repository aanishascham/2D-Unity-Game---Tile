using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePersistant : MonoBehaviour
{ 
    void Awake()
    {
        int numScenePersists = FindObjectsOfType<ScenePersistant>().Length;
        if(numScenePersists> 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
