using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth2 : MonoBehaviour
{

    public TMP_Text playerHealth2;
    public int health2;
    public int maxHealth2= 10;
    [SerializeField] AudioClip playerdeathSFX2;
    [SerializeField][Range(0, 1)] float playerdeathSFXVolume2 = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        health2 = maxHealth2;

    }

    // Update is called once per frame
    void Update()
    {
        playerHealth2.text = health2.ToString();
    }


    public void TakeDamage(int amount)
    {
        health2 -= amount;
        if (health2 <= 0)
        {
            StartCoroutine(Death8());

        }
    }

    private IEnumerator Death8()
    {
        AudioSource.PlayClipAtPoint(playerdeathSFX2, transform.position, playerdeathSFXVolume2);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(21);
    }
   
}