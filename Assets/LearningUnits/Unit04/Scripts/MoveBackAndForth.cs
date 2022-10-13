using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    [SerializeField] GameObject destinationObject;

    Vector3 startPosition;
    [SerializeField] float moveSpeed;
    float moveAmount;


    
    void Start()
    {
        startPosition = transform.position;
        moveAmount = 0;
    }


    void Update()
    {

        transform.position = Vector3.Lerp(startPosition, destinationObject.transform.position, moveAmount);


        if (moveAmount > 0 && transform.position == startPosition)
        {
            moveSpeed = -moveSpeed;
        }


        moveAmount += moveSpeed;


        if ( moveAmount > 0.999 )
        {
            moveSpeed = -moveSpeed;
        }

        


    }
}
