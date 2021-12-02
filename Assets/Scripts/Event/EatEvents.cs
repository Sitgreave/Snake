using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EatEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent _goodEat;
    [SerializeField] private UnityEvent _badEat;
    [SerializeField] private UnityEvent _bombEat;
    [SerializeField] private UnityEvent _crystalEat;
}
