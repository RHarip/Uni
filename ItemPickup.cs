using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ItemPickup : MonoBehaviour
{
    public Text itemCountText; // Drag the UI Text here in Inspector
    private List<GameObject> collectedItems = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            collectedItems.Add(other.gameObject);
            Destroy(other.gameObject);
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        itemCountText.text = "Items: " + collectedItems.Count;
    }
}
