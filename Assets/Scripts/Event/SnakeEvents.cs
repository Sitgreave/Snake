
using UnityEngine;
using UnityEngine.Events;

public class SnakeEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent _onNewSegmentSpawned;
    public static UnityEvent OnNewSegmentSpawned;
    [SerializeField] private UnityEvent _onSegmentDestroyed;
    public static UnityEvent OnSegmentDestroyed;
    private void Start()
    {
        OnNewSegmentSpawned = _onNewSegmentSpawned;
        OnSegmentDestroyed = _onSegmentDestroyed;
    }
}
