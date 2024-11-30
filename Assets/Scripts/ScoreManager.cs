using TMPro;
using UnityEngine;

/// <summary>
/// Gestisce il punteggio corrente e il miglior punteggio di gioco,
/// aggiornando l'interfaccia grafica (GUI) per riflettere i cambiamenti.
/// </summary>
public class ScoreManager : MonoBehaviour
{
    #region Fields and Properties

    private GameObject actualScoreGUI;
    private GameObject bestScoreGUI;

    /// <summary>
    /// Punteggio corrente del giocatore.
    /// Quando viene modificato, aggiorna il relativo elemento GUI.
    /// </summary>
    private int _score;

    /// <summary>
    /// Proprietà per ottenere o impostare il punteggio corrente.
    /// Modificare questa proprietà aggiorna automaticamente la GUI.
    /// </summary>
    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            actualScoreGUI.GetComponent<TextMeshProUGUI>().text = $"{value}";

            if (Score > BestScore) 
            {
                BestScore = Score;
            }
        }
    }

    /// <summary>
    /// Miglior punteggio raggiunto dal giocatore.
    /// </summary>
    private int _bestScore;

    /// <summary>
    /// Proprietà per ottenere o impostare il miglior punteggio.
    /// </summary>
    public int BestScore
    {
        get { return _bestScore; }
        set 
        {
            _bestScore = value; 
            bestScoreGUI.GetComponent<TextMeshProUGUI>().text = $"{BestScore}";
        }
    }

    #endregion

    #region Unity Lifecycle Methods

    void Start()
    {
        actualScoreGUI = GameObject.Find("ActualScore");
        bestScoreGUI = GameObject.Find("BestScore");
    }

    #endregion
}
