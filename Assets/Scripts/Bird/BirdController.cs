using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    
    public GameObject bird;
    public GameObject point;
    public  SlingShotController slingShotController;


    public float launchForce;


    private void Awake()
    {
        spawnBird();
    }


    private void Update()
    {
        if(slingShotController.isDragging)
        {
            print("Dragg");
            dragBird();
        }

        if(slingShotController.isReleased)
        {
            releaseBird();
        }
    }


    void spawnBird()
    {
        GameObject thisBird = Instantiate(bird, slingShotController.idleStripePoint.position, Quaternion.identity);
    }


    void dragBird()
    {
        bird.transform.position = slingShotController.dragEndPos;
    }

    void releaseBird()
    {


    }






}
