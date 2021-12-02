using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoveText : MonoBehaviour
{
    public Transform _target;
    public Transform _myTransform;
    public TMP_Text _text;
    public string _value;

    private void Awake()
    {
        _myTransform = GetComponent<Transform>();
    }
    private void Update()
    {
        _myTransform.position = Vector3.Lerp(_myTransform.position, _target.position, .5f * Time.deltaTime);
        if (_myTransform.position.y > _target.position.y - 100) Destroy(gameObject);
    }

    private void Start()
    {
        _text.text = _value;
    }
}
