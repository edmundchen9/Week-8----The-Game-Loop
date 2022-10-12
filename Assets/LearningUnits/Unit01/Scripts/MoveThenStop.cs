using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThenStop : MonoBehaviour
{
    Vector3 moveDirection;
    Vector3 destination;

    // DIRECTIONS: In this Unit, no new code should be written. The goal is to use
    // the existing code, rearranged, to get the
    // cube to stop moving when it reaches its destination;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3(.01f, 0, 0);
        destination = transform.position + new Vector3(10, 0, 0);
    }

    // Update is called once per frame

    //edmund's comments: By placing return in the if statement, we have it so that it will transform.Translate everytime the distance is <.1f, so it will move.
    void Update()
    {
        transform.Translate(moveDirection);
        
        if (Vector3.Distance(transform.position, destination) < .1f)
        {
            return;
        }
    }
}
