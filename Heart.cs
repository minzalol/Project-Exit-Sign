using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;
    [SerializeField] private int life;
    private bool dead;

    private void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if (dead == true)
        {
            // set dead
        }
        
    }

    public void takeDamage(int damage)
    {
        life -= damage;
        Destroy(hearts[life].gameObject);

        if (life < 1)
        {
            dead = true;
        }
    }
}
