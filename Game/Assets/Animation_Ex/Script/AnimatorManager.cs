using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] AnimationClip[] animationClip;


    void Start()
    {
        for(int i = 0; i < animationClip.Length; i++)
        {
            var data = AnimationUtility.GetAnimationClipSettings(animationClip[i]);

            data.loopTime = false;

            AnimationUtility.SetAnimationClipSettings(animationClip[i], data);
        }
    }

    void Update()
    {
        // 현재 애니메이터에 있는 애니메이션의 이름이 "Close"일 때
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Close"))
            // 현재 애니메이션의 진행도 1보다 크거나 같다면 애니메이터가 있는 게임 오브젝트를 비활성화 한다.
            if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
                animator.gameObject.SetActive(false);
    }

    public void Open()
    {
        animator.gameObject.SetActive(true);
    }

    public void Close()
    {
        animator.SetTrigger("Close");
    }
}
