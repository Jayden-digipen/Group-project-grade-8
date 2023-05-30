using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Npc : MonoBehaviour
{
    public GameObject Dialoguepanel;
    public TMP_Text Dialoguetext;
    public string[] dialogue;
    private int index;

    public GameObject contButton;
    public float wordSpeed;
    public bool playerIsClose;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (Dialoguepanel.activeInHierarchy)
            {
                zeroText();
            }

            else
            {
                Dialoguepanel.SetActive(true);
            }
        }

        if(Dialoguetext.text == dialogue[index])
        {
            contButton.SetActive(true);
        }

    }

   public void zeroText()
    {
        Dialoguetext.text = "";
        index = 0;
        Dialoguepanel.SetActive(false);
    }

   IEnumerator Typing()
    {
        foreach(char letter in dialogue[index].ToCharArray())
        {
            Dialoguetext.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        contButton.SetActive(false);
        
        if (index < dialogue.Length - 1)
        {
            index++;
            Dialoguetext.text = "";
            StartCoroutine(Typing());
        }

        else
        {
            zeroText();
        }
    }
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            zeroText();
        }
    }
}
