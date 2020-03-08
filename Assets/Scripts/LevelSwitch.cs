using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelSwitch : MonoBehaviour
{
 
    

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player" && ) {

            SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
        }


    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



    }
}
