using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader5555555 : MonoBehaviour
{




    [SerializeField] AudioClip playerdeathSFX;
    [SerializeField][Range(0, 1)] float playerdeathSFXVolume = 0.75f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        AudioSource.PlayClipAtPoint(playerdeathSFX, transform.position, playerdeathSFXVolume);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(14);
    }
}
