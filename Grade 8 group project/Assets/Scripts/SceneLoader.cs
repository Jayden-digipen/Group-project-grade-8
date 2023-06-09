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

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            if (collision.CompareTag("Player"))
            {
            SceneManager.LoadScene(4);
            }
               
        
    }
   

    public void LoadJaydenDialogueScene()
    {
        SceneManager.LoadScene(5);
    }
    public void LoadCutScene1()
    {
        SceneManager.LoadScene(6);

    }

    public void LoadCutScene2()
    {
        SceneManager.LoadScene(7);
    }

    public void LoadCut3Scene()
    {
        SceneManager.LoadScene(8);
    }

    public void LoadCutScene4()
    {
        SceneManager.LoadScene(9);
    }
    public void LoadCutScene5()
    {
        SceneManager.LoadScene(10);
    }

    public void LoadCutScene6()
    {
        SceneManager.LoadScene(11);
    }

    public void LoadSSTScene7()
    {
        SceneManager.LoadScene(12);
    }

    public void LoadJaydenScene()
    {
        SceneManager.LoadScene(14);
    }

    public void LoadTExtScene()
    {
        SceneManager.LoadScene(15);
    }

    public void LoadText2Scene()
    {
        SceneManager.LoadScene(16);
    }

    public void LoadTesxt4Scene()
    {
        SceneManager.LoadScene(17);
    }

    // Load Levels.

    public void LoadLevelOne()
    {
        SceneManager.LoadScene("level2scene");
    }

    public void LoadLevelTwo()
    {
        SceneManager.LoadScene("MeganLevelTwo");
    }

    public void LoadLevelThree()
    {
        SceneManager.LoadScene("AinaLevelThree");
    }

    public void LoadLevelFour()
    {
        SceneManager.LoadScene("AinaLevelFour");
    }

    public void LoadLevelFive()
    {
        SceneManager.LoadScene("Level5Megan");
    }

    public void LoadLevelSix()
    {
        SceneManager.LoadScene("AinaLevelSix");
    }

    public void LoadLevelSeven()
    {
        SceneManager.LoadScene("AinaLevelSeven");
    }

    public void LoadLevelEight()
    {
        SceneManager.LoadScene("AinaLevelEight");
    }
}















