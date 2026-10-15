using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject deathScreen;
    private bool isDead = false;

    void Start()
    {
        Time.timeScale = 1f;
        deathScreen.SetActive(false);
    }

    public void PlayerDied()
    {
        if (isDead) return;
        isDead = true;
        deathScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (isDead && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
