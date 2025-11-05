using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [SerializeField] PlayerMovement player;

 
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //PlayerMovement player = GetComponent<PlayerMovement>();

            if (player.health < player.maxHealth)
            {
                player.health += 50;
                Destroy(gameObject);
                Debug.Log("Health restored");
            }
            else
            {
                Debug.Log("Health already full!");
            }
        }
    }
}
