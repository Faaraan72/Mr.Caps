using UnityEngine;

public class particlesystem : MonoBehaviour
{
    private ParticleSystem particles;

    private void Start()
    {
        // Get the ParticleSystem component from the child GameObject
        particles = GetComponentInChildren<ParticleSystem>();

        // Disable the ParticleSystem at the start
        particles.Stop();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the ParticleSystem component exists and the collision has occurred
        if (particles != null && collision.gameObject.CompareTag("bullet"))
        {
            // Play the ParticleSystem
            particles.Play();

            // Destroy the bullet object
            Destroy(collision.gameObject);
        }
    }
}
