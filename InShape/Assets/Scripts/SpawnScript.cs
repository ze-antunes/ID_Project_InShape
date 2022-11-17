using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] balloons;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartSpawning(){
        yield return new WaitForSeconds(8);

        for(int i = 0; i < 3; i++){
            Instantiate(balloons[i], spawnPoints[i].position, Quaternion.identity);
        }

        StartCoroutine(StartSpawning());
    }
}
