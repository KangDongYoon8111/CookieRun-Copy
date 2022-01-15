using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

public class SpineTest : MonoBehaviour
{
    private SkeletonAnimation skeletonAnimation;

    void Start()
    {
        skeletonAnimation = GetComponentInChildren<SkeletonAnimation>();
        skeletonAnimation.state.TimeScale = 1.2f;

        skeletonAnimation.state.SetAnimation(0, "run", true);
    }

    public void Animation(int index)
    {
        switch (index)
        {
            case 0:
                skeletonAnimation.state.TimeScale = 1.0f;
                skeletonAnimation.state.SetAnimation(0, "jump", false);
                break;
            case 1:
                skeletonAnimation.state.SetAnimation(0, "Dubble_Jump", false);
                break;
            case 2:
                skeletonAnimation.state.SetAnimation(0, "slid", true);
                break;
            case 3:
                skeletonAnimation.state.SetAnimation(0, "Speed_run", true);
                break;
            case 4:
                skeletonAnimation.state.SetAnimation(0, "die", false);
                break;
            default:
                skeletonAnimation.state.TimeScale = 1.2f;
                skeletonAnimation.state.SetAnimation(0, "run", true);
                break;
        }
    }

    void Update()
    {
        
    }
}
