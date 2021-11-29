using UnityEngine;
using UnityEngine.Events;

public class StageEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent _onStageCompleted;
    [SerializeField] private UnityEvent _onSegmentSpawned;
    [SerializeField] private UnityEvent _onSnakeColorSwitched;
    public static UnityEvent OnSnakeColorSwitched;
    public static UnityEvent OnStageCompleted;
    public static UnityEvent OnSegmentSpawned;

    private void Awake()
    {
        OnStageCompleted = _onStageCompleted;
        OnSegmentSpawned = _onSegmentSpawned;
        OnSnakeColorSwitched = _onSnakeColorSwitched;
    }
}
