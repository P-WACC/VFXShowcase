using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefab;
    public int amount = 100;
    public Vector3 areaSize = new Vector3(20,0,20);

    void Start()
    {
        for(int i=0;i<amount;i++)
        {
            Vector3 pos = new Vector3(
                Random.Range(-areaSize.x, areaSize.x),
                0,
                Random.Range(-areaSize.z, areaSize.z)
            );

            Instantiate(prefab,pos,Quaternion.identity);
        }
    }
}