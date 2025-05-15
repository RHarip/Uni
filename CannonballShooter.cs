using UnityEngine;

public class CannonballShooter : MonoBehaviour
{
    public GameObject cannonballPrefab;
    public float launchForce = 700f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate cannonball at cannon's position and rotation
        GameObject cannonball = Instantiate(cannonballPrefab, transform.position, transform.rotation);

        // Get Rigidbody and apply force forward
        Rigidbody rb = cannonball.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(transform.forward * launchForce);
        }
    }
}
