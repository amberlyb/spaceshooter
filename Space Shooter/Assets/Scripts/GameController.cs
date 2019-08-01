using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    public AudioSource musicSource;

    public Text scoreText;
    public Text restartText;
    public Text gameOverText;
    public Text winText;

    private bool gameOver;
    private bool restart;
    private int score;

    void Start ()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        winText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine (SpawnWaves ());
        musicSource.Play();
    }

    void Update ()
    {
        if (restart)
        {
            if (Input.GetKeyDown (KeyCode.U))
            {
                SceneManager.LoadScene("Main");
            }
        }
        if (Input.GetKey("escape"))
            Application.Quit();

        if (score >= 100)
        {
            musicSource.clip = musicClip;
            musicSource.Play();
        }
    }

    IEnumerator SpawnWaves ()
    {
        yield return new WaitForSeconds (startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range (0, hazards.Length)];
                Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate (hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds (spawnWait);
            }
            yield return new WaitForSeconds (waveWait);

            if (gameOver)
            {
                restartText.text = "Press 'U' for Restart";
                restart = true;
                break;
                //musicSource.clip = musicClipTwo;
                //musicSource.Play();
            }
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Points: " + score;
        if (score >= 100)
        {
            winText.text = "You win! Game created by Amberly Brewster";
            gameOver = true;
        }
    }

    public void GameOver ()
    {
        gameOverText.text = "Game Over! Game created by Amberly Brewster";
        gameOver = true;
    }
}
