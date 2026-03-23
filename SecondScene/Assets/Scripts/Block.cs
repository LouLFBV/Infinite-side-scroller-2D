using UnityEngine;

public class Block : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 2f;

    [Header("Score Settings")]
    [SerializeField] private int scoreValue = 1;
    private bool _isPickUp = false;

    private void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector2.left);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !_isPickUp)
        {
            PlayerController.instance.AddScore(scoreValue);
            _isPickUp = true;
        }
    }
}
