using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class Extensions
{
	public static bool DotTest(this Transform transform, Transform other, Vector2 testDirection)
	{
		Vector2 direction = other.position - transform.position;
		return Vector2.Dot(direction.normalized, testDirection) > 0.25f;
	}
}
