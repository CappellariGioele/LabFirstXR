using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    #region Public Methods

    /// <summary>
    /// Il Metodo salva la partita e ti riporta al menu.
    /// </summary>
    public void ReturnToMenu()
    {
        GameObject.Find("GameManager").GetComponent<LevelManager>().SaveGameState();
        SceneManager.LoadScene("Menu");
    }

    /// <summary>
    /// Il metodo avvia la scena del gioco.
    /// </summary>
    public void PlayGame()
    {
        SceneManager.LoadScene("BasicScene");
    }

    /// <summary>
    /// Il metodo chiude l'applicazione Unity.
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }

    #endregion
}
