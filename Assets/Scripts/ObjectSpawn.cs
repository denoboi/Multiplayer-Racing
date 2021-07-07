using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject ballPrefab;
    private Vector3 spawnPos = new Vector3(-7, 0, -3);
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ballPrefab, spawnPos, ballPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
