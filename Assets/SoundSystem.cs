using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    [SerializeField] private List<AudioClip> _eatSounds;
    [SerializeField] private AudioClip _newColorSound;
    [SerializeField] private AudioClip _bubleSound;
    [SerializeField] private AudioSource _source;


    private void Start()
    {
        StartCoroutine(Pitcher());
    }
    public void PlayEatSound()
    {
        int randomIndex = Random.Range(0, _eatSounds.Count);
       PlayClip(_eatSounds[randomIndex]);
    }
    public void PlayBubleSound()
    {
        PlayClip(_bubleSound);
    }
    public void PlaySwitchColorSound()
    {
        PlayClip(_newColorSound);
    }
    private void PlayClip(AudioClip clip)
    {
        _source.pitch += .1f;
        _source.PlayOneShot(clip);
    }
    IEnumerator Pitcher()
    {
        while (true)
        {
            if (!_source.isPlaying && _source.pitch != 1) _source.pitch = 1f;
            yield return new WaitForSeconds(1);
        }
    }

}
