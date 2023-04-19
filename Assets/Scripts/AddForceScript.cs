using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceScript : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float velocity = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - velocity, transform.position.z);
    }
}
