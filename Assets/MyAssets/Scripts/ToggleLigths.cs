using System.Collections.Generic;
using UnityEngine;

public class ToggleLigths : MonoBehaviour
{
    [SerializeField] Light[] getLights;
    [SerializeField] AudioClip[] LightOn;
    [SerializeField] AudioClip LightOff;
    [SerializeField] AudioSource audioSource;
    //[SerializeField] List<Light> getLights2;



    void Start()
    {
        if (audioSource == null && GetComponent<AudioSource>()!= null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }


    void OnMouseDown()
    {
        foreach (Light light in getLights)
        {
            /* if (light.enabled)
                 light.enabled = false;

             else
                 light.enabled = true; 
             */
            light.enabled = !light.enabled;

            if (light.enabled)
            {
                if (LightOn.Length == 0) continue;
                int randomInex = Random.Range(0, LightOn.Length);
                if (LightOn[randomInex] == null) continue;
                audioSource.PlayOneShot(LightOn[randomInex]);
            }
            else
            {
                if (LightOff == null) continue;
                audioSource.PlayOneShot(LightOff);
            }

        }




    }




}
