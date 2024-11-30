using UnityEngine;
using UnityEngine.UI;

public class ActionUI : MonoBehaviour
{
    #region Fields and Properties

    private Slider slider;

    [SerializeField]
    private GameObject targetCanvas;
    [SerializeField]
    private GameObject targetCube;
    [SerializeField]
    private GameObject targetDoor;

    #endregion

    #region Unity Lifecycle Methods

    void Start() 
    {
        slider = GameObject.Find("ResizeCubeSlider").GetComponent<Slider>();
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Il metodo attiva e disattiva la UI per le azioni.
    /// </summary>
    public void ToggleUI() 
    {
        targetCanvas.SetActive(!targetCanvas.activeSelf);
    }

    /// <summary>
    /// Il metodo apre la porta dell'armadio se non è stato aperto.
    /// </summary>
    public void OpenArmadioDoor()
    {
        targetDoor.transform.Rotate(0, 0, 90);
    }

    /// <summary>
    /// Il metodo scala la grandezza del cubo verde in base al valore dello slider.
    /// </summary>
    public void ScaleGreenCube()
    {
        targetCube.transform.localScale = new Vector3(slider.value, slider.value, slider.value);
    }

    #endregion
}
