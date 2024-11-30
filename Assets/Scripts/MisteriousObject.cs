using System.Collections;
using UnityEngine;

/// <summary>
/// Gestisce il comportamento di un oggetto misterioso che può essere raccolto.
/// Quando raccolto, aggiorna il punteggio, cambia stato visivo e sonoro, e si autodistrugge.
/// </summary>
public class MisteriousObject : MonoBehaviour
{
    #region Fields and Properties

    /// <summary>
    /// Riferimento al GameObject che rappresenta il GameManager.
    /// </summary>
    private GameObject gameManager;

    #endregion

    #region Unity Lifecycle Methods

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    #endregion

    #region Private Methods
    /// <summary>
    /// Cambia lo stato dell'oggetto misterioso (colore e audio) e lo distrugge dopo un breve ritardo.
    /// </summary>
    /// <returns>Un enumeratore che gestisce il ritardo nella distruzione dell'oggetto.</returns>
    private IEnumerator ChangeStateAndDestroy()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        gameObject.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Raccoglie l'oggetto misterioso.
    /// Incrementa il punteggio e avvia la sequenza di distruzione.
    /// </summary>
    public void Collect()
    {
        gameManager.GetComponent<ScoreManager>().Score++;
        StartCoroutine(ChangeStateAndDestroy());
    }

    #endregion
}
