using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCreateScript : MonoBehaviour
{
    public GameObject player;
    public GameObject bomb;
   
     
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject newBomb = Instantiate(bomb, transform.position, Quaternion.identity);
        }
    }

   
}
