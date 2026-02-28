using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    public GameObject trunk;
    public GameObject leaf;

    void Start()
    {
        int height = Random.Range(3,8);

        for(int i=0;i<height;i++)
        {
            Instantiate(trunk,
                new Vector3(0,i,0),
                Quaternion.identity,
                transform);
        }

        int leafAmount = Random.Range(10,20);

        for(int i=0;i<leafAmount;i++)
        {
            Vector3 pos = new Vector3(
                Random.Range(-2,2),
                height,
                Random.Range(-2,2)
            );

            Instantiate(leaf,pos,Quaternion.identity,transform);
        }
    }
}