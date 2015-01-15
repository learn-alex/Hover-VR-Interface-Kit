﻿using System;

namespace Henu.Navigation {

	/*================================================================================================*/
	public class NavItem {

		public enum ItemType {
			Parent,
			Selection,
			Sticky,
			Checkbox,
			Radio,
			Slider
		}

		public delegate void SelectionHandler(NavItem pNavItem);
		public event SelectionHandler OnSelection;

		private static int ItemCount;

		public int Id { get; private set; }
		public ItemType Type { get; private set; }
		public string Label { get; private set; }
		public float RelativeSize { get; private set; }
		public NavItem[] Children { get; private set; }

		public bool Selected { get; set; }
		public bool NavigateBackUponSelect { get; set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public NavItem(ItemType pType, string pLabel, float pRelativeSize=1) {
			Id = (++ItemCount);
			Type = pType;
			Label = (pLabel ?? "");
			RelativeSize = pRelativeSize;
			Children = null;

			OnSelection += (i => {});
		}


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public void SetChildren(NavItem[] pChildren) {
			if ( Children != null ) {
				throw new Exception("Children already set.");
			}

			if ( Type != ItemType.Parent ) {
				throw new Exception("Only items of type 'Parent' can have children.");
			}

			Children = pChildren;
		}

		/*--------------------------------------------------------------------------------------------*/
		public void Select() {
			OnSelection(this);
		}

		/*--------------------------------------------------------------------------------------------*/
		public bool UsesStickySelection() {
			return (Type == ItemType.Sticky || Type == ItemType.Slider);
		}

		/*--------------------------------------------------------------------------------------------*/
		public bool IsStickySelected() {
			return (Selected && UsesStickySelection());
		}

	}

}
