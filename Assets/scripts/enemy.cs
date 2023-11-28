using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class enemy : MonoBehaviour
{
    
    public NavMeshAgent badGuy;

    public float sqareOfmovement = 20f;

    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;

    private float yposistion;
    private float zposistion;
    private float xposistion;

    public float closeEnhouf = 3f;


    // Start is called before the first frame update
    void Start()
    {
        xMax = zMax = sqareOfmovement;
        xMin = zMin = -sqareOfmovement;
        newLocation();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position,new Vector3(xposistion,yposistion,zposistion)) <= closeEnhouf) 
        {
            newLocation();
        }
             
    }

    public void newLocation()
    {
        xposistion = Random.Range(xMin, xMax);
        yposistion = transform.position.y;
        zposistion = Random.Range(zMin, zMax);
        badGuy.SetDestination(new Vector3(xposistion, yposistion, zposistion));
    }
}
