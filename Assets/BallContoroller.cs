using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallContoroller : MonoBehaviour
{
    //ボールが見える可能性のあるZ軸の最小値
    private float visiblePosZ = -6.5f;
    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;
    //スコアを表示するテキスト
    private GameObject scoreText;
    //得点の追加
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGame OverTextを取得
        this.gameoverText = GameObject.Find("GameOverText");
        //シーン中のScoreTextを取得
        this.scoreText = GameObject.Find("ScoreText");
        
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if(this.transform.position.z < this.visiblePosZ)
        {
            //GameOverTextにゲームオーバーを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
        
    }

    private void OnCollisionEnter(Collision other)
    { 
        // 小さな星に衝突した場合、１０点加算する。
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
