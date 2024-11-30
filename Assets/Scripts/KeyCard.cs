using UnityEngine;

/// <summary>
/// Rappresenta una chiave magnetica (KeyCard) che interagisce con un terminale.
/// Implementa l'interfaccia <see cref="IKey"/>.
/// </summary>
public class KeyCard : MonoBehaviour, IKey
{
    #region Fields and Properties

    /// <summary>
    /// Riferimento al terminale con cui la KeyCard può interagire.
    /// </summary>
    [SerializeField]
    private GameObject terminal;

    #endregion

    #region Unity Colison Methods

    /// <summary>
    /// Metodo chiamato automaticamente da Unity quando un altro oggetto entra in collisione con la KeyCard.
    /// </summary>
    /// <param name="other">L'oggetto con cui la KeyCard ha colliso.</param>
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.Equals(terminal))
        {
            UnlockDoor(terminal);
        }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Abilita il terminale specificato per simulare lo sblocco della porta associata.
    /// </summary>
    /// <param name="terminal">L'oggetto terminale da abilitare.</param>
    public void UnlockDoor(GameObject terminal)
    {
        terminal.GetComponent<Terminal>().Enable();
    }

    #endregion
}