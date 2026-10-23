using UnityEngine;

public class spawner : MonoBehaviour
{
    
     public GameObject[] objects;
    public float rangeX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //creat object every second
        InvokeRepeating(nameof(SpawnObject), 0, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObject()
    {
        int index = UnityEngine.Random.Range(0, objects.Length);
        float rendomX = UnityEngine.Random.Range(-rangeX, rangeX);

        Instantiate(objects[index], new Vector3(rendomX, 0, 16), Quaternion.Euler(0, 180, 0));
    }
}
