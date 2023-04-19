using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FloorSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject floorPrefab;
    [SerializeField] float xSpawnOffset;
    [SerializeField] float minTimeToSpawn;
    [SerializeField] float maxTimeToSpawn;
    [SerializeField] float xMinScale;
    [SerializeField] float xMaxScale;


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
            float timeBetweenSpawnsInSeconds = Random.Range(minTimeToSpawn, maxTimeToSpawn);
            float currentXOffset = Random.Range(this.transform.position.x - xSpawnOffset, this.transform.position.x + xSpawnOffset);
            float currentXScale = Random.Range(xMinScale, xMaxScale);

            Vector3 positionOfSpawnedObject = new Vector3(
                currentXOffset,
                transform.position.y,
                transform.position.z);
            GameObject newObject = Instantiate(floorPrefab.gameObject, positionOfSpawnedObject, Quaternion.identity);

            yield return new WaitForSeconds(timeBetweenSpawnsInSeconds);
        }
    }
}
