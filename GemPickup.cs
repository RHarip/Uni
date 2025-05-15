using UnityEngine;

public class GemPickup : MonoBehaviour
{
    public string gemName = "Gem";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InventoryManager.instance.AddItem(gemName);
            Destroy(gameObject);
        }
    }
}
