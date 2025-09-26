using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject tower = Instantiate(prefab);
            tower.transform.position = RandomPosition(20f, 20f);
        }
    }
    private Vector3 RandomPosition(float min, float max)
    {
        float x = Random.Range(0f, 1f);
        float y = Random.Range(0f, 1f);
        float z = Random.Range(0f, 1f);
        Vector3 randPos = new Vector3(x, y, z);
        return randPos;
    }
}
