using UnityEngine;

public class Gold : MonoBehaviour
{
    [Header("Float Settings")]
    [SerializeField] private int goldValue = 1;
    [SerializeField] private float floatAmplitude = 0.5f; 
    [SerializeField] private float floatSpeed = 1f;

    private float initialY;

    private void Start()
    {
        initialY = transform.position.y;
    }

    private void Update()
    {
        float newY = initialY + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController.instance.AddScore(goldValue);
            AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.audioSource.clip);
            Destroy(gameObject);
        }
    }
}
