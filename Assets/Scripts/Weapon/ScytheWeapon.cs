using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScytheWeapon : Weapon
{
    public const string ANIM_PARM_ISATTACK = "IsAttack";//����������

    private Animator anim;//����������

    public int atkValue = 50;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    

    public override void Attack()
    {
        anim.SetTrigger(ANIM_PARM_ISATTACK);//��������Ӧ
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == Tag.ENEMY)
        {
            other.GetComponent<Enemy>().TakeDamage(atkValue);
        }
    }
}
