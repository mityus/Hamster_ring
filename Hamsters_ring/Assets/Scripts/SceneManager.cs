using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public void ScenceGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene (0);
    }
    
    public void ScenceShop()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene (2);
    }
    
    public void ScenceCataloge()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene (3);
    }
}
