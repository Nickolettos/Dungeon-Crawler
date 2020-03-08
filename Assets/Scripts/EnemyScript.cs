using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    //the transform array of points will be assigned in inspector using game objects in the scene as indicators
    [SerializeField] Transform[] points;
    private int destinationPoint = 0;
    private NavMeshAgent agent;

    //this player will be assigned in inspector and should be the player game object
    [SerializeField] GameObject player;


    //
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;

        GoToNextPoint();

    }

    // Update is called once per frame
    void Update()
    {

        if (!agent.pathPending && agent.remainingDistance < 0.5f) {
            GoToNextPoint();
        }

    }

    void GoToNextPoint()
    {

        //No points have been set up
        if (points.Length == 0)
        {

            return;
        }

        //tells the agent to go to currently selected destination
        agent.destination = points[destinationPoint].position;

        //Choose the next point in the array as the destination
        destinationPoint = (destinationPoint + 1) % points.Length;

    }

   
 
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player") {

       
            Vector3 point = player.transform.position;
            agent.destination = point;
        }

    }

    /*
    private void OnTriggerStay(Collider other) {
    
        Vector3 point = player.transform.position;
        agent.destination = point;
    
    }
    */

    private void OnTriggerExit(Collider other)
    {
       
        //oToNextPoint();
    }

}
