using UnityEngine;
using UnityEngine.UIElements;

public class Tower : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = RandomSize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 RandomSize()
    {
        float x = Random.Range(0f, 1f);
        float y = Random.Range(0f, 1f);
        float z = Random.Range(0f, 1f);
        return new Vector3(x, y, z);

    }
}
