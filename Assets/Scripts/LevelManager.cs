using System.IO;
using UnityEngine;

/// <summary>
/// Gestisce il salvataggio e il caricamento dello stato del gioco, inclusi il punteggio migliore e la posizione di un cubo viola.
/// </summary>
public class LevelManager : MonoBehaviour
{
    #region Fields and Properties

    private string path;
    private GameState gameState;

    #endregion

    #region Unity Lifecycle Methods

    void Start()
    {
        gameState = new GameState();
        path = Application.persistentDataPath + "/gameState.json";
        LoadGameState();
        // carica posizione del cubo viola e best score
        GameObject.Find("VioletCube").transform.position = gameState.violetCubePosition;
        GameObject.Find("GameManager").GetComponent<ScoreManager>().BestScore = gameState.bestScore;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Salva lo stato attuale del gioco su un file JSON nella memoria persistente.
    /// </summary>
    public void SaveGameState()
    {
        // salvo nel oggetto gamestate
        gameState.violetCubePosition = GameObject.Find("VioletCube").transform.position;
        gameState.bestScore = GameObject.Find("GameManager").GetComponent<ScoreManager>().BestScore;

        // salvo su file
        string json = JsonUtility.ToJson(gameState);
        File.WriteAllText(path, json);
    }

    /// <summary>
    /// Carica lo stato del gioco da un file JSON, se esiste.
    /// </summary>
    public void LoadGameState()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            gameState = JsonUtility.FromJson<GameState>(json);
        }
    }

    #endregion

    #region Classi interne

    /// <summary>
    /// Classe serializzabile che rappresenta lo stato del gioco.
    /// Contiene il punteggio migliore e la posizione del cubo viola.
    /// </summary>
    [System.Serializable]
    class GameState
    {
        /// <summary>
        /// Il punteggio migliore raggiunto nel gioco.
        /// </summary>
        public int bestScore;

        /// <summary>
        /// La posizione del cubo viola nel mondo di gioco.
        /// </summary>
        public Vector3 violetCubePosition;
    }

    #endregion
}
