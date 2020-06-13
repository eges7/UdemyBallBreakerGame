using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    Score score;

    private void Start()
    {
        score = FindObjectOfType<Score>();
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void ScoreToZeroButton()
    {
        score.setScoreToZero();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
