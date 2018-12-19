using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    private void Awake () {
        Application.targetFrameRate = 120;

        if (instance == null)
            instance = this;

        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }

    public void PlayerDied () {

    }

    IEnumerator RestartGame () {
        Time.timeScale = 0.3f;
        Time.fixedDeltaTime = 0.0f * Time.timeScale;

        yield return new WaitForSecondsRealtime (2f);

        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
    }
}