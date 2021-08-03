
using UnityEngine;


public class Shape : PersistableObject
{
	int shapeId;
	public int ShapeId
	{
		get
		{
			return shapeId;
		}
		set
		{
			if (shapeId == 0)
			{
				shapeId = value;
			}
			else
			{
				Debug.LogError("Not allowed to change shapeId.");
			}
		}
	}

	
}