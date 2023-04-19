using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestruction : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int destroyTime = 5; 
    void Update() { 
        Destroy(gameObject, destroyTime); 
    }
}
