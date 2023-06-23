using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage6 : MonoBehaviour
{
    public PlayerHealth6 playerHealth6;
    public int damage = 2;

    [SerializeField] AudioClip enemydeathSFX6;
    [SerializeField][Range(0, 1)] float enemydeathSFXVolume6 = 0.75f;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Dmg1());
        }
    }

    IEnumerator Dmg1()
    {
        AudioSource.PlayClipAtPoint(enemydeathSFX6, transform.position);
        yield return new WaitForSeconds(0.5f);
        playerHealth6.TakeDamage(2);
    }
}
