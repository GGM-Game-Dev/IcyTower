using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawnerScript : MonoBehaviour
{
    [SerializeField] GameObject wallPrefab;
    [SerializeField] float timeBetweenSpawnsInSeconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnRoutine() 
    {
        while (true) 
        {
            GameObject newObject = Instantiate(wallPrefab.gameObject, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeBetweenSpawnsInSeconds);

        }
    }
}
