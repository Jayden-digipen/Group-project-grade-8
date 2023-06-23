using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth5 : MonoBehaviour
{
    public TMP_Text playerHealth5;
    public int health5;
    public int maxHealth5 = 10;
    [SerializeField] AudioClip playerdeathSFX5;
    [SerializeField][Range(0, 1)] float playerdeathSFXVolume5 = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        health5 = maxHealth5;

    }

    // Update is called once per frame
    void Update()
    {
        playerHealth5.text = health5.ToString();
    }


    public void TakeDamage(int amount)
    {
        health5-= amount;
        if (health5 <= 0)
        {
            StartCoroutine(Death8());

        }
    }

    private IEnumerator Death8()
    {
        AudioSource.PlayClipAtPoint(playerdeathSFX5, transform.position, playerdeathSFXVolume5);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(24);
    }
}
