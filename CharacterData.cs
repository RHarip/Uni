using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterData", menuName = "Character/Create New Character")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public float moveSpeed;
    public float jumpHeight;
}
