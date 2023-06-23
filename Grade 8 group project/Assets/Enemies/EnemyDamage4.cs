using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage4 : MonoBehaviour
{

    public PlayerHealth4 playerHealth4;
    public int damage = 2;

    [SerializeField] AudioClip enemydeathSFX4;
    [SerializeField][Range(0, 1)] float enemydeathSFXVolume4 = 0.75f;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Dmg1());
        }
    }

    IEnumerator Dmg1()
    {
        AudioSource.PlayClipAtPoint(enemydeathSFX4, transform.position);
        yield return new WaitForSeconds(0.5f);
        playerHealth4.TakeDamage(2);
    }
}
