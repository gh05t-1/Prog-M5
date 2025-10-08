using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float elapsedTime = 0f;  
    public GameObject prefab; //variable or field
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() // method or function
    {
        for (int i = 0; i < 100; i++)
        {
            Color color = RandomColor();
            Vector3 randPos = RandomPosition(-10f, 10f);
            CreateBall(color, randPos);
        }
    }
    private GameObject CreateBall(Color c, Vector3 pos)
    {
       
        GameObject ball = Instantiate(prefab);
        Material mat = ball.GetComponent<MeshRenderer>().material;
        ball.transform.localPosition = pos;

        //Voor URP
        if (mat.shader.name == "Universal Render Pipeline/Lit")
        {
            mat.SetColor("_BaseColor", c);
        }

        return ball;
    }
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            Color color = RandomColor();
            Vector3 randPos = RandomPosition(-100f, 100f);
            GameObject ball = CreateBall(color, randPos);
            DestroyBall(ball);
            elapsedTime = 0f;
        }
    }

    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);
        return randColor;
    }
    private Vector3 RandomPosition(float min, float max )
    {
        float x = Random.Range(0f, 1f);
        float y = Random.Range(0f, 1f);
        float z = Random.Range(0f, 1f);
        Vector3 randPos = new Vector3(x, y, z);
        return randPos;
    }
 
    private void DestroyBall(GameObject ball)
    {
        Destroy(ball, 3f);
    }
}
