using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreation : MonoBehaviour
{

    Terrain terrain;

    float[ , ] terrainHeightData;

    public int rowsAndColumns;

    public float refinement;
    public float maxHeight;

    void Start()
    {
        terrain = GetComponent<Terrain>();

        terrainHeightData = new float[rowsAndColumns, rowsAndColumns];

        for(int x = 0; x < rowsAndColumns; x++)
        {

            for(int y = 0; y < rowsAndColumns; y++)
            { 

                terrainHeightData[x,y] = Mathf.PerlinNoise(x * refinement, y * refinement) * maxHeight;

            }

        }

        terrain.terrainData.SetHeights(0, 0, terrainHeightData);

    }

}
