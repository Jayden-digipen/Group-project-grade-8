using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth6 : MonoBehaviour
{
    public TMP_Text playerHealth6;
    public int health6;
    public int maxHealth6 = 10;
    [SerializeField] AudioClip playerdeathSFX6;
    [SerializeField][Range(0, 1)] float playerdeathSFXVolume6 = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        health6 = maxHealth6;

    }

    // Update is called once per frame
    void Update()
    {
        playerHealth6.text = health6.ToString();
    }


    public void TakeDamage(int amount)
    {
        health6-= amount;
        if (health6 <= 0)
        {
            StartCoroutine(Death8());

        }
    }

    private IEnumerator Death8()
    {
        AudioSource.PlayClipAtPoint(playerdeathSFX6, transform.position, playerdeathSFXVolume6);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(20);
    }
}
