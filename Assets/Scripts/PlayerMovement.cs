using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 4f;
    public Rigidbody2D body;
    
    public Animator animator;

    public ShopDialogueManager shopDialogueManager;


    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //animator parameters
        if(movement!=Vector2.zero)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
        }
        animator.SetFloat("Speed", movement.sqrMagnitude);

        //Disables movement and animations while in dialogue scenarios
        if(shopDialogueManager.GetComponent<ShopDialogueManager>().inDialogueEvent)
        {
            movement = Vector2.zero;
            animator.SetFloat("Horizontal", 0.0f);
            //use Up_Idle when in dialogue with shopkeeper
            animator.SetFloat("Vertical", 1.0f);
            animator.SetFloat("Speed", 0.0f);
        }

    }

    void FixedUpdate()
    {

        //body translation calculation
        body.MovePosition(body.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

}
