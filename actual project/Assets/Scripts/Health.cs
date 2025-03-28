using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private Shield shield;
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public Animator anim;

    public int maxHealth = 4;

    void Start()
    {
        health = maxHealth;
        shield = GetComponent<Shield>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            SceneManager.LoadScene("Death Screen");
            Destroy(gameObject);
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(!shield.ActiveShield)
        {
            if(other.tag == "Enemy")
            {
                TakeDamage(0);
            }
        }
    }

    void Update()
    {
        if(health > numOfHearts) 
        {
            health = numOfHearts;
        }





        for (int i = 0; i < hearts.Length; i++)

        {
            if(i < health){
                hearts[i].sprite = fullHeart;   
            } else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts) {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        
        }
    }
}
