using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour, IMagnetically, IEadible
{
    [SerializeField] private Transform _center;
    [SerializeField] private Transform _myTransform;
    private void Update()
    {
        if(_center != null)
       _myTransform.RotateAround(_center.position, Vector3.up, 90 * Time.deltaTime);
    }
    public void DigestResult()
    {
        TakeEvents.OnCrystalTaked.Invoke();
    }

    public void Magnetized()
    {
        
    }

}
