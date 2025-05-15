using UnityEngine;

public class ColorChangeZone : MonoBehaviour
{
    public Color zoneColor = Color.red;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Renderer rend = other.GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material.color = zoneColor;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Renderer rend = other.GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material.color = Color.white; // Reset color when leaving
            }
        }
    }
}
