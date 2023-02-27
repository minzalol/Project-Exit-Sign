using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 10;
    [SerializeField] private float bentSpeed = 5;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 movementNewInput;
    


    void ProcessInput()
    {
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");
            movementNewInput = new Vector2(moveX, moveY).normalized;
    }

    void OnMove()
        {
            
            if (Input.GetKey(KeyCode.LeftShift) )
            {
                    rb.velocity = new Vector2(movementNewInput.x * playerSpeed, movementNewInput.y * playerSpeed);
                    StaminaBar.instance.UseStamina(1);
                
                
                    
            }
                
            else 
               
            {
                    rb.velocity = new Vector2(movementNewInput.x * bentSpeed, movementNewInput.y * bentSpeed);
                    
            }

        }
        
        void FixedUpdate()
        {
            OnMove();
        }
    
        private void Update()
        {
            ProcessInput();
       
        }

        
}
