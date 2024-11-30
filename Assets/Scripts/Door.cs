using UnityEngine;

public class Door : MonoBehaviour
{
    #region Fields and Properties
    
    /// <summary>
    /// Indica se la porta può ruotare sull'asse Y.
    /// Questo parametro è configurabile tramite l'Inspector di Unity.
    /// </summary>
    [SerializeField]
    private bool shouldRotateOnYAxis;

    /// <summary>
    /// Indica se la porta può ruotare sull'asse Z.
    /// Questo parametro è configurabile tramite l'Inspector di Unity.
    /// </summary>
    [SerializeField]
    private bool shouldRotateOnZAxis;

    /// <summary>
    /// Stato interno che indica se la porta è bloccata.
    /// </summary>
    private bool _isLocked;

    /// <summary>
    /// Proprietà che consente di ottenere o impostare lo stato di blocco della porta.
    /// </summary>
    public bool IsLocked
    {
        get { return _isLocked; }
        set { _isLocked = value; }
    }

    #endregion

    #region Unity Lifecycle Methods

    void Start() 
    {
        IsLocked = true;
        GetComponent<ConfigurableJoint>().angularYMotion = ConfigurableJointMotion.Locked;
        GetComponent<ConfigurableJoint>().angularZMotion = ConfigurableJointMotion.Locked;
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Sblocca la porta e consente la sua rotazione.
    /// Se la porta è bloccata, cambia il suo stato, riproduce un suono e 
    /// consente la rotazione sugli assi Y e Z (se configurato).
    /// </summary>
    /// <returns>
    /// Restituisce true se la porta è stata sbloccata (lo stato IsLocked è false).
    /// Restituisce false se la porta rimane bloccata.
    /// </returns>
    public bool Unlock()
    {
        if (IsLocked)
        {
            IsLocked = false;

            GetComponent<AudioSource>().Play();
        
            if (shouldRotateOnYAxis) 
            {
                GetComponent<ConfigurableJoint>().angularYMotion = ConfigurableJointMotion.Limited;
            }
            if (shouldRotateOnZAxis)
            {
                GetComponent<ConfigurableJoint>().angularZMotion = ConfigurableJointMotion.Limited;
            }
        }

        return !IsLocked;
    }
    
    #endregion
}
