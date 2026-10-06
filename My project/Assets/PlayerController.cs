using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; 
    public float jumpHeight;
    public KeyCode Spacebar; 
    public KeyCode L; 
    public KeyCode R; 

void start(){

}
void Update ()
{
    if(Input.GetKeyDown(Spacebar)) 
    {
        Jump(); 
    }

    if (Input.GetKey(L)) {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        
    }

    if (Input.GetKey(R)) //When user presses the left arrow button
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }
        
}

void Jump()
{
    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
   
}
}