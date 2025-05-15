using UnityEngine;

public class EnemyDisplay : MonoBehaviour
{
    public EnemyData[] enemies;

    void Start()
    {
        foreach (var enemy in enemies)
        {
            Debug.Log($"{enemy.enemyName} has {enemy.health} health.");
        }
    }
}
