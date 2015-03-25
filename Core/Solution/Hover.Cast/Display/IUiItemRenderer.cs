using Hover.Cast.Custom;
using Hover.Cast.State;
using Hover.Common.State;
using UnityEngine;

namespace Hover.Cast.Display {

	/*================================================================================================*/
	public interface IUiItemRenderer {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		void Build(MenuState pMenuState, IBaseItemState pItemState, float pArcAngle,
																		IItemVisualSettings pSettings);

		/*--------------------------------------------------------------------------------------------*/
		void HandleChangeAnimation(bool pFadeIn, int pDirection, float pProgress);


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		Vector3 GetPointNearestToCursor(Vector3 pCursorLocalPos);

	}

}
