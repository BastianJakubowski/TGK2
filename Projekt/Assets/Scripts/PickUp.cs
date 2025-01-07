using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PickUp : MonoBehaviour
{
    float score = 0;
    [SerializeField] float speed = 1.0f;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip clip;


    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Coin"))
        {

            audioSource.PlayOneShot(clip);
            StartCoroutine(MoveToPlayer(other.transform, transform, speed));
            score++;
            Debug.Log("Twój wynik to " + score);
        }

         IEnumerator MoveToPlayer(Transform coin, Transform player, float speed)
        {
            float duration = 3.0f;
            float time = 0;

            while (time < duration)
            {
                coin.position = Vector3.MoveTowards(coin.position, player.position, speed*Time.deltaTime);
                time += Time.deltaTime; // nasz licznik czasu - 0,05 + 0,05 + 0,05 = 3 

                yield return null; // odstêp czasowy - 1 stop klatka

            }

         
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject); ;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }


}
