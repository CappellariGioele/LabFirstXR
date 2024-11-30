using UnityEngine;

/// <summary>
/// Rappresenta un muro che si muove verso l'alto quando abilitato, fino a raggiungere una determinata altezza massima.
/// </summary>
public class MuroDiCasa : MonoBehaviour
{

    #region Fields and Properties

    /// <summary>
    /// Il passo di transizione verticale del muro per ogni aggiornamento.
    /// </summary>
    [SerializeField]
    private float transitionStep;

    /// <summary>
    /// L'altezza massima che il muro può raggiungere.
    /// </summary>
    [SerializeField]
    private float maxHeight;

    /// <summary>
    /// Stato di abilitazione del movimento del muro.
    /// </summary>
    private bool _isEnabled;

    /// <summary>
    /// Proprietà che indica se il movimento del muro è abilitato o meno.
    /// Quando impostata a `true`, il muro inizierà a muoversi verso l'alto.
    /// </summary>
    public bool IsEnabled
    {
        get { return _isEnabled; }
        set { _isEnabled = value; }
    }

    #endregion

    #region Unity Lifecycle Methods

    void Update()
    {
        if (IsEnabled)
        {
            float currentPositionY = transform.position.y;

            if (currentPositionY <= maxHeight)
            {
                transform.Translate(0, transitionStep, 0);
            }
            else
            {
                IsEnabled = false;
            }
        }
    }

    #endregion
}
