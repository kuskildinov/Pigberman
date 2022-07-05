using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{
    public float speed;
    public Transform targetPoint;

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sr;
    
    


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }   
    void Update()
    {
       
        Walk();
    }

    void Walk()
    {
        Vector2 target = targetPoint.position;
        if(rb.position != target)
        rb.AddForce(targetPoint.position.normalized * speed * Time.deltaTime);
               
    }
}
