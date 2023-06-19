using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 2;

    [SerializeField] AudioClip enemydeathSFX;
    [SerializeField][Range(0, 1)] float enemydeathSFXVolume = 0.75f;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            playerHealth.TakeDamage(damage);
            AudioSource.PlayClipAtPoint(enemydeathSFX, Camera.main.transform.position, enemydeathSFXVolume);
            GetComponent<CapsuleCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }

}






