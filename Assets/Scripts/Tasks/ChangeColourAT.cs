using NodeCanvas.Framework;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ChangeColourAT : ActionTask 
	{

		public BBParameter<Renderer> rendererBBP;
		public Color colour;

		protected override void OnExecute() 
		{
			rendererBBP.value.material.color = colour;

			EndAction(true);
		}
	}
}