using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("小屁孩血量"), Range(0f, 100f), Tooltip("調整小屁孩血量")]
    public float Human_HP = 100f;

    [Header("小屁孩攻擊力"), Tooltip("輸入小屁孩攻擊力")]
    public float Human_Atk;

    [Header("殭屍控制")]
    public Zombie ZombimeControl;

    [Header("聲音音源")]
    public AudioSource Human_aud;

    [Header("小屁孩攻擊的音效")]
    public AudioClip Human_ac;

    private void Update()
    {
        HumanAttack();
    }

    public void HumanAttack()
    {
        Human_Atk = Random.Range(0f, 50f);
        if (Input.GetKeyDown(KeyCode.A))
        {
            Human_aud.PlayOneShot(Human_ac);
            ZombimeControl.Zombie_HP = ZombimeControl.Zombie_HP - Human_Atk;
            print("小屁孩攻擊殭屍！殭屍血量剩下：" + ZombimeControl.Zombie_HP);
            if(ZombimeControl.Zombie_HP <= 0)
            {
                print("殭屍被打爛了!");
            }
        }
    }

}
