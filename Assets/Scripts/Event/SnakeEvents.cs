
using UnityEngine;
using UnityEngine.Events;

public class SnakeEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent _onFeverActivated;
    [SerializeField] private UnityEvent _onSegmentCountChanged;
    public static UnityEvent OnSegmentCountChanged;
    public static UnityEvent OnFeverActivated;
    
    private void Start()
    {
        OnFeverActivated = _onFeverActivated;
        OnSegmentCountChanged = _onSegmentCountChanged;
    }
}
