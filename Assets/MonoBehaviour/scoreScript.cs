using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreScript : MonoBehaviour
{
    //クラスの唯一のインスタンスを保持するための静的な変数
    public static scoreScript instance;
    //スコアを表示するためのtextコンポーネントとトータルスコア
    public GameObject scoreText;
    private int totalScore = 0;
    //プライベートコンストラクタ
    private void Awake()
    {
        //インスタンスが存在しない場合はこのインスタンスを設定
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);//シーンをまたいでもインスタンスを保持
        }
        //既に存在する場合は新しいインスタンスを破棄
        else
        {
            Destroy(gameObject);
        }
    }
    //反映されるためのメソッドを定義
    private void Start()
    {
        
    }
    //スコアを更新して、textコンポーネントに反映する
    public void ScoreManeger(int score)
    {
        totalScore += score;
        //コンポーネントを表示する
        UpdataScoreText();
    }
    //スコアをtextコンポーネントに表示するメソッド
    private void UpdataScoreText()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score:"+totalScore.ToString();
    }
}
