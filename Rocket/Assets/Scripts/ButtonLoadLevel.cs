using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadLevel : MonoBehaviour
{

    public string LevelToLoad;

    public void LevelLoad()
    {
        // Load a level
        SceneManager.LoadScene(LevelToLoad);
    }



}