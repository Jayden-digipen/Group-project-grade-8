using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public TMP_Text playerHealth;
    public int health;
    public int maxHealth = 10;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
      
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth.text = health.ToString();
    }


    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}