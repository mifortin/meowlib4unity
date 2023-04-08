//  This Source Code Form is subject to the terms of the Mozilla Public
//  License, v. 2.0. If a copy of the MPL was not distributed with this
//  file, You can obtain one at https://mozilla.org/MPL/2.0/. 

using Unity.Mathematics;
using UnityEngine;

namespace MeowLib
{
	public static class Vector4Ext
	{
		// Until I figure out where Unity hides this one.
		public static readonly Vector4 HomogenousZero = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);
	}
}