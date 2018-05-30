using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //魔法値

    // 攻撃用の関数
    public void Attack()
    {
        
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        
        // 残りhpを減らす
        this.hp -= damage;
    }
    //魔法攻撃用の関数
    public void Magic(int cost)
    {
        if (mp >= cost)
        {
            mp -= cost;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test発展課題 : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        //Magic関数を呼び出して、魔法を使ってください
        for (int i = 0; i < 11; i++)
        {
           lastboss.Magic(5);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}