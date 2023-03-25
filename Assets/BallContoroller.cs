using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallContoroller : MonoBehaviour
{
    //�{�[����������\���̂���Z���̍ŏ��l
    private float visiblePosZ = -6.5f;
    //�Q�[���I�[�o�[��\������e�L�X�g
    private GameObject gameoverText;
    //�X�R�A��\������e�L�X�g
    private GameObject scoreText;
    //���_�̒ǉ�
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������Game OverText���擾
        this.gameoverText = GameObject.Find("GameOverText");
        //�V�[������ScoreText���擾
        this.scoreText = GameObject.Find("ScoreText");
        
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if(this.transform.position.z < this.visiblePosZ)
        {
            //GameOverText�ɃQ�[���I�[�o�[��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
        
    }

    private void OnCollisionEnter(Collision other)
    { 
        // �����Ȑ��ɏՓ˂����ꍇ�A�P�O�_���Z����B
        if(other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
            this.scoreText.GetComponent<Text>().text = "score" + this.score + "pt";
        }
        else if(other.gameObject.tag == "LargeStarTag")
        {
            score += 20;
            this.scoreText.GetComponent<Text>().text = "score" + this.score + "pt";
        }
  
        else if(other.gameObject.tag =="SmallCloudTag")
        {
            score += 40;
            this.scoreText.GetComponent<Text>().text = "score" + this.score + "pt";
        }
    
        else if(other.gameObject.tag == "LargeCloudTag")
        {
            score += 80;
            this.scoreText.GetComponent<Text>().text = "score" + this.score + " pt";
        }
    }

       
    

    
}
