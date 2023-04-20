using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawnerScript : MonoBehaviour
{
    public GameObject wallPrefab;



    void Start()
    {
        this.StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {

            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z);
            GameObject newObject = Instantiate(wallPrefab.gameObject, positionOfSpawnedObject, Quaternion.identity);
            newObject.transform.localScale = new Vector3(1, 1, 1);


            yield return new WaitForSeconds(5);
        }
    }
}
