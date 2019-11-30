using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("人類血量"), Range(0f, 100f), Tooltip("調整玩家血量")]
    public float Human_HP = 100f;

    [Header("人類攻擊力"), Tooltip("輸入玩家攻擊力")]
    public float Human_Atk;

    [Header("殭屍控制")]
    public Zombie ZombimeControl;

    [Header("聲音音源")]
    public AudioSource Human_aud;

    [Header("人類攻擊的音效")]
    public AudioClip Human_ac;


    private void Update()
    {
        attack();
    }

    public void attack()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("小屁孩攻擊殭屍！殭屍血量剩下：" + (Human_HP-Random.Range(0f,100f)));
            print(Random.Range(0f, 100f));
        }
    }

}
