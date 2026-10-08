using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private TMP_Text distanceText;

    [SerializeField] private GameObject results;
    [SerializeField] private TMP_Text finalDistanceText;
    [SerializeField] private AudioManager audioManager;
    private bool gameOverShown = false;

    private void Awake()
    {
        results.SetActive(false);
    }

    void Update()
    {
       int distance = Mathf.FloorToInt(player.distance);
       distanceText.text = distance + " m";

        if (player.isDead)
        {
            results.SetActive(true);
            finalDistanceText.text = distance + " m";

            if (!gameOverShown)
            {
                gameOverShown = true;
                audioManager.StopMusic();
                audioManager.PlayDeath();
            }
        }
    }

    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
