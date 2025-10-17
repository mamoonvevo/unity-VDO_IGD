using UnityEngine;

public class SuperRealistic_Candle : MonoBehaviour
{
    Light getLight => GetComponent<Light>();
    float originalintensity = 1f;
    float counter = 0f;
    [SerializeField] float updateRate = 0.1f;

    void Start()
    {
        originalintensity = getLight.intensity;
    }

    void Update()
    {
        counter += Time.deltaTime;
        
if(counter >= updateRate)
        {
            getLight.intensity = Random.Range(0.025f, originalintensity);
            counter = 0f;    
        }
    }
}
