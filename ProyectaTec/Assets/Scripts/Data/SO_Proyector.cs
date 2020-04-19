using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "SO_", menuName ="Proyector")]
public class SO_Proyector: ScriptableObject
{
    public Proyector proyector;
    public UnityAction SetProyectorAction;

    public void SetProyector(Proyector p)
    {
        proyector = p;
        SetProyectorAction?.Invoke();
    }
}