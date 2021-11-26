using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacuum : MonoBehaviour
{
    [SerializeField] private Transform _mouth;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IMagnetically magnetically))
        {
            magnetically.Magnetized();
            InhaleObj(other.transform);
        }
    }
    public void InhaleObj(Transform objTransform)
    {
          StartCoroutine(LerpObj(objTransform));
    }

    
    IEnumerator LerpObj(Transform objTransform)
    {
        while (objTransform.position.z > _mouth.position.z +.3f)
        {
            objTransform.position = Vector3.Lerp(objTransform.position, _mouth.position, 5f * Time.deltaTime) ;
            yield return new WaitForSeconds(.01f);
        }
    }
}
