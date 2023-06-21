using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    float seconds = 0.75f;
    public AudioClip ButtonSound;
    [Range(0, 1)] float ButtonVolume = 0.75f;
    public void LoadMenuScene()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(Menu());
    }

    public void LoadControlScene()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(Control());
    }


    public void LoadInstructionScene()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(Instruction());
    }


    public void LoadPlayScene()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(Play());
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(4);
        }


    }

    public void LoadPlay2Scene()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(Play2());
    }

    public void LoadJaydenDialogueScene()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(Dialogue());
    }
    public void LoadCutScene1()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(Cut1());

    }

    public void LoadCutScene2()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(Cut2());
    }

    public void LoadCut3Scene()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(Cut3());
    }

    public void LoadCutScene4()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(Cut4());
    }
    public void LoadCutScene5()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(Cut5());
    }

    public void LoadCutScene6()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(Cut6());
    }

    public void LoadSSTScene7()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(SSTScene7());
    }

    public void LoadJaydenScene()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(JaydenScene());
    }

    public void LoadTExtScene()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(TextScene());
    }

    public void LoadText2Scene()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(TextScene2());
    }

    public void LoadTesxt4Scene()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(TextScene4());
    }

    public void LoadMEganScene()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(MeagenScene());
    }




    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    private IEnumerator Menu()
    {

        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(0);
    }

    private IEnumerator Control()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(1);
    }
    private IEnumerator Instruction()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(2);
    }
    private IEnumerator Play()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(3);
    }
    private IEnumerator Play2()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(4);
    }
    private IEnumerator Dialogue()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(5);
    }
    private IEnumerator Cut1()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(6);
    }
    private IEnumerator Cut2()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(7);
    }
    private IEnumerator Cut3()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(8);
    }
    private IEnumerator Cut4()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(9);
    }
    private IEnumerator Cut5()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(10);
    }
    private IEnumerator Cut6()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(11);
    }
    private IEnumerator SSTScene7()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(12);
    }
    private IEnumerator JaydenScene()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(13);
    }
    private IEnumerator TextScene()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(14);
    }
    private IEnumerator TextScene2()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(15);
    }
    private IEnumerator TextScene4()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(16);
    }
    private IEnumerator MeagenScene()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(17);
    }
    private IEnumerator A1()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("level2scene");
    }
    private IEnumerator A2()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("MeganLevelTwo");
    }
    private IEnumerator A3()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("AinaLevelThree");
    }
    private IEnumerator A4()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("AinaLevelFour");
    }
    private IEnumerator A5()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("Level5Megan");
    }
    private IEnumerator A6()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("AinaLevelSix");
    }
    private IEnumerator A7()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("AinaLevelSeven");
    }
    private IEnumerator A8()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("AinaLevelEight");
    }
   

    // Load Levels.

    public void LoadLevelOne()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(A1());
    }

    public void LoadLevelTwo()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(A2());
    }

    public void LoadLevelThree()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(A3());

    }

    public void LoadLevelFour()
    {
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(A4());
    }

    public void LoadLevelFive()
    {
       
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(A5());
    }

    public void LoadLevelSix()
    {
        
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
        StartCoroutine(A6());
    }

    public void LoadLevelSeven()
    {
        StartCoroutine(A7());
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
    }

    public void LoadLevelEight()
    {
        StartCoroutine(A8());
        AudioSource.PlayClipAtPoint(ButtonSound, Camera.main.transform.position, ButtonVolume);
    }
}















