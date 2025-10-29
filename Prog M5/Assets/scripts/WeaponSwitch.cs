using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    private string currentWeapon;
    private float damage;
    private float speed;
    private void Start()
    {
        SetWeaponStats();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EquipWeapon("Sword");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EquipWeapon("Bow");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EquipWeapon("Staff");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            EquipWeapon("Dagger");
        }
    }
    private void EquipWeapon(string weaponName)
    {
        currentWeapon = weaponName;
        SetWeaponStats();
        Debug.Log("Equipped: " + currentWeapon);
    }

    
    private void SetWeaponStats()
    {
        switch (currentWeapon)
        {
            case "Sword":
                damage = 25;
                speed = 1.0f;
                Debug.Log("Sword: Balanced weapon");
                break;

            case "Bow":
                damage = 20;
                speed = 1.5f;
                Debug.Log("Bow: Fast ranged weapon");
                break;

            case "Staff":
                damage = 35;
                speed = 0.7f;
                Debug.Log("Staff: Powerful but slow");
                break;

            case "Dagger":
                damage = 15;
                speed = 2.0f;
                Debug.Log("Dagger: Very fast, low damage");
                break;

            default:
                damage = 10;
                speed = 1.0f;
                Debug.Log("Unarmed: Weak but always available");
                break;
        }

        Debug.Log("Damage: " + damage + ", Speed: " + speed);
    }



}
