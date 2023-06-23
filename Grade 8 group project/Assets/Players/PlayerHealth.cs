using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth1 : MonoBehaviour
{

    public TMP_Text playerHealth;
    public int health1;
    public int maxHealth1 = 10;
    [SerializeField] AudioClip playerdeathSFX1;
    [SerializeField][Range(0, 1)] float playerdeathSFXVolume1 = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        health1 = maxHealth1;

    }

    // Update is called once per frame
    void Update()
    {
        playerHealth.text = health1.ToString();
    }


    public void TakeDamage(int amount)
    {
        health1 -= amount;
        if (health1 <= 0)
        {
            StartCoroutine(Death7());

        }
    }

    private IEnumerator Death7()
    {
        AudioSource.PlayClipAtPoint(playerdeathSFX1, transform.position, playerdeathSFXVolume1);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(4);
    }
   
}