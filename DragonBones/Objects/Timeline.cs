// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
namespace DragonBones
{
		public class Timeline
		{

	
		public int duration;
		public float scale;
		public List<Frame> frameList = new List<Frame>();
	    public Timeline ()
		{
			duration = 0;
			scale = 1.0f;
		}

		public virtual void dispose()
		{
			for (int i = 0; i < frameList.Count;  ++i)
			{
				frameList[i].dispose();
				//delete frameList[i];
			}
			
			frameList.Clear();
		}


		}
}

