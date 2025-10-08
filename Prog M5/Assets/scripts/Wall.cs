using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        var cubeRenderer = GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_BaseColor", Color.magenta);
    }
   private void OnTriggerEnter(Collider other)
    {
        Debug.Log("touched gate");
        Destroy(gameObject);
    }
}
