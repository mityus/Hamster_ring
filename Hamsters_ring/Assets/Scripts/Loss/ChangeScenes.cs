using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScenes : MonoBehaviour
{
    public void ChangeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene (0);
        
        PlayerController._counterCubes = 0;
    }
}
