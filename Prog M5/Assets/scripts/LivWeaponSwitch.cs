using UnityEngine;

public class LivWeaponSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Weapons("Sword", 25f, 1f);
            Debug.Log("Sword: Balanced weapon");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Weapons("Bow", 20f, 15f);
            Debug.Log("Bow: Fast ranged weapon");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Weapons("Staff", 35f, 0.7f);
            Debug.Log("Staff: Powerful but slow");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Weapons("Dagger", 10f, 1f);
            Debug.Log("Dagger: Very fast, low damage");
        }
    }
    private void Weapons(string name, float damage, float attackspeed)
    {
        Debug.Log("Equipped: " + name);
        Debug.Log("Damage: " + damage + " Speed: " + attackspeed);
    }
}
