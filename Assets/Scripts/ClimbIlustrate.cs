using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbIlustrate : MonoBehaviour
{
    [SerializeField] float speed = 0.01f;
    [SerializeField] float yDeadEnd = -10f;
    [SerializeField] float yRelocation =0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
        if (transform.position.y <yDeadEnd) 
        {
            transform.position = new Vector3(transform.position.x, yRelocation, transform.position.z);
        }
    }
}
