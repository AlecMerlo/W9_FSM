using NodeCanvas.Framework;
using System.Collections.Generic;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class SetNewSpotAT : ActionTask
	{
		public BBParameter<List<Transform>> path;
		public BBParameter<Transform> currentSpot;
		public BBParameter<int> currentPathIndex;

		protected override void OnExecute()
		{
			currentPathIndex.value++;
			currentPathIndex.value %= path.value.Count;
			currentSpot.value = path.value[currentPathIndex.value];

			EndAction(true);
		}
	}
}