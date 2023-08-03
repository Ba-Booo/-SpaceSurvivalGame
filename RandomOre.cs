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
        
        playerX = transform.position.x;
        playerZ = transform.position.z;

        for (int i = 0; i < count; i++)
        {
            Instantiate(GameObject, new Vector3(Random.Range(playerX - areaSize, playerX + areaSize), 10, Random.Range(playerZ - areaSize, playerZ + areaSize)), Quaternion.identity );    //복제
        }

    }

    void Update()
    {
        
    }

}
