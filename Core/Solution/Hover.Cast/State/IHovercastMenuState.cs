using Hover.Common.Items;
using Hover.Common.State;
using UnityEngine;

namespace Hover.Cast.State {

	/*================================================================================================*/
	public interface IHovercastMenuState {

		bool IsInputAvailable { get; }
		bool IsOnLeftSide { get; }
		Vector3 Center { get; }
		Quaternion Rotation { get; }
		float Size { get; }
		float DisplayStrength { get; }
		float NavBackStrength { get; }
		IBaseItemState NearestItem { get; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		IBaseItemState[] GetLevelItems();

		/*--------------------------------------------------------------------------------------------*/
		IBaseItem GetLevelParentItem();

		/*--------------------------------------------------------------------------------------------*/
		string GetLevelTitle();

	}

}
