using UnityEngine;

public class CollectFuel : MonoBehaviour
{
    [SerializeField] private AudioClip collisionSound; 
    [SerializeField] private float soundVolume = 1.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collisionSound != null)
            {
                AudioSource.PlayClipAtPoint(collisionSound, transform.position, soundVolume);
            }

            FuelController.Instance.FillFuel(gameObject.tag);

            Destroy(gameObject);
        }
    }
}
