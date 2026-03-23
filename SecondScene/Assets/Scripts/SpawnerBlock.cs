using UnityEngine;

public class SpawnerBlock : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float spawnInterval = 2f;
    [SerializeField] private int spawnHauteur = 1;
    private float _timer;

    [Header("Prefabs")]
    [SerializeField] private GameObject blockPrefab;
    [SerializeField] private GameObject blockPrefab2;
    [SerializeField] private GameObject blockPrefab3;

    void Update()
    {
        if (Time.time - _timer > spawnInterval)
        {
            SpawnBlock();
            _timer = Time.time;
        }
    }

    private void SpawnBlock()
    {
        int random = Random.Range(0, 3);
        int randomHauteur = Random.Range(0, spawnHauteur);

        Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + randomHauteur);
        if (random == 0)
        {
            Instantiate(blockPrefab, spawnPosition, Quaternion.identity);
        }
        else if (random == 1)
        {
            Instantiate(blockPrefab2, spawnPosition, Quaternion.identity);
        }
        else
        {
            Instantiate(blockPrefab3, spawnPosition, Quaternion.identity);
        }
    }
}
