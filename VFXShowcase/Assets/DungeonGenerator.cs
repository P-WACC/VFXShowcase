using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    public GameObject floor;
    public int width = 20;
    public int height = 20;

    void Start()
    {
        for(int x=0;x<width;x++)
        {
            for(int z=0;z<height;z++)
            {
                if(Random.value > 0.3f)
                {
                    Instantiate(floor,new Vector3(x,0,z),Quaternion.identity);
                }
            }
        }
    }
}