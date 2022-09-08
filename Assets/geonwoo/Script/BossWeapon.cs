/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AttackType {CircleFire = 0,}

public class BossWeapon : MonoBehaviour
{
    [Serializable]
    private GameObject projectilePrefab;

    public void StartFiring(AttackType attackType)
    {
        StartCoroutine(attackType.ToString());
    }
    // Start is called before the first frame update
    public void StopFiring(AttackType attackType)
    {
        StopCoroutine(attackType.ToString());
    }

    private IEnumerator CircleFire()
    {
        float attackRate = 0.5f;
        int count = 30;
        float intervalAngle = 360/count;
        float weightAngle = 0;

        while(true)
        {
            for(int i = 0; i<count;++ i)
            {
                GameObject clone = instantiation(projectilePrefab, transform.position, Quaternion.identity);
                
                float angle = weightAngle + intervalAngle * i;

                float x = Mathf.Cos(angle * Mathf.PI / 180.0f);
                float y = Mathf.Sin(angle * Mathf.PI / 180.0f);

                clone.GetComponent<Movement2D>().MoveTo(new Vector2(x,y));
            
            }

            wightAngle += 1;

            yield return new WaitForSeconds(attackRate);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/