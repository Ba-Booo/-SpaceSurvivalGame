using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreation : MonoBehaviour
{

    Terrain terrain;
    
    public Transform Target;

    float[ , ] terrainHeightData;

    public int size;
    public int aroundChunk;

    public float refinement;    //주파수
    public float maxHeight;     //최대높이

    void Start()
    {
        //초기화
        MapShape();
    }

    void Update()
    {

        //청크 위치
        if( transform.position.x + aroundChunk + size <= Target.position.x )        //x좌표
        {
            transform.position = new Vector3(transform.position.x + 257 ,0 ,transform.position.z);
            MapShape();
        }
        else if( transform.position.x - aroundChunk >= Target.position.x )
        {
            transform.position = new Vector3(transform.position.x - 257 ,0 ,transform.position.z);
            MapShape();
        }

        if( transform.position.z + aroundChunk + size <= Target.position.z )        //z좌표
        {
            transform.position = new Vector3(transform.position.x ,0 ,transform.position.z + 257);
            MapShape();
        }
        else if( transform.position.z - aroundChunk >= Target.position.z )
        {
            transform.position = new Vector3(transform.position.x ,0 ,transform.position.z - 257);
            MapShape();
        }

    }

    void MapShape()
    {
        
        terrain = GetComponent<Terrain>();

        terrainHeightData = new float[size, size];

        for(int x = 0; x < size; x++)
        {

            for(int y = 0; y < size; y++)
            { 
                //1000은 대칭방지용
                terrainHeightData[y, x] = Mathf.PerlinNoise( (y + transform.position.z + 1000) * refinement, (x + transform.position.x + 1000) * refinement ) * maxHeight;

            }

        }

        terrain.terrainData.SetHeights(0, 0, terrainHeightData);

    }

}
