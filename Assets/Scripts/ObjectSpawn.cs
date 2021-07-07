using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject ballPrefab;
    private Vector3 spawnPos = new Vector3(-202, 2.50f , 202);
    private Rigidbody ballRb;
    // Start is called before the first frame update

    public float radius = 5.0F;
    public float power = 100.0F;

    //public void Explosion()
    //{
        
    //    //Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
    //    //foreach (Collider hit in colliders)
    //    //{
    //    //    Rigidbody rb = hit.GetComponent<Rigidbody>();

            
                
    //    }
    //}

    void Start()
    {
        ballRb = GetComponent<Rigidbody>();
        
        ballRb.AddForce(Vector3.right * 1000, ForceMode.Impulse);
        InvokeRepeating("ballSpawn", 1, 150);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ballSpawn()
    {
        Instantiate(ballPrefab, spawnPos, ballPrefab.transform.rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {
        PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
        if(playerController)
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 explosionPos = collision.gameObject.transform.position;
            rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
            Debug.Log("exploded");
            Destroy(gameObject);

        }
    }
}
