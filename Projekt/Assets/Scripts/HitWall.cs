using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWall : MonoBehaviour

{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {

            audioSource.PlayOneShot(clip);

        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
