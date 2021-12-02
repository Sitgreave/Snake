using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class ChainSegment : MonoBehaviour
    {
    [SerializeField] private Transform _transform;
    [SerializeField] private SphereCollider _collider;
    [HideInInspector] public Transform _nextSegment;
    [SerializeField] private MeshRenderer _renderer;
    float _diameter;
    public SegmentAnimations EatAnimation;
    private Queue<Vector3> _pointsToMove = new Queue<Vector3>();
    private void Awake()
    {
        _diameter = _collider.radius * _transform.localScale.z;
        
    }

    private void Start()
    {
        StartCoroutine(PointsMark());
        _renderer.material.color = ColorSetter.LastRightColor();
    }
    private void FixedUpdate()
    {
        if (_pointsToMove.Count > 0)
        {
            _transform.position = _pointsToMove.Dequeue();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Begin")
        {
            StageEvents.OnSnakeColorSwitched.Invoke();
            _renderer.material.color = ColorSetter.LastRightColor();
        }
    }
    private Vector3 NextPoint()
    {
        return new Vector3(_nextSegment.position.x, _nextSegment.position.y, _nextSegment.transform.position.z - _diameter);
    }
    


    IEnumerator PointsMark()
    {
        while (true)
        {
            if (_nextSegment != null)
            {
                _pointsToMove.Enqueue(NextPoint());
                yield return new WaitForFixedUpdate();
            }
        }
    }

    private void OnDestroy()
    {
        StopCoroutine(PointsMark());
    }
}