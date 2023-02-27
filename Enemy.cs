using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Heart life;
    [SerializeField] private int damage = 1;

     private void OnTriggerEnter2D(Collider2D col)

     {

         if (col.CompareTag("Player"))
         {
             life.takeDamage(damage);
         }
         
     }
}
