using UnityEngine;

/// <summary>
/// Rappresenta una chiave che può sbloccare una porta associata.
/// Implementa l'interfaccia <see cref="IKey"/>.
/// </summary>
public class Key : MonoBehaviour, IKey
{
    #region Fields and Properties

    /// <summary>
    /// Riferimento alla porta che la chiave può sbloccare.
    /// </summary>
    [SerializeField]
    private GameObject door;

    #endregion

    #region Unity Collision Methods

    /// <summary>
    /// Metodo chiamato automaticamente da Unity quando un altro oggetto entra in collisione con la chiave.
    /// </summary>
    /// <param name="other">L'oggetto con cui la chiave ha colliso.</param>
    private void OnCollisionEnter(Collision other)
    {
        // Verifica se l'oggetto con cui la chiave ha colliso è la porta associata.
        if (other.gameObject.Equals(door)) 
        {
            UnlockDoor(door);
        }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Tenta di sbloccare la porta specificata.
    /// Se la porta viene sbloccata con successo, distrugge l'oggetto chiave.
    /// </summary>
    /// <param name="door">L'oggetto porta da sbloccare.</param>
    public void UnlockDoor(GameObject door)
    {
        bool unlocked = door.GetComponent<Door>().Unlock();

        // Se la porta è stata sbloccata con successo, distrugge la chiave.
        if (unlocked)
        {
            Destroy(gameObject);
        }
    }

    #endregion
}
