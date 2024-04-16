using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyAnimationTransition : MonoBehaviour
{
    
    public bool enemyIsSlain = false;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(enemyIsSlain);
        if (enemyIsSlain == true)
        {
            animator.SetBool("IsEnemySlain", true);
        }
        
    }
}
