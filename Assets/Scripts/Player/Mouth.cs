using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : MonoBehaviour
{
    public delegate void ChewOn ();
    private Queue<ChewOn> _chewedObjects = new Queue<ChewOn>();
    public Queue<ChewOn> ChewedObjects => _chewedObjects;

    public void EatObject(IEadible obj)
    {
        _chewedObjects.Enqueue(obj.DigestResult);
        TakeEvents.OnContacted.Invoke();
    }
}
