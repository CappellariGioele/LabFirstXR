using UnityEngine;

/// <summary>
/// Rappresenta una radio che può essere accesa e messa in pausa, gestendo la riproduzione dell'audio.
/// </summary>
public class Radio : MonoBehaviour
{
    #region Fields and Properties
    private bool isPlaying;

    #endregion
    
    #region Unity Lifecycle Methods

    void Start()
    {
        isPlaying = false;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Alterna lo stato della radio tra acceso (riproduzione audio) e pausa.
    /// </summary>
    public void TurnOnPause()
    {
        if (isPlaying)
        {
            GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<AudioSource>().Pause();
        }

        isPlaying = !isPlaying;
    }

    #endregion
}
