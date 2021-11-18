using UnityEngine;

public class Stage : MonoBehaviour
{
    [SerializeField] private SegmentSpawner _segmentSpawner;
    [SerializeField] private int _segmentCount;
    [SerializeField] private Color _stageColor;

    private void Start()
    {
        _segmentSpawner.Spawn(_segmentCount);
    }
}
public enum Color
{
    green,
    blue,
    red
}