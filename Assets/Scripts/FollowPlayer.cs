using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    Vector3 offset = new Vector3(0,8,-17);
    
    
    void Start()
    {
       
    }

   
    void LateUpdate()
    {
        //kameranin pozisyonu ile player pozisyonu esitleniyor.
        transform.position = player.transform.position + offset;

       
       
    }
}
