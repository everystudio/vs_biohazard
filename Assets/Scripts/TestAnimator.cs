using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class TestAnimator : StateMachineBehaviour
{

	public string m_playName;
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller)
	{
		base.OnStateEnter(animator, stateInfo, layerIndex, controller);
	}

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		AnimatorClipInfo[] infos = animator.GetCurrentAnimatorClipInfo(layerIndex);
		if (stateInfo.IsName(m_playName))
		{
			//Debug.Log(m_playName);
		}

		//Debug.Log(animator.parameters[0].name);
		/*
		for( int i = 0; i < infos.Length; i++)
		{
			Debug.Log(infos[i].clip.name);
		}
		*/
	}
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}
