using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] AudioClip[] _clips;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > 0.1f)
        {
            int index = UnityEngine.Random.Range(0, _clips.Length);
            AudioClip clip = _clips[index];
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }
}
