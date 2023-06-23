using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth4 : MonoBehaviour
{

    public TMP_Text playerHealth4;
    public int health4;
    public int maxHealth4= 10;
    [SerializeField] AudioClip playerdeathSFX4;
    [SerializeField][Range(0, 1)] float playerdeathSFXVolume4 = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        health4 = maxHealth4;

    }

    // Update is called once per frame
    void Update()
    {
        playerHealth4.text = health4.ToString();
    }


    public void TakeDamage(int amount)
    {
        health4 -= amount;
        if (health4 <= 0)
        {
            StartCoroutine(Death8());

        }
    }

    private IEnumerator Death8()
    {
        AudioSource.PlayClipAtPoint(playerdeathSFX4, transform.position, playerdeathSFXVolume4);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(22);
    }
   
}