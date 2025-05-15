using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "Enemy/Enemy Data")]
public class EnemyData : ScriptableObject
{
    public string enemyName;
    public int health;
}
