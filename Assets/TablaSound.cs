using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablaSoundComponent : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip[] soundclips;
    public AudioSource myAudioSource;
    string buttonName;
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit)){
                buttonName = Hit.transform.name;
                switch (buttonName){

                    case "bigTablaSoundProvider":
                        myAudioSource.clip = soundclips[0];
                        myAudioSource.Play();
                        break;

                    case "smallTablaSoundProvider":
                        myAudioSource.clip = soundclips[1];
                        myAudioSource.Play();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
