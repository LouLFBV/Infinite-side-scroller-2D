using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private GameObject panelPause;


    [Header("Others")]
    [SerializeField] private MurDeMort murDeMort;

    private void Awake()
    {
        Time.timeScale = 1;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && panelPause != null && !murDeMort.IsPlayerDead)
        {
            panelPause.SetActive(!panelPause.activeSelf);
            Time.timeScale = panelPause.activeSelf ? 0 : 1;
        }

    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ResumeGame()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1;
    }
}
