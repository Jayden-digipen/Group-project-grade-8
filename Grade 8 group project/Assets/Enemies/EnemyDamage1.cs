using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage1 : MonoBehaviour
{
    public PlayerHealth1 playerHealth1;
    public int damage = 2;

    [SerializeField] AudioClip enemydeathSFX1;
    [SerializeField][Range(0, 1)] float enemydeathSFXVolume1 = 0.75f;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Dmg1());
        }
    }

    IEnumerator Dmg1()
    {
        AudioSource.PlayClipAtPoint(enemydeathSFX1, transform.position);
        yield return new WaitForSeconds(0.5f);
        playerHealth1.TakeDamage(2);
    }
}











