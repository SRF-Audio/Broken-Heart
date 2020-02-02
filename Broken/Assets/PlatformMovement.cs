using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public GameObject platform;
    public float speed;
    public Transform current;    
    public Transform[] points;    
    public int pointSelection;


    Vector3 nextPosition; 
    // Start is called before the first frame update
    void Start()
    {
        current = points[pointSelection];
    }

    // Update is called once per frame
    void Update()
    {
        platform.transform.position = Vector3.MoveTowards(platform.transform.position, current.position, Time.deltaTime * speed);

        if(platform.transform.position == current.position)
            {
            pointSelection++;
            if(pointSelection == points.Length)
            {
                pointSelection = 0;
            }
            current = points[pointSelection];
        }
    }
   
}
