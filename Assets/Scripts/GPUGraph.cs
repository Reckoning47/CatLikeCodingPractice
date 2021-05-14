﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPUGraph : MonoBehaviour
{
	public enum TransitionMode { Cycle, Random }


	[SerializeField, Range(10, 200)]
	int resolution = 10;

	[SerializeField]
	FunctionLibrary.FunctionName function = default;

	[SerializeField]
	TransitionMode transitionMode = TransitionMode.Cycle;

	[SerializeField, Min(0f)]
	float functionDuration = 1f, transitionDuration = 1f;


	float duration;
	bool transitioning;


	FunctionLibrary.FunctionName transitionFunction;
	ComputeBuffer positionsBuffer;

	void OnEnable()
	{
		positionsBuffer = new ComputeBuffer(resolution * resolution, 3 * 4);
	}


	void OnDisable()
	{
		positionsBuffer.Release();
		positionsBuffer = null;
	}

	private void Update()
	{
		duration += Time.deltaTime;
		if (transitioning)
		{
			if (duration >= transitionDuration)
			{
				duration -= transitionDuration;
				transitioning = false;
			}
		}
		else if (duration >= functionDuration)
		{
			duration -= functionDuration;
			transitioning = true;
			transitionFunction = function;
			PickNextFunction();
		}

	}
	void PickNextFunction()
	{
		function = transitionMode == TransitionMode.Cycle ?
			FunctionLibrary.GetNextFunctionName(function) :
			FunctionLibrary.GetRandomFunctionNameOtherThan(function);
	}
	
}
