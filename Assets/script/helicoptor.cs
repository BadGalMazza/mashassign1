using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicoptor : MonoBehaviour
{
    public float speed = 0.35f;
    private Vector2 dest = Vector2.zero;
    private SpriteRenderer sr;
    


    private void Start()
    {
        dest = transform.position;
        sr = GetComponent<SpriteRenderer>();
        
    }
    private void FixedUpdate()
    {
        Vector2 temp = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(temp);
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            dest = (Vector2)transform.position + Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            dest = (Vector2)transform.position + Vector2.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            dest = (Vector2)transform.position + Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            dest = (Vector2)transform.position + Vector2.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
            { 
            sr.flipX = false;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            sr.flipX = true;
        }
        
            
        
    }
}


