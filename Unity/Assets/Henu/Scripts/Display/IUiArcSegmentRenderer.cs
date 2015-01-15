﻿using Henu.Settings;
using Henu.State;
using UnityEngine;

namespace Henu.Display {

	/*================================================================================================*/
	public interface IUiArcSegmentRenderer {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		void Build(ArcState pArcState, ArcSegmentState pSegState, float pArcAngle,
																		ArcSegmentSettings pSettings);

		/*--------------------------------------------------------------------------------------------*/
		void HandleChangeAnimation(bool pFadeIn, int pDirection, float pProgress);


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		float CalculateCursorDistance(Vector3 pCursorWorldPosition);

	}

}
