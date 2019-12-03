using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [Header("殭屍血量"), Range(0f, 100f), Tooltip("調整殭屍血量")]
    public float Zombie_HP = 100f;

    [Header("殭屍攻擊力"), Tooltip("輸入殭屍攻擊力")]
    public float Zombie_Atk;

    [Header("人類控制")]
    public Player HumanControl;

    [Header("聲音音源")]
    public AudioSource Zombie_aud;

    [Header("殭屍攻擊的音效")]
    public AudioClip Zombie_ac;

    private void Update()
    {
        ZombieAttack();
    }

    public void ZombieAttack()
    {
        Zombie_Atk = Random.Range(0f, 50f);
        if (Input.GetKeyDown(KeyCode.B))
        {
            Zombie_aud.PlayOneShot(Zombie_ac);
            HumanControl.Human_HP = HumanControl.Human_HP - Zombie_Atk;
            print("殭屍攻擊小屁孩！小屁孩血量剩下：" + HumanControl.Human_HP);

            if (HumanControl.Human_HP <= 0 )
            {
                print("小屁孩升天了。");
            }
        }
    }
}
