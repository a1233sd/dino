using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject Spawn;
    public GameObject[] OBJ;
    void Start()
    {
        InvokeRepeating("a", 1, 1.4f);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void a()
    {
        Spawn = Instantiate(OBJ[Random.Range(0,OBJ.Length)], transform.position, Quaternion.identity) as GameObject;
    }
}
