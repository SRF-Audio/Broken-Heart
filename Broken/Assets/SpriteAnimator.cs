using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimator : MonoBehaviour
{
    [SerializeField]private Sprite[] frameArray;
    private int currentFrame;
    private float timer;
    private float Framerate = .1f;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= Framerate)
        {
            timer -= Framerate;
            currentFrame = (currentFrame +1) % frameArray.Length;
            spriteRenderer.sprite = frameArray[currentFrame]; 
               
        }
    }
}
