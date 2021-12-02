using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace My.CharacterScripts
{
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
            if (objTransform != null)
                StartCoroutine(LerpObj(objTransform));
        }


        IEnumerator LerpObj(Transform objTransform)
        {
            while (objTransform != null && objTransform.position.z > _mouth.position.z + .01f)
            {
                objTransform.position = Vector3.Lerp(objTransform.position, _mouth.position, 5f * Time.deltaTime);
                yield return new WaitForSeconds(.01f);
            }

        }
    }
}