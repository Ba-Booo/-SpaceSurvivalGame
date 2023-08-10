using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreation : MonoBehaviour
{

    Terrain terrain;

    float[ , ] terrainHeightData;

    public int size;

    public float refinement;    //주파수
    public float maxHeight;     //최대높이

    void Start()
    {
        terrain = GetComponent<Terrain>();

        terrainHeightData = new float[size, size];

        for(int x = 0; x < size; x++)
        {

            for(int y = 0; y < size; y++)
            { 

                terrainHeightData[y, x] = Mathf.PerlinNoise( (y + transform.position.z) * refinement, (x + transform.position.x) * refinement ) * maxHeight;

            }

        }

        terrain.terrainData.SetHeights(0, 0, terrainHeightData);

    }

}
