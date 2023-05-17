using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;


public class CinematicaStarter : MonoBehaviour
{
    public string juegoSceneName = "Level";

    private void Start()
    {
        GetComponent<PlayableDirector>().played += OnPlayableDirectorPlayed;
        GetComponent<PlayableDirector>().stopped += OnPlayableDirectorStopped;
    }

    private void OnPlayableDirectorPlayed(PlayableDirector playableDirector)
    {
        Time.timeScale = 0; // Pausa el juego mientras se reproduce la cinemática
    }

    private void OnPlayableDirectorStopped(PlayableDirector playableDirector)
    {
        Time.timeScale = 1; // Reanuda el juego después de la cinemática

        SceneManager.LoadScene(juegoSceneName); // Carga la escena del juego principal
    }
}

