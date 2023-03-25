using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    //�ŏ��T�C�Y
    private float minmum = 1.0f;
    //�g��k���X�s�[�h
    private float magspeed = 10.0f;
    //�g�嗦
    private float magnification = 0.07f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�_���g��k��
        this.transform.localScale = new Vector3(this.minmum + Mathf.Sin(Time.time * this.magspeed) * this.magnification, this.transform.localScale.y, this.minmum + Mathf.Sin(Time.time * this.magspeed) * this.magnification);
    }
}
