using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisAndThat : MonoBehaviour
{
    [SerializeField] GameObject blueCube, redCube, door;

    bool isRedCubeDetected, isBlueCubeDetected, areBothCubesDetected;

    // DIRECTIONS: This script is missing a crucial "if statement" in the Update() method.
    // Nothing in Update() needs to change, but something must be added...
    //
    // The "if statements" in OnTriggerEnter() also need to be fixed.


    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Edmund comments; We need to have areBothCubesDetected to be true, if they are then they will open the door
    // Update is called once per frame
    void Update()
    {
        if (isRedCubeDetected && isBlueCubeDetected)
        {
            areBothCubesDetected = true;
        }

        if (areBothCubesDetected)
        {
            door.GetComponent<MoveToLocation>().enabled = true;
        }
    }

    // If the objects are named what they are in Unity, and they enter the TriggerZone, then their detected booleans will be set to true. This then leads to the update methods 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BlueCube")
        {
            isBlueCubeDetected = true;
        }

        if (other.gameObject.name == "RedCube")
        {
           isRedCubeDetected = true;
        }
    }
}
