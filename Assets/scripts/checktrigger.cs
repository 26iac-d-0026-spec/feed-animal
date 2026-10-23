using UnityEngine;

public class checktrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("animal"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
