using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Player Health: " + health);

        if (health <= 0)
        {
            Debug.Log("Player is dead!");
            // Add death logic here if you want
        }
    }
}
