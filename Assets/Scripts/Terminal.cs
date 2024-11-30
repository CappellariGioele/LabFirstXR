using UnityEngine;

/// <summary>
/// Rappresenta un terminale interattivo in grado di abilitare una porta associata
/// e cambiare il proprio stato visivo quando attivato.
/// </summary>
public class Terminal : MonoBehaviour
{
    #region Fields and Properties

    /// <summary>
    /// Indica se il terminale è attualmente abilitato.
    /// </summary>
    private bool isEnabled;

    /// <summary>
    /// Materiale da applicare al terminale quando viene abilitato.
    /// </summary>
    [SerializeField]
    private Material enabledMaterial;

    /// <summary>
    /// Porta associata al terminale che verrà sbloccata quando il terminale è abilitato.
    /// </summary>
    [SerializeField]
    private GameObject door;

    #endregion

    #region Unity Lifecycle Methods

    void Start()
    {
        isEnabled = false;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Abilita il terminale se non è già abilitato.
    /// Quando abilitato:
    /// - Sblocca la porta associata.
    /// - Cambia il materiale del terminale per riflettere lo stato abilitato.
    /// </summary>
    public void Enable()
    {
        if (!isEnabled)
        {
            isEnabled = true;
            door.GetComponent<Door>().Unlock();
            GetComponent<MeshRenderer>().material = enabledMaterial;
        }
    }

    #endregion
}
