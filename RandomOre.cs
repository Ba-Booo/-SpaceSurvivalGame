using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOre : MonoBehaviour
{

    public GameObject GameObject;

    public int count;   //생성개수

    public float areaSize;  //범위

    void Start()
    {

        for (int i = 0; i < count; i++)
        {
            Instantiate(GameObject, new Vector3(Random.Range(areaSize * -1, areaSize), 0, Random.Range(areaSize * -1, areaSize)), Quaternion.identity );    //복제
        }

    }

    void Update()
    {
        
    }

}