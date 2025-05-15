using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public List<string> collectedItems = new List<string>();
    public Text gemCountText;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void AddItem(string itemName)
    {
        collectedItems.Add(itemName);
        UpdateUI();
    }

    void UpdateUI()
    {
        if (gemCountText != null)
        {
            gemCountText.text = "Gems: " + collectedItems.Count;
        }
    }
}
