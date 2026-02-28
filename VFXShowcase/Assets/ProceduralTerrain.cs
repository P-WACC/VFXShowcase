using UnityEngine;

public class ProceduralTerrain : MonoBehaviour
{
    public int width = 100;
    public int height = 100;
    public float scale = 20f;

    void Start()
    {
        Terrain terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
    }

    TerrainData GenerateTerrain(TerrainData data)
    {
        data.heightmapResolution = width + 1;
        data.size = new Vector3(width,20,height);
        data.SetHeights(0,0,GenerateHeights());

        return data;
    }

    float[,] GenerateHeights()
    {
        float[,] heights = new float[width,height];

        for(int x=0;x<width;x++)
        {
            for(int y=0;y<height;y++)
            {
                heights[x,y] = Mathf.PerlinNoise(
                    x*0.1f,
                    y*0.1f
                );
            }
        }

        return heights;
    }
}