using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDamage3 : MonoBehaviour
{
    public PlayerHealth3 playerHealth3;
    public int damage = 2;

    [SerializeField] AudioClip enemydeathSFX3;
    [SerializeField][Range(0, 1)] float enemydeathSFXVolume3 = 0.75f;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Dmg1());
        }
    }

    IEnumerator Dmg1()
    {
        AudioSource.PlayClipAtPoint(enemydeathSFX3, transform.position);
        yield return new WaitForSeconds(0.5f);
        playerHealth3.TakeDamage(2);
    }
}
