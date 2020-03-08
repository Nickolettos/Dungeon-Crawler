using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Camera camera;
    [SerializeField] NavMeshAgent agent;


    void Start()
    {

    }

    // Update is called once per frame
    void Update() {

        //@param left click
        if (Input.GetMouseButtonDown(0)) {

            //create a ray from the camera pointng to the position of the mouse click
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            //holds information on where the ray hits
            RaycastHit hit;

            //@param the rays and storing the contents into ray. RayCast returns true if it hits something
            if (Physics.Raycast(ray, out hit) == true) {

                agent.SetDestination(hit.point); //tell the object with Agent component to move to the point

            }

       }
    }//Update() brace

} //class brace
