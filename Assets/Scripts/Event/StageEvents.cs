using UnityEngine;
using UnityEngine.Events;

public class StageEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent _onStageCompleted;
    [SerializeField] private UnityEvent _onSegmentSpawned;
    public static UnityEvent OnStageCompleted;
    public static UnityEvent OnSegmentSpawned;

    private void Awake()
    {
        OnStageCompleted = _onStageCompleted;
        OnSegmentSpawned = _onSegmentSpawned;
    }
}
