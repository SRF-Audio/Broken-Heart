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
        


    }
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(new Vector2(0f, JumpHeight), ForceMode2D.Impulse);
        }
              

    }
}
