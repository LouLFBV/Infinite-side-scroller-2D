using TMPro;
using UnityEngine;
using System.Collections; 

public class MurDeMort : MonoBehaviour
{
    [Header("Panel de Mort")]
    [SerializeField] private GameObject panelDeMort;
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;

    [Header("Audio")]
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private float fadeOutDuration = 2f; 

    public bool IsPlayerDead { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IsPlayerDead = true;    
            textMeshProUGUI.text = $"Final score : {PlayerController.instance.GetScore()}";
            panelDeMort.SetActive(true);

            StartCoroutine(FadeOutAudio());
        }
    }

    private IEnumerator FadeOutAudio()
    {
        float startVolume = audioSource.volume; 
        float timer = 0f;

        while (timer < fadeOutDuration)
        {
            timer += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(startVolume, 0f, timer / fadeOutDuration);
            yield return null; 
        }

        audioSource.volume = 0f;
    }
}
