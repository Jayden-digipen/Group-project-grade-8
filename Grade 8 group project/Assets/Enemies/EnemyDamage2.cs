using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage2 : MonoBehaviour
{
    public PlayerHealth2 playerHealth2;
    public int damage = 2;

    [SerializeField] AudioClip enemydeathSFX2;
    [SerializeField][Range(0, 1)] float enemydeathSFXVolume2 = 0.75f;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Dmg1());
        }
    }

    IEnumerator Dmg1()
    {
        AudioSource.PlayClipAtPoint(enemydeathSFX2, transform.position);
        yield return new WaitForSeconds(0.5f);
        playerHealth2.TakeDamage(2);
    }
}
