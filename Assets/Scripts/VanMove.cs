using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanMove : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        StartCoroutine(PowerupCountdownRoutine());
    }
    IEnumerator PowerupCountdownRoutine() 
    {
        yield return new WaitForSeconds(25);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

}
    
        
            


