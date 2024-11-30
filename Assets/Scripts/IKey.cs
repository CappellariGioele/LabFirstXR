using UnityEngine;

/// <summary>
/// Interfaccia che rappresenta una chiave in grado di sbloccare una porta.
/// Le classi che implementano questa interfaccia devono definire il comportamento di sblocco.
/// </summary>
public interface IKey
{
    /// <summary>
    /// Sblocca la porta passata come parametro.
    /// Il metodo verrà implementato dalle classi che rappresentano una chiave
    /// e che definiscono la logica per sbloccare una porta specifica.
    /// </summary>
    /// <param name="door">La porta da sbloccare. Deve essere un oggetto di tipo GameObject
    /// che rappresenta una porta nel gioco.</param>
    void UnlockDoor(GameObject door);
}
