using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemyAttack : MonoBehaviour
{
    private Transform player;

    public float atackRange = 10f;

    private enemy enemyScript;


    public Material defautMaterial;
    public Material allerdMaterial;
    public Renderer ren;

    private bool foundPlayer;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        ren = GetComponent<Renderer>();
        enemyScript = GetComponent<enemy>();
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position,player.position) <= atackRange)
        {
            ren.sharedMaterial = allerdMaterial;
            enemyScript.badGuy.SetDestination(player.position);
            foundPlayer = true;
        }
        else if(foundPlayer)
        {
            // only after chasing, give new random coordinate after no longer being in range of player
            ren.sharedMaterial = defautMaterial;
            enemyScript.newLocation();
            foundPlayer = false;
        }
    }
}
