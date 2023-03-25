using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    //ç≈è¨ÉTÉCÉY
    private float minmum = 1.0f;
    //ägëÂèkè¨ÉXÉsÅ[Éh
    private float magspeed = 10.0f;
    //ägëÂó¶
    private float magnification = 0.07f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //â_ÇägëÂèkè¨
        this.transform.localScale = new Vector3(this.minmum + Mathf.Sin(Time.time * this.magspeed) * this.magnification, this.transform.localScale.y, this.minmum + Mathf.Sin(Time.time * this.magspeed) * this.magnification);
    }
}
