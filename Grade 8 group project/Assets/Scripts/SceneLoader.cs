using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadControlScene()
    {
        SceneManager.LoadScene(1);
    }


    public void LoadInstructionScene()
    {
        SceneManager.LoadScene(2);
    }


    public void LoadPlayScene()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadBackScene()
    {
        SceneManager.LoadScene(4);  
    }
}















