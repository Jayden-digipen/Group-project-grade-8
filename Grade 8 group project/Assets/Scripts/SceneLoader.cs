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

    public void LoadPlay2Scene()
    {
        SceneManager.LoadScene(5);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            if (collision.CompareTag("Player"))
            {
            SceneManager.LoadScene(4);
            }
               
        
    }

    public void LoadJaydenDialogueScene()
    {
        SceneManager.LoadScene(7);
    }
    public void LoadCutScene1()
    {
        SceneManager.LoadScene(8);

    }

    public void LoadCutScene2()
    {
        SceneManager.LoadScene(9);
    }

    public void LoadCut3Scene()
    {
        SceneManager.LoadScene(10);
    }

    public void LoadCutScene4()
    {
        SceneManager.LoadScene(11);
    }
    public void LoadCutScene5()
    {
        SceneManager.LoadScene(12);
    }

    public void LoadCutScene6()
    {
        SceneManager.LoadScene(13);
    }

    public void LoadSSTScene7()
    {
        SceneManager.LoadScene(14);
    }

    public void LoadJaydenScene()
    {
        SceneManager.LoadScene(14);
    }
}















