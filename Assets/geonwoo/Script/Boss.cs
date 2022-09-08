using System.Collections;
using System.Collections.Generic;
/*using UnityEngine;

public enum BossState { MoveToAppearPoint = 0, Phase01,}

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    [Serializable]
    private float bossApperPoint = 2.5f;
    private BossState bossState = BossState.MoveToAppearPoint;
    private Movement2D movement2D;

    private void private void Awake() 
    {
        movement2D = GetComponent<Movement2D>();
    }
    

    public void ChangeState(BossState newState)
    {
        StopCoroutine(bossState.ToString());

        bossState = new State;

        StartCoroutine(bossState.ToString());
    }

    private IEnumerator MoveToAppearPoint()
    {
        movement2D.MoveTo(Vector3.down);

        while(true)
        {
            if(transform.position.y <= bossApperPoint)
            {
                movement2D.MoveTo(Vector3.zero);
            }

            yeild return null;
        }
    }

    private IEnumerator Phase01()
    {
        bossWeapon.StartFiring(AttackType.CircleFire);

        while(true)
        {
            yield return null;
        }
    }
}
*/