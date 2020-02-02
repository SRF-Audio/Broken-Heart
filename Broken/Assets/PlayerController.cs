using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float JumpHeight;
    public float speed;
    public bool IsGrounded;
    private Rigidbody2D rb2d;
    private Vector2 velocity;
    private bool facingRight = true;
    private float velX;

    // Start is called before the first frame update
    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * speed;

        velX =Input.GetAxisRaw("Horizontal");

    }
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded == true)
        {
            rb2d.AddForce(new Vector2(0f, JumpHeight), ForceMode2D.Impulse);
        }
              

    }

    void LateUpdate()
    {
        Vector3 localScale = transform.localScale;
        if (velX > 0)
        {
            facingRight = true;
        }
        else if (velX < 0)
        {
            facingRight = false;
        }
        if(((facingRight) && localScale.x < 0) || ((!facingRight) &&(localScale.x >0)))
        {
            localScale.x *= -1;
        }

        transform.localScale = localScale;
    }
        
}
