using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform playerTransform;
    // Start is called before the first frame update

    //enable and set y max and min
    public bool yMaxEnabled = false;
    public bool yMinEnabled = false;
    public float yMaxValue = 0;
    public float yMinValue = 1;


    public bool xMaxEnabled = false;
    public bool xMinEnabled = false;
    public float xMaxValue = 0;
    public float xMinValue = 1;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        Vector3 temp = transform.position;

        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;

        transform.position = temp;

        //veritical constraints
        if(yMaxEnabled && yMinEnabled)
        {
            temp.y = Mathf.Clamp(playerTransform.position.y, yMinValue, yMaxValue);
        }
        else if (yMinEnabled)
        {
            temp.y = Mathf.Clamp(playerTransform.position.y, yMinValue, playerTransform.position.y);
        }
        else if (yMaxEnabled)
        {
            temp.y = Mathf.Clamp(playerTransform.position.y, playerTransform.position.y, yMaxValue);
        }


        //horizontal constraints
        if (xMaxEnabled && xMinEnabled)
        {
            temp.x = Mathf.Clamp(playerTransform.position.x, xMinValue, xMaxValue);
        }
        else if (xMinEnabled)
        {
            temp.x = Mathf.Clamp(playerTransform.position.x,  xMinValue, playerTransform.position.x);
        }
        else if (xMaxEnabled)
        {
            temp.x = Mathf.Clamp(playerTransform.position.x, playerTransform.position.x, xMaxValue);
        }

        transform.position = temp;

    }
}
