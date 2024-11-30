using UnityEngine;

/// <summary>
/// Classe che rappresenta il comportamento di un personaggio chiamato Trump. 
/// Quando il metodo Speak() viene chiamato, riproduce un suono e avvia la costruzione di un muro.
/// </summary>
public class Trump : MonoBehaviour
{
    #region Public Methods

    /// <summary>
    /// Metodo che attiva l'azione di parlare di Trump.
    /// Riproduce un suono associato al componente AudioSource e avvia la costruzione di un muro.
    /// </summary>
    public void Speak()
    {
        GetComponent<AudioSource>().Play();
        // Avvia costruzione muro
        GameObject.Find("MuroDiCasa").GetComponent<MuroDiCasa>().IsEnabled = true;
    }

    #endregion
}
