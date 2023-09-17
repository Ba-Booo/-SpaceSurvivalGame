using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOre : MonoBehaviour
{

    public GameObject GameObject;

    public int count;   //생성개수

    public float areaSize;  //범위

    
    float playerX;
    float playerZ;
    
    void Start()
    {

        for (int i = 0; i < count; i++)
        {
            playerX = Random.Range(transform.position.x - areaSize, transform.position.x+ areaSize);
            playerZ = Random.Range(transform.position.z - areaSize, transform.position.z + areaSize);
            Instantiate(GameObject, new Vector3(playerX, Terrain.activeTerrain.SampleHeight(new Vector3( playerX, 0, playerZ )), playerZ), Quaternion.identity );    //복제
        }
    }

    void Update()
    {
        
    }

}
