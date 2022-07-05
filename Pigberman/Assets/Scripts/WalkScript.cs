using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour
{
    
    public Vector2 moveVector;
    public float speed;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sr;

    public Sprite rigthMoveSprite;
    public Sprite leftMoveSprite;
    public Sprite UpMoveSprite;
    public Sprite DownMoveSprite;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        Walk();
        FlipSprite();
    }

    /// <summary>
    /// Движение спрайти по нажатию кнопок (+ запуск анимации движения)
    /// </summary>
    void Walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }

    /// <summary>
    /// Меняет спрайт в зависимости от направления движения
    /// </summary>
    void FlipSprite()
    {   
        //движение вправо
        if (moveVector.x > 0)
        {
            sr.sprite = rigthMoveSprite;
        }
        //движение влево
        if (moveVector.x < 0)
        {
            sr.sprite = leftMoveSprite;
        }
        //движение вверх
        if (moveVector.y > 0.5)
        {
            sr.sprite = UpMoveSprite;
        }
        //движение вниз
        if (moveVector.y < -0.5)
        {
            sr.sprite = DownMoveSprite;
        }
    }
}
