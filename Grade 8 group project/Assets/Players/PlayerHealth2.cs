using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth3 : MonoBehaviour
{

    public TMP_Text playerHealth3;
    public int health3;
    public int maxHealth3= 10;
    [SerializeField] AudioClip playerdeathSFX3;
    [SerializeField][Range(0, 1)] float playerdeathSFXVolume3 = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        health3 = maxHealth3;

    }

    // Update is called once per frame
    void Update()
    {
        playerHealth3.text = health3.ToString();
    }


    public void TakeDamage(int amount)
    {
        health3 -= amount;
        if (health3 <= 0)
        {
            StartCoroutine(Death8());

        }
    }

    private IEnumerator Death8()
    {
        AudioSource.PlayClipAtPoint(playerdeathSFX3, transform.position, playerdeathSFXVolume3);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(21);
    }
   
}