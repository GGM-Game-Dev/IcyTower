using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeManager : MonoBehaviour
{
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject stage1;
    [SerializeField] GameObject stage2;
    [SerializeField] GameObject stage3;
    [SerializeField] GameObject stage4;
    
    [HideInInspector] public bool gameIsOn = true;

    [SerializeField] FloorSpawnerScript floorSpawner;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(stage1Activation(2));

        IEnumerator stage1Activation(int secs)
        {
            if (gameIsOn) 
            {
                yield return new WaitForSeconds(secs);
                Instantiate(stage1);
                floorSpawner.GetComponent<FloorSpawnerScript>().spawnSpeed = 0.03f;
            }
            
        }

        StartCoroutine(stage2Activation(10));

        IEnumerator stage2Activation(int secs)
        {
            if (gameIsOn)
            {
                yield return new WaitForSeconds(secs);
                Instantiate(stage2);
                floorSpawner.GetComponent<FloorSpawnerScript>().spawnSpeed = 0.05f;


            }
        }

        StartCoroutine(stage3Activation(20));

        IEnumerator stage3Activation(int secs)
        {
            if (gameIsOn)
            {
                yield return new WaitForSeconds(secs);
                Instantiate(stage3);
                floorSpawner.GetComponent<FloorSpawnerScript>().xMaxScale = 1;

            }
        }

        StartCoroutine(stage4Activation(30));

        IEnumerator stage4Activation(int secs)
        {
            if (gameIsOn)
            {
                yield return new WaitForSeconds(secs);
                Instantiate(stage4);
                floorSpawner.GetComponent<FloorSpawnerScript>().spawnSpeed = 0.07f;

            }
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GameOver() 
    {
        Instantiate(gameOver);
        gameIsOn = false;
    }
}
