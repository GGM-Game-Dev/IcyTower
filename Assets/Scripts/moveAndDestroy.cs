using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAndDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 0.01f;
    [SerializeField] float rotarion = 270;
    void Start()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + rotarion);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
        
    }
}
