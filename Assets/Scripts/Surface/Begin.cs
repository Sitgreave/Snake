
using UnityEngine;

public class Begin : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle;
    [SerializeField] private MeshRenderer _renderer;

    private void Start()
    {
       Color color= ColorSetter.GetColorFromStatus(StageColorType.Right);
        _renderer.material.color = new Color(color.r, color.g, color.b, .5f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _particle.Play();
            StageEvents.OnStageCompleted.Invoke();
        }
    }
}
