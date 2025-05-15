using UnityEngine;

public class CharacterPrinter : MonoBehaviour
{
    public CharacterData character;

    void Start()
    {
        if (character != null)
        {
            Debug.Log("Character Name: " + character.characterName);
            Debug.Log("Speed: " + character.moveSpeed);
            Debug.Log("Jump Height: " + character.jumpHeight);
        }
        else
        {
            Debug.LogWarning("Character data not assigned!");
        }
    }
}
