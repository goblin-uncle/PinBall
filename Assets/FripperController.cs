using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJoint�R���|�[�l���g������
    private HingeJoint myhingejoint;
    //�����̌X��
    private float defaultAngle = 20;
    //�e�������̌X��
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        //HingeJoint�R���|�[�l���g���擾
        this.myhingejoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);
        
    }

    // Update is called once per frame
    void Update()
    {
        //�����L�[�������������t���b�p�[�𓮂���
        if(Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //�E���L�[�����������E�t���b�p�[�𓮂���
        if(Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightfripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //���L�[�𗣂��������ɖ߂�
       if(Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
       if(Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightfripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        
    }

    //�t���b�p�[�̌X����ݒ�
    public void SetAngle(float angle)
    {
        JointSpring jointspr = this.myhingejoint.spring;
        jointspr.targetPosition = angle;
        this.myhingejoint.spring = jointspr;
    }
}
