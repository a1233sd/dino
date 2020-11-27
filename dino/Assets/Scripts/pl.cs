using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&& IJ==false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 13, 0);
            IJ = true;
        }
    }
    public bool IJ;
    private void OnCollisionEnter2D(Collision2D Coll)
    {
        if (Coll.gameObject.tag == "Finish")
        {
            IJ = false;
        }
        if (Coll.gameObject.tag == "Respawn")
        {
            Application.LoadLevel("SampleScene");
        }
    }
}
