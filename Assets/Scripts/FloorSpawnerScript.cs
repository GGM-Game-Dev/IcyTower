using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FloorSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject floorPrefab;
    
    [SerializeField] float xSpawnOffset;
    [SerializeField] float minTimeToSpawn;
    [SerializeField] float maxTimeToSpawn;
    [SerializeField] float xMinScale;
    public float xMaxScale;

    public float spawnSpeed = 0.03f;


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
            newObject.transform.localScale = new Vector3(currentXScale, 0.3f, 1);
            newObject.GetComponent<AddForceScript>().velocity = spawnSpeed;
            

            yield return new WaitForSeconds(timeBetweenSpawnsInSeconds);
        }
    }
}
